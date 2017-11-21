using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTier
{
    public class AuthService : IAuthService
    {
        public bool Login(string username, string password)
        {
            return "Mein Schaft" == username && "!# test password #!" == password;
        }
    }
}
