
using log4net;
using log4net.Config;
using System;
using System.ServiceModel;
using testConsole;

namespace ServiceFileManager
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            using (var context = new SqliteContext())
                context.Database.EnsureCreated();
            using (ServiceHost host = new ServiceHost(typeof(FileService)))
            {
                host.Open();
                _log.Debug("Wcf service starts");
                Console.WriteLine($"Service started - {host.BaseAddresses[0]}");
                Console.ReadKey(false);
                host.Close();
            }
        }
    }
}
