using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace BusinessTier
{
    public class CommentControl
    {
        private static CommentControl _instance;
        
        private CommentControl ()
        {

        }

        public static CommentControl GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new CommentControl();
            }
            return _instance;
        }

        public void AddComment (Comment comment)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public void DeleteComment(string id)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            Comment toDelete = new Comment { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Comment GetComment (Comment query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Comment comment = db.Comments.FirstOrDefault(p => p.Id.Equals(query.Id));

            if (comment == null)
            {
                throw new PostNotFoundException();
            }

            return comment;
        }

        //Obsolete
        public IList<Comment> GetComments(int skip, int amount)
        {
            if (amount > 64)
                amount = 64;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Comment> query = db.Comments;

            var pagedQuery = query.OrderBy(p => p.DatePosted).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }

        /// <summary>
        /// Returns an ordered-by-date list of all comments that are replies to a given post.
        /// It is not within this method's responsibility to check if the post exists.
        /// </summary>
        /// <param name="replyId">The id of the specified post</param>
        /// <param name="skip">How many comments to skip from the list</param>
        /// <param name="amount">How many comments to fetch.</param>
        /// <returns></returns>
        public IList<Comment> GetReplies(string replyId, int skip, int amount)
        {
            if (amount > 64)
                amount = 64; //throttling the amount to spare the db server

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Comment> query = db.Comments.Where(c => c.ReplyId.Equals(replyId));

            var pagedQuery = query.OrderBy(p => p.DatePosted).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }
    }
}
