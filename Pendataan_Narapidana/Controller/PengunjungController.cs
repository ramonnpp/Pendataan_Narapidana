using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Controller
{
    public class PengunjungController
    {
        private readonly PengunjungRepository _repository;

        public PengunjungController()
        {
            _repository = new PengunjungRepository();
        }

        public List<Pengunjung> GetAllPengunjung()
        {
            return _repository.GetAllPengunjung();
        }

        public void AddPengunjung(Pengunjung pengunjung)
        {
            _repository.AddPengunjung(pengunjung);
        }

        public void UpdatePengunjung(Pengunjung pengunjung)
        {
            _repository.UpdatePengunjung(pengunjung);
        }

        public void DeletePengunjung(int idPengunjung)
        {
            _repository.DeletePengunjung(idPengunjung);
        }

    }
}
