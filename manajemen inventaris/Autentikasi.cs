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
    public partial class Autentikasi : Form
    {
        
        public Autentikasi()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == manajemen_inventaris.Properties.Settings.Default.pass)
                {
                    masuk();
                }
                else
                {
                    MessageBox.Show("Password Salah!");
                }
            }
        }

        private void masuk()
        {
            Paket paket = new Paket();
            this.Hide();
            paket.ShowDialog();
            this.Close();
        }
    }
}
