using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    public class PenampungKeranjang
    {
        public Produk produk { get; set; }
        public int Jumlah { get; set; }
        public static List<PenampungKeranjang> Daftar { get; set; } = new List<PenampungKeranjang>();

    }
}
