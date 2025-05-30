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
    public partial class Rekomendasi : Form
    {
        public Rekomendasi()
        {
            InitializeComponent();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Petani DPetani = new Dashboard_Petani();
            DPetani.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
