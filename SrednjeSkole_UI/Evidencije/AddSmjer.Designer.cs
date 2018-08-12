namespace SrednjeSkole_UI.Evidencije
{
    partial class AddSmjer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oznakaInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.predmetiList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skolskaGodinaCmb = new System.Windows.Forms.ComboBox();
            this.predmetiAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // oznakaInput
            // 
            this.oznakaInput.Location = new System.Drawing.Point(91, 48);
            this.oznakaInput.Multiline = true;
            this.oznakaInput.Name = "oznakaInput";
            this.oznakaInput.Size = new System.Drawing.Size(136, 71);
            this.oznakaInput.TabIndex = 3;
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(91, 22);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(136, 20);
            this.nazivInput.TabIndex = 4;
            // 
            // predmetiList
            // 
            this.predmetiList.FormattingEnabled = true;
            this.predmetiList.Location = new System.Drawing.Point(91, 168);
            this.predmetiList.Name = "predmetiList";
            this.predmetiList.Size = new System.Drawing.Size(136, 94);
            this.predmetiList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Predmeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Školska godina:";
            // 
            // skolskaGodinaCmb
            // 
            this.skolskaGodinaCmb.FormattingEnabled = true;
            this.skolskaGodinaCmb.Location = new System.Drawing.Point(91, 128);
            this.skolskaGodinaCmb.Name = "skolskaGodinaCmb";
            this.skolskaGodinaCmb.Size = new System.Drawing.Size(136, 21);
            this.skolskaGodinaCmb.TabIndex = 9;
            // 
            // predmetiAddBtn
            // 
            this.predmetiAddBtn.Location = new System.Drawing.Point(233, 168);
            this.predmetiAddBtn.Name = "predmetiAddBtn";
            this.predmetiAddBtn.Size = new System.Drawing.Size(28, 23);
            this.predmetiAddBtn.TabIndex = 14;
            this.predmetiAddBtn.Text = "+";
            this.predmetiAddBtn.UseVisualStyleBackColor = true;
            // 
            // AddSmjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 331);
            this.Controls.Add(this.predmetiAddBtn);
            this.Controls.Add(this.skolskaGodinaCmb);
            this.Controls.Add(this.predmetiList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oznakaInput);
            this.Controls.Add(this.nazivInput);
            this.Name = "AddSmjer";
            this.Text = "AddSmjer";
            this.Load += new System.EventHandler(this.AddSmjer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oznakaInput;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.CheckedListBox predmetiList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox skolskaGodinaCmb;
        private System.Windows.Forms.Button predmetiAddBtn;
    }
}