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

namespace SrednjeSkole_UI.Evidencije
{
    public partial class AddSkolskaGodina : Form
    {
        private WebAPIHelper skolskeGodineService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SkolskeGodineRoute);

        public AddSkolskaGodina()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            SkolskeGodine s = new SkolskeGodine()
            {
                Naziv = skolskaGodinaInput.Text.Trim()
            };

            HttpResponseMessage response = skolskeGodineService.PostResponse(s);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_skGod_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void skolskaGodinaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(skolskaGodinaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(skolskaGodinaInput, Messages.add_skGod_req);
            }
            else
            {
                errorProvider.SetError(skolskaGodinaInput, null);
            }
        }
    }    
}
