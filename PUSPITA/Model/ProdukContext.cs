using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Produk> GetAllProduk()
        {
            string query = @"
        SELECT * FROM produk
         WHERE discontinued = 1 AND id_jenis = 1;
    ";

            var list = new List<Produk>();
            using var kon = new NpgsqlConnection(KoneksiString);
            kon.Open();
            using var cmd = new NpgsqlCommand(query, kon);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Produk
                {
                    ID = reader.GetInt32(reader.GetOrdinal("id_produk")),
                    Nama = reader.GetString(reader.GetOrdinal("nama_produk")),
                    Jenis = reader.GetString(reader.GetOrdinal("jenis")),
                    Dosis = reader.GetInt32(reader.GetOrdinal("dosis")),
                    Harga = reader.GetDecimal(reader.GetOrdinal("harga")),
                    Discontinued = reader.GetInt16(reader.GetOrdinal("discontinued")) == 1
                });
            }
            return list;
        }
        public bool TambahPupuk(string namaPupuk, string jenis, int dosis, int harga)
        {
            string InsertQuery = "Insert into produk (nama_produk, id_jenis,dosis,harga,Discontinued) values (@nama, 1, @dosis, @harga,1)";
            return JalankanQueryTambah(InsertQuery, namaPupuk, jenis, dosis, harga);
        } 
        public bool TambahPestisida(string namaPestisida, string jenis, int dosis, int harga)
        {
            string InsertQuery = "Insert into produk (nama_produk, id_jenis,dosis,harga, Discontinued) values (@nama, 2, @dosis, @harga,1)";
            return JalankanQueryTambah(InsertQuery, namaPestisida, jenis, dosis, harga);
        }
        private bool JalankanQueryTambah(string query, string nama, string jenis, int dosis, int harga)
        {
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jenis", jenis);
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
        public bool HapusPupuk(int IDProduk)
        {
            string queryDelete = "Update produk set Discontinued = 0 where id_produk = @IDProduk";
            return JalankanQueryHapus(queryDelete, IDProduk);
        }
        public bool HapusPestisida(int IDProduk)
        {
            string queryDelete = "Update produk set Discontinued = 0 where id_produk = @IDProduk";
            return JalankanQueryHapus(queryDelete, IDProduk);
        }
        public bool JalankanQueryHapus(string query, int IDProduk)
        {
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                {
                    cmd.Parameters.AddWithValue("@IDProduk", IDProduk);
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
        public bool UpdatePupuk(string nama, string jenis, int dosis, int harga, int IDproduk)
        {
            string queryUpdate = "Update produk set nama_produk = @nama, dosis = @dosis, harga = @harga where id_produk = @IDproduk";
            return JalankanQueryUpdate(queryUpdate, nama, jenis, dosis, harga, IDproduk);
        }
        public bool UpdatePestisida(string nama, string jenis, int dosis, int harga, int IDproduk)
        {
            string queryUpdate = "Update produk set nama_produk = @nama, dosis = @dosis, harga = @harga where id_produk = @IDproduk";
            return JalankanQueryUpdate(queryUpdate, nama, jenis, dosis, harga, IDproduk);
        }
        public bool JalankanQueryUpdate(string query, string nama, string jenis, int dosis, int harga, int IDproduk)
        {
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@dosis", dosis);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@IDproduk", IDproduk);
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
        public DataTable LihatPupuk()
        {
            string queryLihat = "SELECT p.id_produk, p.nama_produk, p.dosis, p.harga \r\nFROM produk p \r\nJOIN jenis_produk jp ON p.id_jenis = jp.id_jenis \r\nJOIN kategori_produk kp ON jp.id_kategori = kp.id_kategori \r\nWHERE kp.kategori = 'Pupuk' AND p.discontinued = 1;";
            return JalankanQueryLihat(queryLihat);
        }
        public DataTable LihatPestisida()
        {
            string queryLihat = "SELECT p.id_produk, p.nama_produk, p.dosis, p.harga FROM produk p JOIN jenis_produk jp ON p.id_jenis = jp.id_jenis JOIN kategori_produk kp ON jp.id_kategori = kp.id_kategori WHERE kp.kategori = 'Pestisida' AND p.discontinued = 1;";
            return JalankanQueryLihat(queryLihat);
        }
        public DataTable JalankanQueryLihat(string query)
        {
           using(NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Kon))
                {
                    try
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }
        }
    }
}
