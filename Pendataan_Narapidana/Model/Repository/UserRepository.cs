using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Context;
using System.Data.SqlClient;

namespace Pendataan_Narapidana.Model.Repository
{
    public class UserRepository
    {
        public bool ValidateUser(string username, string password)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @username AND Password = @password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
