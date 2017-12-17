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
            try
            {
                ServiceHost host = new ServiceHost(typeof(SocialAdService));
                ServiceHost authhost = new ServiceHost(typeof(SocialAdServicePublic));
                host.Open();
                Console.WriteLine("Social Ad service is hosted...");
                authhost.Open();
                Console.WriteLine("AuthService is hosted...");
                Console.ReadLine();
                host.Close();
                authhost.Close();

            } catch (InvalidOperationException ex)
            {
                Console.WriteLine("Certificate error!\nPlease remember to set the X.509 certificate thumbprint in App.config.");
                Console.WriteLine("Change the \"findValue\" attribute under \"serviceCertificate\" to your own certificate's thumbprint. Remember to do this for BOTH service behaviours.");

                Console.WriteLine("\nTHE SERVICE CAN NOT BE STARTED without this.\n");

                Console.WriteLine("Here is the exception message in case this is not the problem:\n");
                throw ex;
            }
        }
    }
}
