using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Model.Entity
{
    public class Petugas
    {
        public int IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public string Jabatan { get; set; }
        public int IdSel { get; set; }
        public Sel Sel { get; set; }

        // Properti untuk menampilkan informasi Sel
        public string DetailSel
        {
            get
            {
                return Sel != null ? $"{Sel.TipeSel} - {Sel.Lokasi}" : "Tidak Ada";
            }
        }
    }

}
