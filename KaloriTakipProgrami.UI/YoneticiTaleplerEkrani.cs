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
        }




        private void dgvTalepler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenTalep = dgvTalepler.SelectedRows[0].DataBoundItem as Talep;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.CurrentRow != null)
            {
                int id = (int)(dgvTalepler.CurrentRow.Cells["Id"].Value);
                var talep = _db.Talepler.Find(id);

                if (talep != null)
                {
                    talep.Durum = "Onaylandı";

                    _db.SaveChanges();
                    Listele();
                    MessageBox.Show("Talebi Onayladınız");
                }
                else
                {
                    MessageBox.Show("Lütfen Reddetmek istediğiniz talebi seçiniz");
                    return;
                }
            }
            else
            {

                MessageBox.Show("Lütfen reddetmek istediğiniz taşebi seçiniz");
                return;
            }
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
                    Listele();
                    MessageBox.Show("Talebi reddettiniz");

                }
                else
                {
                    MessageBox.Show("Lütfen Reddetmek istediğiniz talebi seçiniz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek istediğiniz taşebi seçiniz");
                return;
            }


    }
}

