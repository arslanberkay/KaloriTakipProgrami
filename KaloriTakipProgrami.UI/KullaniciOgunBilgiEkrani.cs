using iTextSharp.text.pdf;
using iTextSharp.text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Net;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciOgunBilgiEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        public KullaniciOgunBilgiEkrani()
        {
            InitializeComponent();
            ListViewSutunEkle();
        }
        private void KullaniciOgunBilgiEkrani_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DataSource = _db.Kategoriler.ToList();
            cmbKategoriler.DisplayMember = "KategoriAdi";   // Kullanıcıya görünen
            cmbKategoriler.ValueMember = "Id";
            cmbKategoriler.SelectedIndex = -1;

            cmbOgunler.DataSource = _db.Ogunler.ToList();
            cmbOgunler.DisplayMember = "OgunAdi";
            cmbOgunler.ValueMember = "Id";
            cmbOgunler.SelectedIndex = -1;

            cmbYemekler.SelectedIndex = -1;
        }
        private void ListViewSutunEkle()
        {
            lsvOgunBilgileri.View = View.Details;
            lsvOgunBilgileri.GridLines = true;
            lsvOgunBilgileri.FullRowSelect = true;
            lsvOgunBilgileri.Columns.Add("ID", 60, HorizontalAlignment.Center);
            lsvOgunBilgileri.Columns.Add("Öğün", 220, HorizontalAlignment.Center);
            lsvOgunBilgileri.Columns.Add("Kategori", 220, HorizontalAlignment.Center);
            lsvOgunBilgileri.Columns.Add("Yemek", 220, HorizontalAlignment.Center);
            lsvOgunBilgileri.Columns.Add("Tarih", 220, HorizontalAlignment.Center);
            lsvOgunBilgileri.Columns.Add("Miktar", 220, HorizontalAlignment.Center);
        }
        public void Listele()
        {
            lsvOgunBilgileri.Items.Clear();

            var ogunBilgileri = _db.OgunYemekler
                .Include(k => k.Ogun)
                .Include(o => o.Yemek)
                .ThenInclude(k => k.Kategori).ToList();

            foreach (var ogun in ogunBilgileri)
            {
                ListViewItem listViewItem = new ListViewItem(ogun.Id.ToString());
                listViewItem.SubItems.Add(ogun.Ogun.OgunAdi);
                listViewItem.SubItems.Add(ogun.Yemek.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(ogun.Yemek.YemekAdi);
                listViewItem.SubItems.Add(ogun.Tarih.ToString());
                listViewItem.SubItems.Add(ogun.Miktar.ToString());

                lsvOgunBilgileri.Items.Add(listViewItem);
            }
        }
        private void Temizle()
        {
            cmbOgunler.SelectedIndex = -1;
            cmbKategoriler.SelectedIndex = -1;
            cmbYemekler.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Now;
            nudMiktar.Value = 0;
        }
        private bool GirdiDogrula()
        {
            if (cmbOgunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Öğün bilgisini Giriniz");
                return false;
            }
            if (cmbKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Kategori bilgisini Giriniz");
                return false;
            }
            if (cmbYemekler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Yemek bilgisini Giriniz");
                return false;
            }
            if (nudMiktar.Value == 0)
            {
                MessageBox.Show("Lütfen Miktar bilgisini Giriniz");
                return false;
            }
            return true;
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
        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void PdfOlustur()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosya|*.pdf";
                saveFileDialog.Title = "Öğün Raporları";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document document = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    string[] columnHeaders = { "Öğünler", "Kategoriler", "Yemek", "Tarih", "Miktar" };
                    PdfPTable table = new PdfPTable(columnHeaders.Length);
                    table.WidthPercentage = 100;

                    foreach (var column in columnHeaders)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(column));
                        pdfPCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(pdfPCell);
                    }

                    foreach (ListViewItem item in lsvOgunBilgileri.Items)
                    {
                        table.AddCell(item.SubItems[1].Text);  // Öğünler
                        table.AddCell(item.SubItems[2].Text);  // Kategoriler
                        table.AddCell(item.SubItems[3].Text);  // Yemek
                        table.AddCell(item.SubItems[4].Text);  // Tarih
                        table.AddCell(item.SubItems[5].Text);  // Miktar
                    }
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("PDF başaryıla oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }
        private void ExcelOlustur()
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var workSheet = workbook.AddWorksheet($"ÖğünBilgileri_{DateTime.Now:yyyyMMdd}");
                    string[] headers = { "Öğünler", "Kategoriler", "Yemek", "Tarih", "Miktar" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        var headerCell = workSheet.Cell(1, i + 1);
                        headerCell.Value = headers[i];

                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    }
                    int satir = 2;
                    foreach (ListViewItem listViewItem in lsvOgunBilgileri.Items)
                    {
                        workSheet.Cell(satir, 1).Value = listViewItem.SubItems[1].Text; // Öğün
                        workSheet.Cell(satir, 2).Value = listViewItem.SubItems[2].Text; // Kategori
                        workSheet.Cell(satir, 3).Value = listViewItem.SubItems[3].Text; // Yemek
                        workSheet.Cell(satir, 4).Value = listViewItem.SubItems[4].Text; // Tarih
                        workSheet.Cell(satir, 5).Value = listViewItem.SubItems[5].Text; // Miktar
                        satir++;
                    }

                    workSheet.Columns().AdjustToContents();

                    var range = workSheet.Range(1, 1, satir - 1, headers.Length);
                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    workSheet.Cell(satir + 1, 1).Value = $"Rapor Oluşturulma Tarihi : {DateTime.Now:dd MMMM yyyy HH:mm}";
                    workSheet.Cell(satir + 1, 1).Style.Font.Italic = true;
                    workSheet.Range(satir + 1, 1, satir + 1, headers.Length).Merge();

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files | .xlsx";
                        saveFileDialog.Title = "Excel Dosyasına Kaydet";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel dosyası başarıyla oluşturuldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel oluşturulurken hata meydana geldi");
            }
        }
        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            PdfOlustur();
        }
        private void btnExcelOlustur_Click(object sender, EventArgs e)
        {
            ExcelOlustur();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (!GirdiDogrula()) return;

                var ogunBilgileri = new OgunYemek
                {
                    OgunId = (int)cmbOgunler.SelectedValue,
                    YemekId = (int)cmbYemekler.SelectedValue,
                    Tarih = dtpTarih.Value.Date,
                    Miktar = nudMiktar.Value,
                };
                _db.OgunYemekler.Add(ogunBilgileri);
                _db.SaveChanges();

                ListViewItem listItem = new ListViewItem(ogunBilgileri.Id.ToString());
                listItem.SubItems.Add(cmbOgunler.SelectedValue.ToString());
                listItem.SubItems.Add(cmbKategoriler.SelectedValue.ToString());
                listItem.SubItems.Add(cmbYemekler.SelectedValue.ToString());
                listItem.SubItems.Add(dtpTarih.Value.Date.ToString());
                listItem.SubItems.Add(nudMiktar.Value.ToString());
                lsvOgunBilgileri.Items.Add(listItem);
                MessageBox.Show("Başarıyla Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata"+ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsvOgunBilgileri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silmek İstediğiniz Satırı Seçiniz");
                return;
            }
            ListViewItem seciliItem = lsvOgunBilgileri.SelectedItems[0];
            int ogunId = Convert.ToInt32(seciliItem.Text);

            var ogun = _db.OgunYemekler.Find(ogunId);
            if (ogun != null)
            {
                _db.OgunYemekler.Remove(ogun);
                _db.SaveChanges();
                lsvOgunBilgileri.Items.Remove(seciliItem);
                MessageBox.Show("Müşteri başarıyla silindi");
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (lsvOgunBilgileri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Güncellemek İstediğiniz Satırı Seçiniz");
                return;
            }

            if (!GirdiDogrula()) return;

            ListViewItem seciliOgun = lsvOgunBilgileri.SelectedItems[0];
            int ogunId = Convert.ToInt32(seciliOgun.Text);

            var ogun = _db.OgunYemekler.Find(ogunId);

            if (ogun != null)
            {
                ogun.OgunId = (int)cmbOgunler.SelectedValue;
                ogun.YemekId = (int)cmbYemekler.SelectedValue;
                ogun.Tarih = dtpTarih.Value.Date;
                ogun.Miktar = nudMiktar.Value;

                _db.SaveChanges();
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi");
                Listele();
                Temizle();
            }
        }
        private void lsvOgunBilgileri_DoubleClick(object sender, EventArgs e)
        {
            if (lsvOgunBilgileri.SelectedItems.Count > 0)
            {
                ListViewItem seciliOgun = lsvOgunBilgileri.SelectedItems[0];
                int ogunId = Convert.ToInt32(seciliOgun.Text);
                var ogun = _db.OgunYemekler.Find(ogunId);
                if (ogun != null)
                {
                    cmbOgunler.SelectedValue = ogun.OgunId;
                    cmbKategoriler.SelectedValue = ogun.Yemek.KategoriId;
                    cmbYemekler.SelectedValue = ogun.YemekId;
                    dtpTarih.Value = ogun.Tarih.Date;
                    nudMiktar.Value = ogun.Miktar;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
