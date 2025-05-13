using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class Talep
    {
        public int Id { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public string Durum { get; set; } //Bekliyor, onaylandı, reddedildi vb.

        public int KullaniciId { get; set; } //Foreign
        public Kullanici Kullanici { get; set; } // 1 talep 1 kullanıcıya aittir 



    }
}
