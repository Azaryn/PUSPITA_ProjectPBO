using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSPITA.Views
{
    public partial class Lihat_Pestisida : Form
    {
        private readonly string konString = "Host=localhost;Port=5432;Username=postgres;Password=rafail;Database=PUSPITA";
        public Lihat_Pestisida()
        {
            InitializeComponent();

        }

        private void Lihat_Pestisida_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(konString))
                {
                    conn.Open();
                    string query = "SELECT nama_pestisida, id_jenispestisida, dosis as stock, harga FROM pestisida ORDER BY nama_pestisida";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data dari database: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPupuk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lihat_Pupuk lihatpupuk = new Lihat_Pupuk();
            lihatpupuk.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
