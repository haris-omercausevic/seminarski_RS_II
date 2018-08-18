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
    public partial class AddSmjer : Form
    {
        private WebAPIHelper smjeroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SmjeroviRoute);
        private WebAPIHelper skolskeGodineService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SkolskeGodineRoute);
        private WebAPIHelper predmetiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PredmetiRoute);


        public AddSmjer()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddSmjer_Load(object sender, EventArgs e)
        {
            BindSkolskeGodine();
            BindPredmeti();
        }
        private void BindSkolskeGodine()
        {
            HttpResponseMessage response = skolskeGodineService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                skolskaGodinaCmb.DataSource = response.Content.ReadAsAsync<List<SkolskeGodine>>().Result;
                skolskaGodinaCmb.DisplayMember = "Naziv";
                skolskaGodinaCmb.ValueMember = "SkolskaGodinaId";
                skolskaGodinaCmb.SelectedValue = "";
            }
        }
        private void BindPredmeti()
        {
            HttpResponseMessage response = predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiList.DataSource = response.Content.ReadAsAsync<List<Predmeti>>().Result;
                predmetiList.DisplayMember = "Naziv";
                predmetiList.ValueMember = "PredmetId";
                predmetiList.ClearSelected();
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SkolskeGodine temp2 = skolskaGodinaCmb.SelectedItem as SkolskeGodine;
                string skolskaGodinaId = "";
                if (temp2 != null)
                    skolskaGodinaId = temp2.SkolskaGodinaId.ToString();

                Smjerovi s = new Smjerovi()
                {
                    Naziv = nazivInput.Text.Trim(),
                    Opis = opisInput.Text,
                    SkolskaGodinaId = Convert.ToInt32(skolskaGodinaId)
                };

                s.Predmeti = predmetiList.CheckedItems.Cast<Predmeti>().ToList();

                HttpResponseMessage response = smjeroviService.PostResponse(s);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_smjer_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void predmetiAddBtn_Click(object sender, EventArgs e)
        {
            AddPredmet f2 = new AddPredmet();
            f2.Show();
            f2.FormClosing += (objSender, args) => { BindPredmeti(); };
        }       

        private void skolskaGodinaAddBtn_Click(object sender, EventArgs e)
        {
            AddSkolskaGodina f2 = new AddSkolskaGodina();
            f2.Show();
            f2.FormClosing += (objSender, args) => { BindSkolskeGodine(); };
        }

        #region Validacija
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.naziv_req);
            }
            else
            {
                errorProvider.SetError(nazivInput, null);
            }
        }

        private void opisInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(opisInput, Messages.opis_req);
            }
            else
            {
                errorProvider.SetError(opisInput, null);
            }
        }

        private void skolskaGodinaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(skolskaGodinaCmb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(skolskaGodinaCmb, Messages.skGod_req);
            }
            else
                errorProvider.SetError(skolskaGodinaCmb, null);
        }

        private void predmetiList_Validating(object sender, CancelEventArgs e)
        {
            if (predmetiList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(predmetiList, Messages.smjer_predmet_req);
            }
            else
                errorProvider.SetError(predmetiList, null);
        }
        #endregion
    }
}
