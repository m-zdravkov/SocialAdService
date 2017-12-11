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
            LoadComments(AdController.GetAdComments(_currentAd.Id).ToCommentUcList());
        }

        public void ControlCommentPosting()
        {
            TbComment.Enabled = AuthHelper.IsLoggedIn();
        }

        private void btnPostComment_Click(object sender, EventArgs e)
        {
            AdController.PostComment(_currentAd.Id, TbComment.Text);
            ReloadComments();
        }
    }
}
