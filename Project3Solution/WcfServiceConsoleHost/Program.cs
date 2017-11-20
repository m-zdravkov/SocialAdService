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

            using (ServiceHost host = new ServiceHost(typeof(SocialAdService)))
            {
                host.Open();
                Console.WriteLine("Social Ad service is hosted...");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
