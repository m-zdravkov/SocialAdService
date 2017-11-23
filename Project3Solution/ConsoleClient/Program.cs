using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.HttpsServiceReference;
using ConsoleClient.AuthServiceReference;

/// <summary>
/// This client exists only to test the connection to the service. It should be replaced by a unit test.
/// </summary>
namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            AuthServiceClient authClient = new AuthServiceClient();
            var isLoggedIn = authClient.Login("mein.schaft@test.com", "!# test password #!");
            if (isLoggedIn)
            {
                Console.WriteLine("AuthService authentication succeeded.");
                SocialAdServiceClient cl = new SocialAdServiceClient();
                cl.ClientCredentials.UserName.UserName = "mein.schaft@test.com";
                cl.ClientCredentials.UserName.Password = "!# test password #!";
                var data = cl.getData();
                Console.WriteLine(data);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Could not log in with AuthService.");
            }
        }
    }
}
