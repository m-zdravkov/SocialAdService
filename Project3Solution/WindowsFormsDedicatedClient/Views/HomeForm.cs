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
            LoadAds(AdController.GetAds().ToShortAdUcList());
            RbAll.Select();
            BtnPost.Enabled = false;
        }

        /// <summary>
        /// This only regards changing the Home view to a logged in user
        /// </summary>
        public void LogIn(LoginViewModel lvm)
        {
            var ctlDashboard = new DashboardUserControl();
            PanelDashboard.Controls.Clear();
            PanelDashboard.Controls.Add(ctlDashboard);
            UpdateAds();
            BtnPost.Enabled = true;
        }

        /// <summary>
        /// This only regards changing the Home view to a logged out user
        /// </summary>
        public void LogOut()
        {
            var ctlDashboard = new LoginDashboardUserControl();
            PanelDashboard.Controls.Clear();
            PanelDashboard.Controls.Add(ctlDashboard);
            UpdateAds();
            BtnPost.Enabled = false;
        }

        public void UpdateAds()
        {
            LoadAds(AdController.GetAds().ToShortAdUcList());
            RbAll.Checked = true;
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
            ViewController.SearchView();
        }

        private void AdPanel_MouseEnter(object sender, EventArgs e)
        {
            if(this.ContainsFocus)
                AdPanel.Focus();
        }

        private void LoadAdsType(AdType type)
        {
            LoadAds(AdController.GetAdsOfType(type).ToShortAdUcList());
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadAds(AdController.GetAds().ToShortAdUcList());
        }

        private void RbSelling_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.Selling);
        }

        private void RbBuying_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.Buying);
        }

        private void RbServiceOffers_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.ServiceOffer);
        }

        private void RbServiceRequests_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.ServiceRequest);
        }

        private void RbEvents_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.Event);
        }

        private void RbOther_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdsType(AdType.Other);
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            ViewController.PostAdView();
        }
    }
}
