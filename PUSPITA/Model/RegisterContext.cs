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
            KoneksiString = "Host=localhost;Username=postgres;Password=ashar;Database=PUSPITA";
        }

            public bool Register(string username, string password,string alamat)
            {
                string query = "SELECT * FROM petani WHERE Username = @username";
                using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
                {
                    Kon.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object hasil = cmd.ExecuteScalar()!;
                        int hitung = (hasil != null) ? Convert.ToInt32(hasil) : 0;
                        if (hitung > 0)
                        {
                            return false;
                        }
                    }
                }
                string queryInsert = "INSERT INTO petani (username, password_petani, alamat) VALUES (@username, @password, @alamat) ";
                using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
                {
                    Kon.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsert, Kon))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@alamat", alamat);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                }
            }

        //public bool IsUsernameExists(string username)
        //{
        //    using (var connection = new NpgsqlConnection(KoneksiString))
        //    {
        //        connection.Open();
        //        string query = "SELECT COUNT(*) FROM petani WHERE Username = @username";
        //        using (var cmd = new NpgsqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@username", username);
        //            int count = Convert.ToInt32(cmd.ExecuteScalar());
        //            return count > 0;
        //        }
        //    }
        //}
    }
}