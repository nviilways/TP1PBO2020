namespace TP1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Catalog = new System.Windows.Forms.Button();
            this.Btn_Cart = new System.Windows.Forms.Button();
            this.L_Barang = new System.Windows.Forms.Label();
            this.Cb_Jenis = new System.Windows.Forms.ComboBox();
            this.Cb_Harga = new System.Windows.Forms.ComboBox();
            this.Btn_Cari = new System.Windows.Forms.Button();
            this.Lb_NimNama = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Kembali = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 87);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_Logout);
            this.panel2.Controls.Add(this.Btn_Catalog);
            this.panel2.Controls.Add(this.Btn_Cart);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 369);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Logout.ImageIndex = 2;
            this.Btn_Logout.ImageList = this.imageList1;
            this.Btn_Logout.Location = new System.Drawing.Point(3, 276);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(115, 77);
            this.Btn_Logout.TabIndex = 2;
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buy.png");
            this.imageList1.Images.SetKeyName(1, "catalog.png");
            this.imageList1.Images.SetKeyName(2, "Logout.png");
            // 
            // Btn_Catalog
            // 
            this.Btn_Catalog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Catalog.ImageIndex = 1;
            this.Btn_Catalog.ImageList = this.imageList1;
            this.Btn_Catalog.Location = new System.Drawing.Point(3, 89);
            this.Btn_Catalog.Name = "Btn_Catalog";
            this.Btn_Catalog.Size = new System.Drawing.Size(115, 77);
            this.Btn_Catalog.TabIndex = 1;
            this.Btn_Catalog.UseVisualStyleBackColor = false;
            this.Btn_Catalog.Click += new System.EventHandler(this.Btn_Catalog_Click);
            // 
            // Btn_Cart
            // 
            this.Btn_Cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Cart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cart.ImageIndex = 0;
            this.Btn_Cart.ImageList = this.imageList1;
            this.Btn_Cart.Location = new System.Drawing.Point(3, 6);
            this.Btn_Cart.Name = "Btn_Cart";
            this.Btn_Cart.Size = new System.Drawing.Size(115, 77);
            this.Btn_Cart.TabIndex = 0;
            this.Btn_Cart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cart.UseVisualStyleBackColor = false;
            this.Btn_Cart.Click += new System.EventHandler(this.Btn_Cart_Click);
            // 
            // L_Barang
            // 
            this.L_Barang.AutoSize = true;
            this.L_Barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Barang.Location = new System.Drawing.Point(166, 120);
            this.L_Barang.Name = "L_Barang";
            this.L_Barang.Size = new System.Drawing.Size(119, 17);
            this.L_Barang.TabIndex = 2;
            this.L_Barang.Text = "Semua Barang:";
            // 
            // Cb_Jenis
            // 
            this.Cb_Jenis.FormattingEnabled = true;
            this.Cb_Jenis.Items.AddRange(new object[] {
            "Jenis Barang...",
            "Elektronik",
            "Baju",
            "Makanan"});
            this.Cb_Jenis.Location = new System.Drawing.Point(460, 119);
            this.Cb_Jenis.Name = "Cb_Jenis";
            this.Cb_Jenis.Size = new System.Drawing.Size(121, 21);
            this.Cb_Jenis.TabIndex = 3;
            this.Cb_Jenis.Text = "Jenis Barang...";
            // 
            // Cb_Harga
            // 
            this.Cb_Harga.FormattingEnabled = true;
            this.Cb_Harga.Items.AddRange(new object[] {
            "Harga...",
            "100rb-200rb",
            "200rb-500rb",
            "500rb-1jt"});
            this.Cb_Harga.Location = new System.Drawing.Point(587, 119);
            this.Cb_Harga.Name = "Cb_Harga";
            this.Cb_Harga.Size = new System.Drawing.Size(121, 21);
            this.Cb_Harga.TabIndex = 4;
            this.Cb_Harga.Text = "Harga...";
            // 
            // Btn_Cari
            // 
            this.Btn_Cari.Location = new System.Drawing.Point(714, 119);
            this.Btn_Cari.Name = "Btn_Cari";
            this.Btn_Cari.Size = new System.Drawing.Size(50, 23);
            this.Btn_Cari.TabIndex = 5;
            this.Btn_Cari.Text = "Cari";
            this.Btn_Cari.UseVisualStyleBackColor = true;
            this.Btn_Cari.Click += new System.EventHandler(this.Btn_Cari_Click);
            // 
            // Lb_NimNama
            // 
            this.Lb_NimNama.AutoSize = true;
            this.Lb_NimNama.Location = new System.Drawing.Point(639, 425);
            this.Lb_NimNama.Name = "Lb_NimNama";
            this.Lb_NimNama.Size = new System.Drawing.Size(149, 13);
            this.Lb_NimNama.TabIndex = 6;
            this.Lb_NimNama.Text = "1804814  - Adithya Kurniawan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(595, 248);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Btn_Kembali
            // 
            this.Btn_Kembali.Location = new System.Drawing.Point(689, 148);
            this.Btn_Kembali.Name = "Btn_Kembali";
            this.Btn_Kembali.Size = new System.Drawing.Size(75, 23);
            this.Btn_Kembali.TabIndex = 8;
            this.Btn_Kembali.Text = "Kembali";
            this.Btn_Kembali.UseVisualStyleBackColor = true;
            this.Btn_Kembali.Visible = false;
            this.Btn_Kembali.Click += new System.EventHandler(this.Btn_Kembali_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Kembali);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Lb_NimNama);
            this.Controls.Add(this.Btn_Cari);
            this.Controls.Add(this.Cb_Harga);
            this.Controls.Add(this.Cb_Jenis);
            this.Controls.Add(this.L_Barang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cart;
        private System.Windows.Forms.Button Btn_Catalog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Label L_Barang;
        private System.Windows.Forms.ComboBox Cb_Jenis;
        private System.Windows.Forms.ComboBox Cb_Harga;
        private System.Windows.Forms.Button Btn_Cari;
        private System.Windows.Forms.Label Lb_NimNama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Kembali;
    }
}