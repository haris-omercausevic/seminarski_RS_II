using SrednjeSkole_API.Models;
using SrednjeSkole_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednjeSkole_UI.ObavijestiNS
{
    public partial class EditObavijest : Form
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ObavijestiRoute);
        private Obavijesti o { get; set; }
        public EditObavijest(Obavijesti_Result temp)
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
            Cursor.Current = Cursors.WaitCursor;
            o = new Obavijesti()
            {
                ObavijestId = temp.ObavijestId,
                KorisnikId = temp.KorisnikId,
                Naslov = temp.Naslov,
                Tekst = temp.Tekst
            };

            FillForm();
        }

        private void FillForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            naslovInput.Text = o.Naslov;
            tekstInput.Text = o.Tekst;
            Cursor.Current = Cursors.Default;
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (o != null)
            {
                if (this.ValidateChildren())
                {
                    o.Naslov = naslovInput.Text;
                    o.Tekst = tekstInput.Text;
                    o.KorisnikId = Global.prijavljeniKorisnik.Id;
                    o.Datum = DateTime.Now;

                    HttpResponseMessage response = obavijestiService.PutResponse(o.ObavijestId, o);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Obavijest sačuvana", Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void naslovInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(naslovInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(naslovInput, Messages.fname_err);
            }
            else
            {
                errorProvider.SetError(naslovInput, "");
            }
        }

        private void tekstInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tekstInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tekstInput, Messages.fname_err);
            }
            else
            {
                errorProvider.SetError(tekstInput, "");
            }
        }
    }
}
