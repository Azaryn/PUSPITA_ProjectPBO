using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSPITA.Model
{
    class Pupuk
    {
        public int ID_Pupuk { get; set; }
        public string Nama_Pupuk { get; set; }
        public int ID_JenisPupuk { get; set; }
        public int stock { get; set; }
        public float Harga { get; set; }

    }
}
