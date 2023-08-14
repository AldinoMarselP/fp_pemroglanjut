using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanAppMVC.Model.Entity
{
    public class Transaksi
    {
        public string ID { get; set; }
        public string Tglp { get; set; }
        public string Tglk { get; set; }
        public string Nama { get; set; }
        public string Merek { get; set; }
        public string Harga { get; set; }
        public string Bayar { get; set; }
        public string Kurang { get; set; }
        public string Status { get; set; }
    }
}
