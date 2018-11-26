using ConsoleApp1.Models.Agreement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace testConsole
{
    public class StorageService:IStorageService
    {
        private static readonly StorageService _storage = new StorageService();

        private readonly SqliteContext _dbContext = new SqliteContext();

        private StorageService()
        {
            //_dbContext = new SqliteContext();
            _dbContext.AgreementOrgs.Load();
            _dbContext.Agreements.Load();
            _dbContext.Bos.Load();
            _dbContext.Schedules.Load();
        }

        public static StorageService GetInstance()
        {
            return _storage;
        }

        public async Task PostAgreementAsync(Agreement[] agreements)
        {
            foreach (var s in agreements)
            {
                _dbContext.Agreements.Add(s);
                try
                {
                    await _dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _dbContext.Agreements.Remove(s);
                }
            }
            await _dbContext.SaveChangesAsync();
        }

    }
}
