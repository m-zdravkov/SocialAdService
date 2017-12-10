using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Controllers;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class LoginDashboardUserControl : UserControl
    {
        public LoginDashboardUserControl()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ViewController.LogInView();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            ViewController.SignUpView();
        }
    }
}
