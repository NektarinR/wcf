using System.IO;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ServiceFileManager
{

    [ServiceContract]
    public interface IFileService
    {

        [OperationContract]
        Task<Stream> DownLoad(string fileName);

        [OperationContract]
        Task Upload(FileType composite);
    }

    
    [MessageContract]
    public class FileType
    {
        private string nameFileValue ;

        [MessageHeader]
        public string NameFileValue
        {
            get { return nameFileValue; }
            set { nameFileValue = value; }
        }

        [MessageBodyMember]
        public Stream FileValue { get; set; }
    }
}
