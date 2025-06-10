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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
        }
        
        private void btnBayar_Click(object sender, EventArgs e)
        {
            DialogResult pertanyaan = MessageBox.Show("Apakah pembayaran sudah sesuai?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (pertanyaan == DialogResult.Yes)
            {
                TransaksiContext TContext = new TransaksiContext();
                try
                {

                    string metodePembayaran = "";
                    string JenisPengiriman = "";
                    DateTime tanggalTransaksi = DateTime.Now;
                    int idPetani = Users.id_petani;

                    if (metodePembayaran == null)
                    {
                        MessageBox.Show("Pilih metode pembayaran.");
                        return;
                    }
                    else if (rdE_Bank.Checked)
                    {
                        metodePembayaran = "E-Bank";
                    }
                    else if (rdPuspiPay.Checked)
                    {
                        metodePembayaran = "Cash";
                    }

                    if (JenisPengiriman == null)
                    {
                        MessageBox.Show("Pilih jenis pengiriman.");
                        return;
                    }
                    else if (rdJNE.Checked)
                    {
                        JenisPengiriman = "JNE";
                    }
                    else if (rdFASPITA.Checked)
                    {
                        JenisPengiriman = "FASPITA";
                    }

                    if (TContext == null)
                    {
                        MessageBox.Show("Transaksi Gagal");
                        return;
                    }


                    int idTransaksiBaru = TContext.TambahTransaksi(tanggalTransaksi, idPetani, metodePembayaran, JenisPengiriman);
                    foreach (var item in PenampungKeranjang.Daftar)
                    {
                        if (PenampungKeranjang.Daftar.Count == 0)
                        {
                            MessageBox.Show("Keranjang kosong, tidak ada produk untuk ditransaksikan.");
                            return;
                        }
                        bool berhasilTambahDetail = TContext.TambahDetail(idTransaksiBaru, item.produk.ID, item.Jumlah, item.produk.Harga);
                    }

                    MessageBox.Show("Transaksi berhasil disimpan!");
                    PenampungKeranjang.Daftar.Clear();
                    this.Close();
                    Dashboard_Petani Dpetani = new Dashboard_Petani();
                    Dpetani.Show();
                }
                catch (Exception ex)
                {
                    foreach (var item in PenampungKeranjang.Daftar)
                    {
                        MessageBox.Show($"{item.produk.ID}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pembayaran dibatalkan.");
            }
        }


        private void Transaksi_Load(object sender, EventArgs e)
        {
            TglPesan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            int totalProduk = PenampungKeranjang.Daftar.Sum(p => p.Jumlah);
            decimal totalHarga = PenampungKeranjang.Daftar.Sum(p => p.produk.Harga * totalProduk);
            LblJumlah.Text = totalProduk.ToString();
            lblTotal.Text = totalHarga.ToString();
            LblAlamat.Text = Users.alamat;
        }
    }
}
