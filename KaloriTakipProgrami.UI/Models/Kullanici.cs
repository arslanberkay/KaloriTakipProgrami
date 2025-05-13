using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public string Cinsiyet { get; set; }
        public string FotografYolu { get; set; } //String olarak tutucaz (picturebox'da göstericez)
        public bool Durum { get; set; } //Hesap dondurulmuş mu bilgisi (Aktif / Pasif)
        public DateTime KayitTarihi { get; set; } = DateTime.Now; //Otomatik o anın tarihini alır

        public List<KullaniciDetay> KulllaniciDetaylari { get; set; } //1 kullanıcının BİRDEN FAZLA kullanıcıdetayi olabilir (Değişen boy kilo yeni bir kullanıcıdetay olarak kabul edilir.)

        public List<Talep> Talepler { get; set; } // 1 kullanıcının BİRDEN FAZLA talebi olabilir. (Ör : Ispanak yemeklerde yok) (Ör : Tam buğday ekmeğinin kalorisi yanlış)

        public List<OgunYemek> OgunYemekler { get; set; } //1 kullanıcının BİRDEN FAZLA ogunyemegi olabilir.
    }
}
