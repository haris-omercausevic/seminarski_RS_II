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


namespace SrednjeSkole_UI.ObavijestiNS
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
                int obavijestId = (Convert.ToInt32(obavijestiGrid.SelectedRows[0].Cells[0].Value));
                HttpResponseMessage response = obavijestiService.GetActionResponse("ById", obavijestId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Obavijesti_Result o = response.Content.ReadAsAsync<Obavijesti_Result>().Result;
                    if (o.KorisnikId == Global.prijavljeniKorisnik.Id)
                    {
                        EditObavijest frm = new EditObavijest(o);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            BindGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Možete urediti samo obavijesti koje ste vi objavili!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                
            }
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (obavijestiGrid.SelectedRows.Count != 0)
            {
                DialogResult upozorenje = MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (upozorenje == DialogResult.Yes)
                {
                    int obavijestId = (Convert.ToInt32(obavijestiGrid.SelectedRows[0].Cells[0].Value));
                    HttpResponseMessage response = obavijestiService.GetActionResponse("ById", obavijestId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        Obavijesti_Result o = response.Content.ReadAsAsync<Obavijesti_Result>().Result;
                        if (o.KorisnikId == Global.prijavljeniKorisnik.Id)
                        {
                            response = obavijestiService.DeleteResponse(o.ObavijestId);
                            MessageBox.Show("Obavijest izbrisana!", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindGrid();
                        }
                        else
                        {
                            MessageBox.Show("Možete izbrisati samo obavijesti koje ste vi objavili!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
