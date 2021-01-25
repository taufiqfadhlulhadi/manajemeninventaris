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
    public partial class Main_Menu_V2 : Form
    {
        connection_class conn = new connection_class();
        class_variable variable = new class_variable();
        int fgtCount = 0;
        int fotCount = 0;
        int gttCount = 0;
        int ottCount = 0;
        int matchaCount = 0;
        int clCount = 0;
        int chocolateCount = 0;
        int vanillaCount = 0;
        int taroCount = 0;
        int tiramitsuCount = 0;
        int redCount = 0;
        int fuzzyCount = 0;
        int kopikoCount = 0;
        int kopmilCount = 0;
        int latteCount = 0;
        int jumlah = 0;

        public Main_Menu_V2()
        {
            InitializeComponent();
            //topping1.Enabled = false;
            label17.Text = variable.Nama.ToString();
            label19.Text = variable.Point.ToString();
        }

        private void freshgthaiBtn_Click(object sender, EventArgs e)
        {
            if (topping1.Enabled == false)
            {
                topping1.Enabled = true;
            }
            fgtCount++;
            fgtcountBox.Text = fgtCount.ToString();
        }

        private void fgtIN_Click(object sender, EventArgs e)
        {
            if (fgtcountBox.Text != "")
            {
                string query = "SELECT harga FROM [menu] WHERE minuman = '" + freshgthaiBtn.Text + "';";
                int total = 0;
                int harga = 0;

                try
                {
                    conn.connect(Application.StartupPath);
                    conn.sql_reader(query);
                    //MessageBox.Show(query);
                    while (conn.read.Read())
                    {
                        harga = conn.read.GetInt16(0);
                        //MessageBox.Show(Convert.ToString(harga));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                conn.con.Close();

                total = harga * Convert.ToInt32(fgtcountBox.Text);

                string[] pesanan = { freshgthaiBtn.Text, topping1.Text,
                                   Convert.ToString(harga), Convert.ToString(total) };
                insert_table(pesanan);
                topping1.Enabled = false;
                fgtcountBox.Clear();
                fgtCount = 0;
            }
        }

        private void insert_table(string[] input)
        {
            var listViewItem = new ListViewItem(input);
            listmenu.Items.Add(listViewItem);
        }

        private void fotIn_Click(object sender, EventArgs e)
        {
            if (fotcntBox.Text != "")
            {
                string menu = freshothaiBtn.Text;
                string jumlah = fotcntBox.Text;
                string topping = topping2.Text;
                insert_button(menu, jumlah, topping);
                topping2.Enabled = false;
                fotcntBox.Clear();
                fotCount = 0;
            }
        }

        private void freshothaiBtn_Click(object sender, EventArgs e)
        {
            if (topping2.Enabled == false)
            {
                topping2.Enabled = true;
            }
            fotCount++;
            fotcntBox.Text = fotCount.ToString();
        }

        private void greentthaiBtn_Click(object sender, EventArgs e)
        {
            if (topping3.Enabled == false)
            {
                topping3.Enabled = true;
            }
            gttCount++;
            gttcntBox.Text = gttCount.ToString();
        }

        private void gttIn_Click(object sender, EventArgs e)
        {
            if (gttcntBox.Text != "")
            {
                string menu = greentthaiBtn.Text;
                string jumlah = gttcntBox.Text;
                string topping = topping3.Text;
                insert_button(menu, jumlah, topping);
                topping3.Enabled = false;
                gttcntBox.Clear();
                gttCount = 0;
            }
        }


        private void insert_button(string menu, string jumlah, string topping)
        {
            string query = "SELECT harga FROM [menu] WHERE minuman = '" + menu + "';";
            int total = 0;
            int harga = 0;

            try
            {
                conn.connect(Application.StartupPath);
                conn.sql_reader(query);
                //MessageBox.Show(query);
                while (conn.read.Read())
                {
                    harga = conn.read.GetInt16(0);
                    //MessageBox.Show(Convert.ToString(harga));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            conn.con.Close();

            total = harga * Convert.ToInt32(jumlah);

            string[] pesanan = { menu, topping, Convert.ToString(harga), Convert.ToString(total) };
            insert_table(pesanan);
        }

        private void originaltthaiBtn_Click(object sender, EventArgs e)
        {
            if (topping4.Enabled == false)
            {
                topping4.Enabled = true;
            }
            ottCount++;
            ottcntBox.Text = ottCount.ToString();
        }

        private void ottIn_Click(object sender, EventArgs e)
        {
            if (ottcntBox.Text != "")
            {
                string menu = originaltthaiBtn.Text;
                string jumlah = ottcntBox.Text;
                string topping = topping4.Text;
                insert_button(menu, jumlah, topping);
                topping4.Enabled = false;
                ottcntBox.Clear();
                ottCount = 0;
            }
        }

        private void matchaBtn_Click(object sender, EventArgs e)
        {
            if (topping5.Enabled == false)
            {
                topping5.Enabled = true;
            }
            matchaCount++;
            mcntBox.Text =matchaCount.ToString();
        }

        private void mIn_Click(object sender, EventArgs e)
        {
            if (mcntBox.Text != "")
            {
                string menu = matchaBtn.Text;
                string jumlah = mcntBox.Text;
                string topping = topping5.Text;
                insert_button(menu, jumlah, topping);
                topping5.Enabled = false;
                mcntBox.Clear();
                matchaCount = 0;
            }
        }

        private void charcoallButton_Click(object sender, EventArgs e)
        {
            if (topping6.Enabled == false)
            {
                topping6.Enabled = true;
            }
            clCount++;
            clcntBox.Text = clCount.ToString();
        }

        private void clIn_Click(object sender, EventArgs e)
        {
            if (clcntBox.Text != "")
            {
                string menu = charcoallButton.Text;
                string jumlah = clcntBox.Text;
                string topping = topping6.Text;
                insert_button(menu, jumlah, topping);
                topping6.Enabled = false;
                clcntBox.Clear();
                clCount = 0;
            }
        }

        public void bayarBtn_Click(object sender, EventArgs e)
        {
            bayar(jumlah);
        }
        //insert into Listview(RoomType, RoomNumber, GuestName, EnteredDate)values('"+listView1.Items[i].SubItems[0].Text+"','"+listView1.Items[i].SubItems[1].Text+"','"+listView1.Items[i].SubItems[2].Text+"','"+listView1.Items[i].SubItems[3].Text+"')",_sqlconnection)

        public void bayar(int jumlah)
        {
            for (int i = 0; i < listmenu.Items.Count; i++)
            {
                jumlah += int.Parse(listmenu.Items[i].SubItems[3].Text);
            }
            variable.Jumlah = jumlah;
            pembayaran bayar = new pembayaran();
            //this.Hide();
            bayar.ShowDialog();
            //this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (topping7.Enabled == false)
            {
                topping7.Enabled = true;
            }
            chocolateCount++;
            MilkChocolatebox.Text = chocolateCount.ToString();
        }

        private void MilkChocolateNext_Click(object sender, EventArgs e)
        {
            if (MilkChocolatebox.Text != "")
            {
                string menu = MilkchocolateBtn.Text;
                string jumlah = MilkChocolatebox.Text;
                string topping = topping7.Text;
                insert_button(menu, jumlah, topping);
                topping7.Enabled = false;
                MilkChocolatebox.Clear();
                chocolateCount = 0;
            }
        }

        private void MilkVanillaBtn_Click(object sender, EventArgs e)
        {
            if (topping8.Enabled == false)
            {
                topping8.Enabled = true;
            }
            vanillaCount++;
            MilkVanillabox.Text = vanillaCount.ToString();
        }

        private void MilkVanillaNext_Click(object sender, EventArgs e)
        {
            if (MilkVanillabox.Text != "")
            {
                string menu = MilkVanillaBtn.Text;
                string jumlah = MilkVanillabox.Text;
                string topping = topping8.Text;
                insert_button(menu, jumlah, topping);
                topping8.Enabled = false;
                MilkVanillabox.Clear();
                vanillaCount = 0;
            }
        }

        private void TaroBtn_Click(object sender, EventArgs e)
        {
            if (topping9.Enabled == false)
            {
                topping9.Enabled = true;
            }
            taroCount++;
            Tarobox.Text = taroCount.ToString();
        }

        private void TaroNext_Click(object sender, EventArgs e)
        {
            if (Tarobox.Text != "")
            {
                string menu = TaroBtn.Text;
                string jumlah = Tarobox.Text;
                string topping = topping9.Text;
                insert_button(menu, jumlah, topping);
                topping9.Enabled = false;
                Tarobox.Clear();
                taroCount = 0;
            }
        }

        private void TiramitsuBtn_Click(object sender, EventArgs e)
        {
            if (Topping10.Enabled == false)
            {
                Topping10.Enabled = true;
            }
            tiramitsuCount++;
            Tiramitsubox.Text = tiramitsuCount.ToString();
        }

        private void TiramitsuNext_Click(object sender, EventArgs e)
        {
            if (Tiramitsubox.Text != "")
            {
                string menu = TiramitsuBtn.Text;
                string jumlah = Tiramitsubox.Text;
                string topping = Topping10.Text;
                insert_button(menu, jumlah, topping);
                Topping10.Enabled = false;
                Tiramitsubox.Clear();
                tiramitsuCount = 0;
            }
        }

        private void VelvetBtn_Click(object sender, EventArgs e)
        {
            if (topping11.Enabled == false)
            {
                topping11.Enabled = true;
            }
            redCount++;
            Velvetbox.Text = redCount.ToString();
        }

        private void VelvetNext_Click(object sender, EventArgs e)
        {
            if (Velvetbox.Text != "")
            {
                string menu = VelvetBtn.Text;
                string jumlah = Velvetbox.Text;
                string topping = topping11.Text;
                insert_button(menu, jumlah, topping);
                topping11.Enabled = false;
                Velvetbox.Clear();
                redCount = 0;
            }
        }

        private void FuzzyBtn_Click(object sender, EventArgs e)
        {
            if (topping12.Enabled == false)
            {
                topping12.Enabled = true;
            }
            fuzzyCount++;
            Fuzzybox.Text = fuzzyCount.ToString();
        }

        private void FuzzyNext_Click(object sender, EventArgs e)
        {
            if (Fuzzybox.Text != "")
            {
                string menu = FuzzyBtn.Text;
                string jumlah = Fuzzybox.Text;
                string topping = topping12.Text;
                insert_button(menu, jumlah, topping);
                topping12.Enabled = false;
                Fuzzybox.Clear();
                fuzzyCount = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (topping13.Enabled == false)
            {
                topping13.Enabled = true;
            }
            kopikoCount++;
            kopikoBox.Text = kopikoCount.ToString();
        }

        private void kopikoNext_Click(object sender, EventArgs e)
        {
            if (kopikoBox.Text != "")
            {
                string menu = kopikoBtn.Text;
                string jumlah = kopikoBox.Text;
                string topping = topping13.Text;
                insert_button(menu, jumlah, topping);
                topping13.Enabled = false;
                kopikoBox.Clear();
                kopikoCount = 0;
            }
        }

        private void kopmilBtn_Click(object sender, EventArgs e)
        {
            if (topping14.Enabled == false)
            {
                topping14.Enabled = true;
            }
            kopmilCount++;
            kopmilBox.Text = kopmilCount.ToString();
        }

        private void kopmilNext_Click(object sender, EventArgs e)
        {
            if (kopmilBox.Text != "")
            {
                string menu = kopmilBtn.Text;
                string jumlah = kopmilBox.Text;
                string topping = topping14.Text;
                insert_button(menu, jumlah, topping);
                topping14.Enabled = false;
                kopmilBox.Clear();
                kopmilCount = 0;
            }
        }

        private void latteBtn_Click(object sender, EventArgs e)
        {
            if (topping15.Enabled == false)
            {
                topping15.Enabled = true;
            }
            latteCount++;
            latteBox.Text = latteCount.ToString();
        }

        private void latteNext_Click(object sender, EventArgs e)
        {
            if (latteBox.Text != "")
            {
                string menu = latteBtn.Text;
                string jumlah = latteBox.Text;
                string topping = topping15.Text;
                insert_button(menu, jumlah, topping);
                topping15.Enabled = false;
                latteBox.Clear();
                latteCount = 0;
            }
        }

        private void listmenu_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listmenu.Items.Count; i++)
            {
                if (listmenu.Items[i].Selected)
                {
                    listmenu.Items[i].Remove();
                    i--;
                }
            }
        }
    }
}
