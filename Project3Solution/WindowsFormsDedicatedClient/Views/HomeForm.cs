using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Views;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Controllers;

namespace WindowsFormsDedicatedClient
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            ViewController.Start(this);
            LogOut(); //Need this to initialize the components in the dashboard
            LoadAds(AdController.GetAds().ToShortAdList());
            RbAll.Select();
        }

        /// <summary>
        /// This only regards changing the Home view to a logged in user
        /// </summary>
        public void LogIn(LoginViewModel lvm)
        {
            var ctlDashboard = new DashboardUserControl();
            PanelDashboard.Controls.Clear();
            PanelDashboard.Controls.Add(ctlDashboard);
        }

        /// <summary>
        /// This only regards changing the Home view to a logged out user
        /// </summary>
        public void LogOut()
        {
            var ctlDashboard = new LoginDashboardUserControl();
            PanelDashboard.Controls.Clear();
            PanelDashboard.Controls.Add(ctlDashboard);
        }

        public void LoadAds(ShortAdUserControl[] list, bool clearFirst = true)
        {
            if (clearFirst)
                AdPanel.Controls.Clear();

            if (list != null)
            {
                foreach (var ad in list)
                {
                    AdPanel.Controls.Add(ad);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void AdPanel_MouseEnter(object sender, EventArgs e)
        {
            AdPanel.Focus();
        }
    }
}
