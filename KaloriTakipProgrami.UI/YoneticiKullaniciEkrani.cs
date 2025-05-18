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
            TabloOlustur();
            ListViewAktar();
        }

        private void TabloOlustur()
        {
            lstvKullanicilar.View = View.Details;
            lstvKullanicilar.GridLines = true;
            lstvKullanicilar.Columns.Add("Id",100);
            lstvKullanicilar.Columns.Add("İsim",150);
            lstvKullanicilar.Columns.Add("Soyisim",150);
            lstvKullanicilar.Columns.Add("Kullanıcı Adı", 200);
            lstvKullanicilar.Columns.Add("Yaş", 100);
            lstvKullanicilar.Columns.Add("Email", 250);
            lstvKullanicilar.Columns.Add("Durum", 150);
        }

        private void ListViewAktar()
        {
            var kullanicilar = _db.Kullanicilar.Select(k => new
            {
                k.Id,
                k.Isim,
                k.Soyisim,
                k.KullaniciAdi,
                k.Email,
                Yas = DateTime.Now.Year - k.DogumTarihi.Year,
                k.Durum //Dondurulmuş hesap mı
            })
                .ToList();

            foreach (var kullanici  in kullanicilar)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text=kullanici.Id.ToString();
                listViewItem.SubItems.Add(kullanici.Isim);
                listViewItem.SubItems.Add(kullanici.Soyisim);
                listViewItem.SubItems.Add(kullanici.KullaniciAdi);
                listViewItem.SubItems.Add(kullanici.Yas.ToString());
                listViewItem.SubItems.Add(kullanici.Email);
                listViewItem.SubItems.Add(kullanici.Durum ? "Aktif" : "Dondurulmuş");

                lstvKullanicilar.Items.Add(listViewItem); 
            }
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
