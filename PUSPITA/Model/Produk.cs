using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    public class Produk
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Jenis { get; set; }
        public int Dosis { get; set; }
        public decimal Harga { get; set; }
        public bool Discontinued { get; set; }

        // Kunci resource image berdasarkan jenis produk
        public string ImageKey
        {
            get
            {
                // Cek apakah jenis mengandung kata "pupuk" (case insensitive)
                if (Jenis != null && Jenis.ToLower().Contains("pupuk"))
                    return "imgPupuk";
                // Untuk jenis pestisida (Insektisida, Herbisida, Fungisida)
                else
                    return "imgPestisida";
            }
        }

    }
}