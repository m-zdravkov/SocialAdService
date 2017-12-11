using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Controllers;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.Helpers;

namespace WindowsFormsDedicatedClient
{
    public partial class AdForm : Form
    {
        private Ad _currentAd;

        public AdForm(Ad ad)
        {
            InitializeComponent();
            LoadAd(ad);
            ReloadComments();
            ControlCommentPosting();
        }

        private void LoadAd(Ad ad)
        {
            if (ad == null)
                return;

            _currentAd = ad;

            LblTitle.Text = ad.Title;
            LblAuthor.Text = ad.Author.Name;
            LblLocation.Text = ad.Location.Name;
            LblDate.Text = ad.DatePosted.ToShortDateString();
            LblTime.Text = ad.DatePosted.ToShortTimeString();
            RtbContent.Text = ad.Content;

            DetermineReserveText();
            DetermineReserveButton();
            DetermineDeleteButton();
            ReloadComments();
        }

        private void LoadComments(CommentUserControl[] comments, bool clearFirst = true)
        {
            if (clearFirst)
                PanelComments.Controls.Clear();

            if(comments.Length > 0)
            {
                foreach (var comment in comments)
                {
                    PanelComments.Controls.Add(comment);
                }
            }
        }

        public void ReloadComments()
        {
            LoadComments(CommentController.GetAdComments(_currentAd.Id).ToCommentUcList());
        }

        public void ControlCommentPosting()
        {
            TbComment.Enabled = AuthHelper.IsLoggedIn();
        }

        private void BtnPostComment_Click(object sender, EventArgs e)
        {
            CommentController.PostComment(_currentAd.Id, TbComment.Text);
            ReloadComments();
        }

        public void DetermineReserveText(bool updateAd = false)
        {
            if (updateAd)
                _currentAd = AdController.GetAd(_currentAd.Id);

            if (_currentAd.ReservedBy != null)
            {
                LblReservedBy.Visible = true;
                LblReservedBy.Text = "Reserved by " + _currentAd.ReservedBy.Name;
            }
            else
                LblReservedBy.Visible = false;
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
                    var user = AuthController.GetUpdatedCurrentUserDetails();
                    //Only enabled if the user is not the author and has reservations
                    BtnReserve.Enabled =
                        (_currentAd.Author.Email != user.Email && user.Reservations > 0);
                }
                else
                {
                    BtnReserve.Enabled = false;
                }
            }
            else
            {
                BtnReserve.Visible = false;
            }
        }

        public void DetermineDeleteButton()
        {
            if(AuthHelper.IsLoggedIn() && _currentAd.Author.Email == AuthHelper.CurrentUser.Email)
            {
                BtnDelete.Visible = true;
            }else
            {
                BtnDelete.Visible = false;
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            AdController.ReserveAd(_currentAd.Id);
            DetermineReserveButton(true);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            AdController.DeleteAd(_currentAd.Id);
        }
    }
}
