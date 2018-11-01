using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public interface IStorageService
    {
        Task<byte[]> GetFileAsync(string name);
        Task PutFileAsync(string name, byte[] file);
    }
}
