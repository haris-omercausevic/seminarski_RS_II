namespace SrednjeSkole_UI.Users
{
    partial class AddUcenik
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
            this.dodajBtn = new System.Windows.Forms.Button();
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
            this.label10 = new System.Windows.Forms.Label();
            this.imeRoditeljaInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.smjerCmb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.razredCmb = new System.Windows.Forms.ComboBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nazivSkoleInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // datumRodjenjaInput
            // 
            this.datumRodjenjaInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumRodjenjaInput.Location = new System.Drawing.Point(131, 165);
            this.datumRodjenjaInput.Name = "datumRodjenjaInput";
            this.datumRodjenjaInput.Size = new System.Drawing.Size(140, 20);
            this.datumRodjenjaInput.TabIndex = 25;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(468, 388);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 29;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(131, 113);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(140, 20);
            this.telefonInput.TabIndex = 23;
            // 
            // jmbgInput
            // 
            this.jmbgInput.Location = new System.Drawing.Point(130, 139);
            this.jmbgInput.MaxLength = 13;
            this.jmbgInput.Name = "jmbgInput";
            this.jmbgInput.Size = new System.Drawing.Size(140, 20);
            this.jmbgInput.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Datum rođenja:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(131, 84);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(140, 20);
            this.emailInput.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(129, 315);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(140, 20);
            this.lozinkaInput.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(129, 289);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(140, 20);
            this.korisnickoImeInput.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(131, 58);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(140, 20);
            this.prezimeInput.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(131, 32);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(140, 20);
            this.imeInput.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ime roditelja:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imeRoditeljaInput
            // 
            this.imeRoditeljaInput.Location = new System.Drawing.Point(130, 191);
            this.imeRoditeljaInput.Name = "imeRoditeljaInput";
            this.imeRoditeljaInput.Size = new System.Drawing.Size(140, 20);
            this.imeRoditeljaInput.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Adresa:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adresaInput
            // 
            this.adresaInput.Location = new System.Drawing.Point(130, 220);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(140, 20);
            this.adresaInput.TabIndex = 20;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(383, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Muško";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(446, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "Žensko";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Spol:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smjerCmb
            // 
            this.smjerCmb.FormattingEnabled = true;
            this.smjerCmb.Location = new System.Drawing.Point(386, 243);
            this.smjerCmb.Name = "smjerCmb";
            this.smjerCmb.Size = new System.Drawing.Size(121, 21);
            this.smjerCmb.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Smjer:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Razred:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // razredCmb
            // 
            this.razredCmb.FormattingEnabled = true;
            this.razredCmb.Location = new System.Drawing.Point(386, 272);
            this.razredCmb.Name = "razredCmb";
            this.razredCmb.Size = new System.Drawing.Size(121, 21);
            this.razredCmb.TabIndex = 31;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(339, 62);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(168, 144);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 32;
            this.imageBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Naziv osnovne škole:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nazivSkoleInput
            // 
            this.nazivSkoleInput.Location = new System.Drawing.Point(130, 248);
            this.nazivSkoleInput.Name = "nazivSkoleInput";
            this.nazivSkoleInput.Size = new System.Drawing.Size(139, 20);
            this.nazivSkoleInput.TabIndex = 20;
            // 
            // AddUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 423);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.razredCmb);
            this.Controls.Add(this.smjerCmb);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.datumRodjenjaInput);
            this.Controls.Add(this.dodajBtn);
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
            this.Controls.Add(this.nazivSkoleInput);
            this.Controls.Add(this.adresaInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.imeRoditeljaInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.Name = "AddUcenik";
            this.Text = "AddUcenik";
            this.Load += new System.EventHandler(this.AddUcenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumRodjenjaInput;
        private System.Windows.Forms.Button dodajBtn;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox imeRoditeljaInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox smjerCmb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox razredCmb;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nazivSkoleInput;
    }
}