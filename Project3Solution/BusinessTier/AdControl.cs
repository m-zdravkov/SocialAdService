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

        public void PostAd(User author, string title, string content)
        {
            var db = new ServiceDbContext();
            

            Ad ad = new Ad
            {
                Content = content,
                DatePosted = DateTime.Now,
                LastEdited = DateTime.Now,
                ExpDate = DateTime.Now,
                Views = 0,
                Title = title,
                Price = new Price { Type = PriceType.Free },
            };
            
            var foundUser = UserControl.GetInstance().GetUser(author);
            db.Ads.Add(ad);
            var authorFull = db.Users.Attach(foundUser);
            ad.Author = authorFull;
            db.SaveChanges();

            //AddAd(ad);
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

        public Ad GetAd (Ad query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Ad post = db.Ads.FirstOrDefault(a => a.Id.Equals(query.Id));

            if (post == null)
            {
                throw new PostNotFoundException();
            }

            return post;
        }

        /// <summary>
        /// Fetches from all ads. Ordered by date.
        /// </summary>
        public IList<Ad> GetAds (int skip, int amount)
        {
            if (amount > 64)
                amount = 64;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Ad> query = db.Ads;

            var pagedQuery = query.OrderBy(a => a.DatePosted).Skip(skip).Take(amount).Include(a => a.Author).ToList();

            return pagedQuery;
        }

        private IList<Comment> GetComments(Ad ad)
        {
            CommentControl comments = CommentControl.GetInstance();
            return comments.GetReplies(ad.Id, 0, 64);
        }
    }
}
