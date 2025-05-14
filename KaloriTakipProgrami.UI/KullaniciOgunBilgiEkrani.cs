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
                    var ogunBilgileri = _db.OgunYemekler.Include(k => k.Ogun).Include(o => o.Yemek).ThenInclude(k => k.Kategori).Select(s => new
                    {
                        Ogunler = s.Ogun.OgunAdi,
                        Kategori = s.Yemek.Kategori.KategoriAdi,
                        Yemek = s.Yemek.YemekAdi,
                        Tarih = s.Tarih,
                        Miktar = s.Miktar,
                    }).ToList();

                    foreach (var item in ogunBilgileri)
                    {
                        table.AddCell(item.Ogunler);
                        table.AddCell(item.Kategori);
                        table.AddCell(item.Yemek);
                        table.AddCell(item.Tarih.ToString("yyyy-mm-dd"));
                        table.AddCell(item.Miktar.ToString());
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
        

        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            PdfOlustur();
        }
    }
}
