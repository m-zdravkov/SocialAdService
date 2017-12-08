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
        public static void LogIn(LoginViewModel lvm)
        {
            try
            {
                AuthHelper.LogIn(lvm);
            }catch (Exception ex)
            {
                MessageBox.Show("Could not log you in with these credentials.","Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SignUp(SignupViewModel svm)
        {
            try
            {
                var client = ServiceHelper.GetAuthServiceClient();
                client.Register(svm.Email, svm.Name, svm.Password, "http://test.com/image.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not register with these credentials.", "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
