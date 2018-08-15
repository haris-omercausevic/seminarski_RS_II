using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.Users
{
    public partial class AddUcenik : Form
    {
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
            BindSmjerovi();
            BindRazredi();
        }
        private void BindSmjerovi()
        {
            HttpResponseMessage response = smjeroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                smjerCmb.DataSource = response.Content.ReadAsAsync<List<Smjerovi>>().Result;
                smjerCmb.DisplayMember = "Naziv";
                smjerCmb.ValueMember = "SmjerId";
                smjerCmb.SelectedValue = "";
            }
        }

        private void BindRazredi()
        {
            HttpResponseMessage response = razrediService.GetResponse();

            smjerCmb.DataSource = response.Content.ReadAsAsync<List<Razredi>>().Result;
            smjerCmb.DisplayMember = "Oznaka";
            smjerCmb.ValueMember = "RazredId";
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
                    NazivOsnovneSkole = nazivSkoleInput.Text
                };
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);

                HttpResponseMessage response2 = ulogeService.GetResponse("Ucenik");
                k.Uloge = new List<Uloge>();
                if (response2.IsSuccessStatusCode)
                    k.Uloge.Add(response2?.Content.ReadAsAsync<List<Uloge>>().Result[0]);


                HttpResponseMessage response = uceniciService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                    UIHelper.SendWelcomeMail(k.Email, k.KorisnickoIme, lozinkaInput.Text);
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

        #region Validacija

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Messages.fname_err);
            }
            else
            {
                errorProvider.SetError(imeInput, "");
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Messages.lname_err);
            }
            else
            {
                errorProvider.SetError(prezimeInput, "");
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Messages.email_req);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                    errorProvider.SetError(emailInput, null);

                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_err);
                }
            }
        }

        private void jmbgInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(jmbgInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(jmbgInput, Messages.jmbg_req);
            }
            else if (jmbgInput.Text.Trim().Length != 13)
            {
                e.Cancel = true;
                errorProvider.SetError(jmbgInput, Messages.jmbg_err);
            }
            else
            {
                errorProvider.SetError(jmbgInput, "");
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void datumRodjenjaInput_Validating(object sender, CancelEventArgs e)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(datumRodjenjaInput.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            if (age < 14)
            {
                e.Cancel = true;
                errorProvider.SetError(datumRodjenjaInput, Messages.datum_err14);
            }
            else if (age > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(datumRodjenjaInput, Messages.datum_err20);
            }
            else
            {
                errorProvider.SetError(datumRodjenjaInput, null);
            }
        }

        private void imeRoditeljaInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void adresaInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void nazivSkoleInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.username_req);
            }
            else if (korisnickoImeInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.username_err);
            }
            else
                errorProvider.SetError(korisnickoImeInput, null);
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_req);
            }
            else if (lozinkaInput.TextLength < 6 || !lozinkaInput.Text.Any(char.IsDigit) || !lozinkaInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_err);
            }
            else
                errorProvider.SetError(lozinkaInput, null);
        }

        private void smjerCmb_Validating(object sender, CancelEventArgs e)
        {

        }

        private void razredCmb_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion

        private void smjerAddBtn_Click(object sender, EventArgs e)
        {
            Evidencije.AddSmjer f2 = new Evidencije.AddSmjer();
            f2.Show();
            f2.FormClosing += new FormClosingEventHandler(AddSmjer_FormClosing);
        }
        private void razredAddBtn_Click(object sender, EventArgs e)
        {
            Evidencije.AddRazred f2 = new Evidencije.AddRazred();
            f2.Show();
            f2.FormClosing += new FormClosingEventHandler(AddRazred_FormClosing);
        }

        private void AddSmjer_FormClosing(object sender, EventArgs e)
        {
            BindSmjerovi();
        }
        private void AddRazred_FormClosing(object sender, EventArgs e)
        {
            BindRazredi();
        }
        
    }
}
