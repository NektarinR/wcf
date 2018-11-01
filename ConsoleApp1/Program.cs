using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static FileServiceClient.FileServiceClient client = new FileServiceClient.FileServiceClient();
        static void Main(string[] args)
        {
            client.Open();
            Upload("SUBSIDY.xml", @"SUBSIDY.xml");
            File.Delete(@"SUBSIDY.xml");
            Download("SUBSIDY.xml");
            client.Close();
        }

        private static void Download(string v)
        {
            var result = client.DownLoad(v);
            using (var fs = new FileStream(Directory.GetCurrentDirectory() + $"\\{v}", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fs);
            }
            result.Close();
        }

        static void Upload(string nameFile, string fileN)
        {
            using (var file = new FileStream(fileN, FileMode.Open,
                FileAccess.Read))
            {
                client.Upload(nameFile, file);
            }
            
        }
    }
}
