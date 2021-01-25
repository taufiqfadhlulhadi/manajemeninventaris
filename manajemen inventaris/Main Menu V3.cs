using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace manajemen_inventaris
{
    public partial class menu_utama : Form
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
        int tiramitsuCount = 0;
        int redCount = 0;
        int kopikoCount = 0;
        int kopmilCount = 0;
        int latteCount = 0;
        int cappucinoCount = 0;
        int matchalatteCount = 0;
        int macchiatoCount = 0;
        int cottonCount = 0;
        int greenteaoreoCount = 0;
        int cadburryCount = 0;
        int taroCount = 0;
        int chickenCount = 0;
        int nuggetCount = 0;
        int potatoCount = 0;
        int kopcadCount = 0;
        int jasmineCount = 0;
        int mangoCount = 0;
        int avocadoCount = 0;
        int safariCount = 0;
        int bananaCount = 0;
        int paket = 0;
        int jumlah = 0;
        int point_sebelumnya = 0;

        public menu_utama()
        {
            InitializeComponent();
            //topping1.Enabled = false;
            label17.Text = variable.Nama.ToString();
            label19.Text = variable.Point.ToString();
            point_sebelumnya = variable.Point;
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket1);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket2);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket3);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket4);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket5);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket6);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket7);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket8);
            paket_cbox.Items.Add(manajemen_inventaris.Properties.Settings.Default.nama_paket9);
        }

        private void freshgthaiBtn_Click(object sender, EventArgs e)
        {
            fgtCount++;
            fgtcountBox.Text = fgtCount.ToString();
        }

        private void fgtIN_Click(object sender, EventArgs e)
        {
            if (fgtcountBox.Text != "")
            {
                string menu = freshgthaiBtn.Text;
                string jumlah = fgtcountBox.Text;
                string size = sizeCbox18.Text;
                string topping = size + " (" + toppingCbox18.Text + ")";

                insert_button(menu, jumlah, size, topping);
                fgtcountBox.Clear();
                fgtCount = 0;
            }
        }

        private void insert_table(string[] input)
        {
            var listViewItem = new ListViewItem(input);
            listmenu.Items.Add(listViewItem);
            jumlah_harga();
        }

        private void fotIn_Click(object sender, EventArgs e)
        {
            if (fotcntBox.Text != "")
            {
                string menu = freshothaiBtn.Text;
                string jumlah = fotcntBox.Text;
                string size = sizeCbox19.Text;
                string topping = size + " (" + toppingCbox19.Text + ")";

                insert_button(menu, jumlah, size, topping);
                fotcntBox.Clear();
                fotCount = 0;
            }
        }

        private void freshothaiBtn_Click(object sender, EventArgs e)
        {
            fotCount++;
            fotcntBox.Text = fotCount.ToString();
        }

        private void greentthaiBtn_Click(object sender, EventArgs e)
        {
            gttCount++;
            gttcntBox.Text = gttCount.ToString();
        }

        private void gttIn_Click(object sender, EventArgs e)
        {
            if (gttcntBox.Text != "")
            {
                string menu = greentthaiBtn.Text;
                string jumlah = gttcntBox.Text;
                string size = sizeCbox20.Text;
                string topping = size + " (" + toppingCbox20.Text + ")";

                insert_button(menu, jumlah, size, topping);
                gttcntBox.Clear();
                gttCount = 0;
            }
        }


        private void insert_button(string menu, string jumlah, string size = "", string topping = "")
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

