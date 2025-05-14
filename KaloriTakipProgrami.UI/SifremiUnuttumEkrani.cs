using KaloriTakipProgrami.UI.Context;
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

        private void btnSifirlamaKoduGonder_Click(object sender, EventArgs e)
        {
            if (_db.Kullanicilar.Any(k => k.Email == txtEmail.Text))
            {
                int kod = rnd.Next(1000, 9999);
                MailGonder(kod);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
