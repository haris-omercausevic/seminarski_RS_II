using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.Evidencije
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void SendPicturesToBack()
        {
            this.smjeroviPictureBox.SendToBack();

            this.razrediPictureBox.SendToBack();

            this.predmetiPctureBox.SendToBack();
        }
        private void BringPicturesToFront()
        {
            this.smjeroviPictureBox.BringToFront();

            this.razrediPictureBox.BringToFront();

            this.predmetiPctureBox.BringToFront();
        }

        private void smjeroviPictureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddSmjer f = new Evidencije.AddSmjer();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.Dock = DockStyle.Top;
            f.StartPosition = FormStartPosition.CenterScreen;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void razrediPictureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddRazred f = new Evidencije.AddRazred();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void predmetiPctureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddPredmet f = new Evidencije.AddPredmet();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void bringToFront_FormClosing(object sender, EventArgs e)
        {
            BringPicturesToFront();
        }
    }
}
