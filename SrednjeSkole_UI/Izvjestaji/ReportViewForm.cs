using Microsoft.Reporting.WinForms;
using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.Izvjestaji
{
    public partial class ReportViewForm : Form
    {
        public RazredIzvjestaj_Result razredIzvjestaj { get; set; }
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRazredIzvjestaj", razredIzvjestaj);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Razred", razredIzvjestaj.Razred));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Razred", razredIzvjestaj.SkolskaGodina));


            this.reportViewer1.RefreshReport();
        }
    }
}
