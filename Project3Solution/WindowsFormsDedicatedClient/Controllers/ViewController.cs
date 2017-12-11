using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;

namespace WindowsFormsDedicatedClient.Controllers
{
    /// <summary>
    /// Responsible for controlling which views are loaded and displayed.
    /// Responsible for connection view actions to controller methods.
    /// </summary>
    public static class ViewController
    {
        private static IDictionary<string, Form> _forms;

        public static HomeForm HomeForm { get; private set; }
        public static LogInForm LogInForm { get; private set; }
        public static SignUpForm SignUpForm { get; private set; }
        public static AdForm AdForm { get; private set; }
        public static YourProfileForm YourProfileForm { get; set; }
        public static SearchForm SearchForm { get; set; }

        public static IReadOnlyDictionary<string, Form> Forms{
            get { return _forms as IReadOnlyDictionary<string, Form>; }
            private set { }
        }

        public static void Start(HomeForm homeForm)
        {
            if (HomeForm == null)
                HomeForm = homeForm;
            else throw new InvalidOperationException("View controller already started.");
        }

        public static void LogInView()
        {
            LogInForm = new LogInForm();
            LogInForm.Show();
        }

        public static void LogIn(LoginViewModel lvm)
        {
            if(AuthController.LogIn(lvm))
            {
                HomeForm.LogIn(lvm);
                LogInForm.Close();
                AdForm?.ControlCommentPosting();
            }else
            {
                MessageBox.Show("Could not log you in with these credentials.",
                        "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SignUpView()
        {
            SignUpForm?.Close();
            SignUpForm = new SignUpForm();
            SignUpForm.Show();
        }

        public static void SignUp(SignupViewModel svm)
        {
            if (AuthController.SignUp(svm))
            {

                LogIn(new LoginViewModel
                {
                    Email = svm.Email,
                    Password = svm.Password
                });

                SignUpForm.Close();
            }else
            {
                MessageBox.Show("Could not register you with these credentials.",
                        "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LogOut()
        {
            AuthController.LogOut();
            HomeForm.LogOut();
            AdForm?.ControlCommentPosting();
        }

        public static void ViewAd(string id)
        {
            AdForm?.Close();
            AdForm = new AdForm(AdController.GetAd(id));
            AdForm.Show();
        }

        public static void ViewYourProfile()
        {
            YourProfileForm?.Close();
            YourProfileForm = new YourProfileForm();
            YourProfileForm.Show();
        }

        public static void SearchView()
        {
            SearchForm?.Close();
            SearchForm = new SearchForm();
            SearchForm.Show();
        }

        public static void FindAds(string query, string location, AdType type)
        {
            var ads = AdController.FindAds(location, query, type);
            HomeForm.LoadAds(ads.ToShortAdUcList());
        }
    }
}
