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
using WindowsFormsDedicatedClient.Helpers;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            LblUserEmail.Text = AuthHelper.CurrentUser.Email;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ViewController.LogOut();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ViewController.ViewYourProfile();
        }
    }
}
