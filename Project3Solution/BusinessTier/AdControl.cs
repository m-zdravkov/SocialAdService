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
            //REFACTOR
            //THIS IS A QUICK FIX
            var db = DbContextControl.GetNew();
            if(db.Ads.Count() == 0)
            {
                if (db.Users.Count() == 0)
                    MigrationSeed.SeedUsers();
                MigrationSeed.SeedAds();

                foreach (var ad in MigrationSeed.Ads)
                {
                    PostAd(ad.Author.Email, ad.Title, ad.Content, ad.Location.Name, ad.Type);
                }

                var blueCar = MigrationSeed.Ads.FirstOrDefault(a => a.Title == "Selling blue sports car");
                ReserveAd(blueCar?.Id, "dan.wallace@test.com");
                CommentControl.GetInstance().PostComment(blueCar.Id, "Interested!", "dan.wallace@test.com");
            }
        }

        public static AdControl GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new AdControl();
            }
            return _instance;
        }

        public Ad PostAd(string authorEmail, string title, string content, string locationName=null, AdType type = AdType.Other)
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
                Type = type,
            };

            //Find a user and attach him to the DB context
            var authorFull = db.Users.Attach(
                db.Users.FirstOrDefault(u => u.Email == authorEmail));
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

        public Ad UpdateAd(string authorEmail, string id, string title, string content, string locationName = null, AdType type = AdType.Other)
        {
            using (var db = DbContextControl.GetNew())
            {
                Ad ad = db.Ads.FirstOrDefault(a => a.Id == id);
                var entry = db.Entry(ad);

                if (ad.Author.Email != authorEmail)
                    throw new InvalidOperationException("Can not edit another person's ad!");

                if(title != null && title != ad.Title)
                {
                    ad.Title = title;
                    entry.Property("Title").IsModified = true;
                }

                //Find a location and attach it to the DB context and to the Ad
                if (locationName != null && locationName != ad.Location.Name)
                {
                    var locationFull = db.Locations.Attach(new Location { Name = locationName });
                    //ad.Location = locationFull;
                    entry.Reference("Location").CurrentValue = locationFull;
                }

                if (content != null && content != ad.Content)
                {
                    ad.Content = content;
                    entry.Property("Content").IsModified = true;
                }

                ad.LastEdited = DateTime.Now;
                entry.Property("LastEdited").IsModified = true;
                
                db.SaveChanges();

                return ad;
            }
        }

        public void DeleteAd(string id, string authorEmail)
        {
            var db = DbContextControl.GetNew();
            Ad toDelete = new Ad { Id = id };
            toDelete.Author = UserControl.GetInstance().GetUser(authorEmail);//TODO:change

            db.Ads.Attach(toDelete);

            Price price = toDelete.Price;
            if (price != null)
            {
                db.Prices.Attach(toDelete.Price);
                db.Prices.Remove(price);
            }

            var comments = db.Comments.Where(c => c.ReplyId == id);
            db.Comments.RemoveRange(comments);

            db.Ads.Remove(toDelete);
            
            //db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public IList<Ad> GetPostedAds(object userEmail)
        {
            throw new NotImplementedException();
        }

        public Ad GetAd(string id)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            Ad post = db.Ads.Include("Author").Include("Location").Include("Price")
                .Include("ReservedBy").FirstOrDefault(a => a.Id.Equals(id));

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

            var db = DbContextControl.GetNew();

            IQueryable<Ad> query = db.Ads;

            var pagedQuery = query
                .OrderByDescending(a => a.DatePosted)
                .Skip(skip)
                .Take(amount)
                .Include(a => a.Author)
                .Include(a => a.Location)
                .Include(a => a.ReservedBy)
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
        public IList<Ad> FindAds(int skip, int amount, string location, string searchQuery, AdType type = AdType.All)
        {
            //Throttle amount of ads found, to reduce load
            if (amount > Throttle)
                amount = Throttle;

            //Get a DB context
            var db = DbContextControl.GetNew();

            //Get all locations that the ad is within
            IList<string> possibleLocations;
            try
            {
                possibleLocations = GetPossibleLocationNames(location);
            }
            catch (LocationNotFoundException)
            {
                possibleLocations = new List<string>();
            }
            
            //Get the keywords for searching in ad content
            var keywords = searchQuery.GetKeywords();

            //Delimit to ads that are within a location, use this as base for the search query
            //Also order by date posted
            IQueryable<Ad> query = db.Ads.Include(a => a.Location);

            //A complex and heavy SQL query to find the searchQuery string within ad titles, contents and categories
            //We are using the keywords list instead of the searchQuery directly
            query = (from ad in query
            where (type == AdType.All || ad.Type == type) //Check type, all or one
                   && (possibleLocations.Count == 0 //Check location, ignore if none apply
                        || possibleLocations.Any(loc => ad.Location.Name == loc))
                   && (keywords.Count == 0 //Check for keywords, ignore if none apply
                        || keywords.Any(kw => ad.Title.ToLower().Contains(kw)
                        || ad.Content.ToLower().Contains(kw)))
                        ///TODO: Add category search
                        //|| ad.Categories.Contains(kw)))
             select ad);

            //Order the query by list
            //Delimit the query to take only a page of results and append the Authors to the ads
            var pagedQuery = query.OrderByDescending(a => a.DatePosted)
                .Skip(skip)
                .Take(amount)
                .Include(a => a.Author)
                .Include(a => a.ReservedBy)
                .Include(a => a.Price)
                .ToList();

            return pagedQuery;
        }

        public IList<Comment> GetComments(int skip, int amount, string adId)
        {
            CommentControl comments = CommentControl.GetInstance();
            return comments.GetReplies(adId, skip, amount);
        }

        /// <summary>
        /// Reserves an ad
        /// </summary>
        /// <param name="id">Id of ad</param>
        /// <param name="userEmail">Email of the reserving user</param>
        /// <exception cref="PostNotFoundException"></exception>
        /// <exception cref="UserNotFoundException"></exception>
        /// <exception cref="ArgumentException">Users can not reserve their own Ad.</exception>
        /// <exception cref="AlreadyReservedException"></exception>
        /// <exception cref="NotEnoughReservationsException"></exception>
        public void ReserveAd(string id, string userEmail)
        {
            Ad ad = GetAd(id);
            User user = UserControl.GetInstance().GetUser(userEmail);

            if (user.Id == ad.ReservedBy?.Id)
                throw new ArgumentException("Users can not reserve their own ads.");

            if (ad.ReservedBy != null)
                throw new AlreadyReservedException(String.Format(
                    "Ad with id '{0}' is already reserved by user with id '{1}'", ad.Id, ad.ReservedBy.Id));

            if (user.Reservations < 1)
                throw new NotEnoughReservationsException("This user can not reserve any more ads.");

            var db = DbContextControl.GetNew();
            //Get ad into context
            db.Ads.Attach(ad);
            db.Entry(ad).State = EntityState.Modified;

            //Get user into context
            db.Users.Attach(user);
            db.Entry(user).State = EntityState.Modified;

            using (var reserveTransaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
            {
                try
                {
                    //Modify ad, reserve
                    ad.ReservedBy = user;

                    //Modify user, remove points
                    user.Reservations -= 1;

                    db.SaveChanges();
                    reserveTransaction.Commit();
                }
                catch (Exception ex)
                {
                    reserveTransaction.Rollback();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Unreserves a user's ad, doesn't refund reservations.
        /// </summary>
        /// <param name="id">Id of the Ad</param>
        /// <param name="userEmail">Email of the user</param>
        /// <exception cref="PostNotFoundException"></exception>
        /// <exception cref="UserNotFoundException"></exception>
        /// <exception cref="ArgumentException">If ad is not reserved or the author is different.</exception>
        public void UnreserveAd(string id, string userEmail)
        {
            Ad ad = GetAd(id);
            User user = UserControl.GetInstance().GetUser(userEmail);

            if (ad.ReservedBy == null)
                throw new ArgumentException("Can not unreserve: Ad is not reserved.");

            if (user.Id != ad.ReservedBy.Id)
                throw new ArgumentException("Users can not unreserve other people's ads.");

            var db = DbContextControl.GetNew();
            //Get ad into context
            db.Ads.Attach(ad);
            db.Entry(ad).State = EntityState.Modified;

            ad.ReservedBy = null;

            db.SaveChanges();
        }

        /// <summary>
        /// Gets all ads posted by a specific user
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        /// <exception cref="UserNotFoundException"></exception>
        public IList<Ad> GetPostedAds(string userEmail)
        {
            User user = UserControl.GetInstance().GetUser(userEmail);
            var userId = user.Id;
            var db = DbContextControl.GetNew();
            return db.Ads.Where(a => a.Author.Id == userId)
                .Include("Author")
                .Include("Location")
                .Include("Price")
                .Include("ReservedBy")
                .OrderByDescending(a => a.DatePosted)
                .ToList();
        }

        /// <summary>
        /// Gets all ads reserved by a specific user
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        /// <exception cref="UserNotFoundException"></exception>
        public IList<Ad> GetReservedAds(string userEmail)
        {
            User user = UserControl.GetInstance().GetUser(userEmail);
            var userId = user.Id;
            var db = DbContextControl.GetNew();
            return db.Ads.Where(a => a.ReservedBy.Id == userId)
                .Include("Author")
                .Include("Location")
                .Include("Price")
                .Include("ReservedBy")
                .OrderByDescending(a => a.DatePosted)
                .ToList();
        }
    }
}
