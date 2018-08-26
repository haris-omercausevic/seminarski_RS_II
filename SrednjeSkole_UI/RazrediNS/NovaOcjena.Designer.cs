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
            this.uceniciRazrediGrid = new System.Windows.Forms.DataGridView();
            this.UcenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolskaGodinaCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opisInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciRazrediGrid)).BeginInit();
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
            this.uceniciRazrediGrid.Location = new System.Drawing.Point(25, 39);
            this.uceniciRazrediGrid.Name = "uceniciRazrediGrid";
            this.uceniciRazrediGrid.ReadOnly = true;
            this.uceniciRazrediGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uceniciRazrediGrid.Size = new System.Drawing.Size(308, 360);
            this.uceniciRazrediGrid.TabIndex = 9;
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
            // skolskaGodinaCmb
            // 
            this.skolskaGodinaCmb.FormattingEnabled = true;
            this.skolskaGodinaCmb.Location = new System.Drawing.Point(442, 82);
            this.skolskaGodinaCmb.Name = "skolskaGodinaCmb";
            this.skolskaGodinaCmb.Size = new System.Drawing.Size(163, 21);
            this.skolskaGodinaCmb.TabIndex = 15;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(442, 161);
            this.opisInput.Multiline = true;
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(136, 71);
            this.opisInput.TabIndex = 10;
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(442, 120);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(136, 20);
            this.nazivInput.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ocijeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NovaOcjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.skolskaGodinaCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.uceniciRazrediGrid);
            this.Controls.Add(this.label1);
            this.Name = "NovaOcjena";
            this.Text = "Nova ocjena";
            ((System.ComponentModel.ISupportInitialize)(this.uceniciRazrediGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uceniciRazrediGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcenikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucenik;
        private System.Windows.Forms.ComboBox skolskaGodinaCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opisInput;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}