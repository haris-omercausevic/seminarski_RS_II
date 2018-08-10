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
    public partial class AddUcenik : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);
        private WebAPIHelper uceniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UceniciRoute);
        private WebAPIHelper smjeroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SmjeroviRoute);
        private WebAPIHelper razrediService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RazrediRoute);



        public AddUcenik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            
        }
        private void AddUcenik_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = smjeroviService.GetResponse();

            smjerCmb.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
            smjerCmb.DisplayMember = "Naziv";
            smjerCmb.ValueMember = "smjerId";
            smjerCmb.SelectedValue = "";
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Ucenici k = new Ucenici
                {
                    Ime = imeInput.Text,
                    Prezime = prezimeInput.Text,
                    Email = emailInput.Text,
                    Telefon = telefonInput.Text,
                    KorisnickoIme = korisnickoImeInput.Text,
                    Aktivan = true,
                    JMBG = jmbgInput.Text,
                    DatumRodjenja = Convert.ToDateTime(datumRodjenjaInput.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                    Adresa = adresaInput.Text,
                    GodinaUpisa = DateTime.Now.Year,
                    ImeRoditelja = imeRoditeljaInput.Text,
                    Spol = radioButton1.Checked?"M":"Z",
                    NazivOsnovneSkole = nazivSkoleInput.Text,
                    

                };
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);

                HttpResponseMessage response2 = ulogeService.GetResponse("Ucenik");
                k.Uloge = new List<Uloge>();
                if (response2.IsSuccessStatusCode)
                    k.Uloge.Add(response2?.Content.ReadAsAsync<List<Uloge>>().Result[0]);

                HttpResponseMessage response = korisniciService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string msg = response.ReasonPhrase;

                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + msg);
                }
            }
        }

        
    }
}
