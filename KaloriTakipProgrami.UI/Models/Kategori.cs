using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; } //Çorbalar,tatlılar,ana yemekler 

        public List<Yemek> Yemekler { get; set; } // 1 kategoride BİRDEN FAZLA yemek olabilir.
    }
}
