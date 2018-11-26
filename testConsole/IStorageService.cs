using ConsoleApp1.Models.Agreement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public interface IStorageService
    {
        Task PostAgreementAsync(Agreement[] agreements);        
    }
}
