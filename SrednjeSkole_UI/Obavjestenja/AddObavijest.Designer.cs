namespace SrednjeSkole_UI.Obavjestenja
{
    partial class AddObavijest
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
            this.components = new System.ComponentModel.Container();
            this.naslovInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tekstInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.objaviBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // naslovInput
            // 
            this.naslovInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovInput.Location = new System.Drawing.Point(87, 25);
            this.naslovInput.Name = "naslovInput";
            this.naslovInput.Size = new System.Drawing.Size(255, 26);
            this.naslovInput.TabIndex = 0;
            this.naslovInput.Validating += new System.ComponentModel.CancelEventHandler(this.naslovInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov:";
            // 
            // tekstInput
            // 
            this.tekstInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstInput.Location = new System.Drawing.Point(87, 66);
            this.tekstInput.Multiline = true;
            this.tekstInput.Name = "tekstInput";
            this.tekstInput.Size = new System.Drawing.Size(445, 298);
            this.tekstInput.TabIndex = 0;
            this.tekstInput.Validating += new System.ComponentModel.CancelEventHandler(this.tekstInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst:";
            // 
            // objaviBtn
            // 
            this.objaviBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objaviBtn.Location = new System.Drawing.Point(457, 400);
            this.objaviBtn.Name = "objaviBtn";
            this.objaviBtn.Size = new System.Drawing.Size(75, 23);
            this.objaviBtn.TabIndex = 2;
            this.objaviBtn.Text = "Objavi";
            this.objaviBtn.UseVisualStyleBackColor = true;
            this.objaviBtn.Click += new System.EventHandler(this.objaviBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 447);
            this.Controls.Add(this.objaviBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekstInput);
            this.Controls.Add(this.naslovInput);
            this.Name = "AddObavijest";
            this.Text = "AddObavijest";
            this.Load += new System.EventHandler(this.AddObavijest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naslovInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tekstInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button objaviBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}