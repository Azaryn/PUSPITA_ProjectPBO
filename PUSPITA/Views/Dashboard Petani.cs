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
    public partial class Dashboard_Petani : Form
    {
        private int _idPetani;
        public Dashboard_Petani()
        {
            InitializeComponent();
            Users.id_petani = _idPetani;
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
            History_Transaksi historyTransaksi = new History_Transaksi(_idPetani);
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