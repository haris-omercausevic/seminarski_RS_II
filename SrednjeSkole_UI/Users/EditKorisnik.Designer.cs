namespace SrednjeSkole_UI.Users
{
    partial class EditKorisnik
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
            this.datumRodjenjaInput = new System.Windows.Forms.DateTimePicker();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.jmbgInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datumRodjenjaInput
            // 
            this.datumRodjenjaInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumRodjenjaInput.Location = new System.Drawing.Point(102, 164);
            this.datumRodjenjaInput.Name = "datumRodjenjaInput";
            this.datumRodjenjaInput.Size = new System.Drawing.Size(200, 20);
            this.datumRodjenjaInput.TabIndex = 25;
            this.datumRodjenjaInput.Validating += new System.ComponentModel.CancelEventHandler(this.datumRodjenjaInput_Validating);
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(101, 265);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(120, 94);
            this.ulogeList.TabIndex = 28;
            this.ulogeList.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeList_Validating);
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.Location = new System.Drawing.Point(224, 385);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBtn.TabIndex = 29;
            this.sacuvajBtn.Text = "Sačuvaj";
            this.sacuvajBtn.UseVisualStyleBackColor = true;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(102, 112);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(197, 20);
            this.telefonInput.TabIndex = 23;
            // 
            // jmbgInput
            // 
            this.jmbgInput.Location = new System.Drawing.Point(101, 138);
            this.jmbgInput.MaxLength = 13;
            this.jmbgInput.Name = "jmbgInput";
            this.jmbgInput.Size = new System.Drawing.Size(197, 20);
            this.jmbgInput.TabIndex = 24;
            this.jmbgInput.Validating += new System.ComponentModel.CancelEventHandler(this.jmbgInput_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Datum rođenja:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(102, 83);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(197, 20);
            this.emailInput.TabIndex = 22;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Uloge:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(101, 236);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(197, 20);
            this.lozinkaInput.TabIndex = 27;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(101, 210);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(197, 20);
            this.korisnickoImeInput.TabIndex = 26;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(102, 57);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(197, 20);
            this.prezimeInput.TabIndex = 21;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(102, 31);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(197, 20);
            this.imeInput.TabIndex = 20;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 421);
            this.Controls.Add(this.datumRodjenjaInput);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.jmbgInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.Name = "EditKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uredi korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumRodjenjaInput;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox jmbgInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}