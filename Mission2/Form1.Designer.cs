namespace Mission2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencarianDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penghapusanDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataBukuToolStripMenuItem,
            this.outputDataBukuToolStripMenuItem,
            this.pencarianDataBukuToolStripMenuItem,
            this.penghapusanDataBukuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataBukuToolStripMenuItem
            // 
            this.inputDataBukuToolStripMenuItem.Name = "inputDataBukuToolStripMenuItem";
            this.inputDataBukuToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.inputDataBukuToolStripMenuItem.Text = "Input Data Buku";
            this.inputDataBukuToolStripMenuItem.Click += new System.EventHandler(this.inputDataBukuToolStripMenuItem_Click);
            // 
            // outputDataBukuToolStripMenuItem
            // 
            this.outputDataBukuToolStripMenuItem.Name = "outputDataBukuToolStripMenuItem";
            this.outputDataBukuToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.outputDataBukuToolStripMenuItem.Text = "Output Data Buku";
            this.outputDataBukuToolStripMenuItem.Click += new System.EventHandler(this.outputDataBukuToolStripMenuItem_Click);
            // 
            // pencarianDataBukuToolStripMenuItem
            // 
            this.pencarianDataBukuToolStripMenuItem.Name = "pencarianDataBukuToolStripMenuItem";
            this.pencarianDataBukuToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.pencarianDataBukuToolStripMenuItem.Text = "Pencarian Data Buku";
            this.pencarianDataBukuToolStripMenuItem.Click += new System.EventHandler(this.pencarianDataBukuToolStripMenuItem_Click);
            // 
            // penghapusanDataBukuToolStripMenuItem
            // 
            this.penghapusanDataBukuToolStripMenuItem.Name = "penghapusanDataBukuToolStripMenuItem";
            this.penghapusanDataBukuToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.penghapusanDataBukuToolStripMenuItem.Text = "Penghapusan Data Buku";
            this.penghapusanDataBukuToolStripMenuItem.Click += new System.EventHandler(this.penghapusanDataBukuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 111);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pengelolaan Data Buku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencarianDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penghapusanDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

