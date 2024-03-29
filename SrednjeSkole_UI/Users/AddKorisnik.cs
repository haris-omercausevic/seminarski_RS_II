﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System.Net.Http;
using System.Net.Mail;
using System.Net;

namespace SrednjeSkole_UI.Users
{
    public partial class AddKorisnik : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        public AddKorisnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddKorisnik_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Korisnici k = new Korisnici
                {
                    Ime = imeInput.Text,
                    Prezime = prezimeInput.Text,
                    Email = emailInput.Text,
                    Telefon = telefonInput.Text,
                    KorisnickoIme = korisnickoImeInput.Text,
                    Aktivan = true,
                    JMBG = jmbgInput.Text,
                    DatumRodjenja = Convert.ToDateTime(datumRodjenjaInput.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"))
            };
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);
                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                HttpResponseMessage response = korisniciService.PostResponse(k);
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
            else if(jmbgInput.Text.Trim().Length != 13)
            {
                e.Cancel = true;
                errorProvider.SetError(jmbgInput, Messages.jmbg_err);
            }
            else
            {
                errorProvider.SetError(jmbgInput, "");
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
        private void datumRodjenjaInput_Validating(object sender, CancelEventArgs e)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(datumRodjenjaInput.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            if (age < 14)
            {
                e.Cancel = true;
                errorProvider.SetError(datumRodjenjaInput, Messages.datum_korisnik_err14);
            }            
            else
            {
                errorProvider.SetError(datumRodjenjaInput, null);
            }
        }

        #endregion


    }
}
