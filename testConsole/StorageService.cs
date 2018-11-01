using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace testConsole
{
    public class StorageService:IStorageService
    {
        private static readonly StorageService _storage = new StorageService();

        //private readonly SqliteContext _dbContext;

        private StorageService()
        {
            //_dbContext = new SqliteContext();
        }

        public static StorageService GetInstance()
        {
            return _storage;
        }

        public async Task<byte[]> GetFileAsync(string name)
        {
            byte[] result;
            using (var _dbContext = new SqliteContext())
            {
                result = (_dbContext.Files.FirstOrDefault(p => p.Name == name)).File;
            }
            return result;
        }

        public async Task PutFileAsync(string name, byte[] file)
        {
            using (var _dbContext = new SqliteContext())
            {
                var fileModel = new FileModel() { Name = name, File = file };
                _dbContext.Files.Add(fileModel);
                _dbContext.SaveChanges();
            }
        
        }

    }
}
