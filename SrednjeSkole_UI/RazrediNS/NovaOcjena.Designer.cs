namespace SrednjeSkole_UI.RazrediNS
{
    partial class NovaOcjena
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
            this.oznaceniUceniciGrid = new System.Windows.Forms.DataGridView();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetiCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.napomenaInput = new System.Windows.Forms.TextBox();
            this.ocjenaInput = new System.Windows.Forms.TextBox();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ocijeniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oznaceniUceniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabrani ucenici ce biti ocijenjeni:";
            // 
            // oznaceniUceniciGrid
            // 
            this.oznaceniUceniciGrid.AllowUserToAddRows = false;
            this.oznaceniUceniciGrid.AllowUserToDeleteRows = false;
            this.oznaceniUceniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oznaceniUceniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oznaceniUceniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcenikId,
            this.RedniBroj,
            this.Ucenik});
            this.oznaceniUceniciGrid.Location = new System.Drawing.Point(25, 39);
            this.oznaceniUceniciGrid.MultiSelect = false;
            this.oznaceniUceniciGrid.Name = "oznaceniUceniciGrid";
            this.oznaceniUceniciGrid.ReadOnly = true;
            this.oznaceniUceniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oznaceniUceniciGrid.Size = new System.Drawing.Size(308, 360);
            this.oznaceniUceniciGrid.TabIndex = 9;
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
            // predmetiCmb
            // 
            this.predmetiCmb.FormattingEnabled = true;
            this.predmetiCmb.Location = new System.Drawing.Point(442, 82);
            this.predmetiCmb.Name = "predmetiCmb";
            this.predmetiCmb.Size = new System.Drawing.Size(163, 21);
            this.predmetiCmb.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Predmet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Napomena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ocjena:";
            // 
            // napomenaInput
            // 
            this.napomenaInput.Location = new System.Drawing.Point(442, 161);
            this.napomenaInput.Multiline = true;
            this.napomenaInput.Name = "napomenaInput";
            this.napomenaInput.Size = new System.Drawing.Size(136, 71);
            this.napomenaInput.TabIndex = 10;
            // 
            // ocjenaInput
            // 
            this.ocjenaInput.Location = new System.Drawing.Point(442, 120);
            this.ocjenaInput.Name = "ocjenaInput";
            this.ocjenaInput.Size = new System.Drawing.Size(136, 20);
            this.ocjenaInput.TabIndex = 11;
            // 
            // datumPicker
            // 
            this.datumPicker.Location = new System.Drawing.Point(442, 45);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(200, 20);
            this.datumPicker.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum:";
            // 
            // ocijeniBtn
            // 
            this.ocijeniBtn.Location = new System.Drawing.Point(567, 352);
            this.ocijeniBtn.Name = "ocijeniBtn";
            this.ocijeniBtn.Size = new System.Drawing.Size(75, 23);
            this.ocijeniBtn.TabIndex = 17;
            this.ocijeniBtn.Text = "Ocijeni";
            this.ocijeniBtn.UseVisualStyleBackColor = true;
            this.ocijeniBtn.Click += new System.EventHandler(this.ocijeniBtn_Click);
            // 
            // NovaOcjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 411);
            this.Controls.Add(this.ocijeniBtn);
            this.Controls.Add(this.datumPicker);
            this.Controls.Add(this.predmetiCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.napomenaInput);
            this.Controls.Add(this.ocjenaInput);
            this.Controls.Add(this.oznaceniUceniciGrid);
            this.Controls.Add(this.label1);
            this.Name = "NovaOcjena";
            this.Text = "Nova ocjena";
            this.Load += new System.EventHandler(this.NovaOcjena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oznaceniUceniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView oznaceniUceniciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucenik;
        private System.Windows.Forms.ComboBox predmetiCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox napomenaInput;
        private System.Windows.Forms.TextBox ocjenaInput;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ocijeniBtn;
    }
}