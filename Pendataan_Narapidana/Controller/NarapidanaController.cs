using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendataan_Narapidana.Controller
{
    public class NarapidanaController
    {
        private readonly NarapidanaRepository _repository;

        public NarapidanaController()
        {
            _repository = new NarapidanaRepository();
        }

        // Metode untuk mengambil data narapidana berdasarkan ID
        public Narapidana GetNarapidanaById(int idNarapidana)
        {
            try
            {
                return _repository.AmbilById(idNarapidana);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public bool HapusNarapidanaTerakhir()
        {
            try
            {
                return _repository.HapusNarapidanaTerakhir();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


        public bool TambahNarapidana(string nama, string jenisKelamin, string pidana,
                                     string alamat, string pekerjaan, DateTime tanggalMasuk,
                                     DateTime tanggalKeluar, int idSel, byte[] foto)
        {
            try
            {
                // Validasi data
                if (string.IsNullOrEmpty(nama))
                    throw new ArgumentException("Nama tidak boleh kosong");

                if (string.IsNullOrEmpty(jenisKelamin))
                    throw new ArgumentException("Jenis kelamin harus dipilih");

                if (string.IsNullOrEmpty(pidana))
                    throw new ArgumentException("Pidana tidak boleh kosong");

                if (tanggalKeluar < tanggalMasuk)
                    throw new ArgumentException("Tanggal keluar tidak boleh lebih awal dari tanggal masuk");

                if (idSel <= 0)
                    throw new ArgumentException("IdSel harus valid dan lebih besar dari 0");

                // Buat objek narapidana
                var narapidana = new Narapidana
                {
                    Nama = nama,
                    JenisKelamin = jenisKelamin,
                    Pidana = pidana,
                    Alamat = alamat,
                    Pekerjaan = pekerjaan,
                    TanggalMasuk = tanggalMasuk,
                    TanggalKeluar = tanggalKeluar,
                    IdSel = idSel,
                    Foto = foto
                };

                // Simpan ke database melalui repository
                _repository.Tambah(narapidana);
                return true;
            }
            catch (Exception ex)
            {
                // Log error (dapat diganti dengan logging ke file atau sistem lain)
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public List<Narapidana> AmbilSemuaNarapidana()
        {
            try
            {
                return _repository.AmbilSemua();
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Narapidana>();
            }
        }
        public bool EditNarapidana(Narapidana narapidana)
        {
            try
            {
                _repository.Edit(narapidana);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool HapusNarapidana(int idNarapidana)
        {
            try
            {
                _repository.Hapus(idNarapidana);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}