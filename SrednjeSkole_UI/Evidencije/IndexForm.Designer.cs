﻿namespace SrednjeSkole_UI.Evidencije
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
            this.predmetiPctureBox = new System.Windows.Forms.PictureBox();
            this.razrediPictureBox = new System.Windows.Forms.PictureBox();
            this.smjeroviPictureBox = new System.Windows.Forms.PictureBox();
            this.zaduzenjaLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiPctureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjeroviPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // predmetiPctureBox
            // 
            this.predmetiPctureBox.BackColor = System.Drawing.Color.DarkGreen;
            this.predmetiPctureBox.Image = global::SrednjeSkole_UI.Properties.Resources.predmeti;
            this.predmetiPctureBox.Location = new System.Drawing.Point(0, 276);
            this.predmetiPctureBox.Name = "predmetiPctureBox";
            this.predmetiPctureBox.Size = new System.Drawing.Size(701, 138);
            this.predmetiPctureBox.TabIndex = 0;
            this.predmetiPctureBox.TabStop = false;
            this.predmetiPctureBox.Click += new System.EventHandler(this.predmetiPctureBox_Click);
            // 
            // razrediPictureBox
            // 
            this.razrediPictureBox.BackColor = System.Drawing.Color.Gold;
            this.razrediPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.razredi;
            this.razrediPictureBox.Location = new System.Drawing.Point(0, 138);
            this.razrediPictureBox.Name = "razrediPictureBox";
            this.razrediPictureBox.Size = new System.Drawing.Size(701, 138);
            this.razrediPictureBox.TabIndex = 0;
            this.razrediPictureBox.TabStop = false;
            this.razrediPictureBox.Click += new System.EventHandler(this.razrediPictureBox_Click);
            // 
            // smjeroviPictureBox
            // 
            this.smjeroviPictureBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.smjeroviPictureBox.Image = global::SrednjeSkole_UI.Properties.Resources.smjerovi;
            this.smjeroviPictureBox.Location = new System.Drawing.Point(0, 0);
            this.smjeroviPictureBox.Name = "smjeroviPictureBox";
            this.smjeroviPictureBox.Size = new System.Drawing.Size(701, 138);
            this.smjeroviPictureBox.TabIndex = 0;
            this.smjeroviPictureBox.TabStop = false;
            this.smjeroviPictureBox.Click += new System.EventHandler(this.smjeroviPictureBox_Click);
            // 
            // zaduzenjaLabel
            // 
            this.zaduzenjaLabel.AutoSize = true;
            this.zaduzenjaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.zaduzenjaLabel.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaduzenjaLabel.LinkColor = System.Drawing.Color.White;
            this.zaduzenjaLabel.Location = new System.Drawing.Point(732, 204);
            this.zaduzenjaLabel.Name = "zaduzenjaLabel";
            this.zaduzenjaLabel.Size = new System.Drawing.Size(135, 30);
            this.zaduzenjaLabel.TabIndex = 18;
            this.zaduzenjaLabel.TabStop = true;
            this.zaduzenjaLabel.Text = "Zaduženja";
            this.zaduzenjaLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.zaduzenjaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zaduzenjaLabel_LinkClicked);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 415);
            this.Controls.Add(this.zaduzenjaLabel);
            this.Controls.Add(this.predmetiPctureBox);
            this.Controls.Add(this.razrediPictureBox);
            this.Controls.Add(this.smjeroviPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.Text = "Evidencije";
            ((System.ComponentModel.ISupportInitialize)(this.predmetiPctureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjeroviPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox smjeroviPictureBox;
        private System.Windows.Forms.PictureBox razrediPictureBox;
        private System.Windows.Forms.PictureBox predmetiPctureBox;
        private System.Windows.Forms.LinkLabel zaduzenjaLabel;
    }
}