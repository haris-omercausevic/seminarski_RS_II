namespace SrednjeSkole_UI.Evidencije
{
    partial class AddSkolskaGodina
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
            this.dodajBtn = new System.Windows.Forms.Button();
            this.skolskaGodinaInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(157, 52);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 0;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            // 
            // skolskaGodinaInput
            // 
            this.skolskaGodinaInput.Location = new System.Drawing.Point(101, 12);
            this.skolskaGodinaInput.Mask = "0000/0000";
            this.skolskaGodinaInput.Name = "skolskaGodinaInput";
            this.skolskaGodinaInput.Size = new System.Drawing.Size(100, 20);
            this.skolskaGodinaInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Školska godina:";
            // 
            // AddSkolskaGodina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skolskaGodinaInput);
            this.Controls.Add(this.dodajBtn);
            this.Name = "AddSkolskaGodina";
            this.Text = "AddSkolskaGodina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.MaskedTextBox skolskaGodinaInput;
        private System.Windows.Forms.Label label1;
    }
}