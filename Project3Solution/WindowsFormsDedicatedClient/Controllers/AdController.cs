using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePublic;
using WindowsFormsDedicatedClient.Views;
using WindowsFormsDedicatedClient.Helpers;

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
    }
}
