using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class KullaniciGunlukRaporEkrani : Form
    {
        private readonly KaloriTakipDbContext _db;

        Kullanici _girisYapanKullanici;
        public KullaniciGunlukRaporEkrani(Kullanici girisYapanKullanici)
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
            _girisYapanKullanici = girisYapanKullanici;
        }
        public KullaniciGunlukRaporEkrani()
        {
        }
        private void KullaniciGunlukRaporEkrani_Load(object sender, EventArgs e)
        {
            OgunleriGetir();
            TabloOlustur();
        }
        private void OgunleriGetir()
        {
            var ogunler = _db.Ogunler.ToList();

            //Comboboxta tüm öğünler diye bir seçenek de eklemek için genel liste
            var comboboxicinOgunler = new List<Ogun>();

            comboboxicinOgunler.Add(new Ogun
            {
                Id = -1,
                OgunAdi = "Tüm Öğünler"
            });

            comboboxicinOgunler.AddRange(ogunler);

            cmbOgunler.DataSource = comboboxicinOgunler;
            cmbOgunler.DisplayMember = "OgunAdi";
            cmbOgunler.ValueMember = "Id";
            cmbOgunler.SelectedIndex = -1;
        }
        private bool ValidateInputs()
        {
            if (dtpTarih.Value > DateTime.Now)
            {
                MessageBox.Show("Görüntülemek istediğiniz tarih bugünden ileri bir tarih olmamalıdır!");
                return false;
            }
            else if (cmbOgunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir öğün seçiniz!");
                return false;
            }
            return true;
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            if ((int)cmbOgunler.SelectedValue == -1)
            {
                //Seçilen tarihe göre kullanıcının yemeklerini öğünlerini listeler
                var tariheGoreYemekler = _db.OgunYemekler
                    .Include(oy => oy.Yemek.Kategori)
                    .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                                    .ToList();

                //Seçilen tarihe göre kullanıcının bütün yediği yemeklerin toplam kalorisi
                decimal tariheGoreToplamKalori = _db.OgunYemekler
                    .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                    .Sum(oy => (oy.Miktar / 100) * oy.Yemek.Kalori);

                lblKaloriBilgilendirme.Text = $"Gün İçinde Alınan Toplam Kalori : {Math.Round(tariheGoreToplamKalori)} kcal";

                ListViewdeGoster(tariheGoreYemekler);
            }
            else
            {
                //Seçilen tarihe ve seçilen öğüne göre yemekler
                var tariheVeOguneGoreYemekler = _db.OgunYemekler
                    .Include(oy => oy.Yemek.Kategori)
                    .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id && oy.OgunId == (int)cmbOgunler.SelectedValue)
                    .ToList();

                //Seçilen tarihe ve seçilen öğüne göre yemeklerin toplam kalorisi
                decimal tariheVeOguneGoreToplamKalori = _db.OgunYemekler
                    .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id && oy.OgunId == (int)cmbOgunler.SelectedValue)
                    .Sum(oy => (oy.Miktar / 100) * oy.Yemek.Kalori);

                lblKaloriBilgilendirme.Text = $"{(cmbOgunler.SelectedItem as Ogun).OgunAdi} İçin Alınan Toplam Kalori : {Math.Round(tariheVeOguneGoreToplamKalori)} kcal";

                ListViewdeGoster(tariheVeOguneGoreYemekler);
            }
        }
        private void TabloOlustur()
        {
            lstvOgunYemekDetayliRapor.View = System.Windows.Forms.View.Details;
            lstvOgunYemekDetayliRapor.GridLines = true;
            lstvOgunYemekDetayliRapor.Columns.Add("Tarih", 200);
            lstvOgunYemekDetayliRapor.Columns.Add("Öğün", 200);
            lstvOgunYemekDetayliRapor.Columns.Add("Kategori", 200);
            lstvOgunYemekDetayliRapor.Columns.Add("Yemek", 200);
            lstvOgunYemekDetayliRapor.Columns.Add("Miktar", 200);
            lstvOgunYemekDetayliRapor.Columns.Add("Toplam Kalori", 200);
        }

        /// <summary>
        /// İçine gönderilen OgunYemek tipindeki listeyi ListView'de gösterir.
        /// </summary>
        /// <param name="filtrelenmisYemekler"></param>
        private void ListViewdeGoster(List<OgunYemek> filtrelenmisYemekler)
        {
            TabloTemizle();

            foreach (var filtrelenmisYemek in filtrelenmisYemekler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = filtrelenmisYemek.Tarih.ToShortDateString();
                listViewItem.SubItems.Add(filtrelenmisYemek.Ogun.OgunAdi);
                listViewItem.SubItems.Add(filtrelenmisYemek.Yemek.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(filtrelenmisYemek.Yemek.YemekAdi);
                listViewItem.SubItems.Add(Math.Round(filtrelenmisYemek.Miktar).ToString() + " gr");
                listViewItem.SubItems.Add(Math.Round(((filtrelenmisYemek.Miktar / 100) * filtrelenmisYemek.Yemek.Kalori)).ToString() + " kcal");

                lstvOgunYemekDetayliRapor.Items.Add(listViewItem);
            }
        }
        private void TabloTemizle()
        {
            lstvOgunYemekDetayliRapor.Items.Clear();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
