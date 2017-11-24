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
            SocialAdServiceClient client = new SocialAdServiceClient("WSHttpBinding_ISocialAdService");
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }

        public static SocialAdServiceClient GetServiceClientLoggedIn()
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            SocialAdServiceClient client = new SocialAdServiceClient("WSHttpBinding_ISocialAdService");
            client.ClientCredentials.UserName.UserName = AuthHelper.CurrentUser.Email;
            client.ClientCredentials.UserName.Password = AuthHelper.CurrentUser.Password;
            return client;
        }

        public static AuthServiceClient GetAuthServiceClient()
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            return new AuthServiceClient("WSHttpBinding_IAuthService");
        }
    }
}