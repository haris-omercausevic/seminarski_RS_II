﻿namespace SrednjeSkole_UI.MaterijaliNS
{
    partial class AddMaterijal
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
            this.components = new System.ComponentModel.Container();
            this.predajeCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dodajFajlBtn = new System.Windows.Forms.Button();
            this.fajlInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // predajeCmb
            // 
            this.predajeCmb.FormattingEnabled = true;
            this.predajeCmb.Location = new System.Drawing.Point(75, 29);
            this.predajeCmb.Name = "predajeCmb";
            this.predajeCmb.Size = new System.Drawing.Size(163, 21);
            this.predajeCmb.TabIndex = 1;
            this.predajeCmb.Validating += new System.ComponentModel.CancelEventHandler(this.predajeCmb_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(4, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Predmet:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dodajFajlBtn
            // 
            this.dodajFajlBtn.Location = new System.Drawing.Point(276, 74);
            this.dodajFajlBtn.Name = "dodajFajlBtn";
            this.dodajFajlBtn.Size = new System.Drawing.Size(56, 23);
            this.dodajFajlBtn.TabIndex = 3;
            this.dodajFajlBtn.Text = "Browse";
            this.dodajFajlBtn.UseVisualStyleBackColor = true;
            this.dodajFajlBtn.Click += new System.EventHandler(this.dodajFajlBtn_Click);
            // 
            // fajlInput
            // 
            this.fajlInput.Location = new System.Drawing.Point(75, 76);
            this.fajlInput.Name = "fajlInput";
            this.fajlInput.Size = new System.Drawing.Size(195, 20);
            this.fajlInput.TabIndex = 2;
            this.fajlInput.TabStop = false;
            this.fajlInput.Validating += new System.ComponentModel.CancelEventHandler(this.fajlInput_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(35, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Fajl:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sacuvajBtn.Location = new System.Drawing.Point(261, 143);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(71, 29);
            this.sacuvajBtn.TabIndex = 4;
            this.sacuvajBtn.Text = "Sačuvaj";
            this.sacuvajBtn.UseVisualStyleBackColor = true;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 189);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.dodajFajlBtn);
            this.Controls.Add(this.fajlInput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.predajeCmb);
            this.Controls.Add(this.label4);
            this.Name = "AddMaterijal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj materijal";
            this.Load += new System.EventHandler(this.AddMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox predajeCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button dodajFajlBtn;
        private System.Windows.Forms.TextBox fajlInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}