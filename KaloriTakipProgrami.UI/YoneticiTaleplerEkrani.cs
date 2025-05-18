using DocumentFormat.OpenXml.Office2010.PowerPoint;
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
                o.Id,
                o.Konu,
                o.Mesaj,
                Kullanıcı = o.Kullanici.KullaniciAdi,
                o.Durum
            }).ToList();

            dgvTalepler.ClearSelection();
        }
        private void dgvTalepler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenTalep = dgvTalepler.SelectedRows[0].DataBoundItem as Talep;
        }
        private void btnReddedildi_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.CurrentRow != null)
            {
                int id = (int)(dgvTalepler.CurrentRow.Cells["Id"].Value);
                var talep = _db.Talepler.Find(id);

                if (talep != null)
                {

                    talep.Durum = "Reddedildi";

                    _db.SaveChanges();
                    MessageBox.Show("Talep başarıyla reddedildi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen reddetmek istediğiniz talebi seçiniz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek istediğiniz talebi seçiniz");
                return;
            }
        }
        private void btnOnayla_Click_1(object sender, EventArgs e)
        {
            if (dgvTalepler.CurrentRow != null)
            {
                int id = (int)(dgvTalepler.CurrentRow.Cells["Id"].Value);
                var talep = _db.Talepler.Find(id);

                if (talep != null)
                {
                    talep.Durum = "Onaylandı";

                    _db.SaveChanges();
                    MessageBox.Show("Talep başarıyla onaylandı");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen onaylamak istediğiniz talebi seçiniz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak istediğiniz talebi seçiniz");
                return;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTümü_Click(object sender, EventArgs e)
        {
            Listele();
        }
        /// <summary>
        /// Talep durumuna göre filtreleme için içine gönderilen paramatreye göre Onay red veya bekliyor olan talepleri getirmeye yarayan metod
        /// </summary>
        /// <param name="onaylandiMi"></param>
        private void TalepFiltrele(string durumBilgisi)
        {
            dgvTalepler.DataSource = _db.Talepler
          .Include(t => t.Kullanici)
          .Where(t => t.Durum == durumBilgisi)
          .Select(t => new
          {
              t.Id,
              t.Konu,
              t.Mesaj,
              t.Kullanici.KullaniciAdi,
              t.Durum
          })
          .ToList();
        }
        private void btnOnaylanmis_Click(object sender, EventArgs e)
        {
            TalepFiltrele("Onaylandı");
        }
        private void btnReddedilmis_Click(object sender, EventArgs e)
        {
            TalepFiltrele("Reddedildi");
        }
        private void btnOkunmamis_Click(object sender, EventArgs e)
        {
            TalepFiltrele("Bekliyor");
        }

        private void YoneticiTaleplerEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}

