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
    public partial class AddRazred : Form
    {
        private WebAPIHelper razrediService= new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RazrediRoute);
        private WebAPIHelper smjeroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SmjeroviRoute);
        private WebAPIHelper skolskeGodineService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SkolskeGodineRoute);
        private WebAPIHelper nastavniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.NastavniciRoute);

        public AddRazred()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        private void AddRazred_Load(object sender, EventArgs e)
        {
            BindSkolskeGodine();
            BindSmjerovi();
            BindNastavnici();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SkolskeGodine skGodTemp = skolskaGodinaCmb.SelectedItem as SkolskeGodine;
                string skolskaGodinaId = "";
                if (skGodTemp != null)
                    skolskaGodinaId = skGodTemp.SkolskaGodinaId.ToString();

                Smjerovi smjerTemp = smjerCmb.SelectedItem as Smjerovi;
                string smjerId = "";
                if (smjerTemp != null)
                    smjerId = smjerTemp.SmjerId.ToString();

                string razrednikId = ((KeyValuePair<string, string>)razrednikCmb.SelectedItem).Key;

                Razredi r = new Razredi()
                {
                    Odjeljenje = odjeljenjeInput.Text.Trim(),
                    RazredBrojcano = Convert.ToInt32(razredInput.Text),
                    Oznaka = razredInput + "-" + odjeljenjeInput.Text,                    
                    SkolskaGodinaId = Convert.ToInt32(skolskaGodinaId),
                    SmjerId = Convert.ToInt32(smjerId),
                    NastavnikId = Convert.ToInt32(razrednikId)                    
                };

                HttpResponseMessage response = razrediService.PostResponse(r);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_razred_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        public void BindSkolskeGodine()
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
        public void BindSmjerovi()
        {
            HttpResponseMessage response = smjeroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                smjerCmb.DataSource = response.Content.ReadAsAsync<List<Smjerovi>>().Result;
                smjerCmb.DisplayMember = "Naziv";
                smjerCmb.ValueMember = "SmjerId";
                smjerCmb.SelectedValue = "";
            }
        }
        public void BindNastavnici()
        {
            HttpResponseMessage response = nastavniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Nastavnici> nastavnici = response.Content.ReadAsAsync<List<Nastavnici>>().Result;                
                Dictionary<string, string> nastavniciCmbList = new Dictionary<string, string>();
                foreach (var item in nastavnici)
                {
                    nastavniciCmbList.Add(item.Id.ToString(), item.Zvanje + " " + item.Ime + " " + item.Prezime);
                }
                razrednikCmb.DataSource = new BindingSource(nastavniciCmbList, null);
                razrednikCmb.DisplayMember= "Value";
                razrednikCmb.ValueMember = "Key";
                razrednikCmb.SelectedValue = "";

                // Get combobox selection (in handler)
                //string value = ((KeyValuePair<string, string>)skolskaGodinaCmb.SelectedItem).Value;
            }
        }

        #region PlusButtonsEventHandlers


        private void skolskaGodinaAddBtn_Click(object sender, EventArgs e)
        {
            AddSkolskaGodina f2 = new AddSkolskaGodina();
            f2.Show();
            f2.FormClosing += new FormClosingEventHandler(AddSkolskaGodina_FormClosing);
        }

        private void smjerAddBtn_Click(object sender, EventArgs e)
        {
            AddSmjer f2 = new AddSmjer();
            f2.Show();
            f2.FormClosing += new FormClosingEventHandler(AddSmjer_FormClosing);

        }

        private void razrednikAddBtn_Click(object sender, EventArgs e)
        {
            Users.AddNastavnik f2 = new Users.AddNastavnik();
            f2.Show();
            f2.FormClosing += new FormClosingEventHandler(AddNastavnik_FormClosing);
        }

        private void AddSkolskaGodina_FormClosing(object sender, EventArgs e)
        {
            BindSkolskeGodine();
        }

        private void AddSmjer_FormClosing(object sender, EventArgs e)
        {
            BindSmjerovi();
        }
        private void AddNastavnik_FormClosing(object sender, EventArgs e)
        {
            BindNastavnici();
        }
        #endregion

        #region Validacija

        private void razredInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(razredInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(razredInput, Messages.add_razredBroj_req);
            }
            else
            {
                errorProvider.SetError(razredInput, null);
            }
        }

        private void odjeljenjeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(odjeljenjeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(odjeljenjeInput, Messages.add_razredOdjeljenje_req);
            }
            else
            {
                errorProvider.SetError(odjeljenjeInput, null);
            }
        }

        private void skolskaGodinaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (skolskaGodinaCmb.SelectedValue.ToString() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(skolskaGodinaCmb, Messages.skGod_req);
            }
            else
                errorProvider.SetError(skolskaGodinaCmb, null);
        }

        private void smjerCmb_Validating(object sender, CancelEventArgs e)
        {
            if (smjerCmb.SelectedValue.ToString() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(smjerCmb, Messages.smjer_req);
            }
            else
                errorProvider.SetError(smjerCmb, null);
        }

        private void razrednikCmb_Validating(object sender, CancelEventArgs e)
        {
            if (razrednikCmb.SelectedValue.ToString() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(razrednikCmb, Messages.add_razredRazrednik_req);
            }
            else
                errorProvider.SetError(razrednikCmb, null);
        }
        #endregion

    }
}
