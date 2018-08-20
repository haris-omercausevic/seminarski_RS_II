using SrednjeSkole_UI.Util;
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
    public partial class MainForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:64818", "api/Korisnici");
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendPicturesToBack()
        {
            this.upravljanjeKorisnicimaPictureBox.SendToBack();
            this.upravljanjeKorisnicimaLabel.SendToBack();

            this.evidencijePictureBox.SendToBack();
            this.evidencijeLabel.SendToBack();

            this.dodajUcenikaPictureBox.SendToBack();
            this.dodajUcenikaLabel.SendToBack();

            this.dodajNastavnikaPictureBox.SendToBack();
            this.dodajNastavnikaLabel.SendToBack();

        }
        private void BringPicturesToFront()
        {
            this.upravljanjeKorisnicimaPictureBox.BringToFront();
            this.upravljanjeKorisnicimaLabel.BringToFront();

            this.evidencijePictureBox.BringToFront();
            this.evidencijeLabel.BringToFront();

            this.dodajUcenikaPictureBox.BringToFront();
            this.dodajUcenikaLabel.BringToFront();

            this.dodajNastavnikaPictureBox.BringToFront();
            this.dodajNastavnikaLabel.BringToFront();
        }

        private void upravljanjeKorisnicimaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Users.IndexForm f = new Users.IndexForm();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void bringToFront_FormClosing(object sender, EventArgs e)
        {
            BringPicturesToFront();
        }

        private void evidencijeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Evidencije.IndexForm f = new Evidencije.IndexForm();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void dodajUcenikaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Users.AddUcenik f = new Users.AddUcenik();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }

        private void dodajNastavnikaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Users.AddNastavnik f = new Users.AddNastavnik();
            f.FormClosing += new FormClosingEventHandler(bringToFront_FormClosing);
            f.MdiParent = this;
            f.Dock = DockStyle.Top;
            SendPicturesToBack();
            f.BringToFront();
            f.Show();
        }
    }
}
