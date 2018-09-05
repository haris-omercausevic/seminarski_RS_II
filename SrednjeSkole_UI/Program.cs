using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (Global.brojUloga >= 2)
                {
                    IzborMenijaUloge f = new IzborMenijaUloge();
                    f.ShowDialog();
                    if (f.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new MainForm());
                    }
                    else if (f.DialogResult == DialogResult.No)
                        Application.Run(new MainFormNast());
                }
                else if (Global.prijavljeniKorisnik.Uloge.Exists(x => x.Naziv =="Nastavnik"))
                {
                    Application.Run(new MainFormNast());
                }
                else
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}

