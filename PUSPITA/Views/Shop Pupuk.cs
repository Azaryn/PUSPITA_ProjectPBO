using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; 

namespace PUSPITA.Views
{
    public partial class Shop_Pupuk : Form
    {
        // Hanya satu koneksi string untuk seluruh form
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=ashar;Database=PUSPITA;";

        public Shop_Pupuk()
        {
            InitializeComponent();
        }

        private void ShopPupuk_Load(object sender, EventArgs e)
        {
            LoadDataPupuk();
        }

        private void LoadDataPupuk()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.Nama_pupuk AS ""Nama Pupuk"",
                        j.Jenis_pupuk AS ""Jenis Pupuk"",
                        p.Stock AS ""Stock"",
                        p.Harga AS ""Harga""
                    FROM pupuk p
                    JOIN jenis_pupuk j ON p.ID_JenisPupuk = j.ID_JenisPupuk;
                ";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvShopPupuk.DataSource = dt;

                // Hapus kolom checkbox lama jika ada (hindari duplikasi saat refresh data)
                if (dgvShopPupuk.Columns.Contains("Pilih"))
                {
                    dgvShopPupuk.Columns.Remove("Pilih");
                }

                // Tambahkan kolom checkbox di akhir (sebelah kanan)
                // Tambahkan kolom checkbox di akhir (sebelah kanan)
                DataGridViewCheckBoxColumn checkboxCol = new DataGridViewCheckBoxColumn();
                checkboxCol.HeaderText = "Pilih";
                checkboxCol.Name = "Pilih";
                checkboxCol.Width = 50;
                checkboxCol.ReadOnly = false;
                dgvShopPupuk.Columns.Add(checkboxCol);

                conn.Close();
            }
        }

        private void dgvShopPupuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosong dulu, nanti bisa diisi logika checkbox
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Petani Dpetani = new Dashboard_Petani();
            Dpetani.Show();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
        }
    }
}
