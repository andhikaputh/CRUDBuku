namespace Mission2
{
    partial class InputDataBuku
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textJudul = new System.Windows.Forms.TextBox();
            this.textPenulis = new System.Windows.Forms.TextBox();
            this.textPenerbit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTahunTerbit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul Buku :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penulis : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penerbit : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textJudul
            // 
            this.textJudul.Location = new System.Drawing.Point(15, 37);
            this.textJudul.Name = "textJudul";
            this.textJudul.Size = new System.Drawing.Size(298, 20);
            this.textJudul.TabIndex = 3;
            // 
            // textPenulis
            // 
            this.textPenulis.Location = new System.Drawing.Point(15, 81);
            this.textPenulis.Name = "textPenulis";
            this.textPenulis.Size = new System.Drawing.Size(298, 20);
            this.textPenulis.TabIndex = 4;
            // 
            // textPenerbit
            // 
            this.textPenerbit.Location = new System.Drawing.Point(15, 128);
            this.textPenerbit.Name = "textPenerbit";
            this.textPenerbit.Size = new System.Drawing.Size(298, 20);
            this.textPenerbit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tahun Terbit :";
            // 
            // textTahunTerbit
            // 
            this.textTahunTerbit.Location = new System.Drawing.Point(15, 178);
            this.textTahunTerbit.Name = "textTahunTerbit";
            this.textTahunTerbit.Size = new System.Drawing.Size(298, 20);
            this.textTahunTerbit.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputDataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTahunTerbit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPenerbit);
            this.Controls.Add(this.textPenulis);
            this.Controls.Add(this.textJudul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputDataBuku";
            this.Text = "InputDataBuku";
            this.Load += new System.EventHandler(this.InputDataBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJudul;
        private System.Windows.Forms.TextBox textPenulis;
        private System.Windows.Forms.TextBox textPenerbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTahunTerbit;
        private System.Windows.Forms.Button button1;
    }
}