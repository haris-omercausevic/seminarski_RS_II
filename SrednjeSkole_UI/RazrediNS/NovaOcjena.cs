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
    public partial class NovaOcjena : Form
    {
        private WebAPIHelper predajeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PredajeRoute);
        private WebAPIHelper uceniciOcjeneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UceniciOcjeneRoute);
        private int _razredId;
        List<UceniciRazredi_Result> _oznaceniUcenici = new List<UceniciRazredi_Result>();

        public NovaOcjena(List<UceniciRazredi_Result> oznaceniUcenici, int razredId)
        {
            InitializeComponent();     
            this.AutoValidate = AutoValidate.Disable;
            oznaceniUceniciGrid.AutoGenerateColumns = false;
            _oznaceniUcenici = oznaceniUcenici;
            _razredId = razredId;

            oznaceniUceniciGrid.DataSource = _oznaceniUcenici;
            oznaceniUceniciGrid.ClearSelection();
        }
        private void NovaOcjena_Load(object sender, EventArgs e)
        {
            BindPredmeti();
            oznaceniUceniciGrid.ClearSelection();
        }

        private void BindPredmeti()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = predajeService.GetActionResponse("ByNastavnikRazred",  Global.prijavljeniKorisnik.Id.ToString() + "/" + _razredId.ToString() );
            if (response.IsSuccessStatusCode)
            {
                predajeCmb.DataSource = response.Content.ReadAsAsync<List<Predaje_Result>>().Result;
                predajeCmb.DisplayMember = "Naziv";
                predajeCmb.ValueMember = "PredajeId";
                predajeCmb.SelectedValue = "";                    
            }

            Cursor.Current = Cursors.WaitCursor;
        }

        private void ocijeniBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (this.ValidateChildren())
            {
                Predaje_Result pTemp = predajeCmb.SelectedItem as Predaje_Result;
                
                string predmetId = pTemp?.PredmetId.ToString();
                List<UceniciOcjene> uceniciOcjene = new List<UceniciOcjene>();
                foreach (var item in _oznaceniUcenici)
                {
                    uceniciOcjene.Add(new UceniciOcjene()
                    {
                        PredajeId = pTemp.PredajeId,
                        Datum = datumPicker.Value.Date,
                        Napomena = napomenaInput.Text,
                        UcenikId = item.UcenikId,
                        Vrijednost = Convert.ToInt32(ocjenaInput.Text)
                    });
                }

                HttpResponseMessage response = uceniciOcjeneService.PostResponse(uceniciOcjene);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno dodana ocjena odabranim učenicima", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void predajeCmb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(predajeCmb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(predajeCmb, Messages.predmet_req);
            }
            else
            {
                errorProvider.SetError(predajeCmb, null);
            }
        }

        private void ocjenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ocjenaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ocjenaInput, Messages.ocjena_req);
            }
            if(!int.TryParse(ocjenaInput.Text, out int n) || n > 5 || n < 1)
            {                
                e.Cancel = true;
                errorProvider.SetError(ocjenaInput, Messages.ocjena_1do5);
            }
            else
            {
                errorProvider.SetError(ocjenaInput, null);
            }
        }
    }
}
