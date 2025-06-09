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

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            TglPesan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            int totalProduk = PenampungKeranjang.Daftar.Sum(p => p.Jumlah);
            decimal totalHarga = PenampungKeranjang.Daftar.Sum(p => p.produk.Harga * totalProduk);
            LblJumlah.Text = totalProduk.ToString();
            lblTotal.Text = totalHarga.ToString();
        }
    }
}
