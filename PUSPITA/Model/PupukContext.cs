using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    class PupukContext
    {
        private readonly string KoneksiString;
        public PupukContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
        public bool TambahPupuk(string namaPupuk, int jenispupuk, int dosis, int harga)
        {
            string queryinsert = "Insert into pupuk (nama_pupuk, id_jenispupuk,dosis,harga) values (@nama_pupuk, @jenispupuk,@dosis,@harga)";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryinsert, Kon))
                {
                    cmd.Parameters.AddWithValue("@nama_pupuk", namaPupuk);
                    cmd.Parameters.AddWithValue("@jenispupuk", jenispupuk);
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
        public bool HapusPupuk(int IDPupuk)
        {
            string queryDelete = "Delete From pupuk where id_pupuk = @IDPupuk";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryDelete, Kon))
                {
                    cmd.Parameters.AddWithValue("@IDPupuk", IDPupuk);
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
        public bool LihatPupuk()
        {
            string queryLihat = "Select id_pupuk, nama_pupuk, id_jenispupuk, dosis, harga from pupuk";
            using (NpgsqlConnection Kon = new NpgsqlConnection())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryLihat,Kon))
                {
                    using (NpgsqlDataReader Baca = cmd.ExecuteReader())
                    {
                        //Belom selesai
                    }
                }
                    return true;
            }
        }
        public bool UpdatePupuk(string namaPupuk,int IDjenisPupuk,int dosis,int harga,int IDpupuk)
        {
            string queryUpdate = "Update pupuk set nama_pupuk = @namapupuk, id_jenispupuk = @idjenispupuk, dosis = @dosis, harga = @harga where id_pupuk = @idpupuk";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryUpdate, Kon))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@namapupuk", namaPupuk);
                        cmd.Parameters.AddWithValue("@idjenispupuk", IDjenisPupuk);
                        cmd.Parameters.AddWithValue("@dosis", dosis);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@idpupuk", IDpupuk);
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
        public int ValidasiData()
        {
            string queryValidasi = "Select Count(*) from pupuk";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                Kon.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryValidasi, Kon))
                {
                    try
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return 0;
                    }
                }
            }
        }
    }
}
