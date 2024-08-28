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
    public partial class PencarianDataBuku : Form
    {
        private List<Buku1> daftarBuku;
        public PencarianDataBuku(List<Buku1> daftarBuku)
        {
            InitializeComponent();
            this.daftarBuku = daftarBuku;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string cari = textBoxCari.Text.ToLower();
            var hasil = daftarBuku.FindAll(k => k.Judul.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0 ||
            k.Penulis.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0);

            listBoxHasil.Items.Clear();

            if (hasil.Any())
            {
                foreach (var buku in hasil)
                {
                    listBoxHasil.Items.Add($"Judul: {buku.Judul}, Penulis: {buku.Penulis}, Penerbit: {buku.Penerbit}, Tahun Terbit: {buku.TahunTerbit}");
                }
            }
            else {
                listBoxHasil.Items.Add("Buku tidak ditemukan");
            }
        }

        private void PencarianDataBuku_Load(object sender, EventArgs e)
        {

        }
    }
}
