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
            this.materijaliLabel = new System.Windows.Forms.LinkLabel();
            this.obavijestiLabel = new System.Windows.Forms.LinkLabel();
            this.dodajUcenikaLabel = new System.Windows.Forms.LinkLabel();
            this.razrediLabel = new System.Windows.Forms.LinkLabel();
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
            // materijaliLabel
            // 
            this.materijaliLabel.AutoSize = true;
            this.materijaliLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.materijaliLabel.Font = new System.Drawing.Font("Forte", 20.25F);
            this.materijaliLabel.LinkColor = System.Drawing.Color.White;
            this.materijaliLabel.Location = new System.Drawing.Point(596, 184);
            this.materijaliLabel.Name = "materijaliLabel";
            this.materijaliLabel.Size = new System.Drawing.Size(136, 30);
            this.materijaliLabel.TabIndex = 14;
            this.materijaliLabel.TabStop = true;
            this.materijaliLabel.Text = "Materijali";
            this.materijaliLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.materijaliLabel_LinkClicked);
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
            this.dodajUcenikaLabel.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.dodajUcenikaLabel.LinkColor = System.Drawing.Color.White;
            this.dodajUcenikaLabel.Location = new System.Drawing.Point(114, 416);
            this.dodajUcenikaLabel.Name = "dodajUcenikaLabel";
            this.dodajUcenikaLabel.Size = new System.Drawing.Size(221, 30);
            this.dodajUcenikaLabel.TabIndex = 16;
            this.dodajUcenikaLabel.TabStop = true;
            this.dodajUcenikaLabel.Text = "Dodaj učenika";
            // 
            // razrediLabel
            // 
            this.razrediLabel.AutoSize = true;
            this.razrediLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.razrediLabel.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razrediLabel.LinkColor = System.Drawing.Color.White;
            this.razrediLabel.Location = new System.Drawing.Point(175, 172);
            this.razrediLabel.Name = "razrediLabel";
            this.razrediLabel.Size = new System.Drawing.Size(100, 30);
            this.razrediLabel.TabIndex = 17;
            this.razrediLabel.TabStop = true;
            this.razrediLabel.Text = "Razredi";
            this.razrediLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.razrediLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.razrediLabel_LinkClicked);
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
            this.Controls.Add(this.materijaliLabel);
            this.Controls.Add(this.obavijestiLabel);
            this.Controls.Add(this.dodajUcenikaLabel);
            this.Controls.Add(this.razrediLabel);
            this.Controls.Add(this.evidencijePictureBox);
            this.Controls.Add(this.obavijestiPictureBox);
            this.Controls.Add(this.dodajUcenikaPictureBox);
            this.Controls.Add(this.upravljanjeKorisnicimaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

        private System.Windows.Forms.LinkLabel materijaliLabel;
        private System.Windows.Forms.LinkLabel obavijestiLabel;
        private System.Windows.Forms.LinkLabel dodajUcenikaLabel;
        private System.Windows.Forms.LinkLabel razrediLabel;
        private System.Windows.Forms.PictureBox evidencijePictureBox;
        private System.Windows.Forms.PictureBox obavijestiPictureBox;
        private System.Windows.Forms.PictureBox dodajUcenikaPictureBox;
        private System.Windows.Forms.PictureBox upravljanjeKorisnicimaPictureBox;
    }
}