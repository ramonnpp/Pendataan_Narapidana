using Pendataan_Narapidana.Model.Context;
using Pendataan_Narapidana.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Narapidana.Model.Repository
{
    public class PengunjungRepository
    {
        public List<Pengunjung> GetAllPengunjung()
        {
            var pengunjungList = new List<Pengunjung>();
            using (var connection = DbContext.GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand(
                    @"SELECT p.Id_Pengunjung, p.Nama, p.Alamat, p.Hubungan, p.NoHp, p.Id_Narapidana, n.Nama AS NamaNarapidana, p.WaktuKunjungan
              FROM Pengunjung p
              JOIN Narapidana n ON p.Id_Narapidana = n.Id_Narapidana",
                    connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pengunjung = new Pengunjung
                        {
                            Id_Pengunjung = reader.GetInt32(0),
                            Nama = reader.GetString(1),
                            Alamat = reader.GetString(2),
                            Hubungan = reader.GetString(3),
                            NoHp = reader.GetString(4),
                            Id_Narapidana = reader.GetInt32(5),
                            NamaNarapidana = reader.GetString(6),
                            WaktuKunjungan = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7)
                        };

                        Console.WriteLine($"Id_Pengunjung: {pengunjung.Id_Pengunjung}, Id_Narapidana: {pengunjung.Id_Narapidana}"); // Debug log
                        pengunjungList.Add(pengunjung);
                    }
                }
            }
            return pengunjungList;
        }

        public void AddPengunjung(Pengunjung pengunjung)
        {
            using (var connection = DbContext.GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand(
                    @"INSERT INTO Pengunjung (Nama, Alamat, Hubungan, NoHp, Id_Narapidana, WaktuKunjungan) 
              VALUES (@Nama, @Alamat, @Hubungan, @NoHp, @Id_Narapidana, @WaktuKunjungan)",
                    connection);
                command.Parameters.AddWithValue("@Nama", pengunjung.Nama);
                command.Parameters.AddWithValue("@Alamat", pengunjung.Alamat);
                command.Parameters.AddWithValue("@Hubungan", pengunjung.Hubungan);
                command.Parameters.AddWithValue("@NoHp", pengunjung.NoHp);
                command.Parameters.AddWithValue("@Id_Narapidana", pengunjung.Id_Narapidana);
                command.Parameters.AddWithValue("@WaktuKunjungan", pengunjung.WaktuKunjungan); 
                command.ExecuteNonQuery();
            }
        }
        public void UpdatePengunjung(Pengunjung pengunjung)
        {
            using (var connection = DbContext.GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand(
                    @"UPDATE Pengunjung 
              SET Nama = @Nama, 
                  Alamat = @Alamat, 
                  Hubungan = @Hubungan, 
                  NoHp = @NoHp, 
                  Id_Narapidana = @Id_Narapidana 
              WHERE Id_Pengunjung = @Id_Pengunjung", // Jangan ubah WaktuKunjungan
                    connection);

                command.Parameters.AddWithValue("@Nama", pengunjung.Nama);
                command.Parameters.AddWithValue("@Alamat", pengunjung.Alamat);
                command.Parameters.AddWithValue("@Hubungan", pengunjung.Hubungan);
                command.Parameters.AddWithValue("@NoHp", pengunjung.NoHp);
                command.Parameters.AddWithValue("@Id_Narapidana", pengunjung.Id_Narapidana);
                command.Parameters.AddWithValue("@Id_Pengunjung", pengunjung.Id_Pengunjung);

                command.ExecuteNonQuery();
            }
        }


        public void DeletePengunjung(int idPengunjung)
        {
            using (var connection = DbContext.GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand(
                    @"DELETE FROM Pengunjung WHERE Id_Pengunjung = @Id_Pengunjung", connection);
                command.Parameters.AddWithValue("@Id_Pengunjung", idPengunjung);
                command.ExecuteNonQuery();
            }
        }
    }



}
