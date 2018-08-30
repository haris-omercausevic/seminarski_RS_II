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
            this.razrediLabel = new System.Windows.Forms.LinkLabel();
            this.materijaliPictureBox = new System.Windows.Forms.PictureBox();
            this.obavijestiPictureBox = new System.Windows.Forms.PictureBox();
            this.razrediPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materijaliLabel
            // 
            this.materijaliLabel.AutoSize = true;
            this.materijaliLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.materijaliLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.materijaliLabel.LinkColor = System.Drawing.Color.White;
            this.materijaliLabel.Location = new System.Drawing.Point(578, 181);
            this.materijaliLabel.Name = "materijaliLabel";
            this.materijaliLabel.Size = new System.Drawing.Size(205, 36);
            this.materijaliLabel.TabIndex = 14;
            this.materijaliLabel.TabStop = true;
            this.materijaliLabel.Text = "Materijali";
            this.materijaliLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.materijaliLabel_LinkClicked);
            // 
            // obavijestiLabel
            // 
            this.obavijestiLabel.AutoSize = true;
            this.obavijestiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.obavijestiLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.obavijestiLabel.LinkColor = System.Drawing.Color.White;
            this.obavijestiLabel.Location = new System.Drawing.Point(578, 416);
            this.obavijestiLabel.Name = "obavijestiLabel";
            this.obavijestiLabel.Size = new System.Drawing.Size(205, 36);
            this.obavijestiLabel.TabIndex = 15;
            this.obavijestiLabel.TabStop = true;
            this.obavijestiLabel.Text = "Obavijesti";
            this.obavijestiLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.obavijestiLabel_LinkClicked);
            // 
            // razrediLabel
            // 
            this.razrediLabel.AutoSize = true;
            this.razrediLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.razrediLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.razrediLabel.LinkColor = System.Drawing.Color.White;
            this.razrediLabel.Location = new System.Drawing.Point(158, 400);
            this.razrediLabel.Name = "razrediLabel";
            this.razrediLabel.Size = new System.Drawing.Size(148, 36);
            this.razrediLabel.TabIndex = 17;
            this.razrediLabel.TabStop = true;
            this.razrediLabel.Text = "Razredi";
            this.razrediLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.razrediLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.razrediLabel_LinkClicked);
            // 
            // materijaliPictureBox
            // 
            this.materijaliPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.razredi_smjerovi_predmeti;
            this.materijaliPictureBox.Location = new System.Drawing.Point(456, 0);
            this.materijaliPictureBox.Name = "materijaliPictureBox";
            this.materijaliPictureBox.Size = new System.Drawing.Size(456, 231);
            this.materijaliPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.materijaliPictureBox.TabIndex = 10;
            this.materijaliPictureBox.TabStop = false;
            this.materijaliPictureBox.Click += new System.EventHandler(this.materijaliPictureBox_Click);
            // 
            // obavijestiPictureBox
            // 
            this.obavijestiPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.obavjesti;
            this.obavijestiPictureBox.Location = new System.Drawing.Point(456, 231);
            this.obavijestiPictureBox.Name = "obavijestiPictureBox";
            this.obavijestiPictureBox.Size = new System.Drawing.Size(456, 231);
            this.obavijestiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obavijestiPictureBox.TabIndex = 11;
            this.obavijestiPictureBox.TabStop = false;
            this.obavijestiPictureBox.Click += new System.EventHandler(this.obavijestiPictureBox_Click);
            // 
            // razrediPictureBox
            // 
            this.razrediPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.razredi_4;
            this.razrediPictureBox.Location = new System.Drawing.Point(0, 0);
            this.razrediPictureBox.Name = "razrediPictureBox";
            this.razrediPictureBox.Size = new System.Drawing.Size(456, 462);
            this.razrediPictureBox.TabIndex = 13;
            this.razrediPictureBox.TabStop = false;
            this.razrediPictureBox.Click += new System.EventHandler(this.razrediPictureBox_Click);
            // 
            // MainFormNast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.materijaliLabel);
            this.Controls.Add(this.obavijestiLabel);
            this.Controls.Add(this.razrediLabel);
            this.Controls.Add(this.materijaliPictureBox);
            this.Controls.Add(this.obavijestiPictureBox);
            this.Controls.Add(this.razrediPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFormNast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Srednje škole :: Nastavnik";
            ((System.ComponentModel.ISupportInitialize)(this.materijaliPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel materijaliLabel;
        private System.Windows.Forms.LinkLabel obavijestiLabel;
        private System.Windows.Forms.LinkLabel razrediLabel;
        private System.Windows.Forms.PictureBox materijaliPictureBox;
        private System.Windows.Forms.PictureBox obavijestiPictureBox;
        private System.Windows.Forms.PictureBox razrediPictureBox;
    }
}