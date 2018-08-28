using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.MaterijaliNS
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper materijaliService = new WebAPIHelper(System.Configuration.ConfigurationManager.AppSettings["APIAddress"], Global.MaterijaliRoute);
        private WebAPIHelper predajeService = new WebAPIHelper(System.Configuration.ConfigurationManager.AppSettings["APIAddress"], Global.PredajeRoute);

        public IndexForm()
        {
            InitializeComponent();
            materijaliGrid.AutoGenerateColumns = false;
        }
        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindPredmeti();
        }

        private void BindPredmeti()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = predajeService.GetActionResponse("ByNastavnik", Global.prijavljeniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode)
            {
                predajeCmb.DataSource = response.Content.ReadAsAsync<List<Predaje_Result>>().Result;
                predajeCmb.DisplayMember = "Naziv";
                predajeCmb.ValueMember = "PredajeId";
                predajeCmb.SelectedValue = "";
            }

            Cursor.Current = Cursors.Default;
        }

        private void BindGrid(int predmetId)
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = materijaliService.GetActionResponse("ByPredmetId", predmetId.ToString());

            if (response.IsSuccessStatusCode)
            {
                materijaliGrid.DataSource = response.Content.ReadAsAsync<List<Materijali_Result>>().Result; ;
                materijaliGrid.ClearSelection();

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Akcija";
                buttonColumn.HeaderText = "Akcija";
                buttonColumn.Text = "Izbrisi";
                // Use the Text property for the button text for all cells rather
                // than using each cell's value as the text for its own button.
                buttonColumn.UseColumnTextForButtonValue = true;
                materijaliGrid.Columns.Insert(4, buttonColumn);
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            Cursor.Current = Cursors.Default;
        }
        private void noviMaterijalBtn_Click(object sender, EventArgs e)
        {
            AddMaterijal f = new AddMaterijal();
            f.Show();
        }

        private void predmetiCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Predaje_Result predaje = (sender as ComboBox).SelectedItem as Predaje_Result;
            BindGrid(predaje.PredmetId);
        }
    }
    }
