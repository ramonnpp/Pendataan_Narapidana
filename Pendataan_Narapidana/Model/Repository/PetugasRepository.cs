using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Pendataan_Narapidana.Model.Context;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.View;

namespace Pendataan_Narapidana.Model.Repository
{
    public class PetugasRepository
    {
        // Tambah Petugas
        public void Tambah(Petugas petugas)
        {
            if (petugas == null)
                throw new ArgumentException("Data Petugas tidak boleh null.");

            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Petugas (NamaPetugas, Jabatan, IdSel) VALUES (@nama, @jabatan, @idSel)";
                    Console.WriteLine("Query: " + sql);

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", petugas.NamaPetugas);
                        cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                        cmd.Parameters.AddWithValue("@idSel", petugas.IdSel);

                        Console.WriteLine($"Parameters: @nama={petugas.NamaPetugas}, @jabatan={petugas.Jabatan}, @idSel={petugas.IdSel}");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Tambah Petugas: {ex.Message}");
                    throw;
                }
            }
        }

        // Ambil Semua Petugas
        public List<Petugas> AmbilSemua()
        {
            var listPetugas = new List<Petugas>();
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT p.IdPetugas, p.NamaPetugas, p.Jabatan, p.IdSel, 
                                          s.TipeSel, s.Lokasi
                                   FROM Petugas p
                                   JOIN Sel s ON p.IdSel = s.IdSel";
                    Console.WriteLine("Query: " + sql);

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var petugas = new Petugas
                                {
                                    IdPetugas = Convert.ToInt32(reader["IdPetugas"]),
                                    NamaPetugas = reader["NamaPetugas"].ToString(),
                                    Jabatan = reader["Jabatan"].ToString(),
                                    IdSel = Convert.ToInt32(reader["IdSel"]),
                                    Sel = new Sel
                                    {
                                        IdSel = Convert.ToInt32(reader["IdSel"]),
                                        TipeSel = reader["TipeSel"].ToString(),
                                        Lokasi = reader["Lokasi"].ToString()
                                    }
                                };

                                Console.WriteLine($"Petugas: {petugas.NamaPetugas}, Jabatan: {petugas.Jabatan}, Sel: {petugas.Sel.TipeSel}");
                                listPetugas.Add(petugas);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Ambil Semua Petugas: {ex.Message}");
                    throw;
                }
            }
            return listPetugas;
        }

        // Update Petugas
        public void Update(Petugas petugas)
        {
            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Petugas
                       SET NamaPetugas = @nama, Jabatan = @jabatan, 
                           IdSel = @idsel
                       WHERE IdPetugas = @id_petugas";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_petugas", petugas.IdPetugas);
                    cmd.Parameters.AddWithValue("@nama", petugas.NamaPetugas);
                    cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                    cmd.Parameters.AddWithValue("@idsel", petugas.IdSel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Hapus Petugas
        public void Hapus(int idPetugas)
        {
            if (idPetugas <= 0)
                throw new ArgumentException("ID Petugas tidak valid.");

            using (SQLiteConnection conn = DbContext.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM Petugas WHERE IdPetugas = @idPetugas";
                    Console.WriteLine("Query: " + sql);

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPetugas", idPetugas);
                        Console.WriteLine($"Parameter: @idPetugas={idPetugas}");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Hapus Petugas: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
