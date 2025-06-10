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

        public Shop()
        {
            InitializeComponent();

            // Setup FLPproduk panel for product cards
            FLPproduk.AutoScroll = true;
            FLPproduk.WrapContents = true;
            FLPproduk.FlowDirection = FlowDirection.LeftToRight;
            FLPproduk.Padding = new Padding(10);
            FLPproduk.Margin = new Padding(0);

            ShowProduk("pupuk");

        }

        private void CardProduk_TambahClicked(object sender, Produk produk)
        {
            //keranjang.Add(produk);
            var Ada = PenampungKeranjang.Daftar.FirstOrDefault(p => p.produk.Nama == produk.Nama);
            if (Ada != null)
            {
                Ada.Jumlah++;
            }
            else
            {
                PenampungKeranjang.Daftar.Add(new PenampungKeranjang{produk = produk, Jumlah = 1});
            }
            MessageBox.Show($"{produk.Nama} berhasil ditambahkan ke keranjang!",
                "Produk Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowProduk(string jenisProduk)
        {
            FLPproduk.SuspendLayout();

            FLPproduk.Controls.Clear();

            DataTable dtProduk = jenisProduk == "pupuk"
                ? produkContext.LihatPupuk()
                : produkContext.LihatPestisida();

            List<Produk> produkList = new List<Produk>();

            foreach (DataRow row in dtProduk.Rows)
            {
                try
                {
                    Produk produkItem = new Produk
                    {
                        Nama = row.Table.Columns.Contains("nama_produk") ? row["nama_produk"].ToString() : "",
                        Dosis = row.Table.Columns.Contains("Dosis") && row["Dosis"] != DBNull.Value ? Convert.ToInt32(row["Dosis"]) : 0,
                        Harga = row.Table.Columns.Contains("Harga") && row["Harga"] != DBNull.Value ? Convert.ToDecimal(row["Harga"]) : 0,
                        Jenis = jenisProduk
                    };

                    // Pastikan produkItem tidak kosong
                    if (!string.IsNullOrEmpty(produkItem.Nama))
                    {
                        produkList.Add(produkItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
            foreach (Control card in FLPproduk.Controls)
            {
                if (card is cardproduk cp)
                {
                    cp.DebugLabelVisibility();
                }
            }

            // Menampilkan produk
            foreach (var produk in produkList)
            {

                var card = new cardproduk();
                card.Width = 278;
                card.Margin = new Padding(10);
                card.Padding = new Padding(10);

                card.SetData(produk);

                Image image = produk.Jenis == "pupuk" ? Properties.Resources.gmbrPupuk
                    : Properties.Resources.gmbrpestisida;
                card.SetImage(image);

                card.TambahClicked += CardProduk_TambahClicked;
                card.Margin = new Padding(10);
                card.Width = 278;
                card.Padding = new Padding(10);

                FLPproduk.Controls.Add(card);
            }
            FLPproduk.ResumeLayout(true);
            FLPproduk.Refresh();
            this.Text = $"PUSPITA - Shop ({produkList.Count} produk {jenisProduk})";
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            BtnPestisida.Visible = true;
            BtnPupuk.Visible = false;
            ShowProduk("pupuk");
            //FLPproduk.BringToFront();
        }


        private void BtnPestisida_Click_1(object sender, EventArgs e)
        {
            BtnPestisida.Visible = false;
            BtnPupuk.Visible = true;
            ShowProduk("pestisida");
            //FLPproduk.BringToFront();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            PenampungKeranjang.Daftar.Clear();
            Dashboard_Petani Dpetani = new Dashboard_Petani();
            Dpetani.Show();
        }

        private void BtnKeranjang_Click(object sender, EventArgs e)
        {
            this.Close();
            Keranjang keranjangForm = new Keranjang();
            keranjangForm.Show();
        }

    }
}
