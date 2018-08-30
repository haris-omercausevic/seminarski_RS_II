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

        //private void SendPicturesToBack()
        //{
        //    this.smjeroviPictureBox.SendToBack();
        //    this.zaduzenjaPictureBox.SendToBack();
        //    this.predmetiPctureBox.SendToBack();
        //    this.razrediPictureBox.SendToBack();
        //    this.smjeroviLabel.SendToBack();
        //    this.zaduzenjaLabel.SendToBack();
        //    this.predmetiLabel.SendToBack();
        //    this.razrediLabel.BringToFront();
        //}
        //private void BringPicturesToFront()
        //{
        //    this.smjeroviPictureBox.BringToFront();
        //    this.zaduzenjaPictureBox.BringToFront();
        //    this.predmetiPctureBox.BringToFront();
        //    this.razrediPictureBox.BringToFront();
        //    this.smjeroviLabel.BringToFront();
        //    this.zaduzenjaLabel.BringToFront();
        //    this.predmetiLabel.BringToFront();
        //    this.razrediLabel.BringToFront();
        //}
              
        private void smjeroviPictureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddSmjer f = new Evidencije.AddSmjer();
            f.Dock = DockStyle.Top;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.BringToFront();
            f.Show();
        }
        private void zaduzenjaPictureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddZaduzenja f = new Evidencije.AddZaduzenja();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.SendToBack();
            f.Dock = DockStyle.Top;            
            f.BringToFront();
            f.Show();
        }


        private void predmetiPctureBox_Click(object sender, EventArgs e)
        {
            Evidencije.AddPredmet f = new Evidencije.AddPredmet();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            f.BringToFront();
            f.Show();
        }

        private void razrediPictureBox_Click(object sender, EventArgs e)
        {
            RazrediNS.IndexForm f = new RazrediNS.IndexForm();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Dock = DockStyle.Top;
            f.BringToFront();
            f.Show();
        }

      
    }
}
