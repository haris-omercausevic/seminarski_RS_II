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

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.IndexForm f = new Users.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void smjeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evidencije.AddSmjer f = new Evidencije.AddSmjer();
            f.MdiParent = this;
            f.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evidencije.AddPredmet f = new Evidencije.AddPredmet();
            f.MdiParent = this;
            f.Show();
        }

        private void razrediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evidencije.AddRazred f = new Evidencije.AddRazred();
            f.MdiParent = this;
            f.Show();
        }

        private void uceniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.AddUcenik f = new Users.AddUcenik();
            //f.MdiParent = this;
            f.Show();
        }

        private void nastavniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.AddNastavnik f = new Users.AddNastavnik();
            f.MdiParent = this;
            f.Show();
        }
    }
}
