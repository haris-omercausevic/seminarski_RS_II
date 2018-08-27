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

namespace SrednjeSkole_UI.RazrediNS
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

       

        #region Binds
        public void BindSkolskeGodine()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = skolskeGodineService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                skolskaGodinaCmb.DataSource = response.Content.ReadAsAsync<List<SkolskeGodine>>().Result;
                skolskaGodinaCmb.DisplayMember = "Naziv";
                skolskaGodinaCmb.ValueMember = "SkolskaGodinaId";
                skolskaGodinaCmb.SelectedValue = "";
            }
            Cursor.Current = Cursors.Default;

        }
        public void BindSmjerovi()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = smjeroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                smjerCmb.DataSource = response.Content.ReadAsAsync<List<Smjerovi>>().Result;
                smjerCmb.DisplayMember = "Naziv";
                smjerCmb.ValueMember = "SmjerId";
                smjerCmb.SelectedValue = "";
            }
            Cursor.Current = Cursors.Default;

        }
        public void BindNastavnici()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = nastavniciService.GetActionResponse("notrazrednici");

            if (response.IsSuccessStatusCode)
            {
                razrednikCmb.DataSource = response.Content.ReadAsAsync<List<Nastavnici_Result>>().Result;
                razrednikCmb.DisplayMember= "nastavnik";
                razrednikCmb.ValueMember = "Id";
                razrednikCmb.SelectedValue = "";

                // Get combobox selection (in handler)
                //string value = ((KeyValuePair<string, string>)skolskaGodinaCmb.SelectedItem).Value;
            }
            Cursor.Current = Cursors.Default;

        }
        #endregion
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SkolskeGodine skGodTemp = skolskaGodinaCmb.SelectedItem as SkolskeGodine;
                string skolskaGodinaId = skGodTemp?.SkolskaGodinaId.ToString();

                Smjerovi smjerTemp = smjerCmb.SelectedItem as Smjerovi;
                string smjerId = smjerTemp?.SmjerId.ToString();

                Razredi r = new Razredi()
                {
                    Odjeljenje = odjeljenjeInput.Text.Trim(),
                    RazredBrojcano = Convert.ToInt32(razredInput.Text),
                    Oznaka = razredInput.Text + "-" + odjeljenjeInput.Text,
                    SkolskaGodinaId = Convert.ToInt32(skolskaGodinaId),
                    SmjerId = Convert.ToInt32(smjerId),
                    NastavnikId = Convert.ToInt32(razrednikCmb?.SelectedValue),
                    Aktivan = 1
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


        #region PlusButtonsEventHandlers


        private void skolskaGodinaAddBtn_Click(object sender, EventArgs e)
        {
            Evidencije.AddSkolskaGodina f2 = new Evidencije.AddSkolskaGodina();
            f2.Show();
            f2.FormClosing += (objSender, args) => { BindSkolskeGodine(); }; ;
        }

        private void smjerAddBtn_Click(object sender, EventArgs e)
        {
            Evidencije.AddSmjer f2 = new Evidencije.AddSmjer();
            f2.Show();
            f2.FormClosing += (objSender, args) => { BindSkolskeGodine(); };

        }

        private void razrednikAddBtn_Click(object sender, EventArgs e)
        {
            Users.AddNastavnik f2 = new Users.AddNastavnik();
            f2.Show();
            f2.FormClosing += (objSender, args) => { BindNastavnici(); };
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
            if (String.IsNullOrEmpty(skolskaGodinaCmb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(skolskaGodinaCmb, Messages.skGod_req);
            }
            else
                errorProvider.SetError(skolskaGodinaCmb, null);
        }

        private void smjerCmb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(smjerCmb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(smjerCmb, Messages.smjer_req);
            }
            else
                errorProvider.SetError(smjerCmb, null);
        }

        private void razrednikCmb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(razrednikCmb.Text))
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
