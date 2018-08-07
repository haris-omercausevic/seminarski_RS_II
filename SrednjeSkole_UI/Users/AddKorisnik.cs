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

namespace SrednjeSkole_UI.Users
{
    public partial class AddKorisnik : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50178", "api/Korisnici");

        public AddKorisnik()
        {
            InitializeComponent();
        }
    }
}
