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
    public partial class AddZaduzenja : Form
    {
        private WebAPIHelper predmetiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PredmetiRoute);
        private WebAPIHelper nastavniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.NastavniciRoute);
        private WebAPIHelper predajeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PredajeRoute);
        private WebAPIHelper razrediService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RazrediRoute);

        List<Razredi_Result> oznaceniRazredi = new List<Razredi_Result>();

        List<Predmeti_Result> predmetiPrvi;
        List<Predmeti_Result> predmetiDrugi;
        List<Predmeti_Result> predmetiTreci;
        List<Predmeti_Result> predmetiCetvrti;


        public AddZaduzenja()
        {
            InitializeComponent();
        }
        private void AddZaduzenja_Load(object sender, EventArgs e)
        {
            BindNastavnici();
            BindPredmeti();
            BindRazredi();
        }
        private void BindPredmeti()
        {
                    Cursor.Current = Cursors.WaitCursor;
                    for (int i = 1; i <= 4; i++)
                    {
                        HttpResponseMessage response = predmetiService.GetActionResponse("ByRazred", i.ToString());
                        if (response.IsSuccessStatusCode)
                        {
                            if (i == 1)
                            {
                                predmetiPrviList.DataSource = response.Content.ReadAsAsync<List<Predmeti_Result>>().Result;
                                predmetiPrviList.DisplayMember = "Naziv";
                                predmetiPrviList.ValueMember = "PredmetId";
                                predmetiPrviList.ClearSelected();
                            }
                            else if (i == 2)
                            {
                                predmetiDrugiList.DataSource = response.Content.ReadAsAsync<List<Predmeti_Result>>().Result;
                                predmetiDrugiList.DisplayMember = "Naziv";
                                predmetiDrugiList.ValueMember = "PredmetId";
                                predmetiDrugiList.ClearSelected();
                            }
                            else if (i == 3)
                            {
                                predmetiTreciList.DataSource = response.Content.ReadAsAsync<List<Predmeti_Result>>().Result;
                                predmetiTreciList.DisplayMember = "Naziv";
                                predmetiTreciList.ValueMember = "PredmetId";
                                predmetiTreciList.ClearSelected();
                            }
                            else if (i == 4)
                            {
                                predmetiCetvrtiList.DataSource = response.Content.ReadAsAsync<List<Predmeti_Result>>().Result;
                                predmetiCetvrtiList.DisplayMember = "Naziv";
                                predmetiCetvrtiList.ValueMember = "PredmetId";
                                predmetiCetvrtiList.ClearSelected();
                            }
                        }
                    }
            Cursor.Current = Cursors.Default;
        }

        private void BindRazredi()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = razrediService.GetActionResponse("Aktivni");

            if (response.IsSuccessStatusCode)
            {
                razrediList.DataSource = response.Content.ReadAsAsync<List<Razredi_Result>>().Result;
                razrediList.DisplayMember = "Oznaka";
                razrediList.ValueMember = "RazredId";
                razrediList.ClearSelected();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            Cursor.Current = Cursors.Default;
        }
        private void BindNastavnici()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = nastavniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                nastavnikCmb.DataSource = response.Content.ReadAsAsync<List<Nastavnici_Result>>().Result;
                nastavnikCmb.DisplayMember = "nastavnik";
                nastavnikCmb.ValueMember = "Id";
                nastavnikCmb.SelectedValue = "";

                // Get combobox selection (in handler)
                //string value = ((KeyValuePair<string, string>)skolskaGodinaCmb.SelectedItem).Value;
            }
            Cursor.Current = Cursors.Default;
        }

        private void dodijeliBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (this.ValidateChildren())
            {
                List<Predaje> predajeList = new List<Predaje>();
                predmetiPrvi = predmetiPrviList.CheckedItems.Cast<Predmeti_Result>().ToList();
                predmetiDrugi = predmetiDrugiList.CheckedItems.Cast<Predmeti_Result>().ToList();
                predmetiTreci = predmetiTreciList.CheckedItems.Cast<Predmeti_Result>().ToList();
                predmetiCetvrti = predmetiCetvrtiList.CheckedItems.Cast<Predmeti_Result>().ToList();

                oznaceniRazredi = razrediList.CheckedIndices.Cast<Razredi_Result>().ToList();

                foreach (Razredi_Result razred in oznaceniRazredi)
                {
                    if(razred.Oznaka[0] == '1')
                    {
                        foreach (Predmeti_Result predmet in predmetiPrvi.FindAll(x => x.Razred == razred.Oznaka[0]))
                        {
                            predajeList.Add(new Predaje
                            {
                                NastavnikId = Convert.ToInt32(nastavnikCmb?.SelectedValue),
                                PredmetId = predmet.PredmetId,
                                RazredId = razred.RazredId
                            });
                        }
                    }
                    else if (razred.Oznaka[0] == '2')
                    {
                        foreach (Predmeti_Result predmet in predmetiDrugi.FindAll(x => x.Razred == razred.Oznaka[0]))
                        {
                            predajeList.Add(new Predaje
                            {
                                NastavnikId = Convert.ToInt32(nastavnikCmb?.SelectedValue),
                                PredmetId = predmet.PredmetId,
                                RazredId = razred.RazredId
                            });
                        }
                    }
                    else if (razred.Oznaka[0] == '3')
                    {
                        foreach (Predmeti_Result predmet in predmetiTreci.FindAll(x => x.Razred == razred.Oznaka[0]))
                        {
                            predajeList.Add(new Predaje
                            {
                                NastavnikId = Convert.ToInt32(nastavnikCmb?.SelectedValue),
                                PredmetId = predmet.PredmetId,
                                RazredId = razred.RazredId
                            });
                        }
                    }
                    else if (razred.Oznaka[0] == '4')
                    {
                        foreach (Predmeti_Result predmet in predmetiCetvrti.FindAll(x => x.Razred == razred.Oznaka[0]))
                        {
                            predajeList.Add(new Predaje
                            {
                                NastavnikId = Convert.ToInt32(nastavnikCmb?.SelectedValue),
                                PredmetId = predmet.PredmetId,
                                RazredId = razred.RazredId
                            });
                        }
                    }                    
                }
                
            }

            Cursor.Current = Cursors.Default;
        }

        private void nastavnikCmb_Validating(object sender, CancelEventArgs e)
        {

        }

        private void razrediList_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
