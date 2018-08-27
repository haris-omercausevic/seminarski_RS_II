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
                predmetiCmb.DataSource = response.Content.ReadAsAsync<List<Predaje_Result>>().Result;
                predmetiCmb.DisplayMember = "Naziv";
                predmetiCmb.ValueMember = "PredajeId";
                predmetiCmb.SelectedValue = "";
            }

            Cursor.Current = Cursors.WaitCursor;
        }


        private void dodajFajlBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            fajlInput.Text = openFileDialog.FileName;
            fajlInput.ReadOnly = true;
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            string naziv = openFileDialog.SafeFileName; //file name + ekstenzija
            string blobName = "";
            MemoryStream fileStream = new MemoryStream(File.ReadAllBytes(fajlInput.Text));
            HttpContent fileStreamContent = new StreamContent(fileStream);
            fileStreamContent.ReadAsMultipartAsync();
            var formData = new MultipartFormDataContent();
            formData.Add(fileStreamContent);
                HttpResponseMessage response = WebAPIHelper.client.PostAsync(Global.BlobsRoute, formData).Result;
                if (response.IsSuccessStatusCode)
                {
                    blobName = response.Content.ReadAsStringAsync().Result;
                    Materijali m = new Materijali()
                    {
                        DateCreated = DateTime.Now,
                        Url = Global.BlobStorageUrl + blobName,
                        BlobName = blobName,
                        Naziv = naziv,
                        NastavnikId = Global.prijavljeniKorisnik.Id,
                        PredmetId = Convert.ToInt32(predmetiCmb?.SelectedValue)
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
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
        }

       
    }
}
