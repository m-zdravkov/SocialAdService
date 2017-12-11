using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Helpers;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;

namespace WindowsFormsDedicatedClient.Controllers
{
    public static class AuthController
    {
        public static bool LogIn(LoginViewModel lvm)
        {
            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                try
                {
                    if (client.Login(lvm.Email, lvm.Password))
                    {
                        AuthHelper.LogIn(lvm);

                        using (var privateClient = ServiceHelper.GetServiceClientLoggedIn())
                        {
                            AuthHelper.CurrentUserDetails = privateClient.GetAuthenticatedUser();
                        }
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An internal error occured while trying to log in. Details:\n"+ex.Message,
                        "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static bool SignUp(SignupViewModel svm)
        {
            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                try
                {
                    return client.Register(svm.Email, svm.Name, svm.Password, "http://test.com/image.jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An internal error occured while trying to register. Details:\n" + ex.Message,
                        "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static void LogOut()
        {
            AuthHelper.LogOut();
        }

        public static SaServicePrivate.User GetUpdatedCurrentUserDetails()
        {
            SaServicePrivate.User user = null;
            using (var client = ServiceHelper.GetServiceClientLoggedIn())
            {
                user = client.GetCurrentUser();
                AuthHelper.CurrentUserDetails = user;
            }

            return user;
        }
    }
}
