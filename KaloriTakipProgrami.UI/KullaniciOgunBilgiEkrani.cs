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

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciOgunBilgiEkrani : Form
    {
        KaloriTakipDbContext _db = new KaloriTakipDbContext();
        public KullaniciOgunBilgiEkrani()
        {
            InitializeComponent();
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
                        table.AddCell(item.SubItems[0].Text);  // Öğünler
                        table.AddCell(item.SubItems[1].Text);  // Kategoriler
                        table.AddCell(item.SubItems[2].Text);  // Yemek
                        table.AddCell(item.SubItems[3].Text);  // Tarih
                        table.AddCell(item.SubItems[4].Text);  // Miktar
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
                        workSheet.Cell(satir, 1).Value = listViewItem.SubItems[0].Text;
                        workSheet.Cell(satir, 2).Value = listViewItem.SubItems[1].Text;
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
    }
}
