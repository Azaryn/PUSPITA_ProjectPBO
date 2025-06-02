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
        private int dosisPupuk = 250;
        private decimal dosisPestisida = 1.5M;
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
            if (TbLuas != null && BulanPicker != null && rbBawang != null && rbCabai != null && rbPadi != null)
            {
                //int bulan = BulanPicker.Value.Month;
                //decimal luas = Convert.ToDecimal(TbLuas.Text);
                //int jenis = 0;
                //if (rbPadi.Checked)
                //{
                //    jenis = 1;
                //}
                //else if (rbCabai.Checked)
                //{
                //    jenis = 2;
                //}
                //else if (rbBawang.Checked)
                //{
                //    jenis = 3;
                //}
                //decimal TakaranPupuk = dosisPupuk * luas;
                //decimal TakaranPestisida = dosisPestisida * luas;
                HasilRekom hasilRekom = new HasilRekom();
                hasilRekom.ShowDialog();
            }
        }
    }
}
