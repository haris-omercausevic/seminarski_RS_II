﻿using SrednjeSkole_API.Models;
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
    public partial class IndexForm : Form
    {
        private WebAPIHelper razrediService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RazrediRoute);
        private WebAPIHelper uceniciOcjeneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UceniciOcjeneRoute);

        private Razredi_Result oznaceniRazred = null;
        public IndexForm()
        {
            InitializeComponent();
            razrediGrid.AutoGenerateColumns = false;
            if (Global.prijavljeniKorisnik.Uloge.Exists(x => x.Naziv == "Nastavnik"))
                noviRazredBtn.Visible = false;
            else
                noviRazredBtn.Visible = true;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            HttpResponseMessage response = razrediService.GetActionResponse("Pretraga", oznakaInput.Text);

            if (response.IsSuccessStatusCode)
            {
                List<Razredi_Result> razredi = response.Content.ReadAsAsync<List<Razredi_Result>>().Result;
                razrediGrid.DataSource = razredi;
                razrediGrid.ClearSelection();
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

        private void detaljiBtn_Click(object sender, EventArgs e)
        {
            if(razrediGrid.SelectedRows.Count != 0)
            {
                DetaljiForm f = new DetaljiForm(Convert.ToInt32(razrediGrid.SelectedRows[0].Cells[0].Value));
                f.Text = "Razred: " + razrediGrid.SelectedRows[0].Cells[1].Value;
                f.ShowDialog();
            }
        }

        private void noviRazredBtn_Click(object sender, EventArgs e)
        {
            RazrediNS.AddRazred f = new RazrediNS.AddRazred();
            if(f.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void izvjestajBtn_Click(object sender, EventArgs e)
        {
            if (razrediGrid.SelectedRows.Count != 0)
            {
                oznaceniRazred = razrediGrid.SelectedRows[0].DataBoundItem as Razredi_Result;
                HttpResponseMessage response = uceniciOcjeneService.GetActionResponse("RazredIzvjestajStavke", oznaceniRazred.RazredId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Izvjestaji.ReportViewForm frm = new Izvjestaji.ReportViewForm();
                    oznaceniRazred.razredIzvjestajStavke = response.Content.ReadAsAsync<List<RazredIzvjestajStavke_Result>>().Result;
                    frm.razredIzvjestaj = oznaceniRazred;
                    frm.Show();
                }
            }
        }
    }
}
