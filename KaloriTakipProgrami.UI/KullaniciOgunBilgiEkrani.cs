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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciOgunBilgiEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        public KullaniciOgunBilgiEkrani()
        {
            InitializeComponent();
             dgvOgunBilgileri.DataSource = _db.OgunYemekler
    .              Select(oy => new
                         {
                         oy.Miktar,
                         oy.Tarih,
                         Öğun = oy.Ogun.OgunAdi,
                         Yemek = oy.Yemek.YemekAdi,
                         Kullanıcı = oy.Kullanici
                         })
                            .ToList();

        }

        private void KullaniciOgunBilgiEkrani_Load(object sender, EventArgs e)
        {
            //todo 

            cmbKategoriler.DataSource = _db.Kategoriler.ToList();
            cmbKategoriler.DisplayMember = "KategoriAdi";   // Kullanıcıya görünen
            cmbKategoriler.ValueMember = "Id";


            cmbOgunler.DataSource = _db.Ogunler.ToList();
            cmbOgunler.DisplayMember = "OgunAdi";
            cmbOgunler.ValueMember = "Id";



        }
        public void Filtrele()
        {
            var secilenKategori = cmbKategoriler.SelectedItem as Kategori;

            if (secilenKategori != null)
            {
                // LINQ method syntax ile filtreleme
                var yemekler = _db.Yemekler
                                  .Where(y => y.KategoriId == secilenKategori.Id)
                                  .ToList();

                // Sonuçları yemekler combobox'ına ata
                cmbYemekler.DataSource = yemekler;
                cmbYemekler.DisplayMember = "YemekAdi";
                cmbYemekler.ValueMember = "Id";


            }
        }

       

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo mefeaygn
            Filtrele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgunYemek ogunYemek = new OgunYemek()
            {
                OgunId=(int)cmbOgunler.SelectedValue,
                YemekId=(int)cmbYemekler.SelectedValue,
                Miktar=nupdMiktar.Value,
                Tarih=dtpTarih.Value,
            
            
            
            
            };
            //todo mefeaygn
            
        }
        public void HataKontrolleri()
        {
            if (dtpTarih.Value>DateTime.Now)
            {
                MessageBox.Show("Lütfen geçerli bir tarih giriniz");
                return;

            }
            



        }
    }
}

