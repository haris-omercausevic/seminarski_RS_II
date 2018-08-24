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

namespace SrednjeSkole_UI
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            HttpResponseMessage response = korisniciService.GetActionResponse("ByUsername", korisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                HttpResponseMessage response2 = ulogeService.GetActionResponse("GetByKorisnikId", k.Id.ToString());
                k.Uloge = response2.Content.ReadAsAsync<List<Uloge>>().Result;

                if (k.LozinkaHash == UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text))
                {
                    bool ulogeValidne = false;
                    foreach (var item in k.Uloge)
                    {
                        if (item.Naziv == "SuperAdministrator")
                            ulogeValidne = true;
                        else if (item.Naziv == "Administrator")
                            ulogeValidne = true;
                    }
                    if (ulogeValidne == true)
                    {
                        MessageBox.Show("Dobrodošli " + k.Ime + " " + k.Prezime);
                        Global.prijavljeniKorisnik = k;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                        MessageBox.Show("Nemate pravo pristupa ovom dijelu sistema!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu validni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                MessageBox.Show("Korisničko ime ili lozinka nisu validni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase);

            Cursor.Current = Cursors.Default;
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
