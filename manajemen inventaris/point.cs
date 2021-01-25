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
    public partial class point : Form
    {
        class_variable variable = new class_variable();
        connection_class conn = new connection_class();
        DateTime time = DateTime.Now;
        
        public point()
        {
            InitializeComponent();
            textBox1.Text = variable.Jumlah.ToString();
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            label7.Hide();
            label8.Text = variable.Point.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int point = Convert.ToInt32(textBox2.Text);
                label8.Text = Convert.ToString((variable.Point - Convert.ToInt32(textBox2.Text)));
                textBox3.Text = Convert.ToString((Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox2.Text))
                    - Convert.ToInt32(textBox1.Text));
                if (variable.Point < Convert.ToInt32(textBox3.Text))
                {
                    bayarBtn.Enabled = false;
                    label7.Show();
                }
                else
                {
                    bayarBtn.Enabled = true;
                    label7.Hide();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString((Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox2.Text))
                    - Convert.ToInt32(textBox1.Text));
            }
            catch(Exception ex)
            {

            }
        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(textBox2.Text)) <= variable.Point)
            {
                if (variable.Jumlah - (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text)) <= 0)
                {
                    variable.Penggunaan_Point = Convert.ToInt32(textBox2.Text);
                    variable.Kembalian = Convert.ToInt32(textBox4.Text);
                    variable.Point = variable.Point - variable.Penggunaan_Point;
                    variable.Point = variable.Point + (5 * (Convert.ToInt32(textBox1.Text) - variable.Penggunaan_Point) / 100);

                    string query = "INSERT INTO [pelaporan] VALUES ('" + time + "', '" + variable.Nama + "', '" +
                variable.Jumlah.ToString() + "', '" + variable.Penggunaan_Point.ToString() + "', '" + variable.History + "'); ";
                    conn.connect(Application.StartupPath);
                    conn.sql_execution(query);

                    query = "UPDATE [user] SET point = '" + Convert.ToInt32(variable.Point) + "' WHERE no_hp = '" + variable.noHP.ToString() + "' ";
                    conn.connect(Application.StartupPath);
                    conn.sql_execution(query);
                    conn.con.Close();
                    variable.Metode = "point";
                    variable.Kembalian = Convert.ToInt32(textBox3.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Uang Kurang!");
                }
            }
            else
            {
                MessageBox.Show("Point Kurang!");
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
