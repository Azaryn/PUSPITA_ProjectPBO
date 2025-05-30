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
    public partial class Hapus_Pupuk : Form
    {
        public Hapus_Pupuk()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            try
            {
                int IDPupuk = Convert.ToInt32(tbIDPupuk.Text);
                PupukContext pupukContext = new PupukContext();
                bool benar = pupukContext.HapusPupuk(IDPupuk);
                if (benar)
                {
                    MessageBox.Show("Pupuk Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Kelola_Produksi Kproduksi = new Kelola_Produksi();
                    Kproduksi.Show();
                }
                else
                {
                    MessageBox.Show("Pupuk Gagal DIhapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terdapat Kesalahan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Produksi Kproduksi = new Kelola_Produksi();
            Kproduksi.Show();
        }
    }
}
