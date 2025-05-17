using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciBilgiGuncelleEkrani : Form
    {
        private readonly KaloriTakipDbContext _context;
        private Kullanici GirisYapanKullanici;

        private KullaniciEkrani ekran;
        KullaniciDetay detay = new KullaniciDetay();   //yeni eklenen boy kilo değişimi görebilmek için nesne oluşturucaz 
        public List<string> Cinsiyetler { get; set; } = new List<string> { "Erkek", "Kadın" };
        public KullaniciBilgiGuncelleEkrani(KullaniciEkrani Ekran, Kullanici girisYapanKullanici)
        {
            ekran = Ekran;//geriye basınca diğer form doldurabilmek için 
            _context = new KaloriTakipDbContext();
            girisYapanKullanici = _context.Kullanicilar.FirstOrDefault(aaa => aaa.Id == 1);
            GirisYapanKullanici = girisYapanKullanici; //kullanıcı eşlemesi yapacak
            InitializeComponent();
           
        }
        private void KullaniciBilgileri()
        {
          
            var kullanici = _context.Kullanicilar
       .Include(k => k.KullaniciDetaylari)
       .FirstOrDefault(k => k.Id == GirisYapanKullanici.Id);

            if (kullanici == null) return;

            // Ana kullanıcı bilgileri
            txtAd.Text = kullanici.Isim;
            txtSoyad.Text = kullanici.Soyisim;
            txtEposta.Text = kullanici.Email;
            cmbCinsiyet.Text = kullanici.Cinsiyet;
            dtpDogumTarihi.Value = kullanici.DogumTarihi;
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            lblKullaniciAdi.Text = "KULLANICI ADI : " + kullanici.KullaniciAdi;
            pbFoto.Text = kullanici.FotografYolu;

            // Son kullanıcı detayı
            var detay = kullanici.KullaniciDetaylari?
                .OrderBy(k => k.Tarih)
                .LastOrDefault();

            if (detay?.Kilo == null && detay?.Boy != null)
            {
                txtKilo.Text = "--";
                lblVki.Text = "--";
                txtBoy.Text = detay.Boy.ToString();
            }
            else if (detay?.Boy == null && detay?.Kilo != null)
            {
                txtBoy.Text = "--";
                lblVki.Text = "--";
                txtKilo.Text = detay.Kilo.ToString();
            }
            else if (detay?.Boy == null && detay?.Kilo == null)
            {
                txtKilo.Text = "--";
                lblVki.Text = "--";
                txtBoy.Text = "--";
            }
            else
            {
                txtKilo.Text = detay.Kilo.ToString();
                txtBoy.Text = detay.Boy.ToString();
                lblVki.Text = Vki().ToString("0.00");
            }
        }
        
        private float Vki()
        {
            float.TryParse(txtKilo.Text, out float kilo);  //kg cinsinden
            float.TryParse(txtBoy.Text, out float boy);  //m cinsinden

            return kilo / (boy * boy);
        }
        private void KullaniciBilgiGuncelleEkrani_Load(object sender, EventArgs e)
        {
            KullaniciBilgileri();
        }
        private void btnBilgilendirme_MouseEnter(object sender, EventArgs e)
        {
            // butonun üstüne geldiğinde orada vki ile ilgili bilgilendirme mesajı çıkacak
            Form customMsgBox = new Form();
            customMsgBox.Text = "VKİ Bilgilendirme";
            customMsgBox.BackColor = Color.FromArgb(164, 172, 134); // Arka plan rengini buton renginde yaptım
            customMsgBox.StartPosition = FormStartPosition.CenterScreen;
            customMsgBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            customMsgBox.MaximizeBox = false;
            customMsgBox.MinimizeBox = false;
            customMsgBox.Size = new Size(500, 300);

            Label lbl = new Label();
            lbl.Text =
                       "18.5 kg/m²'nin altında ise   =>   ZAYIF\n" +
                       "18.5 - 24.9 kg/m² arasında   =>   NORMAL KİLOLU\n" +
                       "25 - 29.9 kg/m² arasında     =>   HAFİF ŞİŞMAN\n" +
                       "30 - 34.9 kg/m² arasında     =>   ORTA DERECE (I)\n" +
                       "35 - 39.9 kg/m² arasında     =>   AĞIR DERECE (II)\n" +
                       "40 kg/m²'nin üstü            =>   ÇOK AĞIR (III)";
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(20, 20);

            Button btnOK = new Button();
            btnOK.Text = "Tamam";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(customMsgBox.Width / 2 - 40, customMsgBox.Height - 70);

            customMsgBox.Controls.Add(lbl);
            customMsgBox.Controls.Add(btnOK);
            customMsgBox.AcceptButton = btnOK;

            customMsgBox.ShowDialog();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Adınız boş olamaz", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                MessageBox.Show("Mailiniz boş olamaz.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Soyadınız boş olamaz", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifreniz boş olamaz", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                MessageBox.Show("Cinsiyetiniz boş olamaz", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpDogumTarihi.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Doğum tarihiniz geçerli değil", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSifre.Text.Length < 4 || txtSifre.Text.Length > 12)
            {
                MessageBox.Show("Şifre 4-12 karakter arasında olmalıdır", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtKilo.Text, out float kilo) || kilo < 0)
            {
                MessageBox.Show("Kilo geçersiz, kilogram cinsinden yazdığınıza emin olun", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtBoy.Text, out float boy) || boy < 0 || boy > 3)
            {
                MessageBox.Show("Boy geçersiz,metre cinsinden yazdığınıza emin olun", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(txtEposta.Text.EndsWith("@gmail.com") || txtEposta.Text.EndsWith("@hotmail.com")))
            {
                MessageBox.Show(" E-posta adresinizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!ValidateInputs())
                    return;

                // Giriş yapan kullanıcıyı context'ten çek (yeni context'e ait hale getir)
                GirisYapanKullanici = _context.Kullanicilar
                    .Include(k => k.KullaniciDetaylari)
                    .FirstOrDefault(k => k.Id == GirisYapanKullanici.Id);

                GirisYapanKullanici.Isim = txtAd.Text;
                GirisYapanKullanici.Soyisim = txtSoyad.Text;
                GirisYapanKullanici.Email = txtEposta.Text;
                GirisYapanKullanici.Cinsiyet = cmbCinsiyet.Text;
                GirisYapanKullanici.DogumTarihi = dtpDogumTarihi.Value;
                GirisYapanKullanici.Sifre = txtSifre.Text;
                GirisYapanKullanici.Durum = true;

              
             
                if (!decimal.TryParse(txtKilo.Text, out decimal kilo))
                { MessageBox.Show("Lütfen kilonuzu kontrol ediniz");
                    return;
                }
                if(!decimal.TryParse(txtBoy.Text, out decimal boy))
                { MessageBox.Show("Lütfen boyunuzu kontrol ediniz");
                    return;
                }
                detay.Kilo = kilo;
                detay.Boy = boy;

                detay.KullaniciId = GirisYapanKullanici.Id;

                _context.KullaniciDetaylari.Add(detay);
                _context.SaveChanges(); // GirisYapanKullanici değişikliklerini de otomatik yakalar

                MessageBox.Show("Bilgileriniz güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            KullaniciBilgileri();
        }
        private void btnHesapDondur_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                "Hesabınızı dondurmak istediğinize emin misiniz?", // Mesaj
                "Onay",                                            // Başlık
                MessageBoxButtons.YesNo,                           // Yes/No seçenekleri
                MessageBoxIcon.Question);                          // Soru simgesi

                if (result == DialogResult.Yes)
                {
                    GirisYapanKullanici.Durum = false;
                    _context.Kullanicilar.Update(GirisYapanKullanici);
                    _context.SaveChanges();
                    MessageBox.Show("Hesabınız donduruldu,Tekrar giriş yaptığınızda hesabınız aktif hale gelecektir.Tekrar Beklerizz :)", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciGirisEkrani kullaniciGirisEkrani = new KullaniciGirisEkrani();
                    kullaniciGirisEkrani.Show();
                }
                else
                {
                    // Kullanıcı 'No' tıkladıysa, işlem iptal edilir
                    MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbCinsiyet_Click(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Cinsiyetler;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            ekran.GeriDonunceYenile();// bu sayede yenilenen bilgi diğer sayfaya geçişte yansıyor
            ekran.Show();
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
