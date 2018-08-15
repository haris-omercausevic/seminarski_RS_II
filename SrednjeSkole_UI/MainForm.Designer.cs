namespace SrednjeSkole_UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uceniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smjeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razrediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.evidencijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.uceniciToolStripMenuItem,
            this.nastavniciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // uceniciToolStripMenuItem
            // 
            this.uceniciToolStripMenuItem.Name = "uceniciToolStripMenuItem";
            this.uceniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uceniciToolStripMenuItem.Text = "Ucenici";
            this.uceniciToolStripMenuItem.Click += new System.EventHandler(this.uceniciToolStripMenuItem_Click);
            // 
            // nastavniciToolStripMenuItem
            // 
            this.nastavniciToolStripMenuItem.Name = "nastavniciToolStripMenuItem";
            this.nastavniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nastavniciToolStripMenuItem.Text = "Nastavnici";
            this.nastavniciToolStripMenuItem.Click += new System.EventHandler(this.nastavniciToolStripMenuItem_Click);
            // 
            // evidencijaToolStripMenuItem
            // 
            this.evidencijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smjeroviToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.razrediToolStripMenuItem});
            this.evidencijaToolStripMenuItem.Name = "evidencijaToolStripMenuItem";
            this.evidencijaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.evidencijaToolStripMenuItem.Text = "Evidencija";
            // 
            // smjeroviToolStripMenuItem
            // 
            this.smjeroviToolStripMenuItem.Name = "smjeroviToolStripMenuItem";
            this.smjeroviToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.smjeroviToolStripMenuItem.Text = "Smjerovi";
            this.smjeroviToolStripMenuItem.Click += new System.EventHandler(this.smjeroviToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // razrediToolStripMenuItem
            // 
            this.razrediToolStripMenuItem.Name = "razrediToolStripMenuItem";
            this.razrediToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.razrediToolStripMenuItem.Text = "Razredi";
            this.razrediToolStripMenuItem.Click += new System.EventHandler(this.razrediToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Srednje škole";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smjeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razrediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uceniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastavniciToolStripMenuItem;
    }
}

