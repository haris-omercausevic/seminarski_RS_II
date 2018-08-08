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
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("Pretraga", imeInput.Text + "&prezime=" + prezimeInput.Text + "&ulogaId=" + ulogaCmb.SelectedItem.ToString());
                //client.GetAsync(Global.KorisniciRoute + "/" + "Pretraga" + "?" + "ime=" + k.Ime + "&prezime=" + k.Prezime + "&ulogaId=" + k.UlogaId).Result;

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> korisnici = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;                
                korisniciGrid.DataSource = korisnici;
                korisniciGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void noviKorisnikBtn_Click(object sender, EventArgs e)
        {
            AddKorisnik frm = new AddKorisnik();
            frm.ShowDialog();
            BindGrid();
        }

        private void izmijeniBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
