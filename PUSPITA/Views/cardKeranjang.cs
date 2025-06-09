using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUSPITA.Model;

namespace PUSPITA.Views
{
    public partial class cardKeranjang : UserControl
    {
        private Produk produkData;
        public event EventHandler<Produk> HapusClicked;
        public cardKeranjang()
        {
            InitializeComponent();

        }
        public void SetData(Produk produk, int jumlah)
        {
            produkData = produk;
            lblNamaProduk.Text = produk.Nama;
            lblHarga.Text = $"Rp {produk.Harga:N0}";
            tbQuantity.Text = jumlah.ToString();

            Image image = produk.Jenis == "pupuk" ? Properties.Resources.gmbrPupuk
                : Properties.Resources.gmbrpestisida;
            SetImage(image);
        }
        public void SetImage(Image image)
        {
            pbGambarProduk.Image = image;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuantity.Text, out int ProdukQuantity))
            {
                // Tambahkan kuantitas
                ProdukQuantity++;
                tbQuantity.Text = ProdukQuantity.ToString();
            }
            else
            {
                // Jika ada kesalahan parsing, set kembali ke 1
                tbQuantity.Text = "1";
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuantity.Text, out int ProdukQuantity))
            {
                // Kurangi kuantitas, pastikan tidak kurang dari 1
                if (ProdukQuantity > 1) // Batasi minimal 1
                {
                    ProdukQuantity--;
                    tbQuantity.Text = ProdukQuantity.ToString();
                }

            }
            else
            {
                // Jika ada kesalahan parsing, set kembali ke 1
                tbQuantity.Text = "1";
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            HapusClicked?.Invoke(this, produkData);
        }
    }
}