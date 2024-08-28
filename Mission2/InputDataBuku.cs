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
    public partial class InputDataBuku : Form
    {
        private List<Buku1> daftarBuku;

        public InputDataBuku(List<Buku1> buku)
        {
            InitializeComponent();
            this.daftarBuku = buku;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textJudul.Text) ||
                string.IsNullOrWhiteSpace(textPenulis.Text) ||
                string.IsNullOrWhiteSpace(textPenerbit.Text) ||
                string.IsNullOrWhiteSpace(textTahunTerbit.Text)) 
            {
                MessageBox.Show("Semua field harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textTahunTerbit.Text, out int tahunTerbit)) 
            {
                MessageBox.Show("Tahun terbit harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Buku1 bukubaru = new Buku1()
            {
                Judul = textJudul.Text,
                Penulis = textPenulis.Text,
                Penerbit = textPenerbit.Text,
                TahunTerbit = tahunTerbit
            };

            daftarBuku.Add(bukubaru);

            textJudul.Clear();
            textPenulis.Clear();
            textPenerbit.Clear();
            textTahunTerbit.Clear();

            MessageBox.Show("Data buku berhasil disimpan", "Informasi", MessageBoxButtons.OK); 
        }
        private void InputDataBuku_Load(object sender, EventArgs e)
        {

        }
    }
    public class Buku1
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public int TahunTerbit { get; set; }
    }
}
