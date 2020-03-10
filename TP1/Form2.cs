using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form2 : Form
    {
        Form parent; // Parent form
        Item[] item = new Item[5]; // Instansiasi array of object
        public Form2(Form parentForm)
        {
            InitializeComponent();
            parent = parentForm; // Pointer parent form atau login form
        }

        private void Btn_Logout_Click(object sender, EventArgs e) // Logout
        {
            this.Close(); // Menutup form menu
            parent.Show(); // Membuka form login
        }

        private void Btn_Cart_Click(object sender, EventArgs e)
        {
            /* Menghapus isi flowLayoutPanel1 */
            List<Control> listControls = new List<Control>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            Form2_Load(this, null); // Load ulang form menu
        }

        private void Form2_Load(object sender, EventArgs e) // Inisialisasi form menu
        {
            int i; // Iterator
            for(i = 0; i < 5; i++)
            {
                item[i] = new Item(); // Instansiasi tiap object pada array of object
            }

            /* Edit tampilan menu */
            Cb_Harga.Visible = true; // ComboBox Harga ditampilkan
            Cb_Jenis.Visible = true; // ComboBox Jenis ditampilkan
            Btn_Cari.Visible = true; // Button Cari ditampilkan
            L_Barang.Text = "Semua Barang:";

            // List of items
            item[0].nama = "Baju Mahal";
            item[0].harga = 500000;
            item[0].tipe = "Baju";
            item[1].nama = "Baju Biasa";
            item[1].harga = 250000;
            item[1].tipe = "Baju";
            item[2].nama = "Hp Mewah";
            item[2].harga = 1000000;
            item[2].tipe = "Elektronik";
            item[3].nama = "Hp Biasa";
            item[3].harga = 650000;
            item[3].tipe = "Elektronik";
            item[4].nama = "Pijja";
            item[4].harga = 100000;
            item[4].tipe = "Makanan";

            //for(i = 0; i < 5; i++)
            //{
            //    Label l = addLabel(i);
            //    flowLayoutPanel1.Controls.Add(l);
            //}

            i = 0;
            foreach(var barang in item) // Mengisi flowLayoutPanel1 secara dinamis
            {
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                PictureBox pb = addPicture(barang.nama); // Picture barang
                Label l = addLabel(barang.nama); // Label barang
                Label k = addLabel(Convert.ToString(barang.harga)); // Label harga
                Button bt = addButton(i); // Button beli barang
                flowLayoutPanel1.Controls.Add(pb);
                flowLayoutPanel1.Controls.Add(l);
                flowLayoutPanel1.Controls.Add(k);
                flowLayoutPanel1.Controls.Add(bt);
                i++; // Iterasi
            }

        }

        Label addLabel(string name)
        {
            Label l = new Label(); // Instansiasi label baru
            string nama = name.Replace(" ", ""); // Menghapus spasi
            l.Name = "Item"+nama; // Nama label barang
            //Console.WriteLine(l.Name);
            if(nama[0] >= '1' && nama[0] <= '9') // Kasus memberi label pada uang yang berjenis integer
            {
                l.Text = "Rp." + name;
            }
            else
            {
                l.Text = name;
            }
            l.ForeColor = Color.Black;
            l.Font = new Font("Serif", 12, FontStyle.Regular);
            l.TextAlign = ContentAlignment.BottomCenter;
            l.Margin = new Padding(5);

            return l;
        }

        PictureBox addPicture(string nama)
        {
            PictureBox pb = new PictureBox(); // Instansiasi picture baru
            pb.ImageLocation = "../../assets/"+ nama + ".jpg"; // Lokasi picture
            pb.Size = new Size(90, 90); // size

            return pb;
        }

        Button addButton(int i)
        {
            Button bt = new Button(); // Instansiasi button baru
            bt.Name = "button" + i; // memberi nama button
            bt.Text = "Beli"; // Text button
            bt.Size = new Size(100, 40); // size
            bt.Click += Bt_Click; // Click event

            return bt;
        }

        private void Bt_Click(object sender, EventArgs e) // Click event pada button beli
        {
            /* Menghapus isi flowLayoutPanel1 */
            List<Control> listControls = new List<Control>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            /* Edit tampilan menu */
            Cb_Harga.Visible = false;
            Cb_Jenis.Visible = false;
            Btn_Cari.Visible = false;
            Btn_Kembali.Visible = true; // Button kembali ditampilkan
            L_Barang.Text = "Detail Barang:"; // Mengubah label "Semua Barang"

            string b = (sender as Button).Name; // Mencari nama button yang digunakan
            
            /* Event pada tiap button untuk detail barang */
            if(b == "button0")
            {
                foreach (var barang in item)
                {
                    if(barang.nama == "Baju Mahal")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        PictureBox pb = addPicture(barang.nama);
                        Label l = addLabel(barang.nama);
                        Label k = addLabel(Convert.ToString(barang.harga));
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(l);
                        flowLayoutPanel1.Controls.Add(k);
                    }
                }
            }

            else if(b == "button1")
            {
                foreach (var barang in item)
                {
                    if (barang.nama == "Baju Biasa")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        PictureBox pb = addPicture(barang.nama);
                        Label l = addLabel(barang.nama);
                        Label k = addLabel(Convert.ToString(barang.harga));
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(l);
                        flowLayoutPanel1.Controls.Add(k);
                    }
                }
            }

            else if(b == "button2")
            {
                foreach (var barang in item)
                {
                    if (barang.nama == "Hp Mewah")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        PictureBox pb = addPicture(barang.nama);
                        Label l = addLabel(barang.nama);
                        Label k = addLabel(Convert.ToString(barang.harga));
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(l);
                        flowLayoutPanel1.Controls.Add(k);
                    }
                }
            }

            else if(b == "button3")
            {
                foreach (var barang in item)
                {
                    if (barang.nama == "Hp Biasa")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        PictureBox pb = addPicture(barang.nama);
                        Label l = addLabel(barang.nama);
                        Label k = addLabel(Convert.ToString(barang.harga));
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(l);
                        flowLayoutPanel1.Controls.Add(k);
                    }
                }
            }

            else if(b == "button4")
            {
                foreach (var barang in item)
                {
                    if (barang.nama == "Pijja")
                    {
                        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        PictureBox pb = addPicture(barang.nama);
                        Label l = addLabel(barang.nama);
                        Label k = addLabel(Convert.ToString(barang.harga));
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(l);
                        flowLayoutPanel1.Controls.Add(k);
                    }
                }
            }
        }

        private void Btn_Catalog_Click(object sender, EventArgs e) // Event button catalog
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/"); // Hyperlink ke tokped
        }

        private void Btn_Cari_Click(object sender, EventArgs e)
        {
            /* Menghapus isi flowLayoutPanel1 */
            List<Control> listControls = new List<Control>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            string jenis = Cb_Jenis.Text; // Mengambil jenis yang dipilih
            string harga = Cb_Harga.Text; // Mengambil barang yang dipilih

            int hargaValue; // Menentukan harga range mana yang dipilih
            if(harga[0] == '1') // 100rb
            {
                hargaValue = 1;
            }
            else if(harga[0] == '2') // 200rb
            {
                hargaValue = 2;
            }
            else // 500rb
            {
                hargaValue = 3;
            }

            /* Event ketika button cari di click */
            foreach(var barang in item)
            {
                if(barang.tipe == jenis || jenis == "Jenis Barang...")
                {
                    if(hargaValue == 1 || harga == "Harga...")
                    {
                        if(barang.harga >= 100000 && barang.harga <= 200000)
                        {
                            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox pb = addPicture(barang.nama);
                            Label l = addLabel(barang.nama);
                            Label k = addLabel(Convert.ToString(barang.harga));
                            flowLayoutPanel1.Controls.Add(pb);
                            flowLayoutPanel1.Controls.Add(l);
                            flowLayoutPanel1.Controls.Add(k);

                        }
                    }
                    if(hargaValue == 2 || harga == "Harga...")
                    {
                        if(barang.harga >= 200000 && barang.harga <= 500000)
                        {
                            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox pb = addPicture(barang.nama);
                            Label l = addLabel(barang.nama);
                            Label k = addLabel(Convert.ToString(barang.harga));
                            flowLayoutPanel1.Controls.Add(pb);
                            flowLayoutPanel1.Controls.Add(l);
                            flowLayoutPanel1.Controls.Add(k);

                        }
                    }
                    if(hargaValue == 3 || harga == "Harga...")
                    {
                        if(barang.harga >= 500000 && barang.harga <= 1000000)
                        {
                            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                            PictureBox pb = addPicture(barang.nama);
                            Label l = addLabel(barang.nama);
                            Label k = addLabel(Convert.ToString(barang.harga));
                            flowLayoutPanel1.Controls.Add(pb);
                            flowLayoutPanel1.Controls.Add(l);
                            flowLayoutPanel1.Controls.Add(k);

                        }
                    }
                }
            }

        }

        private void Btn_Kembali_Click(object sender, EventArgs e) // Event Button kembali
        {
            Btn_Kembali.Visible = false; // Menyembunyikan Button kembali
            Btn_Cart_Click(this, null); // Memanggil fungsi yang sama seperti mengclick icon cart
        }
    }
}
