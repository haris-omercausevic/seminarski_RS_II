using Microsoft.WindowsAzure.Storage.Blob;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


//https://github.com/TahirNaushad/Fiver.Azure.Blob

namespace SrednjeSkole_API.Util.BlobStorage
{
    public interface IAzureBlobStorage
    {
        Task UploadAsync(string blobName, string filePath);
        Task UploadAsync(string blobName, Stream stream);
        Task<MemoryStream> DownloadAsync(string blobName);
        Task DownloadAsync(string blobName, string path);
        Task<List<AzureBlobItem>> ListAsync();
        Task<string> GetBlobByName(string blobName);
        Task DeleteAsync(string blobName);
    }
}