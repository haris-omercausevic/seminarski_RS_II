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
            _oznaceniUcenici = oznaceniUcenici;
            _razredId = razredId;

            oznaceniUceniciGrid.DataSource = _oznaceniUcenici;
            oznaceniUceniciGrid.ClearSelection();
        }
        private void NovaOcjena_Load(object sender, EventArgs e)
        {
            BindPredmeti();
        }

        private void BindPredmeti()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = predajeService.GetActionResponse("ByNastavnikRazred", _razredId.ToString() + "/" + Global.prijavljeniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode)
            {
                predmetiCmb.DataSource = response.Content.ReadAsAsync<List<Predaje_Result>>().Result;
                predmetiCmb.DisplayMember = "Naziv";
                predmetiCmb.ValueMember = "PredajeId";
                predmetiCmb.SelectedValue = "";                    
            }

            Cursor.Current = Cursors.WaitCursor;
        }

        private void ocijeniBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (this.ValidateChildren())
            {
                Predaje_Result pTemp = predmetiCmb.SelectedItem as Predaje_Result;
                //predmetiCmb se zove combobox jer se u njemu bira predmet, 
                //ali se objekat castuje u Predaje_Result jer su i ostali podaci od Predaje tu
                // da ne bi 2 puta pozivao API i radio pretragu po svim parametrima da nadjem tacan Predaje objekat
                
                 
                
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

       
    }
}
