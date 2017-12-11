using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePrivate;

namespace WindowsFormsDedicatedClient.Helpers
{
    public class AuthHelper
    {
        private static LoginViewModel _currentUser;

        public static LoginViewModel CurrentUser
        {
            get
            {
                return _currentUser;
            }
            private set
            {
                _currentUser = value;
            }
        }

        public static User CurrentUserDetails { get; set; }


        public static bool IsLoggedIn()
        {
            return _currentUser != null;
        }
        public static void LogIn(LoginViewModel lvm)
        {
            _currentUser = lvm;
        }
        public static void LogOut()
        {
            _currentUser = null;
        }
    }
}
