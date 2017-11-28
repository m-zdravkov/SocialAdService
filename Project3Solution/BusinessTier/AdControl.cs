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
            var db = DbContextControl.GetNew();

            Ad ad = new Ad
            {
                Content = content,
                DatePosted = DateTime.Now,
                LastEdited = DateTime.Now,
                ExpDate = DateTime.Now,
                Views = 0,
                Title = title,
                Location = null,
                Price = null,
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
            
            ad.Price = new Price { Id = ad.Id, Type = PriceType.Free, High = 0, Low = 0 };

            db.Ads.Add(ad);
            db.SaveChanges();

            return ad;
        }

        public void AddAd (Ad ad)
        {
            var db = DbContextControl.GetNew();
            db.Ads.Add(ad);
            db.SaveChanges();
        }

        public void DeleteAd(string id, User author)
        {
            var db = DbContextControl.GetNew();
            Ad toDelete = new Ad { Id = id, Author = UserControl.GetInstance().GetUser(author) };
            db.Ads.Attach(toDelete);
            db.Ads.Remove(toDelete);
            //db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Ad GetAd (Ad query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Ad post = db.Ads.Include("Author").Include("Location").FirstOrDefault(a => a.Id.Equals(query.Id));

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
                .Include(a => a.Location)
                .ToList();

            return pagedQuery;
        }

        /// <summary>
        /// This method is used to shorten the finding of possible locations for search methods
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private IList<Location> GetPossibleLocations(string location)
        {
            IList<Location> possibleLocations = location?.GetLocationObject()?.GetChildren(true);
            
            if (possibleLocations == null)
            {
                throw new LocationNotFoundException("Could not find ads within a location, because it doesn't exist.");
            }

            return possibleLocations;
        }

        /// <summary>
        /// Like GetPossibleLocations, but returns string list, for easier comparison
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public IList<string> GetPossibleLocationNames(string location)
        {
            var list = GetPossibleLocations(location);
            var strings = new List<string>();

            foreach (var item in list)
            {
                strings.Add(item.Name);
            }

            return strings;
        }

        public IList<Ad> GetAdsWithinLocation(int skip, int amount, string location)
        {
            if (amount > Throttle)
                amount = Throttle;

            IList<string> possibleLocationNames = GetPossibleLocationNames(location);

            ///TODO: use one universal db context when possible
            ServiceDbContext db = DbContextControl.GetLastOrNew();
            IQueryable<Ad> query = /*(from ad in db.Ads
                                    where possibleLocations.Any(loc => ad.Location.Name == loc)
                                    select ad);*/
                                    db.Ads.Include("Location")
                                    .Where(a => a.Location!=null
                                        && possibleLocationNames.Contains(a.Location.Name));

            var pagedQuery = query
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

            var db = DbContextControl.GetNew();

            var possibleLocations = GetPossibleLocationNames(location);

            var keywords = searchQuery.GetKeywords();

            //Delimit to ads that are within a location 
            //This copies GetAdsWithinLocation, but we would like to do the search in the same query
            IQueryable<Ad> query = db.Ads.OrderBy(a => a.DatePosted)
                .Include("Location");

            //A complex and heavy SQL query to find the search query within ad titles, contents and categories
            query = (from ad in query
             where possibleLocations.Any(loc => ad.Location.Name == loc)
                   && keywords.Any(kw => ad.Title.ToLower().Contains(kw)
                                   || ad.Content.ToLower().Contains(kw))
                                   ///TODO: Add category search
                                   //|| ad.Categories.Contains(kw))
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
