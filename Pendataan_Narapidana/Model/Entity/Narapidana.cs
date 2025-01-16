using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Model.Entity
{
    public class Narapidana
    {
        public int Id_Narapidana { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Pidana { get; set; }
        public string Alamat { get; set; }
        public string Pekerjaan { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public DateTime TanggalKeluar { get; set; }
        public int IdSel { get; set; }
        public Sel Sel { get; set; }
        public byte[] Foto { get; set; } 
        public string DetailSel
        {
            get
            {
                return Sel != null ? $"{Sel.TipeSel} - {Sel.Lokasi}" : "Tidak Ada";
            }
        }
    }
}
