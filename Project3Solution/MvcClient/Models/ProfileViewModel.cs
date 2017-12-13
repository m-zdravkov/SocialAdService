using MvcClient.SocialAdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public AuthService.Ad[] ReservedAds { get; set; }
        public AuthService.Ad[] PostedAds { get; set; }
    }
}