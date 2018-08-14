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

        public AddSmjer()
        {
            InitializeComponent();
        }

        private void AddSmjer_Load(object sender, EventArgs e)
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
                    SkolskaGodinaId = Convert.ToInt32(temp2.SkolskaGodinaId)                    
                };

                s.Predmeti = predmetiList.CheckedItems.Cast<Predmeti>().ToList();                

                HttpResponseMessage response = smjeroviService.PostResponse(s);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_predmet_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {

                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
    }
}
