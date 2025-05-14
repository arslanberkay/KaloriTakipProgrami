using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciBilgiGuncelleEkrani : Form
    {
        private readonly KaloriTakipDbContext _context;
        private Kullanici GirisYapanKullanici;
        public List<string> Cinsiyetler { get; set; } = new List<string> { "Erkek", "Kadın" };
        public KullaniciBilgiGuncelleEkrani()
        {
            InitializeComponent();
            _context = new KaloriTakipDbContext();
        }
        private void KullaniciBilgileri()
        {
            txtAd.Text = GirisYapanKullanici.Isim;
            txtSoyad.Text = GirisYapanKullanici.Soyisim;
            txtEposta.Text = GirisYapanKullanici.Email;
            cmbCinsiyet.Text = GirisYapanKullanici.Cinsiyet;
            dtpDogumTarihi.Value = GirisYapanKullanici.DogumTarihi;
            txtSifre.Text = GirisYapanKullanici.Sifre;
            txtSifreTekrar.Text = GirisYapanKullanici.Sifre;
            lblKullaniciAdi.Text = GirisYapanKullanici.KullaniciAdi;
            //txtKilo.Text = GirisYapanKullanici.KullaniciDetaylari.LastOrDefault().Kilo.ToString();
            //txtBoy.Text = GirisYapanKullanici.KullaniciDetaylari.LastOrDefault().Boy.ToString();
            //lblVki.Text = Vki().ToString();
            //fotoğraf yükleme ?
        }

        private float Vki()
        {
            float.TryParse(txtKilo.Text, out float kilo);  //kg cinsinden
            float.TryParse(txtBoy.Text, out float boy);  //m cinsinden

            return kilo / (boy * boy);
        }
        private void KullaniciBilgiGuncelleEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanKullanici = _context.Kullanicilar.FirstOrDefault(k => k.Id == 1);  //kullanıcı eşlemesi yapacak
            KullaniciBilgileri();
        }


        private void btnBilgilendirme_MouseEnter(object sender, EventArgs e)
        {
            // butonun üstüne geldiğinde orada vki ile ilgili bilgilendirme mesajı çıkacak
            MessageBox.Show("18.5 kg/m2 'nin altında ise\t\tZayıf\r\n18.5 - 24.9 kg/m2 'nin arasında ise\tNormal Kilolu\r\n25 - 29.9 kg/m2 'nin arasında ise\tHafif şişman (fazla kilolu)\r\n30 - 34.9 kg/m2 'nin arasında ise\tOrta derecede şişman (I. Derece)\r\n35 - 39.9 kg/m2 'nin arasında ise\tAğır derecede şişman (II. Derece)\r\n40 kg/m2 'nin üzerinde ise\tÇok ağır derecede şişman (III.Derece)");
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

            if (!float.TryParse(txtKilo.Text, out float kilo) && kilo <=0)
            {
                MessageBox.Show("Kilo geçersiz, kilogram cinsinden yazdığınıza emin olun", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtBoy.Text, out float boy) && boy <= 0 && boy > 3)
            {
                MessageBox.Show("Noy geçersiz,metre cinsinden yazdığınıza emin olun", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if((!GirisYapanKullanici.Email.EndsWith("@hotmail.com")) || (!GirisYapanKullanici.Email.EndsWith("@gmail.com")))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            GirisYapanKullanici.Isim = txtAd.Text;
            GirisYapanKullanici.Soyisim = txtSoyad.Text;
            GirisYapanKullanici.Email = txtEposta.Text;
            GirisYapanKullanici.Cinsiyet = cmbCinsiyet.Text;
            GirisYapanKullanici.DogumTarihi = dtpDogumTarihi.Value;
            GirisYapanKullanici.Sifre = txtSifre.Text;
            GirisYapanKullanici.Durum = true;
            //GirisYapanKullanici.KulllaniciDetaylari.LastOrDefault().Kilo = Convert.ToInt32(lblKilo.Text);
            //GirisYapanKullanici.KulllaniciDetaylari.LastOrDefault().Boy = Convert.ToInt32(lblBoy.Text);

            try
            {
                _context.Kullanicilar.Update(GirisYapanKullanici);
                _context.SaveChanges();
                MessageBox.Show("Bilgileriniz güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KullaniciBilgileri();

        }

        private void cbSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifre.Checked)
            {
                txtSifre.PasswordChar = '\0';  // Şifreyi görünür yapar
                txtSifreTekrar.PasswordChar = '\0';  // Şifreyi görünür yapar
            }
            else
            {
                txtSifre.PasswordChar = '•';  // Şifreyi tekrar gizler
                txtSifreTekrar.PasswordChar = '•';  // Şifreyi tekrar gizler
            }
        }
        private void btnHesapDondur_Click(object sender, EventArgs e)
        {

            try
            {
                GirisYapanKullanici.Durum = false;
                _context.Kullanicilar.Update(GirisYapanKullanici);
                _context.SaveChanges();
                MessageBox.Show("Hesabınız donduruldu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
    }
}
