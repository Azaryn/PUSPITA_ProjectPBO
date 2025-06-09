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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PUSPITA.Views
{
    public partial class Shop : Form
    {
        private readonly ProdukContext produkContext = new ProdukContext();
        private List<Produk> keranjang;
        private const string PupukImagePath = @"C:\Users\HABIB\Downloads\pupuk.png";
        private const string PestisidaImagePath = @"C:\Users\HABIB\Downloads\pestisida.png";

        public Shop()
        {
            InitializeComponent();

            // Setup FLPproduk panel for product cards
            FLPproduk.AutoScroll = true;
            FLPproduk.WrapContents = true;
            FLPproduk.FlowDirection = FlowDirection.LeftToRight;
            FLPproduk.Padding = new Padding(10);
            FLPproduk.Margin = new Padding(0);

            keranjang = new List<Produk>();
            ShowProduk("pupuk");

            FLPproduk.BringToFront();
        }

        private void CardProduk_TambahClicked(object sender, Produk produk)
        {
            keranjang.Add(produk);
            MessageBox.Show($"{produk.Nama} berhasil ditambahkan ke keranjang!",
                "Produk Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowProduk(string jenisProduk)
        {
            FLPproduk.Controls.Clear();

            DataTable dtProduk = jenisProduk == "pupuk"
                ? produkContext.LihatPupuk()
                : produkContext.LihatPestisida();

            string imagePath = jenisProduk == "pupuk" ? PupukImagePath : PestisidaImagePath;

            List<Produk> produkList = new List<Produk>();
            foreach (DataRow row in dtProduk.Rows)
            {
                try
                {
                    Produk produkItem = new Produk
                    {
                        Nama = row.Table.Columns.Contains("Nama_pupuk") ? row["Nama_pupuk"].ToString() :
                               (row.Table.Columns.Contains("Nama_Pestisida") ? row["Nama_Pestisida"].ToString() : ""),
                        Dosis = row.Table.Columns.Contains("Dosis") && row["Dosis"] != DBNull.Value ? Convert.ToInt32(row["Dosis"]) : 0,
                        Harga = row.Table.Columns.Contains("Harga") && row["Harga"] != DBNull.Value ? Convert.ToDecimal(row["Harga"]) : 0,
                        Jenis = jenisProduk
                    };
                    produkList.Add(produkItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var produk in produkList)
            {
                var card = new cardproduk();
                card.SetData(produk);

                // Set image for the card's PictureBox
                if (File.Exists(imagePath))
                    card.SetImage(Image.FromFile(imagePath));
                else
                    card.SetImage(null); // Or set a default image

                card.TambahClicked += CardProduk_TambahClicked;
                card.Margin = new Padding(10);
                card.Width = 278;
                card.Padding = new Padding(10);

                FLPproduk.Controls.Add(card);
            }

            this.Text = $"PUSPITA - Shop ({produkList.Count} produk {jenisProduk})";
            FLPproduk.BringToFront();
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            BtnPestisida.Visible = true;
            BtnPupuk.Visible = false;
            ShowProduk("pupuk");
            FLPproduk.BringToFront();
        }


        private void BtnPestisida_Click_1(object sender, EventArgs e)
        {
            BtnPestisida.Visible = false;
            BtnPupuk.Visible = true;
            ShowProduk("pestisida");
            FLPproduk.BringToFront();
        }
    }
}
