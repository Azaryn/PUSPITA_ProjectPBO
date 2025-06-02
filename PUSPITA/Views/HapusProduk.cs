using PUSPITA.Model;
using PUSPITA.Properties;
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
    public partial class HapusProduk : Form
    {
        bool CheckProduk = false;
        ProdukContext produkContext = new ProdukContext();
        public HapusProduk()
        {
            InitializeComponent();
        }

        private void BtnPestisida_Click(object sender, EventArgs e)
        {
            CheckProduk = true;
            Header.Text = "Hapus Pestisida";
            Nama.Text = "ID Pestisida";
            BtnPupuk.Visible = true;
            BtnPestisida.Visible = false;
            LoadPestisida();
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            CheckProduk = false;
            Header.Text = "Hapus Pupuk";
            Nama.Text = "ID Pupuk";
            BtnPupuk.Visible = false;
            BtnPestisida.Visible = true;
            LoadPupuk();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int IDPupuk = Convert.ToInt32(TBIDProduk.Text);
                //ProdukContext produkContext = new ProdukContext();
                bool benar = false;
                if (CheckProduk)
                {
                    benar = produkContext.HapusPestisida(IDPupuk);
                }
                else
                {
                    benar = produkContext.HapusPupuk(IDPupuk);
                }
                if (benar)
                {
                    if (CheckProduk)
                    {
                        MessageBox.Show("Pestisida berhasil Dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Pupuk berhasil Dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Produk Gagal Dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HapusProduk_Load(object sender, EventArgs e)
        {
            LoadPupuk();
        }
        private void LoadPupuk()
        {
            DataTable dt = produkContext.LihatPupuk();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVProduk.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tidak ada data produk yang tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadPestisida()
        {
            DataTable dt = produkContext.LihatPestisida();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVProduk.DataSource = dt;
            }
        }
    }
}
