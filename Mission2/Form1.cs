using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2
{
    public partial class Form1 : Form
    {
        private List<Buku1> daftarBuku;
        public Form1()
        {
            InitializeComponent();
            daftarBuku = new List<Buku1>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputDataBuku outputDataBuku = new OutputDataBuku(daftarBuku);
            outputDataBuku.Show();
        }

        private void inputDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDataBuku inputdatabuku = new InputDataBuku(daftarBuku);
            inputdatabuku.Show();
        }

        private void pencarianDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencarianDataBuku pencarianDataBuku = new PencarianDataBuku(daftarBuku);
            pencarianDataBuku.Show();
        }

        private void penghapusanDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenghapusanDataBuku penghapusanDataBuku = new PenghapusanDataBuku(daftarBuku);
            penghapusanDataBuku.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
