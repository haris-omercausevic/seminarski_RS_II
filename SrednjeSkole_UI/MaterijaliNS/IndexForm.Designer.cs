namespace SrednjeSkole_UI.MaterijaliNS
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
            this.materijaliGrid = new System.Windows.Forms.DataGridView();
            this.Materijalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviMaterijalBtn = new System.Windows.Forms.Button();
            this.predajeCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadMaterijalBtn = new System.Windows.Forms.Button();
            this.izbrisiMaterijalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materijaliGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materijaliGrid
            // 
            this.materijaliGrid.AllowUserToAddRows = false;
            this.materijaliGrid.AllowUserToDeleteRows = false;
            this.materijaliGrid.AllowUserToOrderColumns = true;
            this.materijaliGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materijaliGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materijaliGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materijalid,
            this.Naziv,
            this.Datum,
            this.nastavnik,
            this.Rating,
            this.BrojOcjena});
            this.materijaliGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materijaliGrid.Location = new System.Drawing.Point(0, 70);
            this.materijaliGrid.MultiSelect = false;
            this.materijaliGrid.Name = "materijaliGrid";
            this.materijaliGrid.ReadOnly = true;
            this.materijaliGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materijaliGrid.Size = new System.Drawing.Size(800, 380);
            this.materijaliGrid.TabIndex = 24;
            // 
            // Materijalid
            // 
            this.Materijalid.DataPropertyName = "MaterijalId";
            this.Materijalid.HeaderText = "Id";
            this.Materijalid.Name = "Materijalid";
            this.Materijalid.ReadOnly = true;
            this.Materijalid.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // nastavnik
            // 
            this.nastavnik.DataPropertyName = "nastavnik";
            this.nastavnik.HeaderText = "Nastavnik";
            this.nastavnik.Name = "nastavnik";
            this.nastavnik.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // BrojOcjena
            // 
            this.BrojOcjena.DataPropertyName = "BrojOcjena";
            this.BrojOcjena.HeaderText = "Broj ocjena";
            this.BrojOcjena.Name = "BrojOcjena";
            this.BrojOcjena.ReadOnly = true;
            // 
            // noviMaterijalBtn
            // 
            this.noviMaterijalBtn.Location = new System.Drawing.Point(321, 19);
            this.noviMaterijalBtn.Name = "noviMaterijalBtn";
            this.noviMaterijalBtn.Size = new System.Drawing.Size(96, 23);
            this.noviMaterijalBtn.TabIndex = 28;
            this.noviMaterijalBtn.Text = "Novi materijal";
            this.noviMaterijalBtn.UseVisualStyleBackColor = true;
            this.noviMaterijalBtn.Click += new System.EventHandler(this.noviMaterijalBtn_Click);
            // 
            // predajeCmb
            // 
            this.predajeCmb.FormattingEnabled = true;
            this.predajeCmb.Location = new System.Drawing.Point(102, 21);
            this.predajeCmb.Name = "predajeCmb";
            this.predajeCmb.Size = new System.Drawing.Size(121, 21);
            this.predajeCmb.TabIndex = 29;
            this.predajeCmb.SelectionChangeCommitted += new System.EventHandler(this.predmetiCmb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Predmet:";
            // 
            // downloadMaterijalBtn
            // 
            this.downloadMaterijalBtn.Location = new System.Drawing.Point(500, 19);
            this.downloadMaterijalBtn.Name = "downloadMaterijalBtn";
            this.downloadMaterijalBtn.Size = new System.Drawing.Size(96, 23);
            this.downloadMaterijalBtn.TabIndex = 28;
            this.downloadMaterijalBtn.Text = "Download";
            this.downloadMaterijalBtn.UseVisualStyleBackColor = true;
            this.downloadMaterijalBtn.Click += new System.EventHandler(this.downloadMaterijalBtn_Click);
            // 
            // izbrisiMaterijalBtn
            // 
            this.izbrisiMaterijalBtn.Location = new System.Drawing.Point(646, 19);
            this.izbrisiMaterijalBtn.Name = "izbrisiMaterijalBtn";
            this.izbrisiMaterijalBtn.Size = new System.Drawing.Size(96, 23);
            this.izbrisiMaterijalBtn.TabIndex = 28;
            this.izbrisiMaterijalBtn.Text = "Izbrisi";
            this.izbrisiMaterijalBtn.UseVisualStyleBackColor = true;
            this.izbrisiMaterijalBtn.Click += new System.EventHandler(this.izbrisiMaterijalBtn_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.predajeCmb);
            this.Controls.Add(this.izbrisiMaterijalBtn);
            this.Controls.Add(this.downloadMaterijalBtn);
            this.Controls.Add(this.noviMaterijalBtn);
            this.Controls.Add(this.materijaliGrid);
            this.Name = "IndexForm";
            this.Text = "Pregled materijala";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materijaliGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView materijaliGrid;
        private System.Windows.Forms.Button noviMaterijalBtn;
        private System.Windows.Forms.ComboBox predajeCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button downloadMaterijalBtn;
        private System.Windows.Forms.Button izbrisiMaterijalBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materijalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOcjena;
    }
}