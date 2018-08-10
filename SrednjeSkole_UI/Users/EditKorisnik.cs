using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
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
        private List<Uloge> sveUloge { get; set; }
        public EditKorisnik(int korisnikId)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = korisniciService.GetActionResponse("ById", korisnikId.ToString());


            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                k = null;
            else if (response.IsSuccessStatusCode)
            {
                Korisnici_Result temp = response.Content.ReadAsAsync<Korisnici_Result>().Result;
                k = new Korisnici
                {
                    Id = temp.Id,
                    Ime = temp.Ime,
                    Prezime = temp.Ime,
                    Telefon = temp.Telefon,
                    Email = temp.Email,
                    KorisnickoIme = temp.KorisnickoIme,
                    DatumRodjenja = temp.DatumRodjenja,
                    JMBG = temp.JMBG,
                    Uloge = new List<Uloge>()
                };
                foreach (var item in temp.Uloga.Split(',').ToList())
                {
                    HttpResponseMessage response2 = ulogeService.GetResponse(item);
                    k.Uloge.Add(response2.Content.ReadAsAsync<List<Uloge>>().Result[0]);
                    //ako je trazena 1 uloga vratiti ce 1 ulogu na poziciji [0]
                    //ako je poslano null vracaju se sve
                }

                //k.Uloge = new List<Uloge>();
                //foreach (var item in trenutneUloge)
                //{
                //    HttpResponseMessage response2 = ulogeService.GetResponse(item);                                        
                //    k.Uloge.Add(response2.Content.ReadAsAsync<List<Uloge>>().Result[0]);
                //}
                FillForm();
            }
        }

        private void FillForm()
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                sveUloge = ulogeList.Items.Cast<Uloge>().ToList();
                ulogeList.DisplayMember = "Naziv";
            }
            imeInput.Text = k.Ime;
            prezimeInput.Text = k.Prezime;
            telefonInput.Text = k.Telefon;
            emailInput.Text = k.Email;
            korisnickoImeInput.Text = k.KorisnickoIme;
            if (k.DatumRodjenja != null)
                datumRodjenjaInput.Value = k.DatumRodjenja.Value.Date;
            jmbgInput.Text = k.JMBG;

            for (int i = 0; i < sveUloge.Count; i++)
            {
                if (k.Uloge.Any(x => x.UlogaId == sveUloge[i].UlogaId))
                    ulogeList.SetItemChecked(i, true);
            }
        }


        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                if (this.ValidateChildren())
                {
                    k.Ime = imeInput.Text;
                    k.Prezime = prezimeInput.Text;
                    k.Telefon = telefonInput.Text;
                    k.Email = emailInput.Text;
                    k.JMBG = jmbgInput.Text;
                    k.KorisnickoIme = korisnickoImeInput.Text;
                    k.DatumRodjenja = Convert.ToDateTime(datumRodjenjaInput.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));


                    if (lozinkaInput.Text != String.Empty)
                    {
                        k.LozinkaSalt = UIHelper.GenerateSalt();
                        k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                    }

                    k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();
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
        }


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
            else if (jmbgInput.TextLength != 13)
            {
                e.Cancel = true;
                errorProvider.SetError(jmbgInput, Messages.jmbg_err);
            }
            else
            {
                errorProvider.SetError(jmbgInput, "");
            }
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

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Messages.roles_req);
            }
            else
                errorProvider.SetError(ulogeList, null);
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text.Trim()))
            {
                errorProvider.SetError(lozinkaInput, null);
            }
            else if (lozinkaInput.TextLength < 6 || !lozinkaInput.Text.Any(char.IsDigit) || !lozinkaInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_err);
            }
            else
                errorProvider.SetError(lozinkaInput, null);
        }
    }
}
