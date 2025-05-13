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
                KullaniciEkrani kullaniciEkrani = new KullaniciEkrani();
                kullaniciEkrani.Show(); //Kullanıcı ekranına geç
            }


        }
    }
}
