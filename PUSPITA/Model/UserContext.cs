using Npgsql;

namespace PUSPITA.Model
{
    class UserContext
    {
        private readonly string KoneksiString;
        public static int IdPetani { get; set; }
        public UserContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=ashar;Database=PUSPITA";
        }
        public bool Validasi(string username, string password, out int petaniId)
        {
            petaniId = 0;
            string query = "SELECT id_petani, Username FROM petani WHERE username = @username AND password_petani = @password";
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
    }
}
