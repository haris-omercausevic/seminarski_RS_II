namespace SrednjeSkole_UI.ObavijestiNS
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
            this.obavijestiGrid = new System.Windows.Forms.DataGridView();
            this.ObavijestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objavio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmijeniBtn = new System.Windows.Forms.Button();
            this.novaObavijestBtn = new System.Windows.Forms.Button();
            this.traziBtn = new System.Windows.Forms.Button();
            this.naslovInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // obavijestiGrid
            // 
            this.obavijestiGrid.AllowUserToAddRows = false;
            this.obavijestiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obavijestiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obavijestiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestId,
            this.Naslov,
            this.Objavio,
            this.Datum});
            this.obavijestiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.obavijestiGrid.Location = new System.Drawing.Point(0, 69);
            this.obavijestiGrid.Name = "obavijestiGrid";
            this.obavijestiGrid.ReadOnly = true;
            this.obavijestiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obavijestiGrid.Size = new System.Drawing.Size(891, 346);
            this.obavijestiGrid.TabIndex = 17;
            // 
            // ObavijestId
            // 
            this.ObavijestId.DataPropertyName = "ObavijestId";
            this.ObavijestId.HeaderText = "Id";
            this.ObavijestId.Name = "ObavijestId";
            this.ObavijestId.ReadOnly = true;
            this.ObavijestId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Objavio
            // 
            this.Objavio.DataPropertyName = "Objavio";
            this.Objavio.HeaderText = "Objavio";
            this.Objavio.Name = "Objavio";
            this.Objavio.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // izmijeniBtn
            // 
            this.izmijeniBtn.Location = new System.Drawing.Point(597, 20);
            this.izmijeniBtn.Name = "izmijeniBtn";
            this.izmijeniBtn.Size = new System.Drawing.Size(96, 23);
            this.izmijeniBtn.TabIndex = 16;
            this.izmijeniBtn.Text = "Izmijeni obavijest";
            this.izmijeniBtn.UseVisualStyleBackColor = true;
            this.izmijeniBtn.Click += new System.EventHandler(this.izmijeniBtn_Click);
            // 
            // novaObavijestBtn
            // 
            this.novaObavijestBtn.Location = new System.Drawing.Point(405, 19);
            this.novaObavijestBtn.Name = "novaObavijestBtn";
            this.novaObavijestBtn.Size = new System.Drawing.Size(96, 23);
            this.novaObavijestBtn.TabIndex = 15;
            this.novaObavijestBtn.Text = "Nova obavijest";
            this.novaObavijestBtn.UseVisualStyleBackColor = true;
            this.novaObavijestBtn.Click += new System.EventHandler(this.novaObavijestBtn_Click);
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(258, 20);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 14;
            this.traziBtn.Text = "Traži";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // naslovInput
            // 
            this.naslovInput.Location = new System.Drawing.Point(86, 22);
            this.naslovInput.Name = "naslovInput";
            this.naslovInput.Size = new System.Drawing.Size(146, 20);
            this.naslovInput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naslov:";
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Location = new System.Drawing.Point(736, 19);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(96, 23);
            this.izbrisiBtn.TabIndex = 16;
            this.izbrisiBtn.Text = "Izbriši obavijest";
            this.izbrisiBtn.UseVisualStyleBackColor = true;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 415);
            this.Controls.Add(this.obavijestiGrid);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.izmijeniBtn);
            this.Controls.Add(this.novaObavijestBtn);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.naslovInput);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.Text = "Pregled obavijesti";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obavijestiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView obavijestiGrid;
        private System.Windows.Forms.Button izmijeniBtn;
        private System.Windows.Forms.Button novaObavijestBtn;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.TextBox naslovInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objavio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Button izbrisiBtn;
    }
}