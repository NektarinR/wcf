using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ServiceFileManager
{

    [ServiceContract]
    public interface IFileService
    {

        //[OperationContract]
        //Task<Stream> DownLoad(string fileName);

        [OperationContract]
        Task Upload(FileType composite);
    }

    
    [MessageContract]
    public class FileType
    {
        [MessageBodyMember]
        public Stream FileValue { get; set; }
    }
}
