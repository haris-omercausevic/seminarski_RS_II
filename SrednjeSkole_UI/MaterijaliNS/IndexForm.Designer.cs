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
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbrisiBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.noviMaterijalBtn = new System.Windows.Forms.Button();
            this.predmetiCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Predmet,
            this.Datum,
            this.izbrisiBtn});
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
            this.noviMaterijalBtn.Location = new System.Drawing.Point(488, 21);
            this.noviMaterijalBtn.Name = "noviMaterijalBtn";
            this.noviMaterijalBtn.Size = new System.Drawing.Size(96, 23);
            this.noviMaterijalBtn.TabIndex = 28;
            this.noviMaterijalBtn.Text = "Novi materijal";
            this.noviMaterijalBtn.UseVisualStyleBackColor = true;
            this.noviMaterijalBtn.Click += new System.EventHandler(this.noviMaterijalBtn_Click);
            // 
            // predmetiCmb
            // 
            this.predmetiCmb.FormattingEnabled = true;
            this.predmetiCmb.Location = new System.Drawing.Point(102, 21);
            this.predmetiCmb.Name = "predmetiCmb";
            this.predmetiCmb.Size = new System.Drawing.Size(121, 21);
            this.predmetiCmb.TabIndex = 29;
            this.predmetiCmb.SelectionChangeCommitted += new System.EventHandler(this.predmetiCmb_SelectionChangeCommitted);
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
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.predmetiCmb);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Materijalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn izbrisiBtn;
        private System.Windows.Forms.Button noviMaterijalBtn;
        private System.Windows.Forms.ComboBox predmetiCmb;
        private System.Windows.Forms.Label label3;
    }
}