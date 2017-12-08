using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Models;
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
        public static LoginForm LoginForm { get; private set; }
        public static SignupForm SignupForm { get; set; }

        public static IReadOnlyDictionary<string, Form> Forms{
            get { return _forms as IReadOnlyDictionary<string, Form>; }
            private set { }
        }

        public static void Start()
        {
            HomeForm = new HomeForm();
        }

        public static void LogInView()
        {
            LoginForm = new LoginForm();
        }

        public static void LogIn(LoginViewModel lvm)
        {
            AuthController.LogIn(lvm);
            HomeForm.LogIn(lvm);
        }

        public static void SignUpView()
        {
            SignupForm = new SignupForm();
        }

        public static void SignUp(SignupViewModel svm)
        {
            AuthController.SignUp(svm);

            LogIn(new LoginViewModel
            {
                Email = svm.Email,
                Password = svm.Password
            });
        }

        public static void LogOut()
        {
            HomeForm.LogOut();
        }
    }
}
