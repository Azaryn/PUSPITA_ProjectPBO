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
    public partial class History_Transaksi_Admin : Form
    {
        HistoryAdminContext HAContext = new HistoryAdminContext();
        public History_Transaksi_Admin()
        {
            InitializeComponent();
        }

        private void History_Transaksi_Admin_Load(object sender, EventArgs e)
        {
            DataTable dt = HAContext.AmbilHistory();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVHistory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tidak Ada History Transaksi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Admin Dadmin = new Dashboard_Admin();
            Dadmin.Show();
        }
    }
}
