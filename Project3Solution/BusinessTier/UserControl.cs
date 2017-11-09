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
        

        public User RegisterUser(string name, string email, string picutreURL, string password)
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
            
            AddUser(user);
            return user;
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
