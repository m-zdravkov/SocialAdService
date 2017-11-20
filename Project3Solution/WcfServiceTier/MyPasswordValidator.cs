using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WcfServiceTier
{
    public class MyPasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "Mein Schaft" && password == "!# test password #!")
            {

            }
            else
            {
                throw new FaultException<Exception>(new Exception("Incorrect Login"), "Try again maaatey");
            }
            /*try
            {
                SocialAdService service = new SocialAdService();
                service.Authenticate(userName, password);
            }
            catch
            {
                throw new FaultException<Exception>(new Exception("Incorrect Login"), "Invalid login attempt");
            }*/
        }
    }
}
