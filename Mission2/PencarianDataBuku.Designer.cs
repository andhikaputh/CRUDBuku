namespace Mission2
{
    partial class PencarianDataBuku
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
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(12, 50);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(519, 20);
            this.textBoxCari.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukkan Judul/Penulis";
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.Location = new System.Drawing.Point(12, 126);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(519, 121);
            this.listBoxHasil.TabIndex = 2;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(254, 76);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // PencarianDataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.listBoxHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCari);
            this.Name = "PencarianDataBuku";
            this.Text = "PencarianDataBuku";
            this.Load += new System.EventHandler(this.PencarianDataBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHasil;
        private System.Windows.Forms.Button buttonCari;
    }
}