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

namespace SrednjeSkole_UI.Obavjestenja
{
    public partial class AddObavijest : Form
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ObavijestiRoute);

        public AddObavijest()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddObavijest_Load(object sender, EventArgs e)
        {

        }

        private void objaviBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Obavijesti o = new Obavijesti()
                {
                    Naslov = naslovInput.Text,
                    Tekst = tekstInput.Text,
                    KorisnikId = Global.prijavljeniKorisnik.Id
                };
                HttpResponseMessage response = obavijestiService.PostResponse(o);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Obavijest uspješno objavljena!", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {                    
                        MessageBox.Show("Error Code" +
                        response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void naslovInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(naslovInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(naslovInput, Messages.fname_err);
            }
            else
            {
                errorProvider.SetError(naslovInput, "");
            }
        }

        private void tekstInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tekstInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tekstInput, Messages.fname_err);
            }
            else
            {
                errorProvider.SetError(tekstInput, "");
            }
        }
    }
}
