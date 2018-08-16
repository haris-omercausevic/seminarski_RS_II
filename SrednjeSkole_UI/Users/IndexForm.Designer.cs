namespace SrednjeSkole_UI.Users
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
            this.label1 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.ulogaCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.traziBtn = new System.Windows.Forms.Button();
            this.noviKorisnikBtn = new System.Windows.Forms.Button();
            this.izmijeniBtn = new System.Windows.Forms.Button();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(53, 22);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(100, 20);
            this.imeInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(212, 22);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(100, 20);
            this.prezimeInput.TabIndex = 2;
            // 
            // ulogaCmb
            // 
            this.ulogaCmb.FormattingEnabled = true;
            this.ulogaCmb.Location = new System.Drawing.Point(362, 22);
            this.ulogaCmb.Name = "ulogaCmb";
            this.ulogaCmb.Size = new System.Drawing.Size(121, 21);
            this.ulogaCmb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uloga:";
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(510, 22);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 4;
            this.traziBtn.Text = "Traži";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // noviKorisnikBtn
            // 
            this.noviKorisnikBtn.Location = new System.Drawing.Point(627, 22);
            this.noviKorisnikBtn.Name = "noviKorisnikBtn";
            this.noviKorisnikBtn.Size = new System.Drawing.Size(96, 23);
            this.noviKorisnikBtn.TabIndex = 5;
            this.noviKorisnikBtn.Text = "Novi korisnik";
            this.noviKorisnikBtn.UseVisualStyleBackColor = true;
            this.noviKorisnikBtn.Click += new System.EventHandler(this.noviKorisnikBtn_Click);
            // 
            // izmijeniBtn
            // 
            this.izmijeniBtn.Location = new System.Drawing.Point(769, 22);
            this.izmijeniBtn.Name = "izmijeniBtn";
            this.izmijeniBtn.Size = new System.Drawing.Size(96, 23);
            this.izmijeniBtn.TabIndex = 6;
            this.izmijeniBtn.Text = "Izmijeni korisnika";
            this.izmijeniBtn.UseVisualStyleBackColor = true;
            this.izmijeniBtn.Click += new System.EventHandler(this.izmijeniBtn_Click);
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AllowUserToAddRows = false;
            this.korisniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.Uloga});
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 97);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.ReadOnly = true;
            this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciGrid.Size = new System.Drawing.Size(914, 364);
            this.korisniciGrid.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.korisniciGrid);
            this.Controls.Add(this.izmijeniBtn);
            this.Controls.Add(this.noviKorisnikBtn);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ulogaCmb);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija korisnika";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.ComboBox ulogaCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button noviKorisnikBtn;
        private System.Windows.Forms.Button izmijeniBtn;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
    }
}