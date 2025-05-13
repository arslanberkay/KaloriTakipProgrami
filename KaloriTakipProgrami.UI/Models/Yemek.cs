using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class Yemek
    {
        public int Id { get; set; }
        public string YemekAdi { get; set; }
        public decimal Kalori { get; set; }

        public int KategoriId { get; set; } //Foreign
        public Kategori Kategori { get; set; } // 1 yemeğin 1 kategorisi olur

        public List<OgunYemek> OgunYemekler { get; set; }
    }
}
