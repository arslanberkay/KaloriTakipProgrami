using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriTakipProgrami.UI.Models;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciEkrani : Form
    {
        private Kullanici _girisYapanKullanici;


       
        public KullaniciEkrani()
        {
                

        }
        public KullaniciEkrani(Kullanici girisYapanKullanici)
        {
            InitializeComponent();
            // giriş yapan kullanıcın tüm bilgileri 
            _girisYapanKullanici = girisYapanKullanici;
            BilgileriYukle();
        }
        private void BilgileriYukle()
        {
            //kayıt olan kullanıcının bilgilerini profilde göstermek için

            if (_girisYapanKullanici != null)
            {
                lblKullaniciAdi.Text = _girisYapanKullanici.KullaniciAdi;
                lblAd.Text = _girisYapanKullanici.Isim;
                lblSoyad.Text = _girisYapanKullanici.Soyisim;
                lblCinsiyet.Text = _girisYapanKullanici.Cinsiyet;
                lblDogumTarihi.Text = _girisYapanKullanici.DogumTarihi.ToString();
                lblEposta.Text = _girisYapanKullanici.Email;
                lblKilo.Text = "--";
                lblBoy.Text = "--";
                lblVKİ.Text = "--";
            }
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            //bilgi büncellemeye parametre atadık
            KullaniciBilgiGuncelleEkrani kullaniciBilgiGuncelleEkrani = new KullaniciBilgiGuncelleEkrani(_girisYapanKullanici);
            kullaniciBilgiGuncelleEkrani.ShowDialog();
        }

        private void bnOgunBilgileriGoster_Click(object sender, EventArgs e)
        {
            KullaniciOgunBilgiEkrani kullaniciOgunBilgiEkrani = new KullaniciOgunBilgiEkrani();
            kullaniciOgunBilgiEkrani.ShowDialog();
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            KullaniciGunlukRaporEkrani kullaniciGunlukRaporEkrani = new KullaniciGunlukRaporEkrani(_girisYapanKullanici);
            kullaniciGunlukRaporEkrani.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            KullaniciRaporEkrani kullaniciRaporEkrani = new KullaniciRaporEkrani();
            kullaniciRaporEkrani.ShowDialog();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            KullaniciGrafikEkrani kullaniciGrafikEkrani = new KullaniciGrafikEkrani();
            kullaniciGrafikEkrani.ShowDialog();
        }

        private void btnTalepler_Click(object sender, EventArgs e)
        {
            
           KullaniciTaleplerEkrani kullaniciTaleplerEkrani = new KullaniciTaleplerEkrani(_girisYapanKullanici);
            kullaniciTaleplerEkrani.ShowDialog();
        }
    }
}
