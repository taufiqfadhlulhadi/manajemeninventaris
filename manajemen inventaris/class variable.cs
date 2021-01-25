using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manajemen_inventaris
{
    class class_variable
    {
        private static int jumlah = 0;
        private static int poin = 0;
        private static int permit = 0;
        private static string nama = "";
        private static string metode = "";
        private static int kembalian = 0;
        private static int penggunaan_point = 0;
        private static string nohp = "";
        private static int bayar = 0;
        private static string history = "";

        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }

        public int Point
        {
            get { return poin; }
            set { poin = value; }
        }

        public int Permit
        {
            get { return permit; }
            set { permit = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string noHP
        {
            get { return nohp; }
            set { nohp = value; }
        }

        public string Metode
        {
            get { return metode; }
            set { metode = value; }
        }

        public int Kembalian
        {
            get { return kembalian; }
            set { kembalian = value; }
        }

        public int Penggunaan_Point
        {
            get { return penggunaan_point; }
            set { penggunaan_point = value; }
        }
        public int Bayar
        {
            get { return bayar; }
            set { bayar = value; }
        }

        public string History
        {
            get { return history; }
            set { history = value; }
        }
    }
}
