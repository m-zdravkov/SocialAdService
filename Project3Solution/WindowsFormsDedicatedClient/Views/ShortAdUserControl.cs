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

namespace WindowsFormsDedicatedClient.Views
{
    public partial class ShortAdUserControl : UserControl
    {
        public string Id { get; private set; }

        public ShortAdUserControl(Ad ad)
        {
            InitializeComponent();
            DisplayAd(ad);
        }

        private void DisplayAd(Ad ad)
        {
            Id = ad.Id;
            LblTitle.Text = ad.Title;
            LblAuthor.Text = ad.Author.Name;
            LblDate.Text = ad.DatePosted.ToShortDateString();
            LblTime.Text = ad.DatePosted.ToShortTimeString();
            LblLocation.Text = ad.Location?.Name;
        }

        private void DisplayAd(SaServicePrivate.Ad ad)
        {
            Id = ad.Id;
            LblTitle.Text = ad.Title;
            LblDate.Text = ad.DatePosted.ToShortDateString();
            LblTime.Text = ad.DatePosted.ToShortTimeString();
            LblLocation.Text = ad.Location.Name;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewController.ViewAd(Id);
        }
    }
}
