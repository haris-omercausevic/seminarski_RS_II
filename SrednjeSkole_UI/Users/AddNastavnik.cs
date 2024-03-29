﻿using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.Users
{
    public partial class AddNastavnik : Form
    {
        private WebAPIHelper nastavniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.NastavniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);
        Nastavnici k = new Nastavnici();

        public AddNastavnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.Telefon = telefonInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.Aktivan = true;
                k.JMBG = jmbgInput.Text;
                k.DatumRodjenja = Convert.ToDateTime(datumRodjenjaInput.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                k.Zvanje = zvanjeInput.Text;
                k.GodinaZaposlenja = Convert.ToInt32(godinaZaposlenjaInput.Text);
                k.NaucnaOblast = naucnaOblastInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text);

                HttpResponseMessage response2 = ulogeService.GetResponse("Nastavnik");
                k.Uloge = new List<Uloge>();
                if (response2.IsSuccessStatusCode)
                    k.Uloge.Add(response2?.Content.ReadAsAsync<List<Uloge>>().Result[0]);


                HttpResponseMessage response = nastavniciService.PostResponse(k);
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

        private void zvanjeInput_Validating(object sender, CancelEventArgs e)
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

        #endregion

        private void dodajSlikuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                k.Slika = File.ReadAllBytes(slikaInput.Text);
                Image orgImage = Image.FromFile(slikaInput.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth, resizedImgHeight));

                    if (resizedImg.Width > croppedImgWidth && resizedImg.Height > croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        pictureBox.Image = croppedImg;

                        MemoryStream ms = new MemoryStream();
                        croppedImg.Save(ms, orgImage.RawFormat);

                        k.SlikaThumb = ms.ToArray();

                    }
                    else
                    {
                        MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        k = null;
                    }
                }
                else
                {
                    MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    k = null;
                }
            }
            catch (Exception)
            {
                k.Slika = null;
                k.SlikaThumb = null;
                slikaInput.Text = null;
                pictureBox.Image = null;
            }
        }

        
    }
}
