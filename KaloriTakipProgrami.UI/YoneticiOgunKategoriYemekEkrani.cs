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
    public partial class YoneticiOgunKategoriYemekEkrani : Form
    {
        private readonly KaloriTakipDbContext _db;
        public YoneticiOgunKategoriYemekEkrani()
        {
            InitializeComponent();
            _db = new KaloriTakipDbContext();
        }
        private void YoneticiOgunKategoriYemekEkrani_Load(object sender, EventArgs e)
        {
            OgunListele();
            KategoriListele();
            YemekListele();
            KategorileriGetir();
            DataGridDuzenle();

            dgvKategoriler.ForeColor = Color.Black;
            dgvOgunler.ForeColor = Color.Black;
            dgvYemekler.ForeColor = Color.Black;
        }

        private void DataGridDuzenle()
        {
            dgvKategoriler.Columns["KategoriAdi"].HeaderText = "Kategori Adı";
            dgvOgunler.Columns["OgunAdi"].HeaderText = "Öğün Adı";
            dgvYemekler.Columns["YemekAdi"].HeaderText = "Yemek Adı";
            dgvYemekler.Columns["KategoriAdi"].HeaderText = "Kategori Adı";
        }

        private void OgunListele()
        {
            dgvOgunler.DataSource = _db.Ogunler.ToList();
            dgvOgunler.ClearSelection();
          
        }
        private void KategoriListele()
        {
            dgvKategoriler.DataSource = _db.Kategoriler.ToList();
            dgvKategoriler.ClearSelection();
         
        }
        private void YemekListele()
        {
            dgvYemekler.DataSource = _db.Yemekler
                .Include(y => y.Kategori)
                .Select(y => new
                {
                    y.Id,
                    y.YemekAdi,
                    y.Kalori,
                    y.Kategori.KategoriAdi,
                })
                .OrderBy(y => y.Id)
                .ToList();

            dgvYemekler.ClearSelection();
            
        }
        private bool ValidateInputsOgunler()
        {
            if (string.IsNullOrEmpty(txtOgunAdi.Text))
            {
                MessageBox.Show("Öğün ile ilgili alanlar boş olmamalıdır!");
                return false;
            }
            return true;
        }
        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsOgunler())
            {
                return;
            }
            Ogun ogun = new Ogun()
            {
                OgunAdi = txtOgunAdi.Text,
            };
            _db.Ogunler.Add(ogun);
            _db.SaveChanges();

            MessageBox.Show("Öğün başarıyla eklendi.");
            OgunListele();
            OgunBilgileriTemizle();
        }
        private void OgunBilgileriTemizle()
        {
            foreach (var controls in grpOgunler.Controls) //Group box içinde dön
            {
                if (controls is TextBox txt) //Eğer kontrol Textboxsa
                {
                    txt.Text = string.Empty; //o textboxu temizle
                }
            }
        }
        Ogun secilenOgun;
        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOgunler.SelectedRows.Count == 0)
            {
                return;
            }
            int secilenOgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value;
            secilenOgun = _db.Ogunler.Find(secilenOgunId);

            txtOgunAdi.Text = secilenOgun.OgunAdi;
        }
        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (dgvOgunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğünü seçiniz!");
                return;
            }
            _db.Remove(secilenOgun);
            _db.SaveChanges();

            MessageBox.Show("Öğün başarıyla silindi");
            secilenOgun = null;
            OgunListele();
            OgunBilgileriTemizle();
        }
        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğünü seçiniz!");
                return;
            }
            if (!ValidateInputsOgunler())
            {
                return;
            }
            secilenOgun.OgunAdi = txtOgunAdi.Text;
            _db.SaveChanges();

            MessageBox.Show("Öğün başarıyla güncellendi");
            secilenOgun = null;
            OgunListele();
            OgunBilgileriTemizle();
            YemekListele();
        }
        private bool ValidateInputsKategoriler()
        {
            if (string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori ile ilgili alanlar boş olmamalıdır!");
                return false;
            }
            return true;
        }
        private void KategoriBilgileriTemizle()
        {
            foreach (var control in grpKategoriler.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
            }
        }
        Kategori secilenKategori;
        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                return;
            }

            int secilenKategoriId = (int)dgvKategoriler.SelectedRows[0].Cells["Id"].Value;
            secilenKategori = _db.Kategoriler.Find(secilenKategoriId);

            txtKategoriAdi.Text = secilenKategori.KategoriAdi;
        }

        private void btnKategoriSil_Click_1(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçiniz!");
                return;
            }
            if (_db.Yemekler.Any(y => y.Kategori.KategoriAdi == secilenKategori.KategoriAdi)) //Seçilen kategori , yemekler tablosunda varsa
            {
                MessageBox.Show("Silmek istediğiniz kategoriye ait yemek kayıtları bulundu! Lütfen önce silmek istediğiniz kategoriye ait yemek kayıtlarını siliniz!");
                return;
            }
            _db.Remove(secilenKategori);
            _db.SaveChanges();

            MessageBox.Show("Kategori başarıyla silindi");
            secilenKategori = null;
            KategoriListele();
            KategoriBilgileriTemizle();
        }
        private void btnKategoriGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kategoriyi seçiniz!");
                return;
            }
            secilenKategori.KategoriAdi = txtKategoriAdi.Text;

            _db.SaveChanges();

            MessageBox.Show("Kategori başarıyla güncellendi");
            secilenKategori = null;
            KategoriListele();
            KategoriBilgileriTemizle();
            YemekListele();
        }
        private bool ValidateInputsYemekler()
        {
            if (string.IsNullOrEmpty(txtYemekAdi.Text) || nudKalori.Value == 0 || cbKategori.SelectedItem == null)
            {
                MessageBox.Show("Yemek ile ilgili alanlar boş olmamalıdır!");
                return false;
            }
            return true;
        }
        private void KategorileriGetir()
        {
            cbKategori.DataSource = _db.Kategoriler.ToList();
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "Id";
            cbKategori.SelectedIndex = -1; //Başlangıçta kategori seçili gelmesin.
        }
        private void btnYemekEkle_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputsYemekler()) { return; }

            Yemek yemek = new Yemek();
            yemek.YemekAdi = txtYemekAdi.Text;
            yemek.KategoriId = (int)cbKategori.SelectedValue;
            yemek.Kalori = nudKalori.Value;

            _db.Yemekler.Add(yemek);
            _db.SaveChanges();

            MessageBox.Show("Yemek başarıyla eklendi");
            YemekListele();
            YemekBilgileriTemizle();
        }
        private void YemekBilgileriTemizle()
        {
            foreach (var controls in grpYemekler.Controls)
            {
                if (controls is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                else if (controls is NumericUpDown nud)
                {
                    nud.Value = 0;
                }
                else if (controls is ComboBox cb)
                {
                    cb.SelectedItem = null;
                }
            }
        }
        Yemek secilenYemek;
        private void dgvYemekler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                return;
            }

            int secilenYemekId = (int)dgvYemekler.SelectedRows[0].Cells["Id"].Value;
            secilenYemek = _db.Yemekler.Find(secilenYemekId);

            txtYemekAdi.Text = secilenYemek.YemekAdi;
            cbKategori.SelectedValue = secilenYemek.KategoriId;
            nudKalori.Value = secilenYemek.Kalori;
        }
        private void btnYemekSil_Click_1(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz");
                return;
            }

            _db.Remove(secilenYemek);
            _db.SaveChanges();

            MessageBox.Show("Yemek başarıyla silindi");
            secilenYemek = null;
            YemekListele();
            YemekBilgileriTemizle();
        }
        private void btnYemekGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü seçiniz");
                return;
            }

            if (!ValidateInputsYemekler()) { return; }

            secilenYemek.YemekAdi = txtYemekAdi.Text;
            secilenYemek.KategoriId = (int)cbKategori.SelectedValue;
            secilenYemek.Kalori = nudKalori.Value;

            _db.SaveChanges();

            MessageBox.Show("Yemek başarıyla güncellendi");
            secilenYemek = null;
            YemekListele();
            YemekBilgileriTemizle();
        }
        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
        private void btnKategoriEkle_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputsKategoriler()) { return; }

            Kategori kategori = new Kategori()
            {
                KategoriAdi = txtKategoriAdi.Text,
            };

            _db.Kategoriler.Add(kategori);
            _db.SaveChanges();

            MessageBox.Show("Kategori başarıyla eklendi");
            KategoriListele();
            KategoriBilgileriTemizle();
            KategorileriGetir();
        }
    }
}
