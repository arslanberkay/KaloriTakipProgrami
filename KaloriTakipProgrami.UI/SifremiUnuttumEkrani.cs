using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Helpers;
using KaloriTakipProgrami.UI.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipProgrami.UI
{
    public partial class SifremiUnuttumEkrani : Form
    {
        private readonly KaloriTakipDbContext _db;
        public SifremiUnuttumEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
        }

        Random rnd = new Random();
        int sifirlamaKodu;

        Kullanici sifresiniUnutanKullanici;
        private void btnSifirlamaKoduGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Lütfen sistemde kayıtlı email adresinizi giriniz.");
                return;
            }
            if (_db.Kullanicilar.Any(k => k.Email == txtEmail.Text))
            {
                sifresiniUnutanKullanici = _db.Kullanicilar.FirstOrDefault(k => k.Email == txtEmail.Text);
                sifirlamaKodu = rnd.Next(1000, 9999);
                MailGonder(sifirlamaKodu);
            }
            else
            {
                MessageBox.Show("Programa kayıtlı mail hesabı bulunamadı");
            }
        }
        private void MailGonder(int sifirlamaKodu)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("takipdiyet11@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Şifre Sıfırlama Kodu";
                mail.Body = "4 haneli şifre sıfırlama kodunuz : " + sifirlamaKodu;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("takipdiyet11@gmail.com", "kcuwngsujwclsatp");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail gönderme işlemi başarıyla sonuçlandı.");
                grpSifirlamaKoduGonder.Visible = false;
                grpSifirlamaKodu.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtSifirlamaKodu.Text))
            {
                MessageBox.Show("Lütfen mailinize gelen sıfırlama kodunu giriniz");
            }
            if (mtxtSifirlamaKodu.Text == sifirlamaKodu.ToString())
            {
                grpSifirlamaKodu.Visible = false;
                grpSifreGuncelleme.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen sıfırlama kodunu kontrol ederek tekrar giriniz!");
                mtxtSifirlamaKodu.Text = string.Empty;
                return;
            }
            lblKullaniciAdi.Text = sifresiniUnutanKullanici.KullaniciAdi;
        }
        private void btnSifreyiGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text))
            {
                MessageBox.Show("Yeni şifre alanları boş bırakılamaz");
                return;
            }
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                sifresiniUnutanKullanici.Sifre = SifrelemeHelper.Sha256Hash(txtYeniSifre.Text);
                _db.SaveChanges();
                MessageBox.Show("Şifre güncellemesi başarıyla gerçekleşti");
                KullaniciGirisEkrani kullaniciGirisEkrani = new KullaniciGirisEkrani();
                kullaniciGirisEkrani.Show();
            }
            else
            {
                MessageBox.Show("Yeni şifre ile yeni şifre tekrar uyuşmazlığı oluştu.");
            }
        }
        private void SifremiUnuttumEkrani_Load(object sender, EventArgs e)
        {
            grpSifirlamaKodu.Visible = false;
            grpSifreGuncelleme.Visible = false;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
