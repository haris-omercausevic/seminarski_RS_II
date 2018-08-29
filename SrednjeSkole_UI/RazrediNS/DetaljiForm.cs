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
    public partial class DetaljiForm : Form
    {
        private WebAPIHelper razrediService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RazrediRoute);
        private WebAPIHelper uceniciRazrediService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UceniciRazrediRoute);

        private int _razredId;
        public DetaljiForm(int razredId)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            uceniciRazrediGrid.AutoGenerateColumns = false;
            _razredId = razredId;
            HttpResponseMessage response = uceniciRazrediService.GetActionResponse("ByRazredId", razredId.ToString());
            if(response.IsSuccessStatusCode)
            {
                List<UceniciRazredi_Result> ucenici = response.Content.ReadAsAsync<List<UceniciRazredi_Result>>().Result;
                uceniciRazrediGrid.DataSource = ucenici;
                uceniciRazrediGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase);
            }

            Cursor.Current = Cursors.Default;
        }

        private void ocijeniBtn_Click(object sender, EventArgs e)
        {
            if(uceniciRazrediGrid.SelectedRows.Count != 0)
            {
                List<UceniciRazredi_Result> oznaceniUcenici = new List<UceniciRazredi_Result>();
                foreach (DataGridViewRow item in uceniciRazrediGrid.SelectedRows)
                {
                    oznaceniUcenici.Add(item.DataBoundItem as UceniciRazredi_Result);
                }
                NovaOcjena f = new NovaOcjena(oznaceniUcenici, _razredId);
                f.ShowDialog();
            }
        }
    }
}
