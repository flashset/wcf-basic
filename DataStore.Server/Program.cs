using DataStore.Server.FileStore;
using DataStore.Server.Models;
using System;
using System.ServiceModel;
using System.ServiceProcess; 

namespace DataStore.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var myServiceHost = new ServiceHost(typeof(FileOperations));
            
            try
            { 
                myServiceHost.Open();
                Console.WriteLine("Service Started Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}
