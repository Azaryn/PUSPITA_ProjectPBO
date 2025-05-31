using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUSPITA.Model;

namespace PUSPITA.Views
{
    public partial class Tambah_Pupuk : Form
    {
        public Tambah_Pupuk()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNamaPupuk != null && tbDosisPupuk != null && tbHargaPupuk != null && rbOrganik != null && rbAnorganik != null)
                {
                    int jenisPupuk = 0;
                    string namaPupuk = tbNamaPupuk.Text;
                    if (rbAnorganik.Checked)
                    {
                        jenisPupuk = 2;
                    }
                    else if (rbOrganik.Checked)
                    {
                        jenisPupuk = 1;
                    }
                    else
                    {
                        MessageBox.Show("Jenis Pupuk Tidak Boleh Kosong ya Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int dosis = Convert.ToInt32(tbDosisPupuk.Text);
                    int harga = Convert.ToInt32(tbHargaPupuk.Text);
                     
                    PupukContext pupukContext = new PupukContext();
                    bool Benar = pupukContext.TambahPupuk(namaPupuk, jenisPupuk, dosis, harga);
                    if (Benar)
                    {
                        MessageBox.Show("Pupuk berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Kelola_Produksi Kproduksi = new Kelola_Produksi();
                        Kproduksi.Show();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan pupuk. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Produksi KProduk = new Kelola_Produksi();
            KProduk.Show();
        }

        private void btnPestisida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tambah_Pestisida TPestisida = new Tambah_Pestisida();
            TPestisida.Show();
        }
    }
}
