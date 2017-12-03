using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class UserControl
    {
        private static UserControl _instance;
        //public static bool SaveChanges = true;

        //private DBContext db = new DBContext();

        public static UserControl GetInstance()
        {
            if (_instance == null)
                _instance = new UserControl();
            return _instance;
        }

        private UserControl()
        {
            SeedUsers();
        }

        /// <summary>
        /// Makes sure we have placeholder users in the database, if we find out that it's empty.
        /// </summary>
        private void SeedUsers()
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            int count = db.Users.Count<User>();
            if (count == 0)
            {
                MigrationSeed.SeedUsers();
                
                foreach (var user in MigrationSeed.Users)
                {
                    RegisterUser(user.Name, user.Email, "http://test.com/image.png", "password");
                }
            }
        }
        

        public User RegisterUser(string name, string email, string picutreURL, string password)
        {
            User user = PrepareUserRegistration(name,email.ToLower(),picutreURL.ToLower(),password);

            //Extended method from SecureHashingControl
            user.GeneratePassword(password);
            
            AddUser(user);
            return user;
        }

        /// <summary>
        /// Preparation for registration. Does not do anythig but set the proper fields in a User.
        /// Public visibility because it is used for testing.
        /// </summary>
        public User PrepareUserRegistration(string name, string email, string picutreURL, string password)
        {
            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                DateRegistered = DateTime.Now,
                Name = name,
                Email = email,
                PictureURL = picutreURL,
                Boosts = 5,
                Reservations = 5,
            };

            //if (!user.Validate())
            //    throw new ArgumentException("Invalid User");

            return user;
        }

        private void AddUser(User user)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            db.Users.Add(user);
            db.SaveChanges();
        }
        
        /// <summary>
        /// Can query users by Email
        /// </summary>
        /// <param name="query">A User containing at least Id or Email</param>
        /// <returns></returns>
        public User GetUser(User query)
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();
            
            
            User user = db.Users.FirstOrDefault(u => u.Email.Equals(query.Email));

            if (user == null)
                throw new UserNotFoundException();

            return user;
        }

        public IList<User> GetAllUsers(int skip, int amount)
        {
            if (amount > 64) amount = 64; //limit traffic

            Model.ServiceDbContext db = new Model.ServiceDbContext();

            IQueryable<User> query = db.Users;
            var pagedQuery = query.OrderBy(u => u.Id).Skip(skip).Take(amount).ToList();

            return pagedQuery;
        }

        public int CountUsers()
        {
            Model.ServiceDbContext db = new Model.ServiceDbContext();

            return db.Users.Count();
        }

        public void DeleteUser(string id)
        {
            var db = DbContextControl.GetNew();
            User toDelete = new User { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
