namespace SrednjeSkole_UI.Evidencije
{
    partial class AddPredmet
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
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oznakaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.razredCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(68, 24);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(136, 20);
            this.nazivInput.TabIndex = 1;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // oznakaInput
            // 
            this.oznakaInput.Location = new System.Drawing.Point(68, 50);
            this.oznakaInput.Name = "oznakaInput";
            this.oznakaInput.Size = new System.Drawing.Size(136, 20);
            this.oznakaInput.TabIndex = 2;
            this.oznakaInput.Validating += new System.ComponentModel.CancelEventHandler(this.oznakaInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oznaka:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(175, 113);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 3;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // razredCmb
            // 
            this.razredCmb.FormattingEnabled = true;
            this.razredCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.razredCmb.Location = new System.Drawing.Point(68, 77);
            this.razredCmb.Name = "razredCmb";
            this.razredCmb.Size = new System.Drawing.Size(136, 21);
            this.razredCmb.TabIndex = 4;
            this.razredCmb.Validating += new System.ComponentModel.CancelEventHandler(this.razredCmb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razred:";
            // 
            // AddPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 148);
            this.Controls.Add(this.razredCmb);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oznakaInput);
            this.Controls.Add(this.nazivInput);
            this.Name = "AddPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj predmet";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oznakaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox razredCmb;
        private System.Windows.Forms.Label label3;
    }
}