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
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SocialAdService : ISocialAdService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]

        //When we need to pass the current user to the business logic
        private string GetServiceUserEmail()
        {
            OperationContext oc = OperationContext.Current;
            ServiceSecurityContext ssc = oc.ServiceSecurityContext;
            return ssc.PrimaryIdentity.Name;
        }

        public int CountUsers()
        {
            return UserControl.GetInstance().CountUsers();
        }

        public User GetUser(string userId)
        {
            return UserControl.GetInstance().GetUserById(userId);
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

        ///TODO: DELETE THIS METHOD
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

        public void PostAd(string title, string content, string location, AdType type = AdType.Other)
        {
            try
            {
                var author = GetServiceUserEmail();
                AdControl.GetInstance().PostAd(author, title, content, location, type);
            }
            catch (InvalidOperationException ex)
            {
                throw new WebFaultException<InvalidOperationException>
                    (new InvalidOperationException("The post details were invalid. "+ex.Message), HttpStatusCode.BadRequest);
            }
            catch (UserNotFoundException)
            {
                throw new WebFaultException<UserNotFoundException>(
                    new UserNotFoundException("The post author was not found."), HttpStatusCode.Unauthorized);
            }
            catch (LocationNotFoundException)
            {
                throw new WebFaultException<LocationNotFoundException>
                    (new LocationNotFoundException("The post location was not found."), HttpStatusCode.NotFound);
            }
        }

        public void ReserveAd(string id)
        {
            try
            {
                var user = GetServiceUserEmail();
                AdControl.GetInstance().ReserveAd(id, user);
            }
            catch (AlreadyReservedException ex)
            {
                throw new WebFaultException<AlreadyReservedException>(ex,HttpStatusCode.Forbidden);
            }
            catch (NotEnoughReservationsException ex)
            {
                throw new WebFaultException<NotEnoughReservationsException>(ex,HttpStatusCode.Forbidden);
            }
            catch (PostNotFoundException ex)
            {
                throw new WebFaultException<PostNotFoundException>(ex, HttpStatusCode.Forbidden);
            }
            catch (UserNotFoundException ex)
            {
                throw new WebFaultException<UserNotFoundException>(ex, HttpStatusCode.Forbidden);
            }
            catch (Exception ex)
            {
                throw new WebFaultException<Exception>(ex, HttpStatusCode.InternalServerError);
            }
        }

        public void UnreserveAd(string id)
        {
            try
            {
                var user = GetServiceUserEmail();
                AdControl.GetInstance().UnreserveAd(id, user);
            }
            catch (ArgumentException ex)
            {
                throw new WebFaultException<ArgumentException>(ex, HttpStatusCode.Forbidden);
            }
            catch (PostNotFoundException ex)
            {
                throw new WebFaultException<PostNotFoundException>(ex, HttpStatusCode.Forbidden);
            }
            catch (UserNotFoundException ex)
            {
                throw new WebFaultException<UserNotFoundException>(ex, HttpStatusCode.Forbidden);
            }
            catch (Exception ex)
            {
                throw new WebFaultException<Exception>(ex, HttpStatusCode.InternalServerError);
            }
        }

        public void BuyReservations()
        {
            UserControl.GetInstance().BuyReservations(GetServiceUserEmail());
        }

        public void BuyBoosts()
        {
            UserControl.GetInstance().BuyBoosts(GetServiceUserEmail());
        }

        public IList<Ad> GetPostedAds()
        {
            return AdControl.GetInstance().GetPostedAds(GetServiceUserEmail());
        }

        public IList<Ad> GetReservedAds()
        {
            return AdControl.GetInstance().GetReservedAds(GetServiceUserEmail());
        }

        public User GetCurrentUser()
        {
            return UserControl.GetInstance().GetUser(GetServiceUserEmail());
        }

        public void PostComment(string adId, string content)
        {
            ///TODO: Move to BusinessTier
            Comment c = new Comment
            {
                Author = UserControl.GetInstance().GetUser(GetServiceUserEmail()),
                Content = content,
                ReplyId = adId,
            };

            CommentControl.GetInstance().AddComment(c);
        }
    }
}
