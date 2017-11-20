using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.HttpsServiceReference;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            SocialAdServiceClient cl = new SocialAdServiceClient();
            var data = cl.getData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
