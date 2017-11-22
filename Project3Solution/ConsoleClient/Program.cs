using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.HttpsServiceReference;
using ConsoleClient.AuthServiceReference;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            AuthServiceClient authClient = new AuthServiceClient();
            var isLoggedIn = authClient.Login("Mein Schaft", "!# test password #!");
            if (isLoggedIn)
            {
            SocialAdServiceClient cl = new SocialAdServiceClient();
            cl.ClientCredentials.UserName.UserName = "Mein Schaft";
            cl.ClientCredentials.UserName.Password = "!# test password #!";
            var data = cl.getData();
            Console.WriteLine(data);
            Console.ReadLine();
            }
        }
    }
}
