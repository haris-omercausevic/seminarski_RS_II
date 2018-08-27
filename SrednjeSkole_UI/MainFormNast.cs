using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI
{
    public partial class MainFormNast : Form
    {
        public MainFormNast()
        {
            InitializeComponent();
        }
        private void SendPicturesToBack()
        {
            this.upravljanjeKorisnicimaPictureBox.SendToBack();
            this.razrediLabel.SendToBack();

            this.evidencijePictureBox.SendToBack();
            this.materijaliLabel.SendToBack();

            this.dodajUcenikaPictureBox.SendToBack();
            this.dodajUcenikaLabel.SendToBack();

            this.obavijestiPictureBox.SendToBack();
            this.obavijestiLabel.SendToBack();

        }
        private void BringPicturesToFront()
        {
            this.upravljanjeKorisnicimaPictureBox.BringToFront();
            this.razrediLabel.BringToFront();

            this.evidencijePictureBox.BringToFront();
            this.materijaliLabel.BringToFront();

            this.dodajUcenikaPictureBox.BringToFront();
            this.dodajUcenikaLabel.BringToFront();

            this.obavijestiPictureBox.BringToFront();
            this.obavijestiLabel.BringToFront();
        }
        private void obavijestiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ObavijestiNS.IndexForm f = new ObavijestiNS.IndexForm();
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void razrediLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RazrediNS.IndexForm f = new RazrediNS.IndexForm();
            f.FormClosing += (s, arg) => BringPicturesToFront();
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void materijaliLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
