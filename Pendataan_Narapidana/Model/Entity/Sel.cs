using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Model.Entity
{
    public class Sel
    {
        public int IdSel { get; set; }
        public string TipeSel { get; set; }
        public int Kapasitas { get; set; }
        public string Lokasi { get; set; }
        public int JumlahPenghuni { get; set; }
        public List<Narapidana> Narapidanas { get; set; } = new List<Narapidana>();
        public string NomorSel { get; set; }
        public bool TambahPenghuni()
        {
            if (JumlahPenghuni < Kapasitas)
            {
                JumlahPenghuni++;
                return true;
            }
            return false;
        }

    }
}

