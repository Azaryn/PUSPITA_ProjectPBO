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
    public partial class Rekomendasi : Form
    {
        private int dosisPupuk = 250;
        private int dosisPestisida = 250;
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
                int bulan = BulanPicker.Value.Month;
                if (bulan >=1 && bulan <= 6)
                {
                    PenampungHasilRekom.BulanMenanam = "Fungsida";
                }
                else if(bulan >= 7 && bulan <= 9)
                {
                    PenampungHasilRekom.BulanMenanam = "Herbisida";
                }
                else
                {
                    PenampungHasilRekom.BulanMenanam = "Insectisida";
                }
                PenampungHasilRekom.luas = Convert.ToDecimal(TbLuas.Text);
                if (rbPadi.Checked)
                {
                    PenampungHasilRekom.JenisTanaman = "Padi";
                }
                else if (rbCabai.Checked)
                {
                    PenampungHasilRekom.JenisTanaman = "Cabai";
                }
                else if (rbBawang.Checked)
                {
                    PenampungHasilRekom.JenisTanaman = "Bawang";
                }
                PenampungHasilRekom.TakaranPupuk = dosisPupuk * PenampungHasilRekom.luas;
                PenampungHasilRekom.TakaranPestisida = dosisPestisida * PenampungHasilRekom.luas;
                HasilRekom hasilRekom = new HasilRekom();
                hasilRekom.ShowDialog();
            }
        }
    }
}
