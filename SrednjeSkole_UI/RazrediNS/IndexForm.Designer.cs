namespace SrednjeSkole_UI.RazrediNS
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
            this.RazredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkolskaGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razrednik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smjer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaljiBtn = new System.Windows.Forms.Button();
            this.traziBtn = new System.Windows.Forms.Button();
            this.oznakaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noviRazredBtn = new System.Windows.Forms.Button();
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
            this.RazredId,
            this.Oznaka,
            this.SkolskaGodina,
            this.Razrednik,
            this.Smjer});
            this.razrediGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.razrediGrid.Location = new System.Drawing.Point(0, 70);
            this.razrediGrid.MultiSelect = false;
            this.razrediGrid.Name = "razrediGrid";
            this.razrediGrid.ReadOnly = true;
            this.razrediGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.razrediGrid.Size = new System.Drawing.Size(800, 380);
            this.razrediGrid.TabIndex = 23;
            // 
            // RazredId
            // 
            this.RazredId.DataPropertyName = "RazredId";
            this.RazredId.HeaderText = "Id";
            this.RazredId.Name = "RazredId";
            this.RazredId.ReadOnly = true;
            this.RazredId.Visible = false;
            // 
            // Oznaka
            // 
            this.Oznaka.DataPropertyName = "Oznaka";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            // 
            // SkolskaGodina
            // 
            this.SkolskaGodina.DataPropertyName = "SkolskaGodina";
            this.SkolskaGodina.HeaderText = "Školska godina";
            this.SkolskaGodina.Name = "SkolskaGodina";
            this.SkolskaGodina.ReadOnly = true;
            // 
            // Razrednik
            // 
            this.Razrednik.DataPropertyName = "Razrednik";
            this.Razrednik.HeaderText = "Razrednik";
            this.Razrednik.Name = "Razrednik";
            this.Razrednik.ReadOnly = true;
            // 
            // Smjer
            // 
            this.Smjer.DataPropertyName = "Smjer";
            this.Smjer.HeaderText = "Smjer";
            this.Smjer.Name = "Smjer";
            this.Smjer.ReadOnly = true;
            this.Smjer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // detaljiBtn
            // 
            this.detaljiBtn.BackColor = System.Drawing.SystemColors.Control;
            this.detaljiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.detaljiBtn.ForeColor = System.Drawing.Color.Black;
            this.detaljiBtn.Location = new System.Drawing.Point(562, 12);
            this.detaljiBtn.Name = "detaljiBtn";
            this.detaljiBtn.Size = new System.Drawing.Size(174, 43);
            this.detaljiBtn.TabIndex = 22;
            this.detaljiBtn.Text = "Detalji";
            this.detaljiBtn.UseVisualStyleBackColor = false;
            this.detaljiBtn.Click += new System.EventHandler(this.detaljiBtn_Click);
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(253, 23);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 26;
            this.traziBtn.Text = "Traži";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // oznakaInput
            // 
            this.oznakaInput.Location = new System.Drawing.Point(81, 25);
            this.oznakaInput.Name = "oznakaInput";
            this.oznakaInput.Size = new System.Drawing.Size(146, 20);
            this.oznakaInput.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Oznaka:";
            // 
            // noviRazredBtn
            // 
            this.noviRazredBtn.Location = new System.Drawing.Point(388, 23);
            this.noviRazredBtn.Name = "noviRazredBtn";
            this.noviRazredBtn.Size = new System.Drawing.Size(96, 23);
            this.noviRazredBtn.TabIndex = 27;
            this.noviRazredBtn.Text = "Novi razred";
            this.noviRazredBtn.UseVisualStyleBackColor = true;
            this.noviRazredBtn.Click += new System.EventHandler(this.noviRazredBtn_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noviRazredBtn);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.oznakaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razrediGrid);
            this.Controls.Add(this.detaljiBtn);
            this.Name = "IndexForm";
            this.Text = "Pregled razreda";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razrediGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView razrediGrid;
        private System.Windows.Forms.Button detaljiBtn;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.TextBox oznakaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button noviRazredBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazredId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkolskaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razrednik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smjer;
    }
}