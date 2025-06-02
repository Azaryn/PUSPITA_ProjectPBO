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
    public partial class LihatProduk : Form
    {
        ProdukContext produkContext = new ProdukContext();
        public LihatProduk()
        {
            InitializeComponent();
            BtnPupuk.Visible = true;
        }

        private void BtnPestisida_Click(object sender, EventArgs e)
        {
            Header.Text = "Daftar Pupuk";
            BtnPestisida.Visible = false;
            BtnPupuk.Visible = true;
            LoadPupuk();
        }

        private void BtnPupuk_Click(object sender, EventArgs e)
        {
            Header.Text = "Daftar Pestisida";
            BtnPupuk.Visible = false;
            BtnPestisida.Visible = true;
            LoadPestisida();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LihatProduk_Load(object sender, EventArgs e)
        {
            LoadPupuk();
        }
        private void LoadPupuk()
        {
            DataTable dt = produkContext.LihatPupuk();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVProduk.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tidak ada data produk yang tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadPestisida()
        {
            DataTable dt = produkContext.LihatPestisida();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVProduk.DataSource = dt;
            }
        }
    }
}
