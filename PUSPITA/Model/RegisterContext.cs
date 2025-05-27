using Npgsql;
using PUSPITA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{

        class RegisterContext
        {
            private readonly string KoneksiString;


            public RegisterContext()
            {
                KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
            }

            public bool Validate(string username, string password, out int petaniId)
            {
                petaniId = 0;
                string query = "SELECT ID_Petani, Username FROM petani WHERE Username = @username AND Password_petani = @password";
                using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
                {
                    Kon.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                petaniId = reader.GetInt32(0);
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        
        public bool IsUsernameExists(string username)
        {
            using (var connection = new NpgsqlConnection(KoneksiString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM petani WHERE Username = @username";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}