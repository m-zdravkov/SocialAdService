using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessTier
{
    class PostControl
    {
        private static PostControl _instance;
        User user = new User();
        Post post = new Post();
        //this.syncObject = new object ();
        //this._reviews = new List<Review>();
        //this._cumulativeReviewScore = 0;
        //this._cumulativeReviewCount = 0
        private PostControl ()
        {

        }

        public static PostControl GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new PostControl();
            }
            return _instance;
        }

        public void AddPost (Post post)
        {
            DBContext db = new DBContext();
            db.Posts.add(post);
            db.SaveChanges();
        }

        public void DeletePost(string id)
        {
            DBContext db = new DBContext();
            Post toDelete = new Post { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Post GetPost (Post query)
        {
            DBContext db = new DBContext();

            Post post = db.Posts.FirstOrDefault(p => p.Id.Equals(query.Id));

            if (post == null)
            {
                throw new PostNotFoundException();
            }

            return post;
        }

        public IList<Post> GetAllPosts (int skip, int amount)
        {
            if (amount > 64)
                amount = 64;

            DBContext db = new DBContext();

            IQueryable<Post> query = db.Posts;

            var pagedQuery = query.OrderBy(p => p.Id).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }

        public ReviewResult Reviews
        {
            get
            {
                return new ReviewResult(this._averageRatingScore, this._reviews);
            }
        }

        public void AddReview(Review review)
        {
            lock (this.syncObject)
            {
                if (this._reviews.Any(r => user.Id == user.Id))
                {
                    throw new ReviewValidator(
                        string.Format("User with Id {0} has already submitted a review for post with Id {1}", user.Id, post.Id));
                }

                this._reviews.Add(review);
                this._cumulativeReviewScore += review.RatingScore;
                this._cumulativeReviewCount++;
                this._averageRatingScore = Math.Round((double)(this._cumulativeReviewScore / this._cumulativeReviewCount), 1);
            }
        }
        private object syncObject;

        private List<Review> _reviews;

        private ulong _cumulativeReviewScore;

        private uint _cumulativeReviewCount;

        private double _averageRatingScore;
    }
}
