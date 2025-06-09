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
    public partial class Keranjang : Form
    {
        public Keranjang()
        {
            InitializeComponent();
            FLPproduk.AutoScroll = true;
            FLPproduk.WrapContents = true;
            FLPproduk.FlowDirection = FlowDirection.LeftToRight;
            FLPproduk.Padding = new Padding(10);
            FLPproduk.Margin = new Padding(0);
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            Shop Toko = new Shop();
            Toko.Show();
        }

        private void Keranjang_Load(object sender, EventArgs e)
        {
            foreach (var item in PenampungKeranjang.Daftar)
            {
                var card = new cardKeranjang();
                card.SetData(item.produk, item.Jumlah);
                card.HapusClicked += Card_HapusClicked;
                FLPproduk.Controls.Add(card);
            }
        }
        private void Card_HapusClicked(object sender, Produk produk)
        {
            var barang = PenampungKeranjang.Daftar.FirstOrDefault(p => p.produk.ID == produk.ID);
            if (barang != null)
            {
                PenampungKeranjang.Daftar.Remove(barang);
                MessageBox.Show($"{produk.Nama} Berhasil dihapus dari keranjang", "produk dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (sender is Control control)
            {
                FLPproduk.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
