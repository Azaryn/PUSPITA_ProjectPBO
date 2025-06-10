using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    class HistoryContext
    {
        private int _idPetani;
        protected readonly string KoneksiString;
        public HistoryContext(int Idpetani)
        {
            KoneksiString = "Host=localhost;Username=postgres;Password=lubia2341;Database=PUSPITA";
            _idPetani = Idpetani;
        }
        public DataTable AmbilHistory()
        {
            string queryAmbil = @"
SELECT 
    pt.username AS NamaPetani,
    pt.alamat AS AlamatPetani,
    p.nama_produk AS NamaProduk,
    j.jenis AS JenisProduk,
    dt.jumlah,
    (p.harga * dt.jumlah) AS total_harga,
    t.metode_pembayaran
FROM detail_transaksi dt
JOIN produk p  ON p.id_produk = dt.id_produk
JOIN jenis_produk j  ON j.id_jenis = p.id_jenis 
JOIN transaksi t  ON t.id_transaksi = dt.id_transaksi
JOIN petani pt ON pt.id_petani = t.id_petani
WHERE t.id_petani = @id_petani
ORDER BY t.id_transaksi;
";
            using(NpgsqlConnection Kon = new NpgsqlConnection(KoneksiString))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryAmbil,Kon))
                {
                    cmd.Parameters.AddWithValue("@id_petani", _idPetani);
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
