using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace TesteBlobStorage
{
    public static class BlobStorageHelper
    {
        private static CloudBlobContainer ObterReferenciaContainer(
            string nomeContainer)
        {
            CloudStorageAccount storageAccount =
                CloudStorageAccount.Parse(CloudConfigurationManager
                    .GetSetting("StorageConnectionString"));

            CloudBlobClient blobClient =
                storageAccount.CreateCloudBlobClient();

            return blobClient.GetContainerReference(nomeContainer);
        }

        private static CloudBlockBlob ObterReferenciaBlockBlob(
            string nomeContainer, string nomeBlob)
        {
            CloudBlobContainer container =
                ObterReferenciaContainer(nomeContainer);

            CloudBlockBlob blob =
                container.GetBlockBlobReference(nomeBlob);

            return blob;
        }

        public static void CheckContainer(
            string nomeContainer)
        {
            CloudBlobContainer container =
                ObterReferenciaContainer(nomeContainer);
            container.CreateIfNotExists();
        }

        public static void UploadBlockBlob(
            string nomeContainer,
            string nomeBlob,
            string nomeArquivo)
        {
            CloudBlockBlob blob =
                ObterReferenciaBlockBlob(nomeContainer, nomeBlob);
            blob.UploadFromFile(nomeArquivo);
        }

        public static void DownloadBlockBlob(
            string nomeContainer,
            string nomeBlob,
            string nomeArquivo)
        {
            CloudBlockBlob blob =
                ObterReferenciaBlockBlob(nomeContainer, nomeBlob);
            blob.DownloadToFile(nomeArquivo, FileMode.CreateNew);
        }

        public static void DeleteBlockBlob(
            string nomeContainer,
            string nomeBlob)
        {
            CloudBlockBlob blob =
                ObterReferenciaBlockBlob(nomeContainer, nomeBlob);
            blob.Delete();
        }

        public static List<String> ListBlockBlobs(
            string nomeContainer)
        {
            List<string> blobs = new List<string>();

            CloudBlobContainer container =
                ObterReferenciaContainer(nomeContainer);
            foreach (var blob in container.ListBlobs())
            {
                if (blob is CloudBlockBlob)
                    blobs.Add(((CloudBlockBlob)blob).Name);
            }

            return blobs;
        }
    }
}   