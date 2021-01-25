using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace manajemen_inventaris
{
    public partial class Form1 : Form
    {
        connection_class conn = new connection_class();
        class_variable variable = new class_variable();
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public void login()
        {
            string user = userbox.Text;
            variable.noHP = passbox.Text;
            //string pass = passbox.Text;
            bool permit = false;
                //string hash = GetMd5Hash(md5, pass);
                string query = "SELECT nama, point, tipe FROM [user] WHERE no_hp = '" + passbox.Text + "';";
                //MessageBox.Show(query);
                string result = null;

                try
                {
                    conn.connect(Application.StartupPath);
                    conn.sql_reader(query);
                    while (conn.read.Read())
                    {
                        result = conn.read.GetValue(0).ToString();
                        variable.Nama = conn.read.GetValue(0).ToString();
                        variable.Point = Convert.ToInt32((conn.read.GetValue(1)));
                        variable.Permit = Convert.ToInt32((conn.read.GetValue(2)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

                //MessageBox.Show(result);
                if (result != null)
                {
                    permit = true;
                }
                conn.con.Close();

            if (permit)
            {
                menu_utama main = new menu_utama();
                this.Hide();
                main.ShowDialog();
                this.Show();
                userbox.Clear();
                passbox.Clear();
                permit = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            login();
        } 

        private void label4_Click(object sender, EventArgs e)
        {
            daftarFrm daftar = new daftarFrm();
            daftar.ShowDialog();
            this.Show();
        }

        private void passbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void userbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
