using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcClient.SocialAdService;
using MvcClient.AuthService;
using System.Net;

namespace MvcClient.Helpers
{
    public static class ServiceHelper
    {
        public static SocialAdServiceClient GetServiceClientWithCredentials(string username, string password)
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            SocialAdServiceClient client = new SocialAdServiceClient();// "BasicHttpBinding_ISocialAdService");
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = username;
            return client;
        }

        public static AuthServiceClient GetAuthServiceClient()
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            return new AuthServiceClient("WSHttpBinding_IAuthService");
        }
    }
}