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
            this.components = new System.ComponentModel.Container();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opisInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.predmetiList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skolskaGodinaCmb = new System.Windows.Forms.ComboBox();
            this.predmetiAddBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.skolskaGodinaAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(186, 290);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 7;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
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
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(91, 48);
            this.opisInput.Multiline = true;
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(136, 71);
            this.opisInput.TabIndex = 3;
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(91, 22);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(136, 20);
            this.nazivInput.TabIndex = 4;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // predmetiList
            // 
            this.predmetiList.FormattingEnabled = true;
            this.predmetiList.Location = new System.Drawing.Point(91, 168);
            this.predmetiList.Name = "predmetiList";
            this.predmetiList.Size = new System.Drawing.Size(136, 94);
            this.predmetiList.TabIndex = 8;
            this.predmetiList.Validating += new System.ComponentModel.CancelEventHandler(this.predmetiList_Validating);
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
            this.skolskaGodinaCmb.Validating += new System.ComponentModel.CancelEventHandler(this.skolskaGodinaCmb_Validating);
            // 
            // predmetiAddBtn
            // 
            this.predmetiAddBtn.Location = new System.Drawing.Point(233, 168);
            this.predmetiAddBtn.Name = "predmetiAddBtn";
            this.predmetiAddBtn.Size = new System.Drawing.Size(28, 23);
            this.predmetiAddBtn.TabIndex = 14;
            this.predmetiAddBtn.Text = "+";
            this.predmetiAddBtn.UseVisualStyleBackColor = true;
            this.predmetiAddBtn.Click += new System.EventHandler(this.predmetiAddBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // skolskaGodinaAddBtn
            // 
            this.skolskaGodinaAddBtn.Location = new System.Drawing.Point(233, 128);
            this.skolskaGodinaAddBtn.Name = "skolskaGodinaAddBtn";
            this.skolskaGodinaAddBtn.Size = new System.Drawing.Size(28, 23);
            this.skolskaGodinaAddBtn.TabIndex = 15;
            this.skolskaGodinaAddBtn.Text = "+";
            this.skolskaGodinaAddBtn.UseVisualStyleBackColor = true;
            this.skolskaGodinaAddBtn.Click += new System.EventHandler(this.skolskaGodinaAddBtn_Click);
            // 
            // AddSmjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 331);
            this.Controls.Add(this.skolskaGodinaAddBtn);
            this.Controls.Add(this.predmetiAddBtn);
            this.Controls.Add(this.skolskaGodinaCmb);
            this.Controls.Add(this.predmetiList);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.nazivInput);
            this.Name = "AddSmjer";
            this.Text = "AddSmjer";
            this.Load += new System.EventHandler(this.AddSmjer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opisInput;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.CheckedListBox predmetiList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox skolskaGodinaCmb;
        private System.Windows.Forms.Button predmetiAddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button skolskaGodinaAddBtn;
    }
}