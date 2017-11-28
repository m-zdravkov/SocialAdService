using BusinessTier;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTier
{
    public class SocialAdService : ISocialAdService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]

        public int CountUsers()
        {
            return UserControl.GetInstance().CountUsers();
        }

        public User GetUser(string userId)
        {
            return UserControl.GetInstance().GetUser(new User { Id = userId });
        }

        public IList<User> GetUsers(int skip, int amount)
        {
            return UserControl.GetInstance().GetAllUsers(skip,amount);
        }

        public void Authenticate(string email, string password)
        {
            AuthenticationControl.GetInstance().Authenticate(email,password);
        }

        public void LogOut()
        {
            AuthenticationControl.GetInstance().LogOut();
        }

        public void Register(string email, string password, string name, string pictureURL)
        {
            UserControl.GetInstance().RegisterUser(name, email, pictureURL, password);
        }

        public User GetAuthenticatedUser()
        {
            return AuthenticationControl.GetInstance().AuthenticatedUser;
        }
        public int GetData()
        {
            return 123;
        }

        public Comment GenerateTestPost(string content)
        {
            if (content.Length < 4)
                return null;

            return new Comment()
            {
                Id = content.Substring(0,4) + DateTime.UtcNow.ToString(),
                Content = content,
                DatePosted = DateTime.UtcNow,
            };
        }

        public IList<Ad> FetchAds(int skip, int amount)
        {
            return AdControl.GetInstance().GetAds(skip, amount);
        }

        public void PostAd(string title, string content)
        {
            try
            {
                //Get the author's identity from the service
                OperationContext oc = OperationContext.Current;
                ServiceSecurityContext ssc = oc.ServiceSecurityContext;
                string userEmail = ssc.PrimaryIdentity.Name;

                User author = new User
                {
                    Email = userEmail
                };

                AdControl.GetInstance().PostAd(author, title, content);
            }
            catch (InvalidOperationException)
            {
                throw new WebFaultException<Exception>(new Exception("The post details were invalid."), HttpStatusCode.BadRequest);
            }
            catch (UserNotFoundException)
            {
                throw new WebFaultException<Exception>(new Exception("The post author was not found."), HttpStatusCode.Unauthorized);
            }
        }
    }
}
