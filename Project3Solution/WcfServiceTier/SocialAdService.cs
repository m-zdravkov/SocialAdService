using BusinessTier;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTier
{
    public class SocialAdService : ISocialAdService
    {
        public int CountUsers()
        {
            return UserControl.GetInstance().CountUsers();
        }

        public UserDTO GetUser(string userId)
        {
            User user = UserControl.GetInstance().GetUser(new User { Id = userId });
            return UserDTO.FromUser(user);
        }

        public IList<UserDTO> GetUsers(int skip, int amount)
        {
            IList<User> users = UserControl.GetInstance().GetAllUsers(skip,amount);
            IList<UserDTO> dtos = new List<UserDTO>(users.Count);

            foreach (var user in users)
            {
                dtos.Add(UserDTO.FromUser(user));
            }

            return dtos;
        }

        public void LogIn(string email, string password)
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
    }
}
