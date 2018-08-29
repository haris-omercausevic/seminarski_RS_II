using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using SrednjeSkole_UI.Util.BlobStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.MaterijaliNS
{
    public partial class AddMaterijal : Form
    {
        private WebAPIHelper materijaliService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MaterijaliRoute);
        private WebAPIHelper blobsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.BlobsRoute);
        private WebAPIHelper predajeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PredajeRoute);
        public AddMaterijal()
        {
            InitializeComponent();
        }
        private void AddMaterijal_Load(object sender, EventArgs e)
        {
            BindPredmeti();
        }
        private void BindPredmeti()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = predajeService.GetActionResponse("ByNastavnik", Global.prijavljeniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode)
            {
                predajeCmb.DataSource = response.Content.ReadAsAsync<List<Predaje_Result>>().Result;
                predajeCmb.DisplayMember = "Naziv";
                predajeCmb.ValueMember = "PredajeId";
                predajeCmb.SelectedValue = "";
            }

            Cursor.Current = Cursors.Default;
        }


        private void dodajFajlBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            fajlInput.Text = openFileDialog.FileName;
            fajlInput.ReadOnly = true;
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            Cursor.Current = Cursors.WaitCursor;

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Global.connString);

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference(Global.BlobContainer);

            // Retrieve reference to a blob named "myblob".
            var blobName = Guid.NewGuid().ToString();
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);
            int trenutno = blockBlob.Container.ListBlobs().Count();
            using (var fileStream = System.IO.File.OpenRead(fajlInput.Text))
            {
                blockBlob.UploadFromStream(fileStream);
            }
            string naziv = openFileDialog.SafeFileName; //file name + ekstenzija
            //MemoryStream fileStream = new MemoryStream(File.ReadAllBytes(fajlInput.Text));
            //HttpContent fileStreamContent = new StreamContent(fileStream);
            //fileStreamContent.ReadAsMultipartAsync();
            //var formData = new MultipartFormDataContent();
            //formData.Add(fileStreamContent);
            //HttpResponseMessage response = WebAPIHelper.client.PostAsync(Global.BlobsRoute, formData).Result;
            //   if (response.IsSuccessStatusCode)
            Predaje_Result predaje = predajeCmb.SelectedItem as Predaje_Result;
            if (blockBlob.Container.ListBlobs().Count() == trenutno + 1)
            {
                //blobName = response.Content.ReadAsStringAsync().Result;
                Materijali m = new Materijali()
                {
                    DateCreated = DateTime.Now,
                    Url = Global.BlobStorageUrl + blobName,
                    BlobName = blobName,
                    Naziv = naziv,
                    NastavnikId = Global.prijavljeniKorisnik.Id,
                    PredmetId = predaje.PredmetId
                };
                HttpResponseMessage response2 = materijaliService.PostResponse(m);
                if (response2.IsSuccessStatusCode)
                {
                    MessageBox.Show("Materijal uspjesno dodan!", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response2.StatusCode + " : Message - " + response2.ReasonPhrase);
                }
            }
            else
            {
                MessageBox.Show("Error Code" + blockBlob.Container.ListBlobs().Count());
            }
        }

        private void predajeCmb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(predajeCmb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(predajeCmb, Messages.skGod_req);
            }
            else
                errorProvider.SetError(predajeCmb, null);
        }
    }
}
