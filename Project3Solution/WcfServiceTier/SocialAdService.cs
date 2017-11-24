using BusinessTier;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTier
{
    public class SocialAdService : ISocialAdService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]

        public int CountUsers()
        {
            return UserControl.GetInstance().CountUsers();
        }

        public User GetUser(string userId)
        {
            return UserControl.GetInstance().GetUser(new User { Id = userId });
        }

        public IList<User> GetUsers(int skip, int amount)
        {
            return UserControl.GetInstance().GetAllUsers(skip,amount);
        }

        public void Authenticate(string email, string password)
        {
            AuthenticationControl.GetInstance().Authenticate(email,password);
        }

        public void LogOut()
        {
            AuthenticationControl.GetInstance().LogOut();
        }

        public void Register(string email, string password, string name, string pictureURL)
        {
            UserControl.GetInstance().RegisterUser(name, email, pictureURL, password);
        }

        public User GetAuthenticatedUser()
        {
            return AuthenticationControl.GetInstance().AuthenticatedUser;
        }
        public int GetData()
        {
            return 123;
        }

        public Comment GenerateTestPost(string content)
        {
            if (content.Length < 4)
                return null;

            return new Comment()
            {
                Id = content.Substring(0,4) + DateTime.UtcNow.ToString(),
                Content = content,
                DatePosted = DateTime.UtcNow,
            };
        }
    }
}
