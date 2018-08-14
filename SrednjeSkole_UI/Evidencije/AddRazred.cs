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
    public partial class AddRazred : Form
    {
        public AddRazred()
        {
            InitializeComponent();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {

        }

        private void skolskaGodinaAddBtn_Click(object sender, EventArgs e)
        {
            AddSkolskaGodina f = new AddSkolskaGodina();
            f.Show();
        }

        private void smjerAddBtn_Click(object sender, EventArgs e)
        {
            AddSmjer f = new AddSmjer();
            f.Show();
        }

        private void razrednikAddBtn_Click(object sender, EventArgs e)
        {
            Users.AddNastavnik f = new Users.AddNastavnik();
            f.Show();
        }
    }
}
