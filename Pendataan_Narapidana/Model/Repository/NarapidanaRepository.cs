using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Pendataan_Narapidana.Model.Context;
using Pendataan_Narapidana.Model.Entity;


namespace Pendataan_Narapidana.Model.Repository
{
    public class NarapidanaRepository
    {
        private readonly DbContext _context;

        public NarapidanaRepository()
        {
            _context = new DbContext();
        }

        public Narapidana AmbilById(int idNarapidana)
        {
            Narapidana narapidana = null;

            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Narapidana WHERE Id_Narapidana = @idNarapidana";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idNarapidana", idNarapidana);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            narapidana = new Narapidana
                            {
                                Id_Narapidana = Convert.ToInt32(reader["Id_Narapidana"]),
                                Nama = reader["Nama"].ToString(),
                                Pidana = reader["Pidana"].ToString(),
                                Alamat = reader["Alamat"].ToString(),
                                Pekerjaan = reader["Pekerjaan"].ToString(),
                                TanggalMasuk = Convert.ToDateTime(reader["TanggalMasuk"]),
                                TanggalKeluar = Convert.ToDateTime(reader["TanggalKeluar"]),
                                IdSel = Convert.ToInt32(reader["IdSel"]),
                                Foto = reader["Foto"] as byte[] // Asumsi Foto disimpan sebagai byte array
                            };
                        }
                    }
                }
            }

            return narapidana;
        }

        public bool HapusNarapidanaTerakhir()
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"DELETE FROM Narapidana 
                       WHERE Id_Narapidana = (SELECT MAX(Id_Narapidana) FROM Narapidana)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    return cmd.ExecuteNonQuery() > 0; // Mengembalikan true jika ada baris yang terhapus
                }
            }
        }

        public void Tambah(Narapidana narapidana)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Narapidana (Nama, JenisKelamin, Pidana, Alamat, Pekerjaan, 
                    TanggalMasuk, TanggalKeluar, IdSel, Foto) 
                    VALUES (@nama, @jenisKelamin, @pidana, @alamat, 
                    @pekerjaan, @tanggalMasuk, @tanggalKeluar, @idSel, @foto)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", narapidana.Nama);
                    cmd.Parameters.AddWithValue("@jenisKelamin", narapidana.JenisKelamin);
                    cmd.Parameters.AddWithValue("@pidana", narapidana.Pidana);
                    cmd.Parameters.AddWithValue("@alamat", narapidana.Alamat);
                    cmd.Parameters.AddWithValue("@pekerjaan", narapidana.Pekerjaan);
                    cmd.Parameters.AddWithValue("@tanggalMasuk", narapidana.TanggalMasuk);
                    cmd.Parameters.AddWithValue("@tanggalKeluar", narapidana.TanggalKeluar);
                    cmd.Parameters.AddWithValue("@idSel", narapidana.IdSel);
                    cmd.Parameters.AddWithValue("@foto", narapidana.Foto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Narapidana> AmbilSemua()
        {
            List<Narapidana> listNarapidana = new List<Narapidana>();
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT n.Id_Narapidana, n.Nama, n.JenisKelamin, n.Pidana, n.Alamat, n.Pekerjaan, 
                      n.TanggalMasuk, n.TanggalKeluar, n.IdSel, 
                      s.TipeSel, s.Lokasi, n.Foto
               FROM Narapidana n
               JOIN Sel s ON n.IdSel = s.IdSel";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var narapidana = new Narapidana
                            {
                                Id_Narapidana = Convert.ToInt32(reader["Id_Narapidana"]),
                                Nama = reader["Nama"].ToString(),
                                JenisKelamin = reader["JenisKelamin"].ToString(),
                                Pidana = reader["Pidana"].ToString(),
                                Alamat = reader["Alamat"].ToString(),
                                Pekerjaan = reader["Pekerjaan"].ToString(),
                                TanggalMasuk = Convert.ToDateTime(reader["TanggalMasuk"]),
                                TanggalKeluar = Convert.ToDateTime(reader["TanggalKeluar"]),
                                IdSel = Convert.ToInt32(reader["IdSel"]),
                                Sel = new Sel
                                {
                                    IdSel = Convert.ToInt32(reader["IdSel"]),
                                    TipeSel = reader["TipeSel"].ToString(),
                                    Lokasi = reader["Lokasi"].ToString()
                                },
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };

                            Console.WriteLine($"Narapidana: {narapidana.Nama}, Sel: {narapidana.Sel.TipeSel}");
                            listNarapidana.Add(narapidana);
                        }

                    }
                }

            }
            return listNarapidana;
        }
        public void Edit(Narapidana narapidana)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Narapidana 
                       SET Nama = @nama, Pidana = @pidana, 
                           Alamat = @alamat, Pekerjaan = @pekerjaan, 
                           TanggalMasuk = @tanggalMasuk, TanggalKeluar = @tanggalKeluar, IdSel = @idsel, Foto = @foto
                       WHERE Id_Narapidana = @id_narapidana";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_narapidana", narapidana.Id_Narapidana);
                    cmd.Parameters.AddWithValue("@nama", narapidana.Nama);
                    //cmd.Parameters.AddWithValue("@jenisKelamin", narapidana.JenisKelamin);
                    cmd.Parameters.AddWithValue("@pidana", narapidana.Pidana);
                    cmd.Parameters.AddWithValue("@alamat", narapidana.Alamat);
                    cmd.Parameters.AddWithValue("@pekerjaan", narapidana.Pekerjaan);
                    cmd.Parameters.AddWithValue("@tanggalMasuk", narapidana.TanggalMasuk);
                    cmd.Parameters.AddWithValue("@tanggalKeluar", narapidana.TanggalKeluar);
                    cmd.Parameters.AddWithValue("@idsel", narapidana.IdSel);
                    cmd.Parameters.AddWithValue("@foto", narapidana.Foto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Hapus(int idNarapidana)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Narapidana WHERE Id_Narapidana = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idNarapidana);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}
