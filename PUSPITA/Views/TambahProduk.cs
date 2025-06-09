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
    public partial class TambahProduk : Form
    {
        private bool CheckProduk = false;
        public TambahProduk()
        {
            InitializeComponent();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (TBNama != null && TBDosis != null && TBHarga != null && RBPertama != null && RBKedua != null)
                {
                    string jenis = "";
                    string namaProduk = TBNama.Text;
                    int dosis = Convert.ToInt32(TBDosis.Text);
                    int harga = Convert.ToInt32(TBHarga.Text);

                    ProdukContext produkContext = new ProdukContext();
                    bool Benar = false;
                    if (CheckProduk)
                    {
                        if (RBPertama.Checked)
                        {
                            jenis = "Organik";
                        }
                        else if (RBKedua.Checked)
                        {
                            jenis = "Anorganik";
                        }
                        Benar = produkContext.TambahPestisida(namaProduk, jenis, dosis, harga);
                    }
                    else
                    {
                        if (RBPertama.Checked)
                        {
                            jenis = "Fungisida";
                        }
                        else if (RBKedua.Checked)
                        {
                            jenis = "Herbisida";
                        }
                        else if (RBKetiga.Checked && CheckProduk)
                        {
                            jenis = "Insektisida";
                        }
                        Benar = produkContext.TambahPupuk(namaProduk, jenis, dosis, harga);
                    }



                    if (Benar)
                    {
                        if (CheckProduk)
                        {
                            MessageBox.Show("Pestisida berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Pupuk berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan produk. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPestisida_Click(object sender, EventArgs e)
        {
            CheckProduk = true;
            Header.Text = "Tambah Pestisida";
            Nama.Text = "Nama Pestisida";
            Dosis.Text = "Dosis Pestisida";
            Harga.Text = "Harga Pestisida";
            Jenis.Text = "Jenis Pestisida";
            RBKetiga.Visible = true;
            RBPertama.Text = "Fungisida";
            RBKedua.Text = "Herbisida";
            BtnPupuk.Visible = true;
            BtnPestisida.Visible = false;
            Gambar.Image = Resources.PesticideHand;

        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            CheckProduk = false;
            Header.Text = "Tambah Pupuk";
            Nama.Text = "Nama Pupuk";
            Dosis.Text = "Dosis Pupuk";
            Harga.Text = "Harga Pupuk";
            Jenis.Text = "Jenis Pupuk";
            RBKetiga.Visible = false;
            RBPertama.Text = "Organik";
            RBKedua.Text = "Anorganik";
            BtnPupuk.Visible = false;
            BtnPestisida.Visible = true;
            Gambar.Image = Resources.FertilizerHand;
        }
    }
}
