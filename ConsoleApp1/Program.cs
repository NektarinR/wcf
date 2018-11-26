using ConsoleApp1.Context;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Agreement;
using ConsoleApp1.Models.Industry_list;
using ConsoleApp1.Models.List_Service_Work;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static FileServiceClient.FileServiceClient client = new FileServiceClient.FileServiceClient();
        static void Main(string[] args)
        {

            //using (var sqliteDbContext = new SqliteDbConxext())
            //{
            //    sqliteDbContext.Database.EnsureCreated();
            //    XmlSerializer serializer = new XmlSerializer(typeof(RootAgreement));
            //    using (var reader = XmlReader.Create("AGREEMENT.xml"))
            //    {
            //        RootAgreement info = (RootAgreement)serializer.Deserialize(reader);
            //        sqliteDbContext.AgreementOrgs.Load();
            //        sqliteDbContext.Agreements.Load();
            //        sqliteDbContext.Bos.Load();
            //        sqliteDbContext.Schedules.Load();
            //        foreach (var s in info.Agreements)
            //        {
            //            //if (!sqliteDbContext.AgreementOrgs.Any(f => f.Id == s.AgreementOrg.Id))
            //            //{
            //                sqliteDbContext.Agreements.Add(s);
            //                try
            //                {
            //                    sqliteDbContext.SaveChanges();
            //                }
            //                catch (Exception ex)
            //                {
            //                    Console.WriteLine(ex.Message);
            //                }

            //        }
            //    }
            //}
            client.Open();
            Upload("AGREEMENT.xml", @"AGREEMENT.xml");
            File.Delete(@"SUBSIDY.xml");
            //Download("SUBSIDY.xml");
            client.Close();
        }

        //private static void Download(string v)
        //{

        //    var result = client.DownLoad(v);
        //    using (var fs = new FileStream(Directory.GetCurrentDirectory() + $"\\{v}", FileMode.Create, FileAccess.Write))
        //    {
        //        result.CopyTo(fs);
        //    }
        //    result.Close();
        //}

        static void Upload(string nameFile, string fileN)
        {
            using (var file = new FileStream(fileN, FileMode.Open,
                FileAccess.Read))
            {
                var str = File.ReadAllText(nameFile) ;
                client.Upload(file);
            }
            
        }
    
    }
}
