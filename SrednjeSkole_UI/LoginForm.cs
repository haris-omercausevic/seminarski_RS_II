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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("ByUsername", korisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                if (k.LozinkaHash == UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text))
                {
                    MessageBox.Show("Dobrodošli " + k.Ime + " " + k.Prezime);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu validni!", "Upozrenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase);
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
