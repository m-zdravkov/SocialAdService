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

        public static void ReserveAd(string id)
        {
            try
            {
                using (var client = ServiceHelper.GetServiceClientLoggedIn())
                {
                    client.ReserveAd(id);
                    AuthController.GetUpdatedCurrentUserDetails();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Something went wrong and the ad couldn't be reserved.\nTechnical details:\n\n"+ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteAd(string id)
        {
            using (var client = ServiceHelper.GetServiceClientLoggedIn())
            {
                try
                {
                    client.DeleteAd(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete ad.\nTechnical details\n\n"+ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
