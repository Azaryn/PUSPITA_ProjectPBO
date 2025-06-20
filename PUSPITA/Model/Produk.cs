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
        public string Kategori { get; set; }
        public int Dosis { get; set; }
        public decimal Harga { get; set; }
        public bool Discontinued { get; set; }

        public string ImageKey
        {
            get
            {
                if (Kategori != null && Kategori.ToLower().Contains("pupuk"))
                    return "imgPupuk";

                else
                    return "imgPestisida";
            }
        }

    }
}