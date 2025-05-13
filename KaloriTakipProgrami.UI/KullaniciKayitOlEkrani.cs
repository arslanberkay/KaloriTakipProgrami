using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciKayitOlEkrani : Form
    {

        //todo: şifre hash olacak yapılmadı





        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        public KullaniciKayitOlEkrani()
        {
            InitializeComponent();
            cbCinsiyet.Items.Add("Erkek");
            cbCinsiyet.Items.Add("Kız");




        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı adını boş geçmeyiniz");
                return;
            }
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();//boşlukları silsin diye koyuldu.

            {
                bool kullaniciVarMi = _db.Kullanicilar.Any(k => k.KullaniciAdi.ToLower() == kullaniciAdi.ToLower());

                if (kullaniciVarMi)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                    txtKullaniciAdi.Text = "";
                    return;
                }
            }//üst satırlarda databaseimizde kullanıcı adları aynı olan var mı onun kontrolü yapıldı.





            //burada ise kullaniciyi kaydettik



            /* ************************şifre kısmı ****************************** */

            if (string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                MessageBox.Show("Lütfen şifre alanlarını boş bırakmayınız");
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                return;


            }
            if (!Regex.IsMatch(txtSifre.Text, @"^(?=.*\d).+$"))
            {
                MessageBox.Show("Şifre en az bir rakam içermelidir!");
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                return;

            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler aynı değildir");
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                return;

            }
            /////////////////////////////  Ad ,Soyad kısmı//////////////////////////////

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad kısmını boş geçmeyiniz");
                txtAd.Text = "";
                txtSoyad.Text = "";

                return;

            }
            if (Regex.IsMatch(txtAd.Text, @"\d") || Regex.IsMatch(txtSoyad.Text, @"\d"))
            {
                MessageBox.Show("Ad ve soyad sayı içeremez");
                txtAd.Text = "";
                txtSoyad.Text = "";
                return;
            }
            ///////////////////////doğum tarihi kısmı/////////////////////

            if (dtpDogumTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("Girdiğiniz tarih geçersiz");
                return;

            }
            ///////e mail kısmı/////
            if (!txtMail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Lütfen gmail giriniz");
                txtMail.Text = "";
                return;
            }
            /////////cinsiyet kısmı////////  

            if (cbCinsiyet.SelectedIndex == null)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz");
                return;
            }
            /////fotoğraf kısmı/////
            Kullanici kullanici = new Kullanici()
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Isim = txtAd.Text,
                Soyisim = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Email = txtMail.Text,
                Cinsiyet = cbCinsiyet.SelectedItem.ToString(),
                FotografYolu = txtFotograf.Text,
            };
            bool emailvarMi = _db.Kullanicilar.Any(k => k.Email == txtMail.Text);

            if (emailvarMi)
            {
                MessageBox.Show("Bu E-mail kullanılıyor");
                txtMail.Text = "";
                return;
            }




            _db.Add(kullanici);
            _db.SaveChanges();
            MessageBox.Show("Kullanıcı Bşarıyla eklendi");
            Temizle();

            KullaniciEkrani kullaniciEkrani = new KullaniciEkrani();
            kullaniciEkrani.ShowDialog();



        }

        private void btnFotografSec_Click(object sender, EventArgs e)
        {

            FotografEkle();
        }

        private void FotografEkle()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fotoğraf Seç";
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFotograf.Text = ofd.FileName; // Dosya yolunu TextBox'a yaz
            }
            pbFotograf.ImageLocation = ofd.FileName;
        }
        private void Temizle()
        {
            txtAd.Text = txtFotograf.Text = txtKullaniciAdi.Text = txtMail.Text =
                txtSifre.Text = txtSifreTekrar.Text = txtSoyad.Text = string.Empty;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Şifreyi göster
                txtSifre.PasswordChar = '\0';
                txtSifreTekrar.PasswordChar = '\0';

            }
            else
            {
                // Şifreyi gizle
                txtSifre.PasswordChar = '*';
                txtSifreTekrar.PasswordChar = '*'; // veya istediğin başka bir karakter
            }
        }
    }
}