//MessageBox.Show(topping + "s");

            //check ukuran
            if (size == "M")
            {
                harga = harga + 2000;
            }
            else if (size == "L")
            {
                harga = harga + 5000;
            }
            else if (size == "S" && topping == "S ()")
            {
                harga = harga;
            }
            else if (size == "S" && topping != "S ()")
            {
                harga = harga + 2000;
            }

            total = harga * Convert.ToInt32(jumlah);

            string[] pesanan = { menu + " " + topping, Convert.ToString(harga), Convert.ToString(jumlah), Convert.ToString(total) };
            insert_table(pesanan);
        }

        private void insert_button_smoothies(string menu, string jumlah, string size = "", string topping = "")
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

            //MessageBox.Show(topping + "s");

            //check ukuran
            if (size == "M")
            {
                harga = harga + 3000;
            }
            else if (size == "L")
            {
                harga = harga + 6000;
            }
            else if (size == "S" && topping == "S ()")
            {
                harga = harga;
            }
            else if (size == "S" && topping != "S ()")
            {
                harga = harga + 2000;
            }

            total = harga * Convert.ToInt32(jumlah);

            string[] pesanan = { menu + " " + topping, Convert.ToString(harga), Convert.ToString(jumlah), Convert.ToString(total) };
            insert_table(pesanan);
        }

        private void originaltthaiBtn_Click(object sender, EventArgs e)
        {
            ottCount++;
            ottcntBox.Text = ottCount.ToString();
        }

        private void ottIn_Click(object sender, EventArgs e)
        {
            if (ottcntBox.Text != "")
            {
                string menu = originaltthaiBtn.Text;
                string jumlah = ottcntBox.Text;
                string size = sizeCbox21.Text;
                string topping = size + " (" + toppingCbox21.Text + ")";

                insert_button(menu, jumlah, size, topping);
                ottcntBox.Clear();
                ottCount = 0;
            }
        }

        private void matchaBtn_Click(object sender, EventArgs e)
        {
            //grentea
            matchaCount++;
            greenBox.Text = matchaCount.ToString();
        }

        private void mIn_Click(object sender, EventArgs e)
        {
            if (greenBox.Text != "")
            {
                string menu = greenBtn.Text;
                string jumlah = greenBox.Text;
                string size = sizeCbox12.Text;
                string topping = size + " (" + toppingCbox12.Text + ")";

                insert_button(menu, jumlah, size, topping);
                greenBox.Clear();
                matchaCount = 0;
            }
        }

        private void charcoallButton_Click(object sender, EventArgs e)
        {
            //kopi kekinian
            clCount++;
            clcntBox.Text = clCount.ToString();
        }

        private void clIn_Click(object sender, EventArgs e)
        {
            if (clcntBox.Text != "")
            {
                //coffee thai
                string menu = charcoallButton.Text;
                string jumlah = clcntBox.Text;
                string size = sizeCbox5.Text;
                string topping = size + " (" + toppingCbox5.Text + ")";

                insert_button(menu, jumlah, size, topping);
                clcntBox.Clear();
                clCount = 0;
            }
        }

        public void bayarBtn_Click(object sender, EventArgs e)
        {
            int jumlahcup = 0;
            variable.History = "";
            for (int i = 0; i < listmenu.Items.Count; i++)
            {
                jumlahcup = jumlahcup + Convert.ToInt32(listmenu.Items[i].SubItems[2].Text);
            }
            variable.History = jumlahcup.ToString();
            bayar(jumlah);
            if (variable.Metode == "point" || variable.Metode == "bayar")
            {
                label1.Visible = true;
                DateTime waktu = DateTime.Now;
                label19.Text = variable.Point.ToString();
                //MessageBox.Show(waktu.ToString("dd/MM/yyyy"));
                //MessageBox.Show(manajemen_inventaris.Properties.Settings.Default.waktu.ToString());

                if (manajemen_inventaris.Properties.Settings.Default.waktu.ToString() == waktu.ToString("dd/MM/yyyy"))
                {
                    //MessageBox.Show("betul");
                    manajemen_inventaris.Properties.Settings.Default.antrian = manajemen_inventaris.Properties.Settings.Default.antrian + 1;
                    manajemen_inventaris.Properties.Settings.Default.Save();
                    label11.Text = manajemen_inventaris.Properties.Settings.Default.antrian.ToString();
                    label9.Visible = true;
                    label11.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    label12.Text = variable.Kembalian.ToString();
                }
                else
                {
                    //MessageBox.Show("salah");
                    manajemen_inventaris.Properties.Settings.Default.waktu = DateTime.Now.ToString("dd/MM/yyyy");
                    manajemen_inventaris.Properties.Settings.Default.antrian = 0;
                    manajemen_inventaris.Properties.Settings.Default.antrian = manajemen_inventaris.Properties.Settings.Default.antrian + 1;
                    manajemen_inventaris.Properties.Settings.Default.Save();
                    label11.Text = manajemen_inventaris.Properties.Settings.Default.antrian.ToString();
                    label9.Visible = true;
                    label11.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    label12.Text = variable.Kembalian.ToString();
                }

                for (int i = 0; i <= 1; i++)
                {
                    PrintDialog printDialog = new PrintDialog();

                    PrintDocument printDocument = new PrintDocument();

                    printDialog.Document = printDocument; //add the document to the dialog box...        

                    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                    //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

                    DialogResult result = printDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        printDocument.Print();

                    }
                }
            }
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
            chocolateCount++;
            MilkChocolatebox.Text = chocolateCount.ToString();
        }

        private void MilkChocolateNext_Click(object sender, EventArgs e)
        {
            if (MilkChocolatebox.Text != "")
            {
                string menu = MilkchocolateBtn.Text + " " + comboBox2.Text;
                string jumlah = MilkChocolatebox.Text;
                string size = sizeCbox10.Text;
                string topping = size + " (" + toppingCbox10.Text + ")";

                insert_button(menu, jumlah, size, topping);
                MilkChocolatebox.Clear();
                chocolateCount = 0;
            }
        }

        private void MilkVanillaBtn_Click(object sender, EventArgs e)
        {
            vanillaCount++;
            MilkVanillabox.Text = vanillaCount.ToString();
        }

        private void MilkVanillaNext_Click(object sender, EventArgs e)
        {
            if (MilkVanillabox.Text != "")
            {
                string menu = MilkVanillaBtn.Text + " " + comboBox3.Text;
                string jumlah = MilkVanillabox.Text;
                string size = sizeCbox11.Text;
                string topping = size + " (" + toppingCbox11.Text + ")";

                insert_button(menu, jumlah, size, topping);
                MilkVanillabox.Clear();
                vanillaCount = 0;
            }
        }

        private void TiramitsuBtn_Click(object sender, EventArgs e)
        {

            tiramitsuCount++;
            Tiramitsubox.Text = tiramitsuCount.ToString();
        }

        private void TiramitsuNext_Click(object sender, EventArgs e)
        {
            if (Tiramitsubox.Text != "")
            {
                string menu = TiramitsuBtn.Text;
                string jumlah = Tiramitsubox.Text;
                string size = sizeCbox17.Text;
                string topping = size + " (" + toppingCbox17.Text + ")";

                insert_button(menu, jumlah, size, topping);
                Tiramitsubox.Clear();
                tiramitsuCount = 0;
            }
        }

        private void VelvetBtn_Click(object sender, EventArgs e)
        {
            redCount++;
            Velvetbox.Text = redCount.ToString();
        }

        private void VelvetNext_Click(object sender, EventArgs e)
        {
            if (Velvetbox.Text != "")
            {
                string menu = VelvetBtn.Text;
                string jumlah = Velvetbox.Text;
                string size = sizeCbox14.Text;
                string topping = size + " (" + toppingCbox14.Text + ")";

                insert_button(menu, jumlah, size, topping);
                Velvetbox.Clear();
                redCount = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //americano
            kopikoCount++;
            kopikoBox.Text = kopikoCount.ToString();
        }

        private void kopikoNext_Click(object sender, EventArgs e)
        {
            if (kopikoBox.Text != "")
            {
                string menu = kopikoBtn.Text;
                string jumlah = kopikoBox.Text;
                string size = sizeCbox8.Text;
                string topping = size + " (" + toppingCbox8.Text + ")";

                insert_button(menu, jumlah, size, topping);
                kopikoBox.Clear();
                kopikoCount = 0;
            }
        }

        private void kopmilBtn_Click(object sender, EventArgs e)
        {
            //iced coffee
            kopmilCount++;
            kopmilBox.Text = kopmilCount.ToString();
        }

        private void kopmilNext_Click(object sender, EventArgs e)
        {
            if (kopmilBox.Text != "")
            {
                string menu = kopmilBtn.Text;
                string jumlah = kopmilBox.Text;
                string size = sizeCbox7.Text;
                string topping = size + " (" + toppingCbox7.Text + ")";

                insert_button(menu, jumlah, size, topping);
                kopmilBox.Clear();
                kopmilCount = 0;
            }
        }

        private void latteBtn_Click(object sender, EventArgs e)
        {
            latteCount++;
            latteBox.Text = latteCount.ToString();
        }

        private void latteNext_Click(object sender, EventArgs e)
        {
            if (latteBox.Text != "")
            {
                string menu = "" + latteBtn.Text + " " + comboBox1.Text;
                string jumlah = latteBox.Text;
                string size = sizeCbox3.Text;
                string topping = size + " (" + toppingCbox3.Text + ")";

                insert_button(menu, jumlah, size, topping);
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
            jumlah_harga();
        }

        private void capuchinoBtn_Click(object sender, EventArgs e)
        {
            //mochaccino
            cappucinoCount++;
            capuchinoBox.Text = cappucinoCount.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (capuchinoBox.Text != "")
            {
                string menu = capuchinoBtn.Text;
                string jumlah = capuchinoBox.Text;
                string size = sizeCbox4.Text;
                string topping = size + " (" + toppingCbox4.Text + ")";

                insert_button(menu, jumlah, size, topping);
                capuchinoBox.Clear();
                cappucinoCount = 0;
            }
        }

        private void matchalatteBtn_Click(object sender, EventArgs e)
        {
            //avocado coffee
            matchalatteCount++;
            matchalatteBox.Text = matchalatteCount.ToString();
        }

        private void matchalatteNext_Click(object sender, EventArgs e)
        {
            if (matchalatteBox.Text != "")
            {
                string menu = matchalatteBtn.Text;
                string jumlah = matchalatteBox.Text;
                string size = sizeCbox1.Text;
                string topping = size + " (" + toppingCbox1.Text + ")";
                
                insert_button(menu, jumlah, size, topping);
                matchalatteBox.Clear();
                matchalatteCount = 0;
            }
        }

        private void macchiatoBtn_Click(object sender, EventArgs e)
        {
            macchiatoCount++;
            macchiatoBox.Text = macchiatoCount.ToString();
        }

        private void macchiatoNext_Click(object sender, EventArgs e)
        {
            if (macchiatoBox.Text != "")
            {
                string menu = macchiatoBtn.Text;
                string jumlah = macchiatoBox.Text;
                string size = sizeCbox2.Text;
                string topping = size + " (" + toppingCbox2.Text + ")";

                insert_button(menu, jumlah, size, topping);
                macchiatoBox.Clear();
                macchiatoCount = 0;
            }
        }

        private void cottonBtn_Click(object sender, EventArgs e)
        {
            //expresso
            cottonCount++;
            cottonBox.Text = cottonCount.ToString();
        }

        private void CottonNext_Click(object sender, EventArgs e)
        {
            if (cottonBox.Text != "")
            {
                string menu = cottonBtn.Text;
                string jumlah = cottonBox.Text;
                string size = sizeCbox9.Text;
                string topping = size + " (" + toppingCbox9.Text + ")";

                insert_button(menu, jumlah, size, topping);
                cottonBox.Clear();
                cottonCount = 0;
            }
        }
        private void cadburryBtn_Click(object sender, EventArgs e)
        {
            cadburryCount++;
            cadburryBox.Text = cadburryCount.ToString();
        }

        private void cadburryNext_Click(object sender, EventArgs e)
        {
            if (cadburryBox.Text != "")
            {
                string menu = cadburryBtn.Text;
                string jumlah = cadburryBox.Text;
                string size = sizeCbox15.Text;
                string topping = size + " (" + toppingCbox15.Text + ")";

                insert_button(menu, jumlah, size, topping);
                cadburryBox.Clear();
                cadburryCount = 0;
            }
        }

        private void Main_Menu_V3_FormClosed(object sender, FormClosedEventArgs e)
        {
            variable.Metode = "";
        }

        private void TaroBtn_Click(object sender, EventArgs e)
        {
            taroCount++;
            taroBox.Text = taroCount.ToString();
        }

        private void taroNext_Click(object sender, EventArgs e)
        {
            if (taroBox.Text != "")
            {
                string menu = TaroBtn.Text;
                string jumlah = taroBox.Text;
                string size = sizeCbox16.Text;
                string topping = size + " (" + toppingCbox16.Text + ")";

                insert_button(menu, jumlah, size, topping);
                taroBox.Clear();
                taroCount = 0;
            }
        }

        private void chickenBtn_Click(object sender, EventArgs e)
        {
            chickenCount++;
            chickenBox.Text = chickenCount.ToString();
        }

        private void chickenNext_Click(object sender, EventArgs e)
        {
            if (chickenBox.Text != "")
            {
                string menu = chickenBtn.Text;
                string jumlah = chickenBox.Text;
                insert_button_ukuran_chicken(menu, jumlah);
                chickenBox.Clear();
                chickenCount = 0;
            }
        }

        private void nuggetBtn_Click(object sender, EventArgs e)
        {
            nuggetCount++;
            nuggetBox.Text = nuggetCount.ToString();
        }

        private void nuggetNext_Click(object sender, EventArgs e)
        {
            if (nuggetBox.Text != "")
            {
                string menu = nuggetBtn.Text + " " + comboBox5.Text;
                string jumlah = nuggetBox.Text;
                insert_button(menu, jumlah);
                nuggetBox.Clear();
                nuggetCount = 0;
            }
        }

        private void potatoBtn_Click(object sender, EventArgs e)
        {
            potatoCount++;
            potatoBox.Text = potatoCount.ToString();
        }

        private void potatoNext_Click(object sender, EventArgs e)
        {
            if (potatoBox.Text != "")
            {
                string menu = potatoBtn.Text;
                string jumlah = potatoBox.Text;
                insert_button_ukuran_chicken(menu, jumlah);
                potatoBox.Clear();
                potatoCount = 0;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            kopcadCount++;
            kopcadBox.Text = kopcadCount.ToString();
        }

        private void kopcadNext_Click(object sender, EventArgs e)
        {
            if (kopcadBox.Text != "")
            {
                string menu = kopcadBtn.Text;
                string jumlah = kopcadBox.Text;
                string size = sizeCbox6.Text;
                string topping = size + " (" + toppingCbox6.Text + ")";

                insert_button(menu, jumlah, size, topping);
                kopcadBox.Clear();
                kopcadCount = 0;
            }
        }
        private void insert_button_ukuran_chicken(string menu, string jumlah)
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

            string[] pesanan = { menu, Convert.ToString(harga), Convert.ToString(jumlah), Convert.ToString(total) };
            insert_table(pesanan);
        }

        private void jumlah_harga()
        {
            int jumlah_harga = 0;
            for (int i = 0; i < listmenu.Items.Count; i++)
            {
                try
                {
                    jumlah_harga += int.Parse(listmenu.Items[i].SubItems[3].Text);
                }
                catch (Exception ex)
                {
                    jumlah_harga = 0;
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            label6.Text = "RP " + jumlah_harga + ",-";

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autentikasi auten = new Autentikasi();
            auten.Show();
        }

        private void Main_Menu_V3_Load(object sender, EventArgs e)
        {

        }

        private void paket_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket1)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket1.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket1;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket2)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket2.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket2;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket3)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket3.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket3;
            }
            if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket4)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket4.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket4;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket5)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket5.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket5;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket6)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket6.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket6;
            }
            if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket7)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket7.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket7;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket8)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket8.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket8;
            }
            else if (Convert.ToString(paket_cbox.SelectedItem) == manajemen_inventaris.Properties.Settings.Default.nama_paket9)
            {
                harga_paket.Text = manajemen_inventaris.Properties.Settings.Default.harga_paket9.ToString();
                desc_paket.Text = manajemen_inventaris.Properties.Settings.Default.des_paket9;
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            paket++;
            paket_count.Text = paket.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string menu = paket_cbox.Text;
                string harga = harga_paket.Text;
                string jumlah = paket_count.Text;
                int total = Convert.ToInt32(harga) * Convert.ToInt32(jumlah);

                string[] pesanan = { menu, Convert.ToString(harga), Convert.ToString(jumlah), Convert.ToString(total) };
                insert_table(pesanan);
            }
            catch (Exception ex)
            {

            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Intro Rust Base", 6); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 0;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("MAUTHAI", new Font("Intro Rust Base", 9, FontStyle.Bold), new SolidBrush(Color.Black), 63, startY);
            graphic.DrawString("- Café -", new Font("Intro Rust Base", 6, FontStyle.Bold), new SolidBrush(Color.Black), 76, startY + (int)fontHeight + (int)fontHeight);
            graphic.DrawString("         No. ", new Font("Intro Rust Base", 5, FontStyle.Bold), new SolidBrush(Color.Black), 130, startY + (int)fontHeight + (int)fontHeight + (int)fontHeight);
            graphic.DrawString("Antrian ", new Font("Intro Rust Base", 5, FontStyle.Bold), new SolidBrush(Color.Black), 130, startY + (int)fontHeight + (int)fontHeight + (int)fontHeight + (int)fontHeight);
            graphic.DrawString(manajemen_inventaris.Properties.Settings.Default.antrian.ToString(), new Font("Intro Rust Base", 10, FontStyle.Bold), new SolidBrush(Color.Black), 170, startY + (int)fontHeight + (int)fontHeight + (int)fontHeight);
            //string top = "Pesanan".PadRight(15) + "Jumlah".PadRight(10) + "Harga".PadRight(10) + "Total";
            //graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString(variable.Nama, new Font("Intro Rust Base", 5, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)fontHeight + (int)fontHeight + (int)fontHeight);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("Point: " + point_sebelumnya, new Font("Intro Rust Base", 5, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)fontHeight + (int)fontHeight + (int)fontHeight + (int)fontHeight);
            graphic.DrawString("---------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, offset - 5);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            for (int p = 0; p < listmenu.Items.Count; p++)
            {
                string nama_pesanan, substring_pesanan, jumlah_pesanan, harga_pesanan, total_pesanan;
                nama_pesanan = listmenu.Items[p].SubItems[0].Text;
                //if (nama_pesanan.Length > 25)
                //{
                //    substring_pesanan = nama_pesanan.Substring(0, 11) + "..";
                //}
                //else
                //{
                    substring_pesanan = nama_pesanan;
                    while (substring_pesanan.Length < 25)
                    {
                        substring_pesanan = substring_pesanan + " ";
                    }
                //}

                harga_pesanan = listmenu.Items[p].SubItems[1].Text;
                jumlah_pesanan = listmenu.Items[p].SubItems[2].Text;
                total_pesanan = listmenu.Items[p].SubItems[3].Text;

                //string reciept = substring_pesanan.PadRight(5) + "  " + jumlah_pesanan.PadRight(10) + harga_pesanan.PadRight(10) + total_pesanan;
                //graphic.DrawString(reciept, font, new SolidBrush(Color.Black), startX, startY + offset);

                graphic.DrawString(substring_pesanan, font, new SolidBrush(Color.Black), startX, offset - 10);
                offset = offset + (int)fontHeight - 10; //make the spacing consistent
                string string_harga = jumlah_pesanan + " x " + harga_pesanan;
                graphic.DrawString(string_harga, font, new SolidBrush(Color.Black), startX, offset);
                offset = offset + (int)fontHeight; //make the spacing consistent
                graphic.DrawString(total_pesanan, font, new SolidBrush(Color.Black), 150, (offset - (int)fontHeight));

                offset = offset + (int)fontHeight + 5; //make the spacing consistent
            }
            graphic.DrawString("---------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, offset - 5);
            offset = offset + (int)fontHeight; //make the spacing consistent

            //when we have drawn all of the items add the total
            graphic.DrawString("Total ".PadRight(10) + String.Format("{0:c}", variable.Jumlah), new Font("Intro Rust Base", 6, FontStyle.Bold), new SolidBrush(Color.Black), 100, offset);

            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("Bayar ".PadRight(10) + String.Format("{0:c}", variable.Bayar), font, new SolidBrush(Color.Black), 100, offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("Penggunaan Point     ".PadRight(10) + String.Format("{0:c}", variable.Penggunaan_Point), font, new SolidBrush(Color.Black), 40, offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("Kembalian       ".PadRight(10) + String.Format("{0:c}", variable.Kembalian), font, new SolidBrush(Color.Black), 75, offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("Sisa point       ".PadRight(10) + String.Format("{0:c}", variable.Point), font, new SolidBrush(Color.Black), startX, offset + 5);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("---------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, offset);
            offset = offset + (int)fontHeight; //make the spacing consistent

            graphic.DrawString("Semua harga", new Font("Intro Rust Base", 6, FontStyle.Bold), new SolidBrush(Color.Black), 62, offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("Telah mendapatkan point 5%", new Font("Intro Rust Base", 6, FontStyle.Bold), new SolidBrush(Color.Black), 25, offset + 3);
            offset = offset + (int)fontHeight; //make the spacing consistent

            graphic.DrawString("TERIMA KASIH", new Font("Intro Rust Base", 8, FontStyle.Bold), new SolidBrush(Color.Black), 50, offset + (int)fontHeight);
            offset = offset + (int)fontHeight + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("Silahkan Datang Kembali!", new Font("Intro Rust Base", 6, FontStyle.Bold), new SolidBrush(Color.Black), 30, offset + (int)fontHeight);
            offset = offset + (int)fontHeight; //make the spacing consistent

            variable.Penggunaan_Point = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            jasmineCount++;
            jasmineBox.Text = jasmineCount.ToString();
        }

        private void jasmineNext_Click(object sender, EventArgs e)
        {
            if (jasmineBox.Text != "")
            {
                string menu = jasmineBtn.Text;
                string jumlah = jasmineBox.Text;
                string size = sizeCbox22.Text;
                string topping = size + " (" + toppingCbox22.Text + ")";

                insert_button(menu, jumlah, size, topping);
                jasmineBox.Clear();
                jasmineCount = 0;
            }
        }

        private void mangoBtn_Click(object sender, EventArgs e)
        {
            mangoCount++;
            mangoBox.Text = mangoCount.ToString();
        }

        private void mangoNext_Click(object sender, EventArgs e)
        {
            string menu = mangoBtn.Text + " " + mangoCBox.Text;
            string jumlah = mangoBox.Text;
            string size = sizeCbox23.Text;
            string topping = size + " (" + toppingCbox23.Text + ")";

            insert_button_smoothies(menu, jumlah, size, topping);
            mangoBox.Clear();
            mangoCount = 0;
        }

        private void avocadoBtn_Click(object sender, EventArgs e)
        {
            avocadoCount++;
            avocadoBox.Text = avocadoCount.ToString();
        }

        private void avocadoNext_Click(object sender, EventArgs e)
        {
            string menu = avocadoBtn.Text + " " + avocadoCBox.Text;
            string jumlah = avocadoBox.Text;
            string size = sizeCbox24.Text;
            string topping = size + " (" + toppingCbox24.Text + ")";

            insert_button_smoothies(menu, jumlah, size, topping);
            avocadoBox.Clear();
            avocadoCount = 0;
        }

        private void greenteaoreo_Click(object sender, EventArgs e)
        {
            greenteaoreoCount++;
            greentea.Text = greenteaoreoCount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string menu = greenteaoreo.Text;
            string jumlah = greentea.Text;
            string size = sizeCbox13.Text;
            string topping = size + " (" + toppingCbox13.Text + ")";

            insert_button(menu, jumlah, size, topping);
            greentea.Clear();
            greenteaoreoCount = 0;
        }

        private void greenSafariBtn_Click(object sender, EventArgs e)
        {
            safariCount++;
            safariBtn.Text = safariCount.ToString();
        }

        private void safariNext_Click(object sender, EventArgs e)
        {
            string menu = greenSafariBtn.Text;
            string jumlah = safariBtn.Text;
            string size = sizeCbox25.Text;
            string topping = size + " (" + toppingCbox25.Text + ")";

            insert_button(menu, jumlah, size, topping);
            safariBtn.Clear();
            safariCount = 0;
        }

        private void bananaBtn_Click(object sender, EventArgs e)
        {
            bananaCount++;
            bananaBox.Text = bananaCount.ToString();
        }

        private void bananaNext_Click(object sender, EventArgs e)
        {
            string menu = bananaBtn.Text;
            string jumlah = bananaBox.Text;
            string size = sizeCbox26.Text;
            string topping = size + " (" + toppingCbox26.Text + ")";

            insert_button_smoothies(menu, jumlah, size, topping);
            bananaBox.Clear();
            bananaCount = 0;
        }

        private void Makanan_Enter(object sender, EventArgs e)
        {

        }
    }
}
