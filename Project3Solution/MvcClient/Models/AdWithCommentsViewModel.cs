using MvcClient.AuthService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public class AdWithCommentsViewModel
    {
        public Ad Ad { get; set; }
        public Comment[] Comments { get; set; }
    }
}