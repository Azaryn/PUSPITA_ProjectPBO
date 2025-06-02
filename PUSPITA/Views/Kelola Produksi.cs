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
    public partial class Kelola_Produksi : Form
    {
        public Kelola_Produksi()
        {
            InitializeComponent();
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            TambahProduk Tproduk = new TambahProduk();
            Tproduk.ShowDialog();
        }

        private void btnHapusProduk_Click(object sender, EventArgs e)
        {
            HapusProduk Hproduk = new HapusProduk();
            Hproduk.ShowDialog();
        }

        private void btnUpdateProduk_Click(object sender, EventArgs e)
        {
            UpdateProduk Uproduk = new UpdateProduk();
            Uproduk.ShowDialog();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Admin DAdmin = new Dashboard_Admin();
            DAdmin.Show();
        }

        private void btnLihatProduk_Click(object sender, EventArgs e)
        {
            LihatProduk LProduk = new LihatProduk();
            LProduk.ShowDialog();
        }
    }
}
