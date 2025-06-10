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

        // 2. Atribut supaya Designer tidak nge-serialize properti ini
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Produk ProdukData
        {
            get => _produkData;            // 3. Kembalikan backing field
            private set => _produkData = value;  // 4. Simpan ke backing field
        }



        public event EventHandler<Produk> TambahClicked;

        public cardproduk()
        {
            InitializeComponent();

        }
        public void SetData(Produk produk)
        {
            ProdukData = produk;
            lblNamaProduk.Text = $"{produk.Nama}";
            lblDosis.Text = $"{produk.Dosis} "; // Format dosis
            lblHarga.Text = $"Rp {produk.Harga:N0}"; // Format rupiah

            pbGambrProduk.SendToBack ();

            try
            {
                var image = Properties.Resources.ResourceManager.GetObject(produk.ImageKey);
                if (image != null)
                {
                    pbGambrProduk.Image = (Image)image;
                }
                else
                {
                    // Jika gambar tidak ditemukan, gunakan gambar default atau kosong
                    pbGambrProduk.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Handle error jika resource tidak ditemukan
                pbGambrProduk.Image = null;
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }
        public void SetImage(Image image)
        {
            pbGambrProduk.Image = image;
        }


        private void btnTambah_clickup(object sender, EventArgs e)
        {
            TambahClicked?.Invoke(this, ProdukData);
        }

        internal void DebugLabelVisibility()
        {
            throw new NotImplementedException();
        }
    }
}
