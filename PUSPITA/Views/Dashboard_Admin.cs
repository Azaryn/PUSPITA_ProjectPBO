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
    public partial class Dashboard_Admin : Form
    {
        public Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void btnKelolaProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Produksi kelolaProduk = new Kelola_Produksi();
            kelolaProduk.Show();
        }

        private void btnLogoutDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin Ladmin = new LoginAdmin();
            Ladmin.Show();
        }

        private void btnHistoryTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Transaksi_Admin History = new History_Transaksi_Admin();
            History.Show();
        }
    }
}
