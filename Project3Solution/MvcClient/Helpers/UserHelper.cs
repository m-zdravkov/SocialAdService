using MvcClient.SocialAdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Helpers
{
    public class UserHelper
    {
        public User GetUserById(string id)
        {
            try
            {
                return ServiceHelper.GetServiceClientLoggedIn().GetUser(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}