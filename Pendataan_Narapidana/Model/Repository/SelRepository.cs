using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendataan_Narapidana.Model.Context;
using Pendataan_Narapidana.Model.Entity;

namespace Pendataan_Narapidana.Model.Repository
{
    public class SelRepository
    {
        private readonly DbContext _context;

        public SelRepository()
        {
            _context = new DbContext();
        }

        public void Tambah(Sel sel)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Sel (TipeSel, Kapasitas, Lokasi, JumlahPenghuni, NomorSel) 
              VALUES (@tipeSel, @kapasitas, @lokasi, @jumlahPenghuni, @NomorSel)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    Console.WriteLine($"SQL: {sql}");
                    Console.WriteLine($"@tipeSel={sel.TipeSel}, @kapasitas={sel.Kapasitas}, @lokasi={sel.Lokasi}, @jumlahPenghuni={sel.JumlahPenghuni}, @NomorSel={sel.NomorSel}");

                    cmd.Parameters.AddWithValue("@tipeSel", sel.TipeSel);
                    cmd.Parameters.AddWithValue("@kapasitas", sel.Kapasitas);
                    cmd.Parameters.AddWithValue("@lokasi", sel.Lokasi);
                    cmd.Parameters.AddWithValue("@jumlahPenghuni", sel.JumlahPenghuni);
                    cmd.Parameters.AddWithValue("@NomorSel", sel.NomorSel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Sel> AmbilSemua()
        {
            List<Sel> listSel = new List<Sel>();
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Sel";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sel sel = new Sel
                            {
                                IdSel = Convert.ToInt32(reader["IdSel"]),
                                TipeSel = reader["TipeSel"].ToString(),
                                Kapasitas = Convert.ToInt32(reader["Kapasitas"]),
                                Lokasi = reader["Lokasi"].ToString(),
                                JumlahPenghuni = Convert.ToInt32(reader["JumlahPenghuni"]),
                                NomorSel = reader["NomorSel"].ToString()
                            };
                            listSel.Add(sel);
                        }
                    }
                }
            }
            return listSel;
        }

        public void Update(Sel sel)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Sel SET TipeSel = @tipeSel, Kapasitas = @kapasitas, 
              Lokasi = @lokasi, JumlahPenghuni = @jumlahPenghuni, NomorSel = @NomorSel
              WHERE IdSel = @idSel";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tipeSel", sel.TipeSel);
                    cmd.Parameters.AddWithValue("@kapasitas", sel.Kapasitas);
                    cmd.Parameters.AddWithValue("@lokasi", sel.Lokasi);
                    cmd.Parameters.AddWithValue("@jumlahPenghuni", sel.JumlahPenghuni);
                    cmd.Parameters.AddWithValue("@idSel", sel.IdSel);
                    cmd.Parameters.AddWithValue("@NomorSel", sel.NomorSel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Hapus(int idSel)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Sel WHERE IdSel = @idSel";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idSel", idSel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Sel AmbilById(int idSel)
        {
            Sel sel = null;
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Sel WHERE IdSel = @idSel";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idSel", idSel);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sel = new Sel
                            {
                                IdSel = Convert.ToInt32(reader["IdSel"]),
                                TipeSel = reader["TipeSel"].ToString(),
                                Kapasitas = Convert.ToInt32(reader["Kapasitas"]),
                                Lokasi = reader["Lokasi"].ToString(),
                                JumlahPenghuni = Convert.ToInt32(reader["JumlahPenghuni"]),
                                NomorSel = reader["NomorSel"].ToString()
                            };
                        }
                    }
                }
            }
            return sel;
        }

        // Tambah penghuni pada sel
        public bool TambahPenghuni(int idSel)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Sel 
                           SET JumlahPenghuni = JumlahPenghuni + 1 
                           WHERE IdSel = @idSel AND JumlahPenghuni < Kapasitas";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idSel", idSel);
                    return cmd.ExecuteNonQuery() > 0; // Berhasil jika ada baris yang diperbarui
                }
            }
        }

        // Kurangi penghuni pada sel
        public bool KurangiPenghuni(int idSel)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Sel 
                           SET JumlahPenghuni = JumlahPenghuni - 1 
                           WHERE IdSel = @idSel AND JumlahPenghuni > 0";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idSel", idSel);
                    return cmd.ExecuteNonQuery() > 0; // Berhasil jika ada baris yang diperbarui
                }
            }
        }
    }
}

