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
SELECT p.Nama_pupuk AS NamaProduk, p.Harga AS HargaSatuan, dp.Quantity AS Jumlah, (p.Harga * dp.Quantity) AS TotalHarga, t.tanggal_transaksi, t.metodepembayaran
FROM detail_transaksipupuk dp
JOIN pupuk p ON p.id_pupuk = dp.id_pupuk
JOIN transaksi t ON t.id_transaksi = dp.id_transaksi
where t.id_petani = @id_petani

UNION ALL

SELECT ps.Nama_pestisida AS NamaProduk, ps.Harga AS HargaSatuan, dps.Quantity AS Jumlah, (ps.Harga * dps.Quantity) AS TotalHarga, t.tanggal_transaksi, t.metodepembayaran
FROM detail_transaksipestisida dps
JOIN pestisida ps ON ps.id_pestisida = dps.id_pestisida
JOIN transaksi t ON t.id_transaksi = dps.id_transaksi;
where t.id_petani = @id_petani
";
            using(NpgsqlConnection Kon = new NpgsqlConnection())
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
                        MessageBox.Show("Gagal Mengambil Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }
        }
    }
}
