using KaloriTakipProgrami.UI.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using KaloriTakipProgrami.UI.Helpers;
using KaloriTakipProgrami.UI.Models;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciGirisEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        Kullanici girisYapanKullanici;
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
            TumSifreleriHashle();
        }
        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayitOlEkrani kullaniciKayitOlEkrani = new KullaniciKayitOlEkrani();
            kullaniciKayitOlEkrani.Show();
        }
        private void lnkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumEkrani sifremiUnuttumEkrani = new SifremiUnuttumEkrani();
            sifremiUnuttumEkrani.Show();
        }
        private void TumSifreleriHashle()
        {
            var kullanicilar = _db.Kullanicilar.ToList();
            foreach (var kullanici in kullanicilar)
            {
                if (!string.IsNullOrWhiteSpace(kullanici.Sifre) && kullanici.Sifre.Length != 64) // Boş değilse ve 64 karakter değilse hash'le
                {
                    string hashliSifre = SifrelemeHelper.Sha256Hash(kullanici.Sifre);
                    kullanici.Sifre = hashliSifre;
                }
            }
            var yoneticiler = _db.Yoneticiler.ToList();
            foreach (var yonetici in yoneticiler)
            {
                if (!string.IsNullOrWhiteSpace(yonetici.Sifre) && yonetici.Sifre.Length != 64)
                {
                    string hashliSifre = SifrelemeHelper.Sha256Hash(yonetici.Sifre);
                    yonetici.Sifre = hashliSifre;
                }
            }
            _db.SaveChanges();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
            string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

            if (_db.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text && y.Sifre == hashliSifre)) //Databasede girilen kullanıcı adı ve şifreye ait bir yönetici kaydı varsa
            {
                HataYonetici();  //Yanlış giriş yapıldığında hata mesajı gösterilecek form açılmadan önce yapımalı
                YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();
                yoneticiEkrani.Show();
            }
            else if (_db.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == hashliSifre)) //Databasede girilen kullanıcı adı şifreye ait bir kullanıcı kaydı varsa 
            {
                girisYapanKullanici = _db.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text);
                if (girisYapanKullanici.Durum == false)
                {
                    girisYapanKullanici.Durum = true; //Hesap aktif hale getirildi
                    _db.SaveChanges(); //Değişiklikleri kaydet
                    MessageBox.Show("Hesabınız aktif hale gelmiştir ,Tekrar hoşgeldiniz sizi görmek güzel :)");
                }
                HataUye();
                KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(girisYapanKullanici);
                kullaniciEkrani.Show(); //Kullanıcı ekranına geç
            }
            Temizle();
        }
        public void HataYonetici()
        {
            string sifre = txtSifre.Text;
            string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }
            if (!_db.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text && y.Sifre == hashliSifre)) //Databasede girilen kullanıcı adı ve şifreye ait bir yönetici kaydı varsa
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre lütfen tekrar deneyiniz.");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }
        }
        public void HataUye()
        {
            string sifre = txtSifre.Text;
            string hashliSifre = SifrelemeHelper.Sha256Hash(sifre);

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }
            if (!_db.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == hashliSifre)) //Databasede girilen kullanıcı adı şifreye ait bir kullanıcı kaydı varsa 
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }
        }
        private void Temizle() 
        {
            txtKullaniciAdi.Text=txtSifre.Text=string.Empty;
        }
        private void ButonlarTrue()
        {
            btnSifreGoster.Visible = false;
            btnSifreGizle.Visible = true;
        }
        private void Butonlarfalse()
        {
            btnSifreGoster.Visible = true;
            btnSifreGizle.Visible = false;
        }
        private void btnSifreGizle_Click(object sender, EventArgs e)
        {
            Butonlarfalse();
            txtSifre.PasswordChar = '\0';
        }
        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            ButonlarTrue();
            txtSifre.PasswordChar = '*';
        }      
    }  

}
