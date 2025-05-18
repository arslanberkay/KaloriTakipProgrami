using KaloriTakipProgrami.UI.Context;
using KaloriTakipProgrami.UI.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class KullaniciRaporEkrani : Form
    {
        KaloriTakipDbContext _db;
        Kullanici _girisYapanKullanici;
        public KullaniciRaporEkrani(Kullanici girisYapanKullanici)
        {
            InitializeComponent();
            _girisYapanKullanici = girisYapanKullanici; //Programa giriş yapan kullanıcıyı bu formda kullanacağım için aktardım
            _db = new KaloriTakipDbContext();
        }
        public KullaniciRaporEkrani()
        {
        }
        private void KullaniciRaporEkrani_Load(object sender, EventArgs e)
        {
            TabloOlustur();
            OgunYemekListele();
        }
        /// <summary>
        /// Kullanıcının seçtiği iki tarih arasındaki yemekleri listeler
        /// </summary>
        private void OgunYemekListele()
        {
            lstOgunYemekRaporu.Clear();
            TabloOlustur();

            var tarihAraliginaGoreOgunYemek = _db.OgunYemekler
                .Include(oy => oy.Ogun)
                .Include(oy => oy.Yemek.Kategori)
                .Where(oy => oy.Tarih.Date >= dtpBaslangicTarihi.Value.Date && oy.Tarih.Date <= dtpBitisTarihi.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                .ToList();

            TabloGuncelle(tarihAraliginaGoreOgunYemek);
        }

        //Yemek listelemek için gerekli olan kolonlarla birlikte ListView oluşturur
        private void TabloOlustur()
        {
            lstOgunYemekRaporu.View = View.Details;
            lstOgunYemekRaporu.GridLines = true;
            lstOgunYemekRaporu.Columns.Add("Tarih", 190);
            lstOgunYemekRaporu.Columns.Add("Öğün", 190);
            lstOgunYemekRaporu.Columns.Add("Kategori", 190);
            lstOgunYemekRaporu.Columns.Add("Yemek", 190);
            lstOgunYemekRaporu.Columns.Add("Miktar", 190);
            lstOgunYemekRaporu.Columns.Add("Kalori", 190);
        }
        /// <summary>
        /// İçine gönderilen OgunYemek tipindeki listeyi ListViewe aktarır
        /// </summary>
        /// <param name="ogunyemekler"></param>
        private void TabloGuncelle(List<OgunYemek> ogunyemekler)
        {
            foreach (var ogunYemek in ogunyemekler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = ogunYemek.Tarih.ToShortDateString();
                listViewItem.SubItems.Add(ogunYemek.Ogun.OgunAdi);
                listViewItem.SubItems.Add(ogunYemek.Yemek.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(ogunYemek.Yemek.YemekAdi);
                listViewItem.SubItems.Add(ogunYemek.Miktar.ToString() + " gr");
                listViewItem.SubItems.Add(((ogunYemek.Miktar / 100) * ogunYemek.Yemek.Kalori).ToString() + " kcal");

                lstOgunYemekRaporu.Items.Add(listViewItem);
            }
        }

        private bool ValidateInputs()
        {
            if (dtpBaslangicTarihi.Value.Date > DateTime.Now.Date || dtpBitisTarihi.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Bugünden ileri tarih filtrelenemez!");
                TarihGuncelle();
                return false;
            }
            else if (dtpBaslangicTarihi.Value.Date > dtpBitisTarihi.Value.Date)
            {
                MessageBox.Show("Alt aralık üst aralıktan ileri tarih olamaz!");
                TarihGuncelle();
                return false;
            }
            return true;
        }

        private void TarihGuncelle()
        {
            dtpBaslangicTarihi.Value = dtpBitisTarihi.Value = DateTime.Now;
        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            OgunYemekListele(); //Başlangıç tarihi değiştiğinde yemek kayıtları güncellenir
        }
        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            OgunYemekListele();  //Bitiş tarihi değiştiğinde yemek kayıtları güncellenir
        }
        /// <summary>
        /// İçine gönderilen en çok veya en az durumuna göre raporlama yapar
        /// </summary>
        /// <param name="enCokMu"></param>
        private void YemekTuketimRaporuGoster(bool enCokMu)
        {
            var tariheGoreYemekMiktarlari = _db.OgunYemekler
                .Include(oy => oy.Ogun)
                .Include(oy => oy.Yemek.Kategori)
                .Where(oy => oy.Tarih.Date >= dtpBaslangicTarihi.Value.Date &&
                             oy.Tarih.Date <= dtpBitisTarihi.Value.Date &&
                             oy.KullaniciId == _girisYapanKullanici.Id)
                .GroupBy(oy =>
                new
                {
                    oy.Yemek.YemekAdi,
                    oy.Ogun.OgunAdi,
                    oy.Yemek.Kategori.KategoriAdi

                }) //Yemeklere göre gruplama yapar
                .Select(g => new
                {
                    g.Key.YemekAdi,
                    g.Key.OgunAdi,
                    g.Key.KategoriAdi,
                    ToplamYenilenMiktar = g.Sum(x => x.Miktar) //Aynı yemeklerin miktarlarını toplar
                })
                .ToList();

            if (tariheGoreYemekMiktarlari.Count == 0)
            {
                MessageBox.Show("Belirtilen tarihler arasında veri bulunamadı.");
                return;
            }
            //Gönderilen parametre true ise maximum yenilen miktarı bulur false ise minimum yenilen miktarı bulur
            decimal hedefMiktar = enCokMu
                ? tariheGoreYemekMiktarlari.Max(y => y.ToplamYenilenMiktar)
                : tariheGoreYemekMiktarlari.Min(y => y.ToplamYenilenMiktar);

            //İstenilen hedef miktara eşit olan tüm yemek kayıtlarını getirir.
            var secilenYemekler = tariheGoreYemekMiktarlari
                .Where(y => y.ToplamYenilenMiktar == hedefMiktar)
                .ToList();

            lstOgunYemekRaporu.Clear(); //Eski tabloyu ve kayıtları siler

            //Yeni listview oluşturur.
            lstOgunYemekRaporu.View = View.Details;
            lstOgunYemekRaporu.GridLines = true;
            lstOgunYemekRaporu.Columns.Add("Yemek Adı", 150);
            lstOgunYemekRaporu.Columns.Add("Öğün Adı", 150);
            lstOgunYemekRaporu.Columns.Add("Kategori Adı", 150);
            lstOgunYemekRaporu.Columns.Add("Toplam Yenilen Miktar", 150);

            //ListView içine kayıtları getirir.
            foreach (var yemek in secilenYemekler)
            {
                ListViewItem item = new ListViewItem(yemek.YemekAdi);
                item.SubItems.Add(yemek.OgunAdi);
                item.SubItems.Add(yemek.KategoriAdi);
                item.SubItems.Add(yemek.ToplamYenilenMiktar.ToString());
                lstOgunYemekRaporu.Items.Add(item);
            }
        }
        private void btnAzYenilenler_Click(object sender, EventArgs e)
        {
            YemekTuketimRaporuGoster(false);
        }
        private void btnEnCokYenilen_Click(object sender, EventArgs e)
        {
            YemekTuketimRaporuGoster(true);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
        private void btnTumYemekler_Click(object sender, EventArgs e)
        {
            OgunYemekListele();
            if (lstOgunYemekRaporu.Items.Count == 0)
            {
                MessageBox.Show("Belirtilen tarihler arasında veri bulunamadı.");
                return;
            }
        }
    }
}
