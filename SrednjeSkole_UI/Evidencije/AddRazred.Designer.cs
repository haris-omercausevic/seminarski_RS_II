namespace SrednjeSkole_UI.Evidencije
{
    partial class AddRazred
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
            this.label1 = new System.Windows.Forms.Label();
            this.razredInput = new System.Windows.Forms.TextBox();
            this.odjeljenjeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skolskaGodinaCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smjerCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.razrednikCmb = new System.Windows.Forms.ComboBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.skolskaGodinaAddBtn = new System.Windows.Forms.Button();
            this.smjerAddBtn = new System.Windows.Forms.Button();
            this.razrednikAddBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Razred:";
            // 
            // razredInput
            // 
            this.razredInput.Location = new System.Drawing.Point(99, 21);
            this.razredInput.MaxLength = 1;
            this.razredInput.Name = "razredInput";
            this.razredInput.Size = new System.Drawing.Size(136, 20);
            this.razredInput.TabIndex = 7;
            this.razredInput.Validating += new System.ComponentModel.CancelEventHandler(this.razredInput_Validating);
            // 
            // odjeljenjeInput
            // 
            this.odjeljenjeInput.Location = new System.Drawing.Point(99, 50);
            this.odjeljenjeInput.MaxLength = 1;
            this.odjeljenjeInput.Name = "odjeljenjeInput";
            this.odjeljenjeInput.Size = new System.Drawing.Size(136, 20);
            this.odjeljenjeInput.TabIndex = 7;
            this.odjeljenjeInput.Validating += new System.ComponentModel.CancelEventHandler(this.odjeljenjeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Odjeljenje:";
            // 
            // skolskaGodinaCmb
            // 
            this.skolskaGodinaCmb.FormattingEnabled = true;
            this.skolskaGodinaCmb.Location = new System.Drawing.Point(99, 76);
            this.skolskaGodinaCmb.Name = "skolskaGodinaCmb";
            this.skolskaGodinaCmb.Size = new System.Drawing.Size(136, 21);
            this.skolskaGodinaCmb.TabIndex = 11;
            this.skolskaGodinaCmb.Validating += new System.ComponentModel.CancelEventHandler(this.skolskaGodinaCmb_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Školska godina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Smjer:";
            // 
            // smjerCmb
            // 
            this.smjerCmb.FormattingEnabled = true;
            this.smjerCmb.Location = new System.Drawing.Point(99, 103);
            this.smjerCmb.Name = "smjerCmb";
            this.smjerCmb.Size = new System.Drawing.Size(136, 21);
            this.smjerCmb.TabIndex = 11;
            this.smjerCmb.Validating += new System.ComponentModel.CancelEventHandler(this.smjerCmb_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Razrednik:";
            // 
            // razrednikCmb
            // 
            this.razrednikCmb.FormattingEnabled = true;
            this.razrednikCmb.Location = new System.Drawing.Point(99, 130);
            this.razrednikCmb.Name = "razrednikCmb";
            this.razrednikCmb.Size = new System.Drawing.Size(136, 21);
            this.razrednikCmb.TabIndex = 11;
            this.razrednikCmb.Validating += new System.ComponentModel.CancelEventHandler(this.razrednikCmb_Validating);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(194, 181);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 12;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // skolskaGodinaAddBtn
            // 
            this.skolskaGodinaAddBtn.Location = new System.Drawing.Point(241, 76);
            this.skolskaGodinaAddBtn.Name = "skolskaGodinaAddBtn";
            this.skolskaGodinaAddBtn.Size = new System.Drawing.Size(28, 23);
            this.skolskaGodinaAddBtn.TabIndex = 13;
            this.skolskaGodinaAddBtn.Text = "+";
            this.skolskaGodinaAddBtn.UseVisualStyleBackColor = true;
            this.skolskaGodinaAddBtn.Click += new System.EventHandler(this.skolskaGodinaAddBtn_Click);
            // 
            // smjerAddBtn
            // 
            this.smjerAddBtn.Location = new System.Drawing.Point(241, 103);
            this.smjerAddBtn.Name = "smjerAddBtn";
            this.smjerAddBtn.Size = new System.Drawing.Size(28, 23);
            this.smjerAddBtn.TabIndex = 13;
            this.smjerAddBtn.Text = "+";
            this.smjerAddBtn.UseVisualStyleBackColor = true;
            this.smjerAddBtn.Click += new System.EventHandler(this.smjerAddBtn_Click);
            // 
            // razrednikAddBtn
            // 
            this.razrednikAddBtn.Location = new System.Drawing.Point(241, 130);
            this.razrednikAddBtn.Name = "razrednikAddBtn";
            this.razrednikAddBtn.Size = new System.Drawing.Size(28, 23);
            this.razrednikAddBtn.TabIndex = 13;
            this.razrednikAddBtn.Text = "+";
            this.razrednikAddBtn.UseVisualStyleBackColor = true;
            this.razrednikAddBtn.Click += new System.EventHandler(this.razrednikAddBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddRazred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 220);
            this.Controls.Add(this.razrednikAddBtn);
            this.Controls.Add(this.smjerAddBtn);
            this.Controls.Add(this.skolskaGodinaAddBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.razrednikCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smjerCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skolskaGodinaCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odjeljenjeInput);
            this.Controls.Add(this.razredInput);
            this.Name = "AddRazred";
            this.Text = "Dodaj razred";
            this.Load += new System.EventHandler(this.AddRazred_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razredInput;
        private System.Windows.Forms.TextBox odjeljenjeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox skolskaGodinaCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox smjerCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox razrednikCmb;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button skolskaGodinaAddBtn;
        private System.Windows.Forms.Button smjerAddBtn;
        private System.Windows.Forms.Button razrednikAddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}