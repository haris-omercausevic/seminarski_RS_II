namespace SrednjeSkole_UI
{
    partial class IzborMenijaUloge
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
            this.adminBtn = new System.Windows.Forms.Button();
            this.nastavnikBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adminBtn.Location = new System.Drawing.Point(81, 82);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(132, 67);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Admin modul";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // nastavnikBtn
            // 
            this.nastavnikBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nastavnikBtn.Location = new System.Drawing.Point(293, 82);
            this.nastavnikBtn.Name = "nastavnikBtn";
            this.nastavnikBtn.Size = new System.Drawing.Size(135, 67);
            this.nastavnikBtn.TabIndex = 0;
            this.nastavnikBtn.Text = "Nastavnik modul";
            this.nastavnikBtn.UseVisualStyleBackColor = true;
            this.nastavnikBtn.Click += new System.EventHandler(this.nastavnikBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(126, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite modul kojem želite pristupiti:";
            // 
            // IzborMenijaUloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nastavnikBtn);
            this.Controls.Add(this.adminBtn);
            this.Name = "IzborMenijaUloge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izaberite modul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button nastavnikBtn;
        private System.Windows.Forms.Label label1;
    }
}