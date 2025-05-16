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
    public partial class YoneticiKullaniciEkrani : Form
    {
        KaloriTakipDbContext _db;
        public YoneticiKullaniciEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
        }
        private void YoneticiKullaniciEkrani_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = _db.Kullanicilar.Select(k => new
            {
                k.Id,
                k.Isim,
                k.Soyisim,
                k.KullaniciAdi,
                Yas = DateTime.Now.Year - k.DogumTarihi.Year,
                k.Durum //Dondurulmuş hesap mı
            })
                .ToList();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
