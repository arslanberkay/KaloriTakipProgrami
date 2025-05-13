using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class KullaniciDetay
    {
        public int Id { get; set; }
        public decimal Boy { get; set; }
        public decimal Kilo { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now; //Otomatik o anın tarihini alır 

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; } //Bir kullanıcıdetay bir kullanıcıya aittir.
    }
}
