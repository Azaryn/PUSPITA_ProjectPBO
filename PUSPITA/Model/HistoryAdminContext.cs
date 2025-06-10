using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    class HistoryAdminContext
    {
        protected readonly string KoneksiString;
        public HistoryAdminContext()
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
        }
        public DataTable AmbilHistory()
        {
            string queryAmbil = @"
SELECT 
    pt.username AS NamaPetani,
    pt.alamat AS AlamatPetani,
    p.nama_produk AS NamaProduk,
    dt.jumlah,
    (p.harga * dt.jumlah) AS total_harga,
    t.metode_pembayaran
FROM detail_transaksi dt
JOIN produk p  ON p.id_produk = dt.id_produk
JOIN transaksi t  ON t.id_transaksi = dt.id_transaksi
JOIN petani pt ON pt.id_petani = t.id_petani;";
            using (NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryAmbil,Kon))
                {
                    try
                    {
                        Kon.Open();
                        using (NpgsqlDataReader Baca = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(Baca);
                            return dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }
        }
    }
}
