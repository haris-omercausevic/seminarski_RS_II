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
using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;


namespace SrednjeSkole_UI.Obavjestenja
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ObavijestiRoute);

        public IndexForm()
        {
            InitializeComponent();
            obavijestiGrid.AutoGenerateColumns = false;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = obavijestiService.GetActionResponse("Pretraga", naslovInput.Text);
            //client.GetAsync(Global.KorisniciRoute + "/" + "Pretraga" + "?" + "ime=" + k.Ime + "&prezime=" + k.Prezime + "&ulogaId=" + k.UlogaId).Result;

            if (response.IsSuccessStatusCode)
            {
                List<Obavijesti_Result> obavijesti = response.Content.ReadAsAsync<List<Obavijesti_Result>>().Result;
                obavijestiGrid.DataSource = obavijesti;
                obavijestiGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            Cursor.Current = Cursors.Default;
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void novaObavijestBtn_Click(object sender, EventArgs e)
        {
            AddObavijest frm = new AddObavijest();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void izmijeniBtn_Click(object sender, EventArgs e)
        {
            if (obavijestiGrid.SelectedRows.Count != 0)
            {
                EditObavijest frm = new EditObavijest(Convert.ToInt32(obavijestiGrid.SelectedRows[0].Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
    }
}
