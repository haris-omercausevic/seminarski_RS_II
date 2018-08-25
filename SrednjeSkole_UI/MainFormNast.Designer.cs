namespace SrednjeSkole_UI
{
    partial class MainFormNast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.evidencijeLabel = new System.Windows.Forms.LinkLabel();
            this.obavijestiLabel = new System.Windows.Forms.LinkLabel();
            this.dodajUcenikaLabel = new System.Windows.Forms.LinkLabel();
            this.upravljanjeKorisnicimaLabel = new System.Windows.Forms.LinkLabel();
            this.evidencijePictureBox = new System.Windows.Forms.PictureBox();
            this.obavijestiPictureBox = new System.Windows.Forms.PictureBox();
            this.dodajUcenikaPictureBox = new System.Windows.Forms.PictureBox();
            this.upravljanjeKorisnicimaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajUcenikaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upravljanjeKorisnicimaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // evidencijeLabel
            // 
            this.evidencijeLabel.AutoSize = true;
            this.evidencijeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.evidencijeLabel.Font = new System.Drawing.Font("Forte", 20.25F);
            this.evidencijeLabel.LinkColor = System.Drawing.Color.White;
            this.evidencijeLabel.Location = new System.Drawing.Point(596, 184);
            this.evidencijeLabel.Name = "evidencijeLabel";
            this.evidencijeLabel.Size = new System.Drawing.Size(127, 30);
            this.evidencijeLabel.TabIndex = 14;
            this.evidencijeLabel.TabStop = true;
            this.evidencijeLabel.Text = "Evidencije";
            // 
            // obavijestiLabel
            // 
            this.obavijestiLabel.AutoSize = true;
            this.obavijestiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.obavijestiLabel.Font = new System.Drawing.Font("Forte", 20.25F);
            this.obavijestiLabel.LinkColor = System.Drawing.Color.White;
            this.obavijestiLabel.Location = new System.Drawing.Point(615, 416);
            this.obavijestiLabel.Name = "obavijestiLabel";
            this.obavijestiLabel.Size = new System.Drawing.Size(125, 30);
            this.obavijestiLabel.TabIndex = 15;
            this.obavijestiLabel.TabStop = true;
            this.obavijestiLabel.Text = "Obavijesti";
            this.obavijestiLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.obavijestiLabel_LinkClicked);
            // 
            // dodajUcenikaLabel
            // 
            this.dodajUcenikaLabel.AutoSize = true;
            this.dodajUcenikaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dodajUcenikaLabel.Font = new System.Drawing.Font("Forte", 20.25F);
            this.dodajUcenikaLabel.LinkColor = System.Drawing.Color.White;
            this.dodajUcenikaLabel.Location = new System.Drawing.Point(145, 416);
            this.dodajUcenikaLabel.Name = "dodajUcenikaLabel";
            this.dodajUcenikaLabel.Size = new System.Drawing.Size(180, 30);
            this.dodajUcenikaLabel.TabIndex = 16;
            this.dodajUcenikaLabel.TabStop = true;
            this.dodajUcenikaLabel.Text = "Dodaj učenika";
            // 
            // upravljanjeKorisnicimaLabel
            // 
            this.upravljanjeKorisnicimaLabel.AutoSize = true;
            this.upravljanjeKorisnicimaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.upravljanjeKorisnicimaLabel.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upravljanjeKorisnicimaLabel.LinkColor = System.Drawing.Color.White;
            this.upravljanjeKorisnicimaLabel.Location = new System.Drawing.Point(85, 177);
            this.upravljanjeKorisnicimaLabel.Name = "upravljanjeKorisnicimaLabel";
            this.upravljanjeKorisnicimaLabel.Size = new System.Drawing.Size(288, 30);
            this.upravljanjeKorisnicimaLabel.TabIndex = 17;
            this.upravljanjeKorisnicimaLabel.TabStop = true;
            this.upravljanjeKorisnicimaLabel.Text = "Upravljanje korisnicima";
            this.upravljanjeKorisnicimaLabel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // evidencijePictureBox
            // 
            this.evidencijePictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.razredi_smjerovi_predmeti;
            this.evidencijePictureBox.Location = new System.Drawing.Point(453, 0);
            this.evidencijePictureBox.Name = "evidencijePictureBox";
            this.evidencijePictureBox.Size = new System.Drawing.Size(456, 231);
            this.evidencijePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.evidencijePictureBox.TabIndex = 10;
            this.evidencijePictureBox.TabStop = false;
            // 
            // obavijestiPictureBox
            // 
            this.obavijestiPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.addNastavnik;
            this.obavijestiPictureBox.Location = new System.Drawing.Point(453, 228);
            this.obavijestiPictureBox.Name = "obavijestiPictureBox";
            this.obavijestiPictureBox.Size = new System.Drawing.Size(456, 231);
            this.obavijestiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obavijestiPictureBox.TabIndex = 11;
            this.obavijestiPictureBox.TabStop = false;
            // 
            // dodajUcenikaPictureBox
            // 
            this.dodajUcenikaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.addUcenik;
            this.dodajUcenikaPictureBox.Location = new System.Drawing.Point(0, 228);
            this.dodajUcenikaPictureBox.Name = "dodajUcenikaPictureBox";
            this.dodajUcenikaPictureBox.Size = new System.Drawing.Size(456, 231);
            this.dodajUcenikaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dodajUcenikaPictureBox.TabIndex = 12;
            this.dodajUcenikaPictureBox.TabStop = false;
            // 
            // upravljanjeKorisnicimaPictureBox
            // 
            this.upravljanjeKorisnicimaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.pregledKorisnika;
            this.upravljanjeKorisnicimaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.upravljanjeKorisnicimaPictureBox.Name = "upravljanjeKorisnicimaPictureBox";
            this.upravljanjeKorisnicimaPictureBox.Size = new System.Drawing.Size(456, 231);
            this.upravljanjeKorisnicimaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.upravljanjeKorisnicimaPictureBox.TabIndex = 13;
            this.upravljanjeKorisnicimaPictureBox.TabStop = false;
            // 
            // MainFormNast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.evidencijeLabel);
            this.Controls.Add(this.obavijestiLabel);
            this.Controls.Add(this.dodajUcenikaLabel);
            this.Controls.Add(this.upravljanjeKorisnicimaLabel);
            this.Controls.Add(this.evidencijePictureBox);
            this.Controls.Add(this.obavijestiPictureBox);
            this.Controls.Add(this.dodajUcenikaPictureBox);
            this.Controls.Add(this.upravljanjeKorisnicimaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainFormNast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormNast";
            ((System.ComponentModel.ISupportInitialize)(this.evidencijePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajUcenikaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upravljanjeKorisnicimaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel evidencijeLabel;
        private System.Windows.Forms.LinkLabel obavijestiLabel;
        private System.Windows.Forms.LinkLabel dodajUcenikaLabel;
        private System.Windows.Forms.LinkLabel upravljanjeKorisnicimaLabel;
        private System.Windows.Forms.PictureBox evidencijePictureBox;
        private System.Windows.Forms.PictureBox obavijestiPictureBox;
        private System.Windows.Forms.PictureBox dodajUcenikaPictureBox;
        private System.Windows.Forms.PictureBox upravljanjeKorisnicimaPictureBox;
    }
}