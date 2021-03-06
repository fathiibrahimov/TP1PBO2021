using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1A
{
    class barang
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public int range { get; set; }
        public string jenis { get; set; }

        public barang(string nama, int harga, string gambar, int range, string jenis)
        {
            this.nama = nama;
            this.harga = harga;
            this.gambar = gambar;
            this.range = range;
            this.jenis = jenis;
        }

        public barang()
        {

        }
    }
}
