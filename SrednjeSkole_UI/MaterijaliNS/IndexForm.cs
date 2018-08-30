using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.MaterijaliNS
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper materijaliService = new WebAPIHelper(System.Configuration.ConfigurationManager.AppSettings["APIAddress"], Global.MaterijaliRoute);
        private WebAPIHelper predajeService = new WebAPIHelper(System.Configuration.ConfigurationManager.AppSettings["APIAddress"], Global.PredajeRoute);
        private int _predmetId;

        public IndexForm()
        {
            InitializeComponent();
            materijaliGrid.AutoGenerateColumns = false;
        }
        private void IndexForm_Load(object sender, EventArgs e)
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

        private void BindGrid(int predmetId)
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = materijaliService.GetActionResponse("ByPredmetId", predmetId.ToString());

            if (response.IsSuccessStatusCode)
            {
                materijaliGrid.DataSource = response.Content.ReadAsAsync<List<Materijali_Result>>().Result; ;
                materijaliGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            Cursor.Current = Cursors.Default;
        }
        private void noviMaterijalBtn_Click(object sender, EventArgs e)
        {
            AddMaterijal f = new AddMaterijal();
            f.Show();
        }

        private void predmetiCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Predaje_Result predaje = (sender as ComboBox).SelectedItem as Predaje_Result;
            _predmetId = predaje.PredmetId;
            BindGrid(predaje.PredmetId);
        }

        private void downloadMaterijalBtn_Click(object sender, EventArgs e)
        {
            if (materijaliGrid.SelectedRows.Count != 0)
            {
                int materijalId = (Convert.ToInt32(materijaliGrid.SelectedRows[0].Cells[0].Value));
                HttpResponseMessage response = materijaliService.GetActionResponse("ById", materijalId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Materijali m = response.Content.ReadAsAsync<Materijali>().Result;
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.FileName = m.Naziv;
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        WebClient client = new WebClient();
                        client.DownloadFile(m.Url, saveDialog.FileName);
                    }
                }
            }
        }

        private void izbrisiMaterijalBtn_Click(object sender, EventArgs e)
        {
            if (materijaliGrid.SelectedRows.Count != 0)
            {
                DialogResult upozorenje = MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (upozorenje == DialogResult.Yes)
                {
                    int materijalId = (Convert.ToInt32(materijaliGrid.SelectedRows[0].Cells[0].Value));
                    HttpResponseMessage response = materijaliService.GetActionResponse("ById", materijalId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        Materijali m = response.Content.ReadAsAsync<Materijali>().Result;
                        if(m.NastavnikId == Global.prijavljeniKorisnik.Id)
                        {
                            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Global.connString);
                            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                            CloudBlobContainer container = blobClient.GetContainerReference(Global.BlobContainer);
                            CloudBlockBlob blockBlob = container.GetBlockBlobReference(m.BlobName);
                            blockBlob.DeleteAsync();
                            response = materijaliService.DeleteResponse(m.MaterijalId);
                            MessageBox.Show("Materijal izbrisan!", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindGrid(_predmetId);
                        }
                        else
                        {
                            MessageBox.Show("Možete izbrisati samo materijale koje ste vi objavili!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
