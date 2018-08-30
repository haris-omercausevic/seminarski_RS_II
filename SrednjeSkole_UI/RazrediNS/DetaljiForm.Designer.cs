namespace SrednjeSkole_UI.RazrediNS
{
    partial class DetaljiForm
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
            this.uceniciRazrediGrid = new System.Windows.Forms.DataGridView();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocijeniBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciRazrediGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uceniciRazrediGrid
            // 
            this.uceniciRazrediGrid.AllowUserToAddRows = false;
            this.uceniciRazrediGrid.AllowUserToDeleteRows = false;
            this.uceniciRazrediGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uceniciRazrediGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uceniciRazrediGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcenikId,
            this.RedniBroj,
            this.Ucenik});
            this.uceniciRazrediGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uceniciRazrediGrid.Location = new System.Drawing.Point(0, 70);
            this.uceniciRazrediGrid.Name = "uceniciRazrediGrid";
            this.uceniciRazrediGrid.ReadOnly = true;
            this.uceniciRazrediGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uceniciRazrediGrid.Size = new System.Drawing.Size(800, 380);
            this.uceniciRazrediGrid.TabIndex = 8;
            // 
            // UcenikId
            // 
            this.UcenikId.DataPropertyName = "UcenikId";
            this.UcenikId.HeaderText = "UcenikId";
            this.UcenikId.Name = "UcenikId";
            this.UcenikId.ReadOnly = true;
            this.UcenikId.Visible = false;
            // 
            // RedniBroj
            // 
            this.RedniBroj.DataPropertyName = "RedniBroj";
            this.RedniBroj.FillWeight = 101.5228F;
            this.RedniBroj.HeaderText = "Broj u dnevniku";
            this.RedniBroj.MaxInputLength = 2;
            this.RedniBroj.Name = "RedniBroj";
            this.RedniBroj.ReadOnly = true;
            // 
            // Ucenik
            // 
            this.Ucenik.DataPropertyName = "Ucenik";
            this.Ucenik.FillWeight = 98.47716F;
            this.Ucenik.HeaderText = "Ucenik";
            this.Ucenik.Name = "Ucenik";
            this.Ucenik.ReadOnly = true;
            // 
            // ocijeniBtn
            // 
            this.ocijeniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ocijeniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ocijeniBtn.ForeColor = System.Drawing.Color.Black;
            this.ocijeniBtn.Location = new System.Drawing.Point(554, 12);
            this.ocijeniBtn.Name = "ocijeniBtn";
            this.ocijeniBtn.Size = new System.Drawing.Size(174, 43);
            this.ocijeniBtn.TabIndex = 23;
            this.ocijeniBtn.Text = "Ocijeni";
            this.ocijeniBtn.UseVisualStyleBackColor = false;
            this.ocijeniBtn.Click += new System.EventHandler(this.ocijeniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Označite učenike";
            // 
            // DetaljiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ocijeniBtn);
            this.Controls.Add(this.uceniciRazrediGrid);
            this.Name = "DetaljiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.uceniciRazrediGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uceniciRazrediGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucenik;
        private System.Windows.Forms.Button ocijeniBtn;
        private System.Windows.Forms.Label label1;
    }
}