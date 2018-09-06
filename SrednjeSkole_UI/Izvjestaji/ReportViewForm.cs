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
        public Razredi_Result razredIzvjestaj { get; set; }
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRazredIzvjestaj", razredIzvjestaj.razredIzvjestajStavke);
            this.reportViewer1.LocalReport.DataSources.Add(rds);            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Razred", razredIzvjestaj.Oznaka));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("SkolskaGodina", razredIzvjestaj.SkolskaGodina));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Razrednik", razredIzvjestaj.Razrednik));

            this.reportViewer1.RefreshReport();
        }

        public class ReportCell
        {
            public int RowId { get; set; }
            public string ColumnName { get; set; }
            public string Value { get; set; }

            public static List<ReportCell> ConvertTableToCells(DataTable table)
            {
                List<ReportCell> cells = new List<ReportCell>();

                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        ReportCell cell = new ReportCell
                        {
                            ColumnName = col.Caption,
                            RowId = table.Rows.IndexOf(row),
                            Value = row[col.ColumnName].ToString()
                        };

                        cells.Add(cell);
                    }
                }

                return cells;
            }
        }
    }
}
