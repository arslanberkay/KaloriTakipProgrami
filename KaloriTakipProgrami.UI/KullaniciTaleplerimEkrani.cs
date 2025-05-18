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
    public partial class KullaniciTaleplerimEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        Kullanici girisyapanKullanici;

        public KullaniciTaleplerimEkrani(Kullanici _girisYapanKullanici)
        {
            InitializeComponent();

            girisyapanKullanici = _girisYapanKullanici;
        }

        private void KullaniciTaleplerimEkrani_Load(object sender, EventArgs e)
        {
            ListViewTabloOlustur();
            TalepleriGetir();
        }

        private void ListViewTabloOlustur()
        {
            lstvTalepler.View = View.Details;
            lstvTalepler.GridLines = true;
            lstvTalepler.Columns.Add("Konu", 150);
            lstvTalepler.Columns.Add("Mesaj", 500);
            lstvTalepler.Columns.Add("Durum", 150);
        }

        private void TalepleriGetir()
        {
            var taleplerim = _db.Talepler
                .Where(t => t.KullaniciId == girisyapanKullanici.Id)
                .ToList();

            foreach (var talep in taleplerim)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = talep.Konu;
                listViewItem.SubItems.Add(talep.Mesaj);
                listViewItem.SubItems.Add(talep.Durum);

                lstvTalepler.Items.Add(listViewItem);
            }
        }

        private void btnYeniTalep_Click(object sender, EventArgs e)
        {
            KullaniciTaleplerEkrani kullaniciTaleplerEkrani = new KullaniciTaleplerEkrani(girisyapanKullanici);
            kullaniciTaleplerEkrani.Show();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(girisyapanKullanici);
            kullaniciEkrani.Show();
       

        }


    }
}
