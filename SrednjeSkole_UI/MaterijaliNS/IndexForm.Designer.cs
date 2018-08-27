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
            this.razrediGrid = new System.Windows.Forms.DataGridView();
            this.Materijalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbrisiBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.noviMaterijalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.razrediGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // razrediGrid
            // 
            this.razrediGrid.AllowUserToAddRows = false;
            this.razrediGrid.AllowUserToDeleteRows = false;
            this.razrediGrid.AllowUserToOrderColumns = true;
            this.razrediGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.razrediGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.razrediGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materijalid,
            this.Naziv,
            this.Predmet,
            this.Datum,
            this.izbrisiBtn});
            this.razrediGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.razrediGrid.Location = new System.Drawing.Point(0, 70);
            this.razrediGrid.MultiSelect = false;
            this.razrediGrid.Name = "razrediGrid";
            this.razrediGrid.ReadOnly = true;
            this.razrediGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.razrediGrid.Size = new System.Drawing.Size(800, 380);
            this.razrediGrid.TabIndex = 24;
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
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.DataPropertyName = "\"Izbrisi\"";
            this.izbrisiBtn.HeaderText = "Akcija";
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.ReadOnly = true;
            this.izbrisiBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.izbrisiBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // noviMaterijalBtn
            // 
            this.noviMaterijalBtn.Location = new System.Drawing.Point(405, 24);
            this.noviMaterijalBtn.Name = "noviMaterijalBtn";
            this.noviMaterijalBtn.Size = new System.Drawing.Size(96, 23);
            this.noviMaterijalBtn.TabIndex = 28;
            this.noviMaterijalBtn.Text = "Novi materijal";
            this.noviMaterijalBtn.UseVisualStyleBackColor = true;
            this.noviMaterijalBtn.Click += new System.EventHandler(this.noviMaterijalBtn_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noviMaterijalBtn);
            this.Controls.Add(this.razrediGrid);
            this.Name = "IndexForm";
            this.Text = "Pregled materijala";
            ((System.ComponentModel.ISupportInitialize)(this.razrediGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView razrediGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materijalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn izbrisiBtn;
        private System.Windows.Forms.Button noviMaterijalBtn;
    }
}