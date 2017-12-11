using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;
using WindowsFormsDedicatedClient.Helpers;
using System.Windows.Forms;

namespace WindowsFormsDedicatedClient.Controllers
{
    public static class AdController
    {
        public static Ad[] GetAds()
        {
            Ad[] ads = null;

            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                ads = client.GetAds(0, 1024);
            }

            return ads;
        }

        public static Ad[] GetAdsOfType(AdType type)
        {
            Ad[] ads = null;

            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                ads = client.FindAds(0, 1024, "", "", type);
            }

            return ads;
        }

        public static Ad[] GetReservedAds()
        {
            Ad[] ads = null;

            using (var client = ServiceHelper.GetServiceClientLoggedIn())
            {
                ads = client.GetReservedAds().Convert();
            }

            return ads;
        }

        public static Ad[] GetPostedAds()
        {
            Ad[] ads = null;

            using (var client = ServiceHelper.GetServiceClientLoggedIn())
            {
                ads = client.GetPostedAds().Convert();
            }

            return ads;
        }

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
            }else
            {
                MessageBox.Show("You need to be logged in to comment.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static Ad GetAd(string id)
        {
            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                return client.GetAd(id);
            }
        }

        public static Ad[] FindAds(string location, string query, AdType type)
        {
            using (var client = ServiceHelper.GetAuthServiceClient())
            {
                return client.FindAds(0, 1024, location, query, type);
            }
        }
    }
}
