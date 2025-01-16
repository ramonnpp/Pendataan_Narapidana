using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Pendataan_Narapidana.Model.Context
{
    public class DbContext 
    {
        private const string DbPath = "Data Source=D:\\Data Guah\\File\\Ramon\\AMIKOM\\Sem 3\\PL\\Pendataan_Narapidana_v2\\Pendataan_Narapidana\\Pendataan_Narapidana\\database.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            // Selalu buat koneksi baru
            return new SQLiteConnection(DbPath);
        }
    }
}
