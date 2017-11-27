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
        public const int Throttle = 64;

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

        public Ad PostAd(User author, string title, string content, string locationName=null)
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
                Location = null,
            };

            //Find a user and attach him to the DB context
            var authorFull = db.Users.Attach(
                db.Users.FirstOrDefault(u => u.Email == author.Email));
            //Attach the user to the Ad
            ad.Author = authorFull;

            //Find a location and attach it to the DB context and to the Ad
            if(locationName != null)
            {
                var locationFull = db.Locations.Attach(new Location { Name = locationName });
                ad.Location = locationFull;
            }

            db.SaveChanges();

            return ad;
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
            if (amount > Throttle)
                amount = Throttle;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Ad> query = db.Ads;

            var pagedQuery = query
                .OrderByDescending(a => a.DatePosted)
                .Skip(skip)
                .Take(amount)
                .Include(a => a.Author)
                .ToList();

            return pagedQuery;
        }

        public IList<Ad> GetAdsWithinLocation(int skip, int amount, string location)
        {
            if (amount > Throttle)
                amount = Throttle;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<Ad> query = db.Ads;

            var loc = LocationControl.GetInstance();
            var pagedQuery = query
                .Where(a => a.Location.IsWithin(location))
                .OrderByDescending(a => a.DatePosted)
                .Skip(skip)
                .Take(amount)
                .Include(a => a.Author)
                .ToList();

            return pagedQuery;
        }

        /// <summary>
        /// A VERY expensive operation that searches through ad content. Use with caution.
        /// </summary>
        /// <param name="skip">Skip amount of ads (for paging)</param>
        /// <param name="amount">Take amount of ads (for paging)</param>
        /// <param name="location">General location of ad</param>
        /// <param name="searchQuery">A search query, like a few words that describe what is searched</param>
        /// <returns>A page of ads that match the criteria.</returns>
        public IList<Ad> FindAds(int skip, int amount, string location, string searchQuery)
        {
            if (amount > Throttle)
                amount = Throttle;

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IList<string> keywords = searchQuery.GetKeywords();

            //Delimit to ads that are within a location 
            IQueryable<Ad> query = db.Ads.OrderBy(a => a.DatePosted)
                .Where(a => a.Location.IsWithin(location));

            //A complex and heavy SQL query to find the search query within ad titles, contents and categories
            query = (from ad in query
             where keywords.Any(kw => ad.Title.ToLower().Contains(kw)
                                   || ad.Content.ToLower().Contains(kw)
                                   || ad.Categories.Contains(kw))
             select ad);

            //Delimit the query to take only a page of results and append the Authors to the ads
            var pagedQuery = query.Skip(skip)
                .Take(amount)
                .Include(a => a.Author)
                .ToList();

            return pagedQuery;
        }

        private IList<Comment> GetComments(Ad ad)
        {
            CommentControl comments = CommentControl.GetInstance();
            return comments.GetReplies(ad.Id, 0, 64);
        }
    }
}
