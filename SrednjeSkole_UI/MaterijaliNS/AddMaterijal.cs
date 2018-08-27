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

        private IAzureBlobStorage _blobStorage;

        public AddMaterijal()
        {
            InitializeComponent();            
        }

        private void dodajFajlBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            fajlInput.Text = openFileDialog.FileName;
            fajlInput.ReadOnly = true;
        }

        async private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            var naziv = openFileDialog.SafeFileName; //file name + ekstenzija
            var blobName = Guid.NewGuid().ToString();

            var fileStream = File.OpenRead(fajlInput.Text);

            await _blobStorage.UploadAsync(blobName, fileStream);

            var blobUri = await _blobStorage.GetBlobByName(blobName);

            Materijali m = new Materijali()
            {
                DateCreated = DateTime.Now,
                Url = blobUri,
                BlobName = blobName,
                Naziv = naziv,
                NastavnikId = Global.prijavljeniKorisnik.Id,
                PredmetId = Convert.ToInt32(predmetiCmb?.SelectedValue)
            };
            HttpResponseMessage response = materijaliService.PostResponse(m);
        }
    }
}
