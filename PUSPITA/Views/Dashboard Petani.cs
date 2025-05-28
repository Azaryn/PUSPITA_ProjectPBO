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
    public partial class Dashboard_Petani : Form
    {
        public Dashboard_Petani()
        {
            InitializeComponent();
        }

        private void btnPuspitaShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop_Pupuk puspitaShop = new Shop_Pupuk();
            puspitaShop.Show();
        }

        private void btnRekomendasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rekomendasi rekomendasi = new Rekomendasi();
            rekomendasi.Show();
        }

        private void btnHistoryTransaski_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Transaksi_cs historyTransaksi = new History_Transaksi_cs();
            historyTransaksi.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();   
        }
    }
}