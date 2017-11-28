using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessTier;
using System.ServiceModel.Web;
using System.Net;
using Model;

namespace WcfServiceTier
{
    public class AuthService : IAuthService
    {
        public bool Login(string email, string password)
        {
            //return "Mein Schaft" == username && "!# test password #!" == password;
            var auth = AuthenticationControl.GetInstance();

            try
            {
                auth.Authenticate(email, password);
            }
            catch (Exception ex)
            {
                if (ex is UserNotFoundException || ex is WrongPasswordException || ex is InvalidOperationException)
                    return false;
            }
            //This should always be true at this point, but we compare the authenticated user just in case
            
            return auth.AuthenticatedUser.Email.ToLower().Equals(email.ToLower());
        }

        public bool Register(string email, string name, string password, string pictureUrl)
        {
            try
            {
                UserControl.GetInstance().RegisterUser(name, email, pictureUrl, password);
                return true;
            }
            catch (Exception ex)
            {
                //if (ex is InvalidOperationException)
                //    throw ex;
                Console.WriteLine(ex.Message);
                throw ex;
                //throw new WebFaultException<Exception>(ex, HttpStatusCode.InternalServerError);
            }
        }

        public IList<Ad> GetAds(int skip, int amount)
        {
            return AdControl.GetInstance().GetAds(skip,amount);
        }
    }
}
