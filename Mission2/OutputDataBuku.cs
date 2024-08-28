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
    public partial class OutputDataBuku : Form
    {
        public OutputDataBuku(List<Buku1> daftarBuku)
        {
            InitializeComponent();
            foreach (var buku in daftarBuku)
            {
                listBoxBuku.Items.Add($"{buku.Judul}- {buku.Penulis} - {buku.Penerbit}-{buku.TahunTerbit}");
            }
        }
    }
}
