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
    public partial class PenghapusanDataBuku : Form
    {
        private List<Buku1> daftarBuku;
        public PenghapusanDataBuku(List<Buku1> buku)
        {
            InitializeComponent();
            this.daftarBuku = buku;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string cari = textBoxBuku.Text.ToLower();
            var hasil = daftarBuku.FindAll(k => k.Judul.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0 ||
            k.Penulis.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0);

            listBoxBuku.Items.Clear();

            if (hasil.Any())
            {
                foreach (var buku in hasil)
                {
                    listBoxBuku.Items.Add($"Judul: {buku.Judul}, Penulis: {buku.Penulis}, Penerbit: {buku.Penerbit}, Tahun Terbit: {buku.TahunTerbit}");
                }
                buttonHapus.Enabled = true;
            }
            else
            {
                listBoxBuku.Items.Add("Buku tidak ditemukan");
                buttonHapus.Enabled = false;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string keyword = textBoxBuku.Text.ToLower();
            daftarBuku.RemoveAll(b => b.Judul.ToLower().Contains(keyword) ||
            b.Penulis.ToLower().Contains(keyword));
            listBoxBuku.Items.Clear();
            listBoxBuku.Items.Add("Buku Berhasil dihapus");
            buttonHapus.Enabled = false;
        }

        private void PenghapusanDataBuku_Load(object sender, EventArgs e)
        {
            buttonHapus.Enabled = false;
        }
    }
}
