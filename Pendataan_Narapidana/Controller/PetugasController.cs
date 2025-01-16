using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Repository;

namespace Pendataan_Narapidana.Controller
{
    public class PetugasController
    {
        private readonly PetugasRepository _repository;

        public PetugasController()
        {
            _repository = new PetugasRepository();
        }

        // Ambil semua data petugas
        public List<Petugas> AmbilSemuaPetugas()
        {
            try
            {
                return _repository.AmbilSemua();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Petugas>();
            }
        }

        // Tambah petugas baru
        public bool TambahPetugas(string nama, string jabatan, int idSel)
        {
            try
            {
                // Validasi data
                if (string.IsNullOrWhiteSpace(nama))
                    throw new ArgumentException("Nama petugas tidak boleh kosong.");

                if (string.IsNullOrWhiteSpace(jabatan))
                    throw new ArgumentException("Jabatan petugas tidak boleh kosong.");

                if (idSel <= 0)
                    throw new ArgumentException("ID Sel tidak valid.");

                var petugas = new Petugas
                {
                    NamaPetugas = nama,
                    Jabatan = jabatan,
                    IdSel = idSel
                };

                _repository.Tambah(petugas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Update data petugas
        public bool UpdatePetugas(Petugas petugas)
        {
            try
            {
                _repository.Update(petugas);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hapus petugas
        public bool HapusPetugas(int idPetugas)
        {
            try
            {
                if (idPetugas <= 0)
                    throw new ArgumentException("ID Petugas tidak valid.");

                _repository.Hapus(idPetugas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
