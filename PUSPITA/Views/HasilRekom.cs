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
    public partial class HasilRekom : Form
    {
        public HasilRekom()
        {
            InitializeComponent();
        }
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HasilRekom_Load(object sender, EventArgs e)
        {
            RekomPupuk.Text = $"Anda sedang menanam {PenampungHasilRekom.JenisTanaman} cocok menggunakan pupuk kompos atau pupuk kandang yang baik untuk memperabiki struktur tanah, selain itu dapat menggunakan urea. Tips dalam menanam gunakan pupuk organik dasar untuk meingkatkan kesuburan tanah dan gunakan anorganik untuk melengkapi kebutuhan hara tanaman";
            if (PenampungHasilRekom.BulanMenanam == "Fungsida")
            {
                RekomPestisida.Text = "Jika anda memasuki Bulan Januari - Juni cocok menggunakan Fungisida karena pada bulan tersebut Tinggi Kelembapan yang memudahkan penyakit jamur berkembang di musim hujan. Dan untuk akhiran bulan Juni siapkan Insectisida untuk beberapa hama berkembang pesat di awal musim panas. Contoh Produk Fungisida seperti Mancozeb, Propineb atau Difenokonazol";
            }
            else if (PenampungHasilRekom.BulanMenanam == "Insectisida")
            {
                RekomPestisida.Text = "Jika anda memasuki bulan juli - september cocok menggunakan Insectisida karena di musim kemarau ini populasi hama meningkat saat panas. anda bisa menggunakan Klorantraniliprol, atau sipermetrin";
            }
            else if (PenampungHasilRekom.BulanMenanam == "Herbisida")
            {
                RekomPestisida.Text = "JIka anda memasuki bulan Oktober - Desember cocok menggunakan herbisida karena gulma tumbuh cepat setelah hujan atau awal tanam, perlu dikendalikan sebelum tanaman utama tumbuh optimal. anda dapat menggunakan Oksifluorfren atau Pendimethalin";
            }
            HitungTakar.Text = $"Selain Rekomendasi Pupuk dan Pestisida anda perlu memerhatikan takaran, dengan lahan anda sebesar {PenampungHasilRekom.luas} Hektar gunakan pupuk sebanyak {PenampungHasilRekom.TakaranPupuk} kg per 2-3 musim tanam dan gunakan pestisida {PenampungHasilRekom.TakaranPestisida} Liter dengan pemakaiannya tergantung serangan hama dan tahap pertumbuhan";
        }
    }
}
