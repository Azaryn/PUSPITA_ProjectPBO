using Npgsql;

namespace PUSPITA.Model
{
    class AdminContext
    {
        private readonly string KoneksiString;
        public AdminContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
        public bool Validate(string username, string password, out int adminId)
        {
            adminId = 0;
            string query = "SELECT ID_admin, Username FROM admins WHERE Username = @username AND Password_admin = @password";
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
                            adminId = reader.GetInt32(0);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
