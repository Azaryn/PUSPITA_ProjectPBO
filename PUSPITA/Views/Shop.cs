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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void BtnPestisida_Click(object sender, EventArgs e)
        {
            BtnPestisida.Visible = false;
            BtnPupuk.Visible = true;
            DaftarProduk("pestisida");
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            BtnPestisida.Visible = true;
            BtnPupuk.Visible = false;
            DaftarProduk("pupuk");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_Petani DPetani = new Dashboard_Petani();
            DPetani.Show();
        }

        private void BtnKeranjang_Click(object sender, EventArgs e)
        {
            this.Close();
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            DaftarProduk("pupuk");
        }
        private void DaftarProduk(string produk)
        {
            FLPproduk.Controls.Clear();

            ProdukContext PContext = new ProdukContext();
            DataTable dtProduk;

            if (produk == "pupuk")
            {
                dtProduk = PContext.LihatPupuk();
            }
            else if (produk == "pestisida")
            {
                dtProduk = PContext.LihatPestisida();
            }

            //foreach (DataRow baris in dtProduk.Rows)
            //{

            //}
        }
    }
}
