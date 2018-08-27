using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace SrednjeSkole_UI.Util.BlobStorage
{
    public class AzureBlobStorage: IAzureBlobStorage
    {
        //AzureBlobSetings settings = new AzureBlobSetings("srednjeskole", "Wh8zk+437uReFvE/M1+Q8g9/3AttRTJUIyCbUWs+iKM5MpcftwhMReWRSxDOa+jzII4CrFmeK3H5grDPEpWIhg==", "srednjeskole");
        private readonly AzureBlobSettings settings;
        public AzureBlobStorage(AzureBlobSettings settings)
        {
            this.settings = settings;
        }

        #region public

        public async Task UploadAsync(string blobName, string filePath)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Upload
            using (var fileStream = System.IO.File.Open(filePath, FileMode.Open))
            {
                fileStream.Position = 0;
                await blockBlob.UploadFromStreamAsync(fileStream);
            }
        }

        public async Task UploadAsync(string blobName, Stream stream)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);
                        
            //Upload
            stream.Position = 0;
            await blockBlob.UploadFromStreamAsync(stream);
        }

        public async Task<MemoryStream> DownloadAsync(string blobName)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Download
            using (var stream = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(stream);
                return stream;
            }
        }

        public async Task DownloadAsync(string blobName, string path)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Download
            await blockBlob.DownloadToFileAsync(path, FileMode.Create);
        }

        public async Task DeleteAsync(string blobName)
        {
            //Blob
            CloudBlockBlob blockBlob = await GetBlockBlobAsync(blobName);

            //Delete
            await blockBlob.DeleteAsync();
        }       

        public async Task<List<AzureBlobItem>> ListAsync()
        {
            return await GetBlobListAsync();
        }
        public async Task<string> GetBlobByName(string blobName)
        {
            CloudBlobContainer blobContainer = await GetContainerAsync();                        
            return blobContainer.GetBlockBlobReference(blobName).StorageUri.PrimaryUri.AbsoluteUri;
        }      
        #endregion

        private async Task<CloudBlobContainer> GetContainerAsync()
        {
            //Account
            CloudStorageAccount storageAccount = new CloudStorageAccount(
         new StorageCredentials(settings.StorageAccount, settings.StorageKey), false);

            //Client
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //Container
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(settings.ContainerName);
            await blobContainer.CreateIfNotExistsAsync();

            return blobContainer;
        }

        private async Task<CloudBlockBlob> GetBlockBlobAsync(string blobName)
        {
            //Container
            CloudBlobContainer blobContainer = await GetContainerAsync();

            //Blob
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(blobName);

            return blockBlob;
        }

        private async Task<List<AzureBlobItem>> GetBlobListAsync(bool useFlatListing = true)
        {
            //Container
            CloudBlobContainer blobContainer = await GetContainerAsync();

            //List
            var list = new List<AzureBlobItem>();
            BlobContinuationToken token = null;
            do
            {
                BlobResultSegment resultSegment =
                    await blobContainer.ListBlobsSegmentedAsync("", useFlatListing,
                          new BlobListingDetails(), null, token, null, null);
                token = resultSegment.ContinuationToken;

                foreach (IListBlobItem item in resultSegment.Results)
                {
                    list.Add(new AzureBlobItem(item));
                }
            } while (token != null);

            return list.OrderBy(i => i.Folder).ThenBy(i => i.Name).ToList();
        }        
    }
}
