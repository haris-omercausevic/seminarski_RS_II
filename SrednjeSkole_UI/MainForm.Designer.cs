namespace SrednjeSkole_UI
{
    partial class MainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.upravljanjeKorisnicimaPictureBox = new System.Windows.Forms.PictureBox();
            this.dodajUcenikaPictureBox = new System.Windows.Forms.PictureBox();
            this.dodajNastavnikaPictureBox = new System.Windows.Forms.PictureBox();
            this.evidencijePictureBox = new System.Windows.Forms.PictureBox();
            this.upravljanjeKorisnicimaLabel = new System.Windows.Forms.LinkLabel();
            this.dodajUcenikaLabel = new System.Windows.Forms.LinkLabel();
            this.dodajNastavnikaLabel = new System.Windows.Forms.LinkLabel();
            this.evidencijeLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.upravljanjeKorisnicimaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajUcenikaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajNastavnikaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upravljanjeKorisnicimaPictureBox
            // 
            this.upravljanjeKorisnicimaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.pregledKorisnika;
            this.upravljanjeKorisnicimaPictureBox.Location = new System.Drawing.Point(2, 2);
            this.upravljanjeKorisnicimaPictureBox.Name = "upravljanjeKorisnicimaPictureBox";
            this.upravljanjeKorisnicimaPictureBox.Size = new System.Drawing.Size(456, 231);
            this.upravljanjeKorisnicimaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.upravljanjeKorisnicimaPictureBox.TabIndex = 8;
            this.upravljanjeKorisnicimaPictureBox.TabStop = false;
            // 
            // dodajUcenikaPictureBox
            // 
            this.dodajUcenikaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.addUcenik;
            this.dodajUcenikaPictureBox.Location = new System.Drawing.Point(2, 230);
            this.dodajUcenikaPictureBox.Name = "dodajUcenikaPictureBox";
            this.dodajUcenikaPictureBox.Size = new System.Drawing.Size(456, 231);
            this.dodajUcenikaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dodajUcenikaPictureBox.TabIndex = 8;
            this.dodajUcenikaPictureBox.TabStop = false;
            // 
            // dodajNastavnikaPictureBox
            // 
            this.dodajNastavnikaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.addNastavnik;
            this.dodajNastavnikaPictureBox.Location = new System.Drawing.Point(455, 230);
            this.dodajNastavnikaPictureBox.Name = "dodajNastavnikaPictureBox";
            this.dodajNastavnikaPictureBox.Size = new System.Drawing.Size(456, 231);
            this.dodajNastavnikaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dodajNastavnikaPictureBox.TabIndex = 8;
            this.dodajNastavnikaPictureBox.TabStop = false;
            // 
            // evidencijePictureBox
            // 
            this.evidencijePictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.razredi_smjerovi_predmeti;
            this.evidencijePictureBox.Location = new System.Drawing.Point(455, 2);
            this.evidencijePictureBox.Name = "evidencijePictureBox";
            this.evidencijePictureBox.Size = new System.Drawing.Size(456, 231);
            this.evidencijePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.evidencijePictureBox.TabIndex = 8;
            this.evidencijePictureBox.TabStop = false;
            // 
            // upravljanjeKorisnicimaLabel
            // 
            this.upravljanjeKorisnicimaLabel.AutoSize = true;
            this.upravljanjeKorisnicimaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.upravljanjeKorisnicimaLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upravljanjeKorisnicimaLabel.LinkColor = System.Drawing.Color.White;
            this.upravljanjeKorisnicimaLabel.Location = new System.Drawing.Point(93, 186);
            this.upravljanjeKorisnicimaLabel.Name = "upravljanjeKorisnicimaLabel";
            this.upravljanjeKorisnicimaLabel.Size = new System.Drawing.Size(309, 24);
            this.upravljanjeKorisnicimaLabel.TabIndex = 9;
            this.upravljanjeKorisnicimaLabel.TabStop = true;
            this.upravljanjeKorisnicimaLabel.Text = "Upravljanje korisnicima";
            this.upravljanjeKorisnicimaLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.upravljanjeKorisnicimaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.upravljanjeKorisnicimaLabel_LinkClicked);
            // 
            // dodajUcenikaLabel
            // 
            this.dodajUcenikaLabel.AutoSize = true;
            this.dodajUcenikaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dodajUcenikaLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajUcenikaLabel.LinkColor = System.Drawing.Color.White;
            this.dodajUcenikaLabel.Location = new System.Drawing.Point(147, 418);
            this.dodajUcenikaLabel.Name = "dodajUcenikaLabel";
            this.dodajUcenikaLabel.Size = new System.Drawing.Size(179, 24);
            this.dodajUcenikaLabel.TabIndex = 9;
            this.dodajUcenikaLabel.TabStop = true;
            this.dodajUcenikaLabel.Text = "Dodaj ucenika";
            this.dodajUcenikaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dodajUcenikaLabel_LinkClicked);
            // 
            // dodajNastavnikaLabel
            // 
            this.dodajNastavnikaLabel.AutoSize = true;
            this.dodajNastavnikaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.dodajNastavnikaLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajNastavnikaLabel.LinkColor = System.Drawing.Color.White;
            this.dodajNastavnikaLabel.Location = new System.Drawing.Point(564, 418);
            this.dodajNastavnikaLabel.Name = "dodajNastavnikaLabel";
            this.dodajNastavnikaLabel.Size = new System.Drawing.Size(218, 24);
            this.dodajNastavnikaLabel.TabIndex = 9;
            this.dodajNastavnikaLabel.TabStop = true;
            this.dodajNastavnikaLabel.Text = "Dodaj nastavnika";
            this.dodajNastavnikaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dodajNastavnikaLabel_LinkClicked);
            // 
            // evidencijeLabel
            // 
            this.evidencijeLabel.AutoSize = true;
            this.evidencijeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.evidencijeLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidencijeLabel.LinkColor = System.Drawing.Color.White;
            this.evidencijeLabel.Location = new System.Drawing.Point(598, 186);
            this.evidencijeLabel.Name = "evidencijeLabel";
            this.evidencijeLabel.Size = new System.Drawing.Size(140, 24);
            this.evidencijeLabel.TabIndex = 9;
            this.evidencijeLabel.TabStop = true;
            this.evidencijeLabel.Text = "Evidencije";
            this.evidencijeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.evidencijeLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.evidencijeLabel);
            this.Controls.Add(this.dodajNastavnikaLabel);
            this.Controls.Add(this.dodajUcenikaLabel);
            this.Controls.Add(this.upravljanjeKorisnicimaLabel);
            this.Controls.Add(this.evidencijePictureBox);
            this.Controls.Add(this.dodajNastavnikaPictureBox);
            this.Controls.Add(this.dodajUcenikaPictureBox);
            this.Controls.Add(this.upravljanjeKorisnicimaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Srednje škole :: Admin";
            ((System.ComponentModel.ISupportInitialize)(this.upravljanjeKorisnicimaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajUcenikaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajNastavnikaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox upravljanjeKorisnicimaPictureBox;
        private System.Windows.Forms.PictureBox dodajUcenikaPictureBox;
        private System.Windows.Forms.PictureBox dodajNastavnikaPictureBox;
        private System.Windows.Forms.PictureBox evidencijePictureBox;
        private System.Windows.Forms.LinkLabel upravljanjeKorisnicimaLabel;
        private System.Windows.Forms.LinkLabel dodajUcenikaLabel;
        private System.Windows.Forms.LinkLabel dodajNastavnikaLabel;
        private System.Windows.Forms.LinkLabel evidencijeLabel;
    }
}

