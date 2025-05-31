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
            this.Hide();
            Tambah_Pupuk Tpupuk = new Tambah_Pupuk();
            Tpupuk.Show();
        }

        private void btnHapusProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hapus_Pupuk Hpupuk = new Hapus_Pupuk();
            Hpupuk.Show();
        }

        private void btnUpdateProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePupuk Upupuk = new UpdatePupuk();
            Upupuk.Show();
        }
    }
}
