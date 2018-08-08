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
    public partial class EditKorisnik : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);
        private Korisnici k { get; set; }
        private bool ulogePromijenute = false;
        public EditKorisnik(int korisnikId)
        {
            InitializeComponent();
            HttpResponseMessage response = korisniciService.GetResponse(korisnikId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                k = null;
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Korisnici>().Result;
                FillForm();
            }
        }
        private void FillForm()
        {
            imeInput.Text = k.Ime;
            prezimeInput.Text = k.Prezime;
            telefonInput.Text = k.Telefon;
            emailInput.Text = k.Email;
            korisnickoImeInput.Text = k.KorisnickoIme;
            datumRodjenjaInput.Value = k.DatumRodjenja.Value;
            jmbgInput.Text = k.JMBG;
                        
        }
        private void EditKorisnik_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogeList.DisplayMember = "Naziv";
                //ulogeList.ClearSelected();
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Telefon = telefonInput.Text;
                k.Email = emailInput.Text;
                k.JMBG = jmbgInput.Text;
                k.DatumRodjenja = datumRodjenjaInput.Value;

                k.KorisnickoIme = korisnickoImeInput.Text;

                if (lozinkaInput.Text != String.Empty)
                {
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                }

                HttpResponseMessage response = korisniciService.PutResponse(k.Id, k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void ulogeList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ulogePromijenute = true;
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void jmbgInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void datumRodjenjaInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {

        }

        
    }
}
