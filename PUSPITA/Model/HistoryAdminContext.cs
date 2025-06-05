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
            KoneksiString = "Host=localhost;Username=postgres;Password=ashar;Database=PUSPITA";
        }
        public DataTable AmbilHistory()
        {
            string queryAmbil = @"
SELECT 
    pt.Username AS NamaPetani,
    pt.Alamat AS AlamatPetani,
    pb.Nama_pupuk AS NamaProduk,
    jp.Jenis_Pupuk AS JenisProduk,
    dtp.Quantity AS Jumlah,
    (pb.Harga * dtp.Quantity) AS TotalHarga,
    t.MetodePembayaran
FROM detail_transaksipupuk dtp
JOIN pupuk pb ON pb.ID_Pupuk = dtp.ID_Pupuk
JOIN jenis_pupuk jp ON jp.ID_JenisPupuk = pb.ID_JenisPupuk
JOIN transaksi t ON t.ID_Transaksi = dtp.ID_Transaksi
JOIN petani pt ON pt.ID_Petani = t.ID_Petani

UNION ALL

SELECT 
    pt.Username AS NamaPetani,
    pt.Alamat AS AlamatPetani,
    ps.Nama_Pestisida AS NamaProduk,
    jp.Jenis_Pestisida AS JenisProduk,
    dtps.Quantity AS Jumlah,
    (ps.Harga * dtps.Quantity) AS TotalHarga,
    t.MetodePembayaran
FROM detail_transaksipestisida dtps
JOIN pestisida ps ON ps.ID_Pestisida = dtps.ID_Pestisida
JOIN jenis_pestisida jp ON jp.ID_JenisPestisida = ps.ID_JenisPestisida
JOIN transaksi t ON t.ID_Transaksi = dtps.ID_Transaksi
JOIN petani pt ON pt.ID_Petani = t.ID_Petani;

";
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
                        MessageBox.Show("Gagal Mengambil Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }
        }
    }
}
