using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace BusinessTier
{
    public class PostControl
    {
        private static PostControl _instance;
        
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

        /*public void AddPost (Post post)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void DeletePost(string id)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            Post toDelete = new Post { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Post GetPost (Post query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Post post = db.Posts.FirstOrDefault(p => p.Id.Equals(query.Id));

            if (post == null)
            {
                throw new PostNotFoundException();
            }

            return post;
        }

        public IList<Post> GetPosts (int skip, int amount)
        {
            if (amount > 64)
                amount = 64;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Post> query = db.Posts;

            var pagedQuery = query.OrderBy(p => p.Id).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }*/
    }
}
