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
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.Dock = DockStyle.Top;
            f.StartPosition = FormStartPosition.CenterScreen;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void razrediPictureBox_Click(object sender, EventArgs e)
        {
            RazrediNS.IndexForm f = new RazrediNS.IndexForm();
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void predmetiPctureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddPredmet f = new Evidencije.AddPredmet();
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void zaduzenjaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Evidencije.AddZaduzenja f = new Evidencije.AddZaduzenja();
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }
    }
}
