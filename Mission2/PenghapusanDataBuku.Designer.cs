namespace Mission2
{
    partial class PenghapusanDataBuku
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
            this.textBoxBuku = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Judul/Penerbit yang ingin dihapus :";
            // 
            // textBoxBuku
            // 
            this.textBoxBuku.Location = new System.Drawing.Point(102, 64);
            this.textBoxBuku.Name = "textBoxBuku";
            this.textBoxBuku.Size = new System.Drawing.Size(282, 20);
            this.textBoxBuku.TabIndex = 1;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(212, 99);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 2;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.Location = new System.Drawing.Point(30, 154);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.Size = new System.Drawing.Size(395, 173);
            this.listBoxBuku.TabIndex = 3;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(212, 347);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 4;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // PenghapusanDataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.listBoxBuku);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxBuku);
            this.Controls.Add(this.label1);
            this.Name = "PenghapusanDataBuku";
            this.Text = "PenghapusanDataBuku";
            this.Load += new System.EventHandler(this.PenghapusanDataBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuku;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.ListBox listBoxBuku;
        private System.Windows.Forms.Button buttonHapus;
    }
}