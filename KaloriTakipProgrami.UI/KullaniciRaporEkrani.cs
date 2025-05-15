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
            _girisYapanKullanici = girisYapanKullanici;
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

        private void TabloOlustur()
        {
            lstOgunYemekRaporu.View = View.Details;
            lstOgunYemekRaporu.GridLines = true;
            lstOgunYemekRaporu.Columns.Add("Tarih", 150);
            lstOgunYemekRaporu.Columns.Add("Öğün", 150);
            lstOgunYemekRaporu.Columns.Add("Kategori", 150);
            lstOgunYemekRaporu.Columns.Add("Yemek", 150);
            lstOgunYemekRaporu.Columns.Add("Miktar", 150);
            lstOgunYemekRaporu.Columns.Add("Kalori", 150);
        }

        private void TabloGuncelle(List<OgunYemek> ogunyemekler)
        {
            foreach (var ogunYemek in ogunyemekler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = ogunYemek.Tarih.ToShortDateString();
                listViewItem.SubItems.Add(ogunYemek.Ogun.OgunAdi);
                listViewItem.SubItems.Add(ogunYemek.Yemek.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(ogunYemek.Yemek.YemekAdi);
                listViewItem.SubItems.Add(ogunYemek.Miktar.ToString());
                listViewItem.SubItems.Add(((ogunYemek.Miktar / 100) * ogunYemek.Yemek.Kalori).ToString());

                lstOgunYemekRaporu.Items.Add(listViewItem);
            }
        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            OgunYemekListele();
        }

        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            OgunYemekListele();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }

        private void btnAzYenilenler_Click(object sender, EventArgs e)
        {
            var tariheGoreYemekMiktarlari = _db.OgunYemekler
                .Include(oy => oy.Ogun)
                .Include(oy => oy.Yemek.Kategori)
                .Where(oy => oy.Tarih.Date >= dtpBaslangicTarihi.Value.Date && oy.Tarih.Date <= dtpBitisTarihi.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                .GroupBy(oy => oy.Yemek.YemekAdi)
                .Select(g => new
                {
                    g.Key,
                    ToplamYenilenMiktar = g.Sum(x => x.Miktar)
                })
                .ToList();

            var tariheGoreEnAzYenenYemekMiktari = tariheGoreYemekMiktarlari.Min(y => y.ToplamYenilenMiktar);

            var tariheGoreEnAzYenilenYemekler = tariheGoreYemekMiktarlari
                .Where(y => y.ToplamYenilenMiktar == tariheGoreEnAzYenenYemekMiktari)
                .ToList();


            lstOgunYemekRaporu.Clear();

            lstOgunYemekRaporu.View = View.Details;
            lstOgunYemekRaporu.GridLines = true;
            lstOgunYemekRaporu.Columns.Add("Yemek Adı", 150);
            lstOgunYemekRaporu.Columns.Add("Toplam Yenilen Miktar", 150);

            foreach (var tariheGoreEnAzYenilenYemek in tariheGoreEnAzYenilenYemekler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = tariheGoreEnAzYenilenYemek.Key;
                listViewItem.SubItems.Add(tariheGoreEnAzYenilenYemek.ToplamYenilenMiktar.ToString());

                lstOgunYemekRaporu.Items.Add(listViewItem);
            }
        }



        private void btnEnCokYenilen_Click(object sender, EventArgs e)
        {

        }
    }
}
