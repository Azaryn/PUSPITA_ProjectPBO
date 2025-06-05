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
    public partial class History_Transaksi : Form
    {
       
        private HistoryContext HContext;


        public History_Transaksi()
        {
            InitializeComponent();
            int idPetani = UserContext.IdPetani; 
            HContext = new HistoryContext(idPetani);
            History_Transaksi_Load(this, EventArgs.Empty);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Petani Dpetani = new Dashboard_Petani();
            Dpetani.Show();
        }

        private void History_Transaksi_Load(object sender, EventArgs e)
        {
            DataTable dt = HContext.AmbilHistory();
            if (dt != null && dt.Rows.Count > 0)
            {
                DGVHistory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tidak Ada History Transaksi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
