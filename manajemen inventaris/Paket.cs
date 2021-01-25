using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manajemen_inventaris
{
    public partial class Paket : Form
    {
        public Paket()
        {
            InitializeComponent();
        }

        private void Paket_Load(object sender, EventArgs e)
        {
            nama_paket1.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket1;
            nama_paket2.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket2;
            nama_paket3.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket3;
            nama_paket4.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket4;
            nama_paket5.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket5;
            nama_paket6.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket6;
            nama_paket7.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket7;
            nama_paket8.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket8;
            nama_paket9.Text = manajemen_inventaris.Properties.Settings.Default.nama_paket9;
            harga_paket1.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket1);
            harga_paket2.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket2);
            harga_paket3.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket3);
            harga_paket4.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket4);
            harga_paket5.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket5);
            harga_paket6.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket6);
            harga_paket7.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket7);
            harga_paket8.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket8);
            harga_paket9.Text = Convert.ToString(manajemen_inventaris.Properties.Settings.Default.harga_paket9);
            deskripsi_paket1.Text = manajemen_inventaris.Properties.Settings.Default.des_paket1;
            deskripsi_paket2.Text = manajemen_inventaris.Properties.Settings.Default.des_paket2;
            deskripsi_paket3.Text = manajemen_inventaris.Properties.Settings.Default.des_paket3;
            deskripsi_paket4.Text = manajemen_inventaris.Properties.Settings.Default.des_paket4;
            deskripsi_paket5.Text = manajemen_inventaris.Properties.Settings.Default.des_paket5;
            deskripsi_paket6.Text = manajemen_inventaris.Properties.Settings.Default.des_paket6;
            deskripsi_paket7.Text = manajemen_inventaris.Properties.Settings.Default.des_paket7;
            deskripsi_paket8.Text = manajemen_inventaris.Properties.Settings.Default.des_paket8;
            deskripsi_paket9.Text = manajemen_inventaris.Properties.Settings.Default.des_paket9;
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            manajemen_inventaris.Properties.Settings.Default.nama_paket1 = nama_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket2 = nama_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket3 = nama_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket4 = nama_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket5 = nama_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket6 = nama_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket7 = nama_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket8 = nama_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket9 = nama_paket9.Text;
            manajemen_inventaris.Properties.Settings.Default.harga_paket1 = Convert.ToInt32(harga_paket1.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket2 = Convert.ToInt32(harga_paket2.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket3 = Convert.ToInt32(harga_paket3.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket4 = Convert.ToInt32(harga_paket4.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket5 = Convert.ToInt32(harga_paket5.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket6 = Convert.ToInt32(harga_paket6.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket7 = Convert.ToInt32(harga_paket7.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket8 = Convert.ToInt32(harga_paket8.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket9 = Convert.ToInt32(harga_paket9.Text);
            manajemen_inventaris.Properties.Settings.Default.des_paket1 = deskripsi_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket2 = deskripsi_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket3 = deskripsi_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket4 = deskripsi_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket5 = deskripsi_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket6 = deskripsi_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket7 = deskripsi_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket8 = deskripsi_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket9 = deskripsi_paket9.Text;

            manajemen_inventaris.Properties.Settings.Default.Save();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            manajemen_inventaris.Properties.Settings.Default.nama_paket1 = nama_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket2 = nama_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket3 = nama_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket4 = nama_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket5 = nama_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket6 = nama_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket7 = nama_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket8 = nama_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket9 = nama_paket9.Text;
            manajemen_inventaris.Properties.Settings.Default.harga_paket1 = Convert.ToInt32(harga_paket1.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket2 = Convert.ToInt32(harga_paket2.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket3 = Convert.ToInt32(harga_paket3.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket4 = Convert.ToInt32(harga_paket4.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket5 = Convert.ToInt32(harga_paket5.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket6 = Convert.ToInt32(harga_paket6.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket7 = Convert.ToInt32(harga_paket7.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket8 = Convert.ToInt32(harga_paket8.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket9 = Convert.ToInt32(harga_paket9.Text);
            manajemen_inventaris.Properties.Settings.Default.des_paket1 = deskripsi_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket2 = deskripsi_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket3 = deskripsi_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket4 = deskripsi_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket5 = deskripsi_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket6 = deskripsi_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket7 = deskripsi_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket8 = deskripsi_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket9 = deskripsi_paket9.Text;

            manajemen_inventaris.Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manajemen_inventaris.Properties.Settings.Default.nama_paket1 = nama_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket2 = nama_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket3 = nama_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket4 = nama_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket5 = nama_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket6 = nama_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket7 = nama_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket8 = nama_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.nama_paket9 = nama_paket9.Text;
            manajemen_inventaris.Properties.Settings.Default.harga_paket1 = Convert.ToInt32(harga_paket1.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket2 = Convert.ToInt32(harga_paket2.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket3 = Convert.ToInt32(harga_paket3.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket4 = Convert.ToInt32(harga_paket4.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket5 = Convert.ToInt32(harga_paket5.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket6 = Convert.ToInt32(harga_paket6.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket7 = Convert.ToInt32(harga_paket7.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket8 = Convert.ToInt32(harga_paket8.Text);
            manajemen_inventaris.Properties.Settings.Default.harga_paket9 = Convert.ToInt32(harga_paket9.Text);
            manajemen_inventaris.Properties.Settings.Default.des_paket1 = deskripsi_paket1.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket2 = deskripsi_paket2.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket3 = deskripsi_paket3.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket4 = deskripsi_paket4.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket5 = deskripsi_paket5.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket6 = deskripsi_paket6.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket7 = deskripsi_paket7.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket8 = deskripsi_paket8.Text;
            manajemen_inventaris.Properties.Settings.Default.des_paket9 = deskripsi_paket9.Text;

            manajemen_inventaris.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
