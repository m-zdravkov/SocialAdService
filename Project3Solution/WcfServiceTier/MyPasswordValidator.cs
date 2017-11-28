using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.IdentityModel.Selectors;
using System.ServiceModel;
using BusinessTier;
using System.Net;
using System.ServiceModel.Web;

namespace WcfServiceTier
{
    public class MyPasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string email, string password)
        {
            /*if (userName == "Mein Schaft" && password == "!# test password #!")
            {

            }
            else
            {
                throw new FaultException<Exception>(new Exception("Incorrect Login"), "Try again maaatey");
            }*/
            try
            {
                AuthenticationControl.GetInstance().Authenticate(email, password);
            }
            catch (Exception ex)
            {
                if (ex is UserNotFoundException || ex is WrongPasswordException || ex is InvalidOperationException)
                    throw new WebFaultException(HttpStatusCode.Unauthorized);
            }
        }
    }
}
