using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PUSPITA.Model
{
    class TransaksiContext
    {
        protected readonly string KoneksiString;
        public TransaksiContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
        public int TambahTransaksi(DateTime date, int idpetani, string metode, string pengiriman)
        {
            using (NpgsqlConnection kon = new NpgsqlConnection(KoneksiString))
            {
                kon.Open();
                string query = "INSERT INTO transaksi (tanggal_transaksi, id_petani, metode_pembayaran, jenis_pengiriman) " +
               "VALUES (@tanggal, @id_petani, @metode_pembayaran, @metode_pengiriman) " +
               "RETURNING id_transaksi";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, kon))
                {
                    cmd.Parameters.AddWithValue("@tanggal", date);
                    cmd.Parameters.AddWithValue("@id_petani", idpetani);
                    cmd.Parameters.AddWithValue("@metode_pembayaran", metode);
                    cmd.Parameters.AddWithValue("@metode_pengiriman", pengiriman);
                    var idBaru = cmd.ExecuteScalar();
                    return Convert.ToInt32(idBaru);
                }
            }
        }

        public bool TambahDetail(int id_transaksi, int id_produk, int jumlah, decimal harga)
        {
            using (NpgsqlConnection kon = new NpgsqlConnection(KoneksiString))
            {
                kon.Open();
                string query = "INSERT INTO detail_transaksi (id_transaksi, id_produk, jumlah) VALUES (@id_transaksi, @id_produk, @jumlah)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, kon))
                {
                    cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
                    cmd.Parameters.AddWithValue("@id_produk", id_produk);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
