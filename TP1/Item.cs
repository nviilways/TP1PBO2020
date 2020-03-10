using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Item
    {
        /* Get dan Set untuk class Barang */
        public string nama { get; set; } // Nama barang
        public int harga { get; set; } // Harga barang
        public string tipe { get; set; } // Tipe Barang

        public Item(string nama, int harga, string tipe)
        {
            this.nama = nama;
            this.harga = harga;
            this.tipe = tipe;
        }

        public Item() // Konstruktor
        {

        }
    }
}
