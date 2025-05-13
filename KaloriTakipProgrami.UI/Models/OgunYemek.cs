using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class OgunYemek //Ara tablo : 1 öğünde BİRDEN FAZLA yemek olabilir. 1 yemekte BİRDEN FAZLA öğünde yenebilir.
    {
        public int Id { get; set; }
        public decimal Miktar { get; set; } //Ne kadar yedi
        public DateTime Tarih { get; set; } = DateTime.Now; //Girilmezse o anı alır ama ekstradan tarih seçme verilecek

        public int OgunId { get; set; } //Foreign
        public Ogun Ogun { get; set; }

        public int YemekId { get; set; } //Foreign
        public Yemek Yemek { get; set; }

        public int KullaniciId { get; set; } //Foreign
        public Kullanici Kullanici { get; set; }

    }
}
