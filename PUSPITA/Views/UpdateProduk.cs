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
    public partial class UpdateProduk : Form
    {
        bool CheckProduk = false;
        ProdukContext produkContext = new ProdukContext();
        public UpdateProduk()
        {
            InitializeComponent();
            BtnPupuk.Visible = false;
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            CheckProduk = false;
            BtnPestisida.Visible = true;
            RBKetiga.Visible = false;
            Header.Text = "Update Pupuk";
            Nama.Text = "Nama Pupuk";
            ID.Text = "ID Pupuk";
            Dosis.Text = "Dosis Pupuk";
            Jenis.Text = "Jenis Pupuk";
            BtnPupuk.Visible = false;
            LoadPupuk();
        }

        private void BtnPestisida_Click(object sender, EventArgs e)
        {
            CheckProduk = true;
            BtnPupuk.Visible = true;
            RBKetiga.Visible = true;
            Header.Text = "Update Pestisida";
            ID.Text = "ID Pestisida";
            Nama.Text = "Nama Pestisida";
            Dosis.Text = "Dosis Pestisida";
            Jenis.Text = "Jenis Pestisida";
            BtnPestisida.Visible = false;
            LoadPestisida();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBNama != null && TBDosis != null && TBHarga != null && TBIDProduk != null)
                {

                    int IDPupuk = Convert.ToInt32(TBIDProduk.Text);
                    string nama = TBNama.Text;
                    int dosis = Convert.ToInt32(TBDosis.Text);
                    int harga = Convert.ToInt32(TBHarga.Text);
                    int jenis = 0;
                    if (RBPertama.Checked)
                    {
                        jenis = 1;
                    }
                    else if (RBKedua.Checked)
                    {
                        jenis = 2;
                    }
                    else if (RBKetiga.Checked && CheckProduk)
                    {
                        jenis = 3;
                    }
                    else
                    {
                        MessageBox.Show("Jenis Produk Tidak Boleh Kosong ya Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool benar = false;
                    if (CheckProduk)
                    {
                        benar = produkContext.UpdatePestisida(nama, jenis, dosis, harga, IDPupuk);
                    }
                    else
                    {
                        benar = produkContext.UpdatePupuk(nama, jenis, dosis, harga, IDPupuk);
                    }
                    if (benar)
                    {
                        if (CheckProduk)
                        {
                            MessageBox.Show("Pestisida berhasil Diupdate!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Pupuk berhasil Diupdate!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produk Gagal Diupdate", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduk_Load(object sender, EventArgs e)
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

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnKembali_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
