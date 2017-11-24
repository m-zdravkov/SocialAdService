using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace BusinessTier
{
    public class AdControl
    {
        private static AdControl _instance;
        
        private AdControl ()
        {

        }

        public static AdControl GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new AdControl();
            }
            return _instance;
        }

        public void AddAd (Ad ad)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            db.Ads.Add(ad);
            db.SaveChanges();
        }

        public void DeleteAd(string id)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            Ad toDelete = new Ad { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Comment GetAd (Ad query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Comment post = db.Ads.FirstOrDefault(a => a.Id.Equals(query.Id));

            if (post == null)
            {
                throw new PostNotFoundException();
            }

            return post;
        }

        public IList<Comment> GetAds (int skip, int amount)
        {
            if (amount > 64)
                amount = 64;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Comment> query = db.Ads;

            var pagedQuery = query.OrderBy(a => a.Id).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }

        private void GetAndAppendComments(Ad ad)
        {
            CommentControl comments = CommentControl.GetInstance();
            comments.
        }
    }
}
