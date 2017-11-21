using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceTier;

namespace WcfServiceConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

                ServiceHost host = new ServiceHost(typeof(SocialAdService));
                ServiceHost authhost = new ServiceHost(typeof(AuthService));
                host.Open();
                Console.WriteLine("Social Ad service is hosted...");
                authhost.Open();
                Console.WriteLine("AuthService is hosted...");
                Console.ReadLine();
                host.Close();
                authhost.Close();
            
        }
    }
}
