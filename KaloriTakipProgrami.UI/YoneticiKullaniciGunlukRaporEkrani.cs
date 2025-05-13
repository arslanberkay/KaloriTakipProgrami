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
    public partial class YoneticiKullaniciGunlukRaporEkrani : Form
    {
        private readonly KaloriTakipDbContext _db;
        public YoneticiKullaniciGunlukRaporEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
        }

        private void KullaniciGetir()
        {
            cbKullaniciAdlari.DisplayMember = "KullaniciAdi";
            cbKullaniciAdlari.ValueMember = "Id";
            cbKullaniciAdlari.DataSource = _db.Kullanicilar.
                Select(k => new
                {
                    k.Id,
                    k.KullaniciAdi
                }).ToList();

            cbKullaniciAdlari.SelectedIndex = -1;
        }

        private void YoneticiKullaniciGunlukRaporEkrani_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
            TabloOlustur();
        }

        private bool ValidateInputs()
        {
            if (cbKullaniciAdlari.SelectedItem == null)
            {
                MessageBox.Show("Lütfen günlük raporunuzu görmek istediğiniz kullanıcıyı seçiniz ");
                return false;
            }
            else if (dtpTarih.Value > DateTime.Now)
            {
                MessageBox.Show("Rapor tarihi bugünden ileri olamaz!");
                return false;
            }
            return true;
        }

        private void TabloOlustur()
        {
            lstvKullaniciGunlukRapor.View = View.Details;
            lstvKullaniciGunlukRapor.GridLines = true;
            lstvKullaniciGunlukRapor.Columns.Add("Yemek");
            lstvKullaniciGunlukRapor.Columns.Add("Öğün");
        }


        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            var raporlanacakKullanici = _db.Kullanicilar.FirstOrDefault(k => k.Id == (int)cbKullaniciAdlari.SelectedValue);

            var raporlanacakKullaniciGuneGoreOgunYemekleri = _db.OgunYemekler
                .Include(oy => oy.Yemek)
                .Include(oy => oy.Ogun)
                .Where(oy => oy.KullaniciId == raporlanacakKullanici.Id && oy.Tarih.Date == dtpTarih.Value.Date).ToList();

            lstvKullaniciGunlukRapor.Items.Clear();

            foreach (var raporlanacakKullaniciGuneGoreOgunYemegi in raporlanacakKullaniciGuneGoreOgunYemekleri)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = raporlanacakKullaniciGuneGoreOgunYemegi.Yemek.YemekAdi.ToString();
                listViewItem.SubItems.Add(raporlanacakKullaniciGuneGoreOgunYemegi.Ogun.OgunAdi.ToString());

                lstvKullaniciGunlukRapor.Items.Add(listViewItem);
            }

        }


    }
}
