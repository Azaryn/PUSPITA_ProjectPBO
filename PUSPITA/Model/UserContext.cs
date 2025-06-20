using Npgsql;

namespace PUSPITA.Model
{
    class UserContext
    {
        private readonly string KoneksiString;
        public static int IdPetani { get; set; }
        public UserContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
        public bool Validasi(string username, string password, out int petaniId, out string alamat)
        {
            petaniId = 0;
            alamat = "";
            string query = "SELECT id_petani, Username, alamat FROM petani WHERE username = @username AND password_petani = @password";
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
                            alamat = reader.GetString(2);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
