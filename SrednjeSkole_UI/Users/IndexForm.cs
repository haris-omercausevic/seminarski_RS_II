using Newtonsoft.Json;
using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SrednjeSkole_UI.Users
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        public IndexForm()
        {
            InitializeComponent();
            korisniciGrid.AutoGenerateColumns = false;

        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogaCmb.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogaCmb.DisplayMember = "Naziv";
                ulogaCmb.ValueMember = "UlogaId";
                ulogaCmb.SelectedValue = "";
            }
            BindGrid();

        }
        private void BindGrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            Uloge temp2 = ulogaCmb.SelectedItem as Uloge;
            string uloga = "";
            if (temp2 != null)
                uloga = temp2.UlogaId.ToString();

            HttpResponseMessage response = korisniciService.GetResponse("Pretraga?ime="+ imeInput.Text + "&prezime=" + prezimeInput.Text + "&ulogaId=" + uloga);
                //client.GetAsync(Global.KorisniciRoute + "/" + "Pretraga" + "?" + "ime=" + k.Ime + "&prezime=" + k.Prezime + "&ulogaId=" + k.UlogaId).Result;

            if (response.IsSuccessStatusCode)
            {
                List<KorisniciPretraga_Result> korisnici = response.Content.ReadAsAsync<List<KorisniciPretraga_Result>>().Result;
                korisniciGrid.DataSource = korisnici;
                korisniciGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            Cursor.Current = Cursors.Default;

        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void noviKorisnikBtn_Click(object sender, EventArgs e)
        {
            AddKorisnik frm = new AddKorisnik();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
            
        }

        private void izmijeniBtn_Click(object sender, EventArgs e)
        {
            //List<string> temp = korisniciGrid.SelectedRows[0].Cells[5].Value.ToString().Split(',').ToList();
            //for (int i = 1; i < temp.Count; i++)
            //{
            //    temp[i] = temp[i].Replace(" ", "");
            //}
            //List<Uloge> returnList = JsonConvert.DeserializeObject<List<Uloge>>(korisniciGrid.SelectedRows[0].Cells[5].Value.ToString());   
            if (korisniciGrid.SelectedRows.Count != 0)
            {
                EditKorisnik frm = new EditKorisnik(Convert.ToInt32(korisniciGrid?.SelectedRows[0]?.Cells[0]?.Value));
                frm.ShowDialog();
                BindGrid();
            }
                
        }
    }
}
