using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Helpers;
using WindowsFormsDedicatedClient.SaServicePrivate;
using WindowsFormsDedicatedClient.SaServicePublic;

namespace WindowsFormsDedicatedClient.Controllers
{
    public static class CommentController
    {
        public static Comment[] GetAdComments(string adId)
        {
            Comment[] comments = null;

            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                comments = client.GetAdReplies(0, 64, adId);
            }
            
            return comments;
        }

        public static void PostComment(string adId, string content)
        {
            if (AuthHelper.IsLoggedIn())
            {
                using (var client = ServiceHelper.GetServiceClientLoggedIn())
                {
                    client.PostComment(adId, content);
                }
            }
            else
            {
                MessageBox.Show("You need to be logged in to comment.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
