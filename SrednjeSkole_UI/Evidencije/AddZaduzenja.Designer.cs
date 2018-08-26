namespace SrednjeSkole_UI.Evidencije
{
    partial class AddZaduzenja
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
            this.predmetiPrviList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nastavnikCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.predmetiDrugiList = new System.Windows.Forms.CheckedListBox();
            this.predmetiTreciList = new System.Windows.Forms.CheckedListBox();
            this.predmetiCetvrtiList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dodijeliBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.razrediList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // predmetiPrviList
            // 
            this.predmetiPrviList.FormattingEnabled = true;
            this.predmetiPrviList.Location = new System.Drawing.Point(16, 106);
            this.predmetiPrviList.Name = "predmetiPrviList";
            this.predmetiPrviList.Size = new System.Drawing.Size(146, 274);
            this.predmetiPrviList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite predmete koje predaje:";
            // 
            // nastavnikCmb
            // 
            this.nastavnikCmb.FormattingEnabled = true;
            this.nastavnikCmb.Location = new System.Drawing.Point(96, 12);
            this.nastavnikCmb.Name = "nastavnikCmb";
            this.nastavnikCmb.Size = new System.Drawing.Size(155, 21);
            this.nastavnikCmb.TabIndex = 17;
            this.nastavnikCmb.Validating += new System.ComponentModel.CancelEventHandler(this.nastavnikCmb_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(27, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nastavnik:";
            // 
            // predmetiDrugiList
            // 
            this.predmetiDrugiList.FormattingEnabled = true;
            this.predmetiDrugiList.Location = new System.Drawing.Point(184, 106);
            this.predmetiDrugiList.Name = "predmetiDrugiList";
            this.predmetiDrugiList.Size = new System.Drawing.Size(146, 274);
            this.predmetiDrugiList.TabIndex = 0;
            // 
            // predmetiTreciList
            // 
            this.predmetiTreciList.FormattingEnabled = true;
            this.predmetiTreciList.Location = new System.Drawing.Point(349, 106);
            this.predmetiTreciList.Name = "predmetiTreciList";
            this.predmetiTreciList.Size = new System.Drawing.Size(146, 274);
            this.predmetiTreciList.TabIndex = 0;
            // 
            // predmetiCetvrtiList
            // 
            this.predmetiCetvrtiList.FormattingEnabled = true;
            this.predmetiCetvrtiList.Location = new System.Drawing.Point(519, 106);
            this.predmetiCetvrtiList.Name = "predmetiCetvrtiList";
            this.predmetiCetvrtiList.Size = new System.Drawing.Size(146, 274);
            this.predmetiCetvrtiList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "1. Razred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "2. Razred";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "3. Razred";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "4. Razred";
            // 
            // dodijeliBtn
            // 
            this.dodijeliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dodijeliBtn.Location = new System.Drawing.Point(748, 348);
            this.dodijeliBtn.Name = "dodijeliBtn";
            this.dodijeliBtn.Size = new System.Drawing.Size(87, 32);
            this.dodijeliBtn.TabIndex = 20;
            this.dodijeliBtn.Text = "Dodijeli";
            this.dodijeliBtn.UseVisualStyleBackColor = true;
            this.dodijeliBtn.Click += new System.EventHandler(this.dodijeliBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(679, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Odaberite razrede kojima predaje:";
            // 
            // razrediList
            // 
            this.razrediList.FormattingEnabled = true;
            this.razrediList.Location = new System.Drawing.Point(692, 106);
            this.razrediList.Name = "razrediList";
            this.razrediList.Size = new System.Drawing.Size(159, 214);
            this.razrediList.TabIndex = 21;
            this.razrediList.Validating += new System.ComponentModel.CancelEventHandler(this.razrediList_Validating);
            // 
            // AddZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.razrediList);
            this.Controls.Add(this.dodijeliBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nastavnikCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmetiCetvrtiList);
            this.Controls.Add(this.predmetiTreciList);
            this.Controls.Add(this.predmetiDrugiList);
            this.Controls.Add(this.predmetiPrviList);
            this.Name = "AddZaduzenja";
            this.Text = "Dodjela predmeta i razreda nastavniku";
            this.Load += new System.EventHandler(this.AddZaduzenja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox predmetiPrviList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nastavnikCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox predmetiDrugiList;
        private System.Windows.Forms.CheckedListBox predmetiTreciList;
        private System.Windows.Forms.CheckedListBox predmetiCetvrtiList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodijeliBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox razrediList;
    }
}