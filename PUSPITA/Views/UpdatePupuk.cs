using PUSPITA.Model;
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
    public partial class UpdatePupuk : Form
    {
        public UpdatePupuk()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int IDpupuk = Convert.ToInt32(tbIDPupuk.Text);
            PupukContext pupukContext = new PupukContext();
            int Cek = pupukContext.ValidasiData();
            if (IDpupuk >= 1 && IDpupuk <= Cek)
            {
                try
                {
                    if (tbIDPupuk.Text != null && tbNamaProduk.Text != null && tbHargaProduk != null && tbDosisProduk != null)
                    {
                        string namaPupuk = tbNamaProduk.Text;
                        int jenisPupuk = 0;
                        if (rbAnorganik.Checked)
                        {
                            jenisPupuk = 2;
                        }
                        else if (rbOrganik.Checked)
                        {
                            jenisPupuk = 1;
                        }
                        int dosis = Convert.ToInt32(tbDosisProduk.Text);
                        int harga = Convert.ToInt32(tbHargaProduk.Text);
                        bool Benar = pupukContext.UpdatePupuk(namaPupuk, jenisPupuk, dosis, harga, IDpupuk);
                        if (Benar)
                        {
                            MessageBox.Show("Pupuk berhasil diupdate!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Kelola_Produksi Kproduksi = new Kelola_Produksi();
                            Kproduksi.Show();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengupdate pupuk. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal mengupdate pupuk. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"ID Tidak ada, Jumlah Produk ada {Cek}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
