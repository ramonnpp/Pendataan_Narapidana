using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Repository;
using Pendataan_Narapidana.View;

namespace Pendataan_Narapidana.Controller
{
    public class SelController
    {
        private readonly SelRepository _repository;

        public SelController()
        {
            _repository = new SelRepository();
        }

        public List<Sel> AmbilSemuaSel()
        {
            try
            {
                return _repository.AmbilSemua();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Sel>();
            }
        }

        // Menambah penghuni pada sel
        public bool TambahPenghuni(int idSel)
        {
            try
            {
                // Memanggil metode TambahPenghuni dari repository
                return _repository.TambahPenghuni(idSel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Operasi gagal
            }
        }

        // Mengurangi penghuni pada sel
        public bool KurangiPenghuni(int idSel)
        {
            try
            {
                // Memanggil metode KurangiPenghuni dari repository
                return _repository.KurangiPenghuni(idSel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Operasi gagal
            }
        }

        public bool TambahSel(string tipeSel, int kapasitas, string lokasi, int jumlahPenghuni, string nomorSel)
        {
            try
            {
                Console.WriteLine($"Input: TipeSel={tipeSel}, Kapasitas={kapasitas}, Lokasi={lokasi}, JumlahPenghuni={jumlahPenghuni}, NomorSel={nomorSel}");

                if (string.IsNullOrEmpty(tipeSel))
                    throw new ArgumentException("Tipe Sel tidak boleh kosong.");

                if (kapasitas <= 0)
                    throw new ArgumentException("Kapasitas harus lebih besar dari 0.");

                if (string.IsNullOrEmpty(lokasi))
                    throw new ArgumentException("Lokasi tidak boleh kosong.");

                if (string.IsNullOrEmpty(nomorSel))
                    throw new ArgumentException("Nomor Sel tidak boleh kosong.");

                var sel = new Sel
                {
                    TipeSel = tipeSel,
                    Kapasitas = kapasitas,
                    Lokasi = lokasi,
                    JumlahPenghuni = jumlahPenghuni,
                    NomorSel = nomorSel
                };

                _repository.Tambah(sel);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }



        public bool UpdateSel(Sel sel)
        {
            try
            {
                _repository.Update(sel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool HapusSel(int idSel)
        {
            try
            {
                _repository.Hapus(idSel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Sel AmbilSelById(int idSel)
        {
            try
            {
                if (idSel <= 0)
                    throw new ArgumentException("ID Sel tidak valid.");

                return _repository.AmbilById(idSel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}

