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
        public AdWithCommentsViewModel[] ReservedAds { get; set; }
        public AdWithCommentsViewModel[] PostedAds { get; set; }
    }
}