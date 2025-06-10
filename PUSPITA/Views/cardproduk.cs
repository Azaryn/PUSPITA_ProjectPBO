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
    public partial class cardproduk : UserControl
    {
        private Produk _produkData;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Produk ProdukData
        {
            get => _produkData;
            private set => _produkData = value;
        }

        public event EventHandler<Produk> TambahClicked;

        public cardproduk()
        {
            InitializeComponent();

     
            EnsureLabelVisibility();

        }

        private void EnsureLabelVisibility()
        {
            // Pastikan semua label berada di depan
            if (lblNamaProduk != null)
            {
                lblNamaProduk.BringToFront();
                lblNamaProduk.Visible = true;
            }

            if (lblDosis != null)
            {
                lblDosis.BringToFront();
                lblDosis.Visible = true;
            }

            if (lblHarga != null)
            {
                lblHarga.BringToFront();
                lblHarga.Visible = true;
            }
        }

        public void SetData(Produk produk)
        {
            if (produk == null) return;

            ProdukData = produk;

            // Set data dengan pengecekan null
            if (lblNamaProduk != null)
            {
                lblNamaProduk.Text = !string.IsNullOrEmpty(produk.Nama) ? produk.Nama : "Nama Produk";
                lblNamaProduk.BringToFront();
                lblNamaProduk.Visible = true;
            }

            if (lblDosis != null)
            {
                lblDosis.Text = $"{produk.Dosis}";
                lblDosis.BringToFront();
                lblDosis.Visible = true;
            }

            if (lblHarga != null)
            {
                lblHarga.Text = $"Rp {produk.Harga:N0}";
                lblHarga.BringToFront();
                lblHarga.Visible = true;
            }

            // Kirim gambar ke belakang SETELAH label di-set
            if (pbGambrProduk != null)
            {
                pbGambrProduk.BringToFront();
            }
            LoadProductImage(produk);

            // Pastikan semua label tetap di depan
            EnsureLabelVisibility();

            // Load image
        }

        private void LoadProductImage(Produk produk)
        {
            if (pbGambrProduk == null) return;

            try
            {
                // Coba load dari ImageKey jika ada
                if (!string.IsNullOrEmpty(produk.ImageKey))
                {
                    var image = Properties.Resources.ResourceManager.GetObject(produk.ImageKey);
                    if (image != null)
                    {
                        pbGambrProduk.Image = (Image)image;
                        pbGambrProduk.SendToBack();
                        return;
                    }
                }

                // Jika ImageKey tidak ada, gunakan gambar default berdasarkan jenis
                Image defaultImage = produk.Jenis == "pupuk" ?
                    Properties.Resources.gmbrPupuk :
                    Properties.Resources.gmbrpestisida;

                pbGambrProduk.Image = defaultImage;
                pbGambrProduk.SendToBack();
            }
            catch (Exception ex)
            {
                pbGambrProduk.Image = null;
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }

        public void SetImage(Image image)
        {
            if (pbGambrProduk != null)
            {
                pbGambrProduk.Image = image;
                pbGambrProduk.SendToBack();

                // Pastikan label tetap di depan setelah set image
                EnsureLabelVisibility();
            }
        }

        private void btnTambah_clickup(object sender, EventArgs e)
        {
            TambahClicked?.Invoke(this, ProdukData);
        }

        // Method untuk debugging - bisa dipanggil untuk cek visibility
        public void DebugLabelVisibility()
        {
            Console.WriteLine("=== Card Debug Info ===");
            Console.WriteLine($"Card Visible: {this.Visible}, Size: {this.Size}, Location: {this.Location}");

            if (lblNamaProduk != null)
            {
                Console.WriteLine($"lblNamaProduk - Visible: {lblNamaProduk.Visible}, Text: '{lblNamaProduk.Text}', Location: {lblNamaProduk.Location}, Size: {lblNamaProduk.Size}, Parent: {lblNamaProduk.Parent?.Name}");
            }
            else
            {
                Console.WriteLine("lblNamaProduk is null!");
            }

            if (lblDosis != null)
            {
                Console.WriteLine($"lblDosis - Visible: {lblDosis.Visible}, Text: '{lblDosis.Text}', Location: {lblDosis.Location}, Size: {lblDosis.Size}");
            }

            if (lblHarga != null)
            {
                Console.WriteLine($"lblHarga - Visible: {lblHarga.Visible}, Text: '{lblHarga.Text}', Location: {lblHarga.Location}, Size: {lblHarga.Size}");
            }

            if (pbGambrProduk != null)
            {
                Console.WriteLine($"pbGambrProduk - Visible: {pbGambrProduk.Visible}, Size: {pbGambrProduk.Size}, Location: {pbGambrProduk.Location}, HasImage: {pbGambrProduk.Image != null}");
            }

            Console.WriteLine("===================");
        }


    }
}