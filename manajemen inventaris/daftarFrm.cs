using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace manajemen_inventaris
{
    public partial class daftarFrm : Form
    {
        Form1 login = new Form1();
        connection_class conn = new connection_class();
        public daftarFrm()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void daftar()
        {
            string id = noTxtbox.Text;
            string pass = passTxtbox.Text;

            using (MD5 md5 = MD5.Create())
            {
                string query = "INSERT INTO [user] VALUES ('" + id + "','" + pass + "','0', '0');";
                //MessageBox.Show(query);

                try
                {
                    conn.connect(Application.StartupPath);
                    conn.sql_execution(query);
                    MessageBox.Show("Pendaftaran selesai!", "Pendaftaran", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    label3.Visible = true;
                    label3.Text = "Sudah ada nomor yang sama";
                }
                conn.con.Close();
                this.Close();
            }
        }

        private void daftarBtn_Click(object sender, EventArgs e)
        {
            daftar();
        }
        //static string GetMd5Hash(MD5 md5Hash, string input)
        //{

        //    // Convert the input string to a byte array and compute the hash.
        //    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        //    // Create a new Stringbuilder to collect the bytes
        //    // and create a string.
        //    StringBuilder sBuilder = new StringBuilder();

        //    // Loop through each byte of the hashed data 
        //    // and format each one as a hexadecimal string.
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sBuilder.Append(data[i].ToString("x2"));
        //    }

        //    // Return the hexadecimal string.
        //    return sBuilder.ToString();
        //}

        private void passTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                daftar();
            }
        }

        private void noTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                daftar();
            }
        }
    }
}
