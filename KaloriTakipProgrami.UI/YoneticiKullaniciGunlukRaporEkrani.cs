using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
using System.Xml.Linq;

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
            lstvKullaniciGunlukRapor.Columns.Add("Yemek",200);
            lstvKullaniciGunlukRapor.Columns.Add("Kalori(100gr)",200);
            lstvKullaniciGunlukRapor.Columns.Add("Kategori", 200);
            lstvKullaniciGunlukRapor.Columns.Add("Öğün", 200);   
            lstvKullaniciGunlukRapor.Columns.Add("Yediği Miktar", 200);
            lstvKullaniciGunlukRapor.Columns.Add("Toplam Kalori", 200);

        }


        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            var raporlanacakKullanici = _db.Kullanicilar.FirstOrDefault(k => k.Id == (int)cbKullaniciAdlari.SelectedValue);

            var raporlanacakKullaniciGuneGoreOgunYemekleri = _db.OgunYemekler
                .Include(oy => oy.Yemek.Kategori)
                .Include(oy => oy.Ogun)
                .Where(oy => oy.KullaniciId == raporlanacakKullanici.Id && oy.Tarih.Date == dtpTarih.Value.Date).ToList();

            lstvKullaniciGunlukRapor.Items.Clear();

            foreach (var raporlanacakKullaniciGuneGoreOgunYemegi in raporlanacakKullaniciGuneGoreOgunYemekleri)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = raporlanacakKullaniciGuneGoreOgunYemegi.Yemek.YemekAdi.ToString();
                listViewItem.SubItems.Add(raporlanacakKullaniciGuneGoreOgunYemegi.Yemek.Kalori.ToString() + " kcal");
                listViewItem.SubItems.Add(raporlanacakKullaniciGuneGoreOgunYemegi.Yemek.Kategori.KategoriAdi);
                listViewItem.SubItems.Add(raporlanacakKullaniciGuneGoreOgunYemegi.Ogun.OgunAdi.ToString());
                listViewItem.SubItems.Add(raporlanacakKullaniciGuneGoreOgunYemegi.Miktar.ToString()+ " gr");
                listViewItem.SubItems.Add(((raporlanacakKullaniciGuneGoreOgunYemegi.Miktar/100)*raporlanacakKullaniciGuneGoreOgunYemegi.Yemek.Kalori).ToString() + " kcal");

                lstvKullaniciGunlukRapor.Items.Add(listViewItem);
            }

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            PDFOlustur();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelOlustur();
        }

        private void PDFOlustur()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Türkçe karakter desteği

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF Dosyası Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                    //Font tanımları
                    iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font kalinFont = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 7, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font dateFont = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.ITALIC);

                    //PDF başlığı 
                    Paragraph baslik = new Paragraph("Satış Raporu", baslikFont);
                    baslik.Alignment = Element.ALIGN_CENTER;
                    baslik.SpacingAfter = 10f;
                    document.Add(baslik);

                    //Tarih ve Saat Ekle
                    string currenDateTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                    Paragraph date = new Paragraph("Oluşturma Tarihi : " + currenDateTime, dateFont);
                    date.Alignment = Element.ALIGN_RIGHT;
                    date.SpacingAfter = 20f;
                    document.Add(date);

                    //Tablo Oluşturma
                    PdfPTable table = new PdfPTable(lstvKullaniciGunlukRapor.Columns.Count);
                    table.WidthPercentage = 100;

                    //Başlıkları Ekle
                    foreach (ColumnHeader column in lstvKullaniciGunlukRapor.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text, kalinFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    //Satırları Ekle
                    foreach (ListViewItem listViewItem in lstvKullaniciGunlukRapor.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in listViewItem.SubItems)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, normalFont));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }

                    document.Add(table);
                    document.Close();

                    MessageBox.Show("PDF dosyası başarıyla oluşturuldu!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PDF dosyası oluşturulurken hata oluştu");
            }
        }

        private void ExcelOlustur()
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var workSheet = workbook.AddWorksheet($"KullanıcıRaporu_{DateTime.Now:yyyyMMdd}");
                    string[] headers = { "Yemek", "Öğün" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        var headerCell = workSheet.Cell(1, i + 1);
                        headerCell.Value = headers[i];

                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    }
                    int satir = 2;
                    foreach (ListViewItem listViewItem in lstvKullaniciGunlukRapor.Items)
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
