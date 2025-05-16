using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Models;
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
    public partial class KullaniciTaleplerEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        Kullanici girisyapanKullanici;
        public KullaniciTaleplerEkrani(Kullanici _girisYapanKullanici)
        {
            InitializeComponent();

            girisyapanKullanici = _girisYapanKullanici;
        }
        private void btnGönder_Click(object sender, EventArgs e)
        {
            Talep talep = new Talep()
            {
                Konu = txtKonu.Text,
                Mesaj = txtMesaj.Text,
                Durum = "Bekliyor",
                KullaniciId = girisyapanKullanici
                .Id
            };
            _db.Add(talep);
            _db.SaveChanges();
            MessageBox.Show("Talebiniz oluşturulmuştur");
            txtKonu.Text = "";
            txtMesaj.Text = "";
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
