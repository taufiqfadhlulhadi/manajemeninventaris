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
    public partial class pembayaran : Form
    {
        class_variable variable = new class_variable();
        connection_class conn = new connection_class();
        DateTime time = DateTime.Now;
        public pembayaran()
        {
            InitializeComponent();
            textBox1.Text = variable.Jumlah.ToString();
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            label7.Text = variable.Point.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bayar = Convert.ToInt32(textBox2.Text);
                int kembalian;
                kembalian = bayar - Convert.ToInt32(textBox1.Text);
                textBox3.Text = kembalian.ToString();
                variable.Kembalian = kembalian;
            }
            catch(Exception ex)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            point pembayaran_point = new point();
            this.Hide();
            pembayaran_point.ShowDialog();
            if (variable.Metode != "")
            {
                this.Close();
            }
        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            if (variable.Jumlah - Convert.ToInt32(textBox2.Text) <= 0)
            {
                variable.Point = variable.Point + (5 * Convert.ToInt32(textBox1.Text) / 100);
                string query = "INSERT INTO [pelaporan] VALUES ('" + time + "', '" + variable.Nama + "', '" +
        variable.Jumlah + "', '0', '" + variable.History + "'); ";
                conn.connect(Application.StartupPath);
                conn.sql_execution(query);
                query = "UPDATE [user] SET point = '" + Convert.ToInt32(variable.Point) + "' WHERE no_hp = '" + variable.noHP.ToString() + "' ";
                conn.connect(Application.StartupPath);
                conn.sql_execution(query);
                conn.con.Close();
                variable.Metode = "bayar";
                this.Close();
                variable.Bayar = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Uang Kurang!");
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
