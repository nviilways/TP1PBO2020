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
    public partial class Form1 : Form
    {
        Login user = new Login(); // Instansiasi login
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.username = Convert.ToString(Tb_User.Text); // Mengambil value textbox
            user.password = Convert.ToString(Tb_Pass.Text); // Mengambil value textbox

            if(user.password == "pbo123") // password yang diterima
            {
                Form2 menu = new Form2(this); // Instansiasi form menu
                this.Hide(); // Menyembunyikan form login
                Tb_Pass.Text = "";
                Tb_User.Text = "";
                menu.Show(); // Menampilkan form menu
            }
            else // Jika salah password
            {
                string message = "Password salah !";
                string title = "Close Window";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
