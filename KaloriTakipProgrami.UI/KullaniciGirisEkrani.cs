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

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciGirisEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (_db.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text && y.Sifre == txtSifre.Text)) //Databasede girilen kullanıcı adı ve şifreye ait bir yönetici kaydı varsa
            {
                YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();
                yoneticiEkrani.Show();
            }
            else if (_db.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text)) //Databasede girilen kullanıcı adı şifreye ait bir kullanıcı kaydı varsa 
            {
                var girisYapanKullanici = _db.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text);
                if(girisYapanKullanici.Durum==false)
                {
                    girisYapanKullanici.Durum = true; //Hesap aktif hale getirildi
                    _db.SaveChanges(); //Değişiklikleri kaydet
                    MessageBox.Show("Hesabınız aktif hale gelmiştir ,Tekrar hoşgeldiniz sizi görmek güzel :)");
                }
               
                KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(girisYapanKullanici);
                kullaniciEkrani.Show(); //Kullanıcı ekranına geç
            }
            Hata();

        }
        public void Hata()
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;



            }
            if (!_db.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text && y.Sifre == txtSifre.Text)) //Databasede girilen kullanıcı adı ve şifreye ait bir yönetici kaydı varsa
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre lütfen tekrar deneyiniz.");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }
            else if (!_db.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text)) //Databasede girilen kullanıcı adı şifreye ait bir kullanıcı kaydı varsa 
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                return;
            }


        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                // Şifreyi göster
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                // Şifreyi gizle
                txtSifre.PasswordChar = '*'; // veya istediğin başka bir karakter
            }
        }
    }




}
