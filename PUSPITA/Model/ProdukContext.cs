using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    class ProdukContext
    {
        protected readonly string KoneksiString;
        public ProdukContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
    }
    class PestisidaContext : ProdukContext
    {
        public bool TambahPestisida(string namaPestisida, int jenisPestisida, int dosis, int harga)
        {
            string queryinsert = "Insert into pestisida (nama_pestisida, id_jenispestisida,dosis,harga) values (@nama_pestisida, @jenispestisida,@dosis,@harga)";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryinsert, Kon))
                {
                    cmd.Parameters.AddWithValue("@nama_pupuk", namaPestisida);
                    cmd.Parameters.AddWithValue("@jenispupuk", jenisPestisida);
                    cmd.Parameters.AddWithValue("@dosis", dosis);
                    cmd.Parameters.AddWithValue("@harga", harga);

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
    }
}
