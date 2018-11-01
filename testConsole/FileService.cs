using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using testConsole;

namespace ServiceFileManager
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class FileService : IFileService
    {
        private IStorageService _storageService;
        private readonly ILog _log;
        private readonly ILog _dbLog;

        public FileService()
        {
            _log = LogManager.GetLogger(typeof(FileService));
            _dbLog = LogManager.GetLogger("SqliteLogger");
            _storageService = StorageService.GetInstance();
            _log.Debug("Wcf service is created");
            _dbLog.Debug("Wcf service is created");
        }

        public async Task<Stream> DownLoad(string fileName)
        {
            _log.Info("Entering Download()");
            _log.Debug($"File ({fileName}) is searching in DB");
            var file = await _storageService.GetFileAsync(fileName);
            MemoryStream ms;
            if (file == null)
            {
                _log.Debug($"File - {fileName} cant find");
                ms = new MemoryStream();
            }
            else
            {
                _log.Debug($"File {fileName} catch, its size - {file.Length} byte");
                ms = new MemoryStream(file);
                file = null;
            }
            ms.Position = 0;
            _log.Info("Exiting Download()");
            return ms;
        }
        
        public async Task Upload(FileType composite)
        {
            _log.Info("Entering Upload()");
            byte[] file;
            using (var ms = new MemoryStream())
            {
                await composite.FileValue.CopyToAsync(ms);
                composite.FileValue.Close();
                file = ms.ToArray();
            }
            try
            {
                _log.Debug($"File ({composite.NameFileValue}) upload, size is {file.Length} byte in DB");
                await _storageService.PutFileAsync(composite.NameFileValue, file);
                file = null;
            }catch(Exception e)
            { 
                _log.Error("Exception", e);
                Console.WriteLine(e.Message);
            }
            _log.Info("Exiting Upload()");
        }
    }
}
