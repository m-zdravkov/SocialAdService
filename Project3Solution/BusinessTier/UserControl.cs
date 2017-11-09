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
        private static UserControl instance;

        //private DBContext db = new DBContext();

        public static UserControl GetInstance()
        {
            if (instance == null)
                instance = new UserControl();
            return instance;
        }

        private UserControl() { }

        public static void GenerateUserId(User user)
        {
            if (user.Name == null || user.Email == null)
                throw new NullReferenceException("User.Name and User.Email are required to generate an Id");
            
            // TODO generate Id from hash value
            user.Id = user.Name + "-" + user.Email;
        }

        public void RegisterUser(string name, string email, string picutreURL, string password)
        {
            User user = new User
            {
                Name = name,
                Email = email,
                PictureURL = picutreURL,
                Boosts = 5,
                Reservations = 5,
            };

            GenerateUserId(user);
            AddUser(user);
        }

        public void AddUser(User user)
        {
            DBContext db = new DBContext();
            db.Users.Add(user);
            db.SaveChanges();
        }
        
        public User GetUser(User query)
        {
            DBContext db = new DBContext();
            return db.Users.First(u => u.Name.Equals(query.Name) && u.Email.Equals(query.Email));
        }

        public void DeleteUser(string id)
        {
            DBContext db = new DBContext();
            User toDelete = new User { Id = id };
            db.Entry(toDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
