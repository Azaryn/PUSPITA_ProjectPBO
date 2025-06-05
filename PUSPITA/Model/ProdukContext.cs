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
        public bool TambahPupuk(string namaPupuk, int jenis, int dosis, int harga)
        {
            string InsertQuery = "Insert into pupuk (nama_pupuk, id_jenispupuk,dosis,harga,Discontinued) values (@nama, @jenis, @dosis, @harga,1)";
            return JalankanQueryTambah(InsertQuery, namaPupuk, jenis, dosis, harga);
        } 
        public bool TambahPestisida(string namaPestisida, int jenis, int dosis, int harga)
        {
            string InsertQuery = "Insert into pestisida (nama_pestisida, id_jenispestisida,dosis,harga, Discontinued) values (@nama, @jenis, @dosis, @harga,1)";
            return JalankanQueryTambah(InsertQuery, namaPestisida, jenis, dosis, harga);
        }
        private bool JalankanQueryTambah(string query, string nama, int jenis, int dosis, int harga)
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
            string queryDelete = "Update pupuk set Discontinued = 0 where id_pupuk = @IDProduk";
            return JalankanQueryHapus(queryDelete, IDProduk);
        }
        public bool HapusPestisida(int IDProduk)
        {
            string queryDelete = "Update pestisida set Discontinued = 0 where id_pestisida = @IDProduk";
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
        public bool UpdatePupuk(string nama, int jenis, int dosis, int harga, int IDproduk)
        {
            string queryUpdate = "Update pupuk set nama_pupuk = @nama, id_jenispupuk = @jenis, dosis = @dosis, harga = @harga where id_pupuk = @IDproduk";
            return JalankanQueryUpdate(queryUpdate, nama, jenis, dosis, harga, IDproduk);
        }
        public bool UpdatePestisida(string nama, int jenis, int dosis, int harga, int IDproduk)
        {
            string queryUpdate = "Update pestisida set nama_pestisida = @nama, id_jenispestisida = @jenis, dosis = @dosis, harga = @harga where id_pestisida = @IDproduk";
            return JalankanQueryUpdate(queryUpdate, nama, jenis, dosis, harga, IDproduk);
        }
        public bool JalankanQueryUpdate(string query, string nama, int jenis, int dosis, int harga, int IDproduk)
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
            string queryLihat = "Select * from pupuk";
            return JalankanQueryLihat(queryLihat);
        }
        public DataTable LihatPestisida()
        {
            string queryLihat = "Select * from pestisida";
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
        //public class keranjang()
        //{
//        string query = @"
//select * from pupuk where Discontinued = 1
//UNION ALL
//select * from pestisida where Discontinued = 1
//";
        //}
        //public List<Produk> ProdukShop()
        //{
        //    List<Produk> produklist = new List<Produk>();
            
        //    using (NpgsqlConnection kon = new NpgsqlConnection(KoneksiString))
        //    {
        //        kon.Open();
        //        using (NpgsqlCommand cmd = new NpgsqlCommand(query, kon))
        //        {
        //            using (NpgsqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {

        //                }
        //            }
        //        }
        //    }
        //}
        //method baru
    }
    //class baru

}
