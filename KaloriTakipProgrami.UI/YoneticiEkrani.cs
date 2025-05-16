using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace KaloriTakipProgrami.UI
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            YoneticiKullaniciEkrani yoneticiKullaniciEkrani = new YoneticiKullaniciEkrani();
            yoneticiKullaniciEkrani.Show();
        }

        private void btnOgunlerKategorilerYemekler_Click(object sender, EventArgs e)
        {
            YoneticiOgunKategoriYemekEkrani yoneticiOgunKategoriYemekEkrani = new YoneticiOgunKategoriYemekEkrani();
            yoneticiOgunKategoriYemekEkrani.Show();
        }

        private void btnKullaniciGunlukRaporu_Click(object sender, EventArgs e)
        {
            YoneticiKullaniciGunlukRaporEkrani yoneticiKullaniciGunlukRaporEkrani = new YoneticiKullaniciGunlukRaporEkrani();
            yoneticiKullaniciGunlukRaporEkrani.Show();
        }

        private void btnTalepler_Click(object sender, EventArgs e)
        {
            YoneticiTaleplerEkrani yoneticiTaleplerEkrani = new YoneticiTaleplerEkrani();
            yoneticiTaleplerEkrani.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
        "Çıkış yapmak istediğinize emin misiniz?",  // Mesaj
        "Onay",                                            // Başlık
        MessageBoxButtons.YesNo,                           // Yes/No seçenekleri
        MessageBoxIcon.Question);                          // Soru simgesi

                if (result == DialogResult.Yes)
                {                   
                    KullaniciGirisEkrani kullaniciGirisEkrani = new KullaniciGirisEkrani();
                    this.Close();
                }
                else
                {
                    // Kullanıcı 'No' tıkladıysa, işlem iptal edilir
                    MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Kapatma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
