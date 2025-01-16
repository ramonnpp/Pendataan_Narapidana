using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Model.Entity
{
    public class Pengunjung
    {
        public int Id_Pengunjung { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Hubungan { get; set; }
        public string NoHp { get; set; }
        public int Id_Narapidana { get; set; }
        public string NamaNarapidana { get; set; }
        public DateTime? WaktuKunjungan { get; set; } 
    }
}
