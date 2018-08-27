using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;


using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using SrednjeSkole_API.Util.BlobStorage;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Blobs")]
    public class BlobsController : ApiController
    {
        private const string Container = "srednjeskole";
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> UploadFile()
        {
            var accountName = ConfigurationManager.AppSettings["Blob_StorageAccount"];
            var accountKey = ConfigurationManager.AppSettings["Blob_StorageKey"];
            var storageAccount = new CloudStorageAccount(new StorageCredentials(accountName, accountKey), true);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer materijaliContainer = blobClient.GetContainerReference(Container);
            var provider = new AzureStorageMultipartFormDataStreamProvider(materijaliContainer);
            try
            {
                await Request.Content.ReadAsMultipartAsync(provider);
                //exception: stream not supported for reading
            }
            catch (Exception ex)
            {
                return BadRequest($"An error has occured. Details: {ex.Message}");
            }

            // Retrieve the filename of the file you have uploaded
            var filename = provider.FileData.FirstOrDefault()?.LocalFileName;
            if (string.IsNullOrEmpty(filename))
            {
                return BadRequest("An error has occured while uploading your file. Please try again.");
            }

            return Ok(filename);
        }
    }
}
