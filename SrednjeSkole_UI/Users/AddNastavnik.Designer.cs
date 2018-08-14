namespace SrednjeSkole_UI.Users
{
    partial class AddNastavnik
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
            this.datumRodjenjaInput = new System.Windows.Forms.DateTimePicker();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.jmbgInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datumRodjenjaInput
            // 
            this.datumRodjenjaInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumRodjenjaInput.Location = new System.Drawing.Point(99, 174);
            this.datumRodjenjaInput.Name = "datumRodjenjaInput";
            this.datumRodjenjaInput.Size = new System.Drawing.Size(197, 20);
            this.datumRodjenjaInput.TabIndex = 22;
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(99, 122);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(197, 20);
            this.telefonInput.TabIndex = 20;
            // 
            // jmbgInput
            // 
            this.jmbgInput.Location = new System.Drawing.Point(98, 148);
            this.jmbgInput.MaxLength = 13;
            this.jmbgInput.Name = "jmbgInput";
            this.jmbgInput.Size = new System.Drawing.Size(197, 20);
            this.jmbgInput.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Datum rođenja:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(99, 93);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(197, 20);
            this.emailInput.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(98, 246);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(197, 20);
            this.lozinkaInput.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(98, 220);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(197, 20);
            this.korisnickoImeInput.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(99, 67);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(197, 20);
            this.prezimeInput.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(99, 41);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(197, 20);
            this.imeInput.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(343, 392);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 30;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            // 
            // AddNastavnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.datumRodjenjaInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.jmbgInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.Name = "AddNastavnik";
            this.Text = "AddNastavnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumRodjenjaInput;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox jmbgInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
    }
}