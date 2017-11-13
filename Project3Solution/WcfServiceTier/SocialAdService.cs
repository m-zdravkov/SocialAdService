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
            throw new NotImplementedException();
        }

        public UserDTO GetUser(string userId)
        {
            throw new NotImplementedException();
        }

        public IList<UserDTO> GetUsers(int skip, int amount)
        {
            throw new NotImplementedException();
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register(string email, string password, string name)
        {
            throw new NotImplementedException();
        }
    }
}
