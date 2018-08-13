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
    public partial class AddPredmet : Form
    {
        private WebAPIHelper predmetiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);

        public AddPredmet()
        {
            InitializeComponent();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Predmeti p = new Predmeti()
                {
                    Naziv = nazivInput.Text,
                    Oznaka = oznakaInput.Text
                };

                HttpResponseMessage response = predmetiService.PostResponse(p);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_predmet_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.predmet_naziv_req);
            }
            else
                errorProvider.SetError(nazivInput, null);
        }

        private void oznakaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(oznakaInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(oznakaInput, Messages.predmet_oznaka_req);
            }
            else
                errorProvider.SetError(oznakaInput, null);
        }
    }
}
