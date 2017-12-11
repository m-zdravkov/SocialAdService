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
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Helpers;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class ShortAdUserControl : UserControl
    {
        private Ad _currentAd = null;

        public ShortAdUserControl(Ad ad)
        {
            InitializeComponent();
            DisplayAd(ad);
        }

        private void DisplayAd(Ad ad)
        {
            _currentAd = ad;
            
            LblTitle.Text = ad.Title;
            LblAuthor.Text = ad.Author.Name;
            LblDate.Text = ad.DatePosted.ToShortDateString();
            LblTime.Text = ad.DatePosted.ToShortTimeString();
            LblLocation.Text = ad.Location?.Name;

            DetermineReserveButton();
        }

        public void DetermineReserveButton(bool updateAd = false)
        {
            if (updateAd)
                _currentAd = AdController.GetAd(_currentAd.Id);

            //If it's a selling ad and the user is logged in
            if (_currentAd.Type == AdType.Selling && AuthHelper.IsLoggedIn())
            {
                BtnReserve.Visible = true;

                //If the ad is unreserved
                if (_currentAd.ReservedBy == null)
                {
                    var user = AuthHelper.CurrentUserDetails;
                    //Only enabled if the user is not the author and has reservations
                    BtnReserve.Enabled =
                        (_currentAd.Author.Email != user.Email && user.Reservations > 0);
                }
                else //If the ad is reserved
                {
                    BtnReserve.Enabled = false;
                }
            }else
            {
                BtnReserve.Enabled = false;
                BtnReserve.Visible = false;
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewController.ViewAd(_currentAd.Id);
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            AdController.ReserveAd(_currentAd.Id);
            DetermineReserveButton(true);
        }
    }
}
