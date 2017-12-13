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

        public Comment PostComment(string adId, string content, string authorEmail)
        {
            var db = DbContextControl.GetNew();

            var comment = new Comment {
                Content = content,
                DatePosted = DateTime.Now,
                Indent = 0,
                ImageSource = null,
                LastEdited = DateTime.Now,
                ReplyId = adId,
            };

            //Find a user and attach him to the DB context
            var authorFull = db.Users.Attach(
                db.Users.FirstOrDefault(u => u.Email == authorEmail));
            //Attach the user to the Ad
            comment.Author = authorFull;

            db.Comments.Add(comment);
            db.SaveChanges();

            return comment;
        }

        public void DeleteComment(string id, string userEmail)
        {
            var db = DbContextControl.GetNew();
            
            Comment toDelete = db.Comments.Attach(
                db.Comments.FirstOrDefault(c => c.Id == id));

            if (toDelete.Author.Email != userEmail)
                throw new InvalidOperationException("Can not delete another person's comment.");
            
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

            var db = DbContextControl.GetNew();

            IQueryable<Comment> query = db.Comments;

            var pagedQuery = query.Where(c => c.ReplyId == replyId)
                .OrderByDescending(c => c.DatePosted)
                .Skip(skip)
                .Take(amount)
                .Include(c => c.Author)
                .ToList();

            return pagedQuery;
        }

        public void DeleteReplies(string replyId)
        {
            var db = DbContextControl.GetNew();

            var comments = db.Comments.Where(c => c.ReplyId == replyId);
            db.Comments.RemoveRange(comments);
            db.SaveChanges();
        }
    }
}
