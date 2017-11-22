using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessTier
{
    class ReviewControl
    {
        User user = new User();
        Post post = new Post();
        //this.syncObject = new object ();
        //this._reviews = new List<Review>();
        //this._cumulativeReviewScore = 0;
        //this._cumulativeReviewCount = 0

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
                    throw new ReviewExistsException(
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
