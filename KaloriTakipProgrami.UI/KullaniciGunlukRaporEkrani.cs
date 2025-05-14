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
            cmbOgunler.DataSource = _db.Ogunler.ToList();
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

            //Seçilen tarihe göre kullanıcının yemeklerini öğünlerini listeler
            var tariheGoreYemekler = _db.OgunYemekler
                .Include(oy => oy.Yemek.Kategori)
                .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                
                .ToList();

            //Seçilen tarihe göre kullanıcının bütün yediği yemeklerin toplam kalorisi
            decimal tariheGoreToplamKalori = _db.OgunYemekler
                .Where(oy => oy.Tarih.Date == dtpTarih.Value.Date && oy.KullaniciId == _girisYapanKullanici.Id)
                .Sum(oy => (oy.Miktar / 100) * oy.Yemek.Kalori);

            lblToplamKaloriBilgilendirme.Text = $"Gün içinde alınan toplam kalori miktari : {Math.Round(tariheGoreToplamKalori,2) }kcal";                            

            ListViewdeGoster(tariheGoreYemekler);

        }

        private void TabloOlustur()
        {
            lstvOgunYemekDetayliRapor.View = System.Windows.Forms.View.Details;
            lstvOgunYemekDetayliRapor.GridLines = true;
            lstvOgunYemekDetayliRapor.Columns.Add("Tarih", 150);
            lstvOgunYemekDetayliRapor.Columns.Add("Öğün", 150);
            lstvOgunYemekDetayliRapor.Columns.Add("Kategori", 150);
            lstvOgunYemekDetayliRapor.Columns.Add("Yemek", 150);
            lstvOgunYemekDetayliRapor.Columns.Add("Miktar", 150);
            lstvOgunYemekDetayliRapor.Columns.Add("Kalori", 150);
        }

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
                listViewItem.SubItems.Add(filtrelenmisYemek.Miktar.ToString());
                listViewItem.SubItems.Add(filtrelenmisYemek.Yemek.Kalori.ToString());

                lstvOgunYemekDetayliRapor.Items.Add(listViewItem);
            }
        }

        private void TabloTemizle()
        {
            lstvOgunYemekDetayliRapor.Items.Clear();
        }
    }
}
