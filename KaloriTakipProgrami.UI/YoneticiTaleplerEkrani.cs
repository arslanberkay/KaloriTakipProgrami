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
    public partial class YoneticiTaleplerEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        Talep secilenTalep;
        public YoneticiTaleplerEkrani()
        {
            InitializeComponent();
            Listele();

        }
        public void Listele()
        {
            dgvTalepler.DataSource = _db.Talepler.Select(o =>
            new
            {
                o.Konu,
                o.Mesaj,
                Kullanıcı = o.Kullanici.KullaniciAdi,
                o.Durum
            }).ToList();


        }
        private void dgvTalepler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenTalep = dgvTalepler.SelectedRows[0].DataBoundItem as Talep;
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (secilenTalep != null)
            {
                MessageBox.Show("Lütfen Onaylamak istediğiniz talebi seçiniz");
                return;
            }
            secilenTalep.Durum = "Onaylandı";
            MessageBox.Show("Talebi onayladınız");

        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (secilenTalep != null)
            {
                MessageBox.Show("Lütfen Reddetmek istediğiniz talebi seçiniz");
                return;
            }
            secilenTalep.Durum = "Reddedildi";
            MessageBox.Show("Talebi reddettiniz");
        }


    }
}
