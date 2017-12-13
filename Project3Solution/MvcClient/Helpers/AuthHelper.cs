using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcClient.Models;
using MvcClient.SocialAdService;

namespace MvcClient.Helpers
{
    public class AuthHelper
    {
        private static string LoginSessionName = "LoggedInUser";
        private static LoginViewModel _currentUser;
        private static User _currentUserDetails;

        public static LoginViewModel CurrentUser
        {
            get
            {
                return HttpContext.Current.Session[LoginSessionName] as LoginViewModel;
            }
            set
            {
                _currentUser = value;
            }
        }


        public static bool IsLoggedIn()
        {
            return HttpContext.Current.Session[LoginSessionName] != null;
        }
        public static void LogIn(LoginViewModel lvm)
        {
            HttpContext.Current.Session[LoginSessionName] = lvm;
            _currentUser = lvm;
        }

        public static void  UpdateLogInDetails()
        {
            using (var client = ServiceHelper.GetServiceClientLoggedIn())
            {
                _currentUserDetails = client.GetCurrentUser();
                _currentUser.Name = _currentUserDetails?.Name;
            }
        }

        public static void LogOut()
        {
            HttpContext.Current.Session[LoginSessionName] = null;
        }
    }
}