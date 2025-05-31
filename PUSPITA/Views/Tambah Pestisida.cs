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
    public partial class Tambah_Pestisida : Form
    {
        public Tambah_Pestisida()
        {
            InitializeComponent();
        }

        private void btnPupuk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tambah_Pupuk Tpupuk = new Tambah_Pupuk();
            Tpupuk.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Produksi Kproduksi = new Kelola_Produksi();
            Kproduksi.Show();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNamaProduk != null && tbHargaProduk != null && tbStockProduk != null && rbFungisida != null && rbHerbisida != null && rbInsektisida != null)
                {
                    int jenisPestisida = 0;
                    string NamaPupuk = tbNamaProduk.Text;
                    if (rbFungisida.Checked)
                    {
                        jenisPestisida = 1;
                    }
                    else if (rbHerbisida.Checked)
                    {
                        jenisPestisida = 2;
                    }
                    else if (rbInsektisida.Checked)
                    {
                        jenisPestisida = 3;
                    }
                    else
                    {
                        MessageBox.Show("Jenis Pestisida Tidak Boleh Kosong ya Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int harga = Convert.ToInt32(tbHargaProduk.Text);
                    int stock = Convert.ToInt32(tbStockProduk.Text);
                    PestisidaContext pestisidaContext = new PestisidaContext();
                    bool Benar = pestisidaContext.TambahPestisida(NamaPupuk, jenisPestisida, stock, harga);
                    if (Benar)
                    {
                        MessageBox.Show("Pestisida berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
