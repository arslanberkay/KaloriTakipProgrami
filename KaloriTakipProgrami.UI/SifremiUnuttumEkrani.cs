using KaloriTakipProgrami.UI.Context;
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
            if (_db.Kullanicilar.Any(k => k.Email == txtEmail.Text))
            {
                sifresiniUnutanKullanici = _db.Kullanicilar.FirstOrDefault(k => k.Email == txtEmail.Text);
                sifirlamaKodu = rnd.Next(1000, 9999);
                MailGonder(sifirlamaKodu);
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
            if (mtxtSifirlamaKodu.Text == sifirlamaKodu.ToString())
            {
                grpSifirlamaKodu.Visible = false;
                grpSifreGuncelleme.Visible = true;
            }
        }

        private void btnSifreyiGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                sifresiniUnutanKullanici.Sifre = txtYeniSifre.Text;
                _db.SaveChanges();
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
