namespace SrednjeSkole_UI.Evidencije
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.predmetiPctureBox = new System.Windows.Forms.PictureBox();
            this.razrediPictureBox = new System.Windows.Forms.PictureBox();
            this.zaduzenjaPictureBox = new System.Windows.Forms.PictureBox();
            this.smjeroviPictureBox = new System.Windows.Forms.PictureBox();
            this.razrediLabel = new System.Windows.Forms.Label();
            this.predmetiLabel = new System.Windows.Forms.Label();
            this.smjeroviLabel = new System.Windows.Forms.Label();
            this.zaduzenjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiPctureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaduzenjaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjeroviPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // predmetiPctureBox
            // 
            this.predmetiPctureBox.BackColor = System.Drawing.Color.DarkGreen;
            this.predmetiPctureBox.Image = ((System.Drawing.Image)(resources.GetObject("predmetiPctureBox.Image")));
            this.predmetiPctureBox.Location = new System.Drawing.Point(0, 207);
            this.predmetiPctureBox.Name = "predmetiPctureBox";
            this.predmetiPctureBox.Size = new System.Drawing.Size(446, 207);
            this.predmetiPctureBox.TabIndex = 0;
            this.predmetiPctureBox.TabStop = false;
            this.predmetiPctureBox.Click += new System.EventHandler(this.predmetiPctureBox_Click);
            // 
            // razrediPictureBox
            // 
            this.razrediPictureBox.BackColor = System.Drawing.Color.Gold;
            this.razrediPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("razrediPictureBox.Image")));
            this.razrediPictureBox.Location = new System.Drawing.Point(446, 207);
            this.razrediPictureBox.Name = "razrediPictureBox";
            this.razrediPictureBox.Size = new System.Drawing.Size(446, 207);
            this.razrediPictureBox.TabIndex = 0;
            this.razrediPictureBox.TabStop = false;
            this.razrediPictureBox.Click += new System.EventHandler(this.razrediPictureBox_Click);
            // 
            // zaduzenjaPictureBox
            // 
            this.zaduzenjaPictureBox.BackColor = System.Drawing.Color.Gold;
            this.zaduzenjaPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.zaduzenja;
            this.zaduzenjaPictureBox.Location = new System.Drawing.Point(446, 0);
            this.zaduzenjaPictureBox.Name = "zaduzenjaPictureBox";
            this.zaduzenjaPictureBox.Size = new System.Drawing.Size(446, 207);
            this.zaduzenjaPictureBox.TabIndex = 0;
            this.zaduzenjaPictureBox.TabStop = false;
            this.zaduzenjaPictureBox.Click += new System.EventHandler(this.zaduzenjaPictureBox_Click);
            // 
            // smjeroviPictureBox
            // 
            this.smjeroviPictureBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.smjeroviPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("smjeroviPictureBox.Image")));
            this.smjeroviPictureBox.Location = new System.Drawing.Point(0, 0);
            this.smjeroviPictureBox.Name = "smjeroviPictureBox";
            this.smjeroviPictureBox.Size = new System.Drawing.Size(446, 207);
            this.smjeroviPictureBox.TabIndex = 0;
            this.smjeroviPictureBox.TabStop = false;
            this.smjeroviPictureBox.Click += new System.EventHandler(this.smjeroviPictureBox_Click);
            // 
            // razrediLabel
            // 
            this.razrediLabel.AutoSize = true;
            this.razrediLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.razrediLabel.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold);
            this.razrediLabel.ForeColor = System.Drawing.Color.White;
            this.razrediLabel.Location = new System.Drawing.Point(603, 376);
            this.razrediLabel.Name = "razrediLabel";
            this.razrediLabel.Size = new System.Drawing.Size(141, 34);
            this.razrediLabel.TabIndex = 18;
            this.razrediLabel.TabStop = true;
            this.razrediLabel.Text = "Razredi";
            // 
            // predmetiLabel
            // 
            this.predmetiLabel.AutoSize = true;
            this.predmetiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(6)))), ((int)(((byte)(52)))));
            this.predmetiLabel.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold);
            this.predmetiLabel.ForeColor = System.Drawing.Color.White;
            this.predmetiLabel.Location = new System.Drawing.Point(149, 376);
            this.predmetiLabel.Name = "predmetiLabel";
            this.predmetiLabel.Size = new System.Drawing.Size(159, 34);
            this.predmetiLabel.TabIndex = 18;
            this.predmetiLabel.TabStop = true;
            this.predmetiLabel.Text = "Predmeti";
            // 
            // smjeroviLabel
            // 
            this.smjeroviLabel.AutoSize = true;
            this.smjeroviLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.smjeroviLabel.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold);
            this.smjeroviLabel.ForeColor = System.Drawing.Color.White;
            this.smjeroviLabel.Location = new System.Drawing.Point(137, 170);
            this.smjeroviLabel.Name = "smjeroviLabel";
            this.smjeroviLabel.Size = new System.Drawing.Size(159, 34);
            this.smjeroviLabel.TabIndex = 18;
            this.smjeroviLabel.TabStop = true;
            this.smjeroviLabel.Text = "Smjerovi";
            // 
            // zaduzenjaLabel
            // 
            this.zaduzenjaLabel.AutoSize = true;
            this.zaduzenjaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.zaduzenjaLabel.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold);
            this.zaduzenjaLabel.ForeColor = System.Drawing.Color.White;
            this.zaduzenjaLabel.Location = new System.Drawing.Point(583, 170);
            this.zaduzenjaLabel.Name = "zaduzenjaLabel";
            this.zaduzenjaLabel.Size = new System.Drawing.Size(177, 34);
            this.zaduzenjaLabel.TabIndex = 18;
            this.zaduzenjaLabel.TabStop = true;
            this.zaduzenjaLabel.Text = "Zaduženja";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 415);
            this.Controls.Add(this.zaduzenjaLabel);
            this.Controls.Add(this.smjeroviLabel);
            this.Controls.Add(this.predmetiLabel);
            this.Controls.Add(this.razrediLabel);
            this.Controls.Add(this.predmetiPctureBox);
            this.Controls.Add(this.razrediPictureBox);
            this.Controls.Add(this.zaduzenjaPictureBox);
            this.Controls.Add(this.smjeroviPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.Text = "Evidencije";
            ((System.ComponentModel.ISupportInitialize)(this.predmetiPctureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaduzenjaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjeroviPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox smjeroviPictureBox;
        private System.Windows.Forms.PictureBox zaduzenjaPictureBox;
        private System.Windows.Forms.PictureBox predmetiPctureBox;
        private System.Windows.Forms.PictureBox razrediPictureBox;
        private System.Windows.Forms.Label razrediLabel;
        private System.Windows.Forms.Label predmetiLabel;
        private System.Windows.Forms.Label smjeroviLabel;
        private System.Windows.Forms.Label zaduzenjaLabel;
    }
}