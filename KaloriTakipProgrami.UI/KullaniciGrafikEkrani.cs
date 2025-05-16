using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;
using KaloriTakipProgrami.UI.Models;
using KaloriTakipProgrami.UI.Context;
using DocumentFormat.OpenXml.Drawing;
using iTextSharp.text.pdf;
using Path = System.IO.Path;
using PdfSharp.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciGrafikEkrani : Form
    {
        private Kullanici GirisYapanKullanici;
        private readonly KaloriTakipDbContext _context;

        public KullaniciGrafikEkrani(Kullanici girisYapanKullanici)
        {
            _context = new KaloriTakipDbContext();
            InitializeComponent();

            girisYapanKullanici = _context.Kullanicilar.FirstOrDefault(aaa => aaa.Id == 2);
            GirisYapanKullanici = girisYapanKullanici;
        }
        private void KullaniciGrafikEkrani_Load(object sender, EventArgs e)
        {
            BoyGrafigi();
            KiloGrafigi();
        }
        private void KiloGrafigi()
        {
            //var detaylar = _context.KullaniciDetaylari
            //        .Where(kd => kd.KullaniciId == GirisYapanKullanici.Id)
            //        .OrderBy(kd => kd.Tarih) // Grafik sıralaması için
            //        .ToList();


            //// Grafik ayarları
            //cKiloG.Series.Clear();
            //cKiloG.Titles.Clear();
            //cKiloG.Titles.Add("Kilo Değişimi");

            //var kiloSeri = new System.Windows.Forms.DataVisualization.Charting.Series("Kilo")
            //{
            //    ChartType = SeriesChartType.Spline,
            //    Color = Color.SteelBlue,
            //    BorderWidth = 3,
            //    XValueType = ChartValueType.DateTime
            //};

            //foreach (var detay in detaylar)
            //{
            //    kiloSeri.Points.AddXY(detay.Tarih, detay.Kilo);
            //} 

            //cKiloG.Series.Add(kiloSeri);

            //// Eksen ayarları (X ekseni)
            //var axisX = cKiloG.ChartAreas[0].AxisX;
            //axisX.Title = "Tarih";
            //axisX.LabelStyle.Format = "dd.MM.yyyy";
            //axisX.IntervalType = DateTimeIntervalType.Days;
            //axisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //axisX.LabelStyle.Angle = -45;
            //axisX.IsLabelAutoFit = true;
            //var chartArea = cKiloG.ChartAreas[0];

            //// Zoom
            //chartArea.CursorX.IsUserEnabled = true;
            //chartArea.CursorX.IsUserSelectionEnabled = true;
            //chartArea.AxisX.ScaleView.Zoomable = true;

            //// Scroll bar
            //chartArea.AxisX.ScrollBar.Enabled = true;

            //// Eksen ayarları (Y ekseni)
            //var axisY = cKiloG.ChartAreas[0].AxisY;
            //axisY.Title = "Kilo (kg)";
            //axisY.Minimum = 50;     // Başlangıç kilosu
            //axisY.Maximum = 120;    // En yüksek kilo sınırı
            //axisY.Interval = 5;     // Her 5 kg'de bir çizgi

            // Verileri al
            var detaylar = _context.KullaniciDetaylari
                .Where(kd => kd.KullaniciId == GirisYapanKullanici.Id)
                .OrderBy(kd => kd.Tarih)
                .ToList();

            if (!detaylar.Any())
            {
                MessageBox.Show("Grafikte gösterilecek kilo verisi bulunamadı.");
                return;
            }

            // Grafik temizliği
            cKiloG.Series.Clear();
            cKiloG.Titles.Clear();
            cKiloG.Titles.Add("Kilo Noktaları");

            // Grafik serisi (POINT tipi)
            var kiloSeri = new System.Windows.Forms.DataVisualization.Charting.Series("Kilo")
            {
                ChartType = SeriesChartType.Point,           // Nokta grafiği
                MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,            // Nokta şeklinde
                MarkerSize = 10,                             // Nokta boyutu
                Color = Color.MediumVioletRed,
                XValueType = ChartValueType.DateTime
            };

            // Noktaları ekle
            foreach (var detay in detaylar)
            {
                kiloSeri.Points.AddXY(detay.Tarih, detay.Kilo);
            }

            cKiloG.Series.Add(kiloSeri);

            // X ekseni ayarları
            var axisX = cKiloG.ChartAreas[0].AxisX;
            axisX.Title = "Tarih";
            axisX.LabelStyle.Format = "dd.MM.yyyy";
            axisX.IntervalType = DateTimeIntervalType.Days;
            axisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            axisX.LabelStyle.Angle = -45;
            axisX.IsLabelAutoFit = true;

            // Eğer sadece tek veri varsa, ekseni biraz genişlet
            if (detaylar.Count == 1)
            {
                var tarih = detaylar[0].Tarih;
                axisX.Minimum = tarih.AddDays(-1).ToOADate();
                axisX.Maximum = tarih.AddDays(1).ToOADate();
            }
            // Zoom / Scroll
            var chartArea = cKiloG.ChartAreas[0];
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;

            // Y ekseni otomatik
            var axisY = cKiloG.ChartAreas[0].AxisY;
            axisY.Title = "Kilo (kg)";
            axisY.Minimum = Double.NaN;
            axisY.Maximum = Double.NaN;
            axisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }
        private void BoyGrafigi()
        {
            var detaylar = _context.KullaniciDetaylari
           .Where(kd => kd.KullaniciId == GirisYapanKullanici.Id)
           .OrderBy(kd => kd.Tarih)
           .ToList();

            if (!detaylar.Any())
            {
                MessageBox.Show("Grafikte gösterilecek boy verisi bulunamadı.");
                return;
            }

            // Grafik ayarları
            cBoyG.Series.Clear();
            cBoyG.Titles.Clear();
            cBoyG.Titles.Add("Boy Noktaları");

            var boySeri = new System.Windows.Forms.DataVisualization.Charting.Series("Boy (m)")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.DarkOliveGreen,
                BorderWidth = 3,
                XValueType = ChartValueType.DateTime,// Tarihe göre düzgün sıralama sağlar.
                MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,// nokta şeklinde gözükmesi için
                MarkerSize = 10
            };

            foreach (var detay in detaylar)
            {
                boySeri.Points.AddXY(detay.Tarih, detay.Boy);
            }

            cBoyG.Series.Add(boySeri);

            // X ekseni ayarları (Tarih)
            var axisX = cBoyG.ChartAreas[0].AxisX;
            axisX.Title = "Tarih";
            axisX.LabelStyle.Format = "dd.MM.yyyy";
            axisX.IntervalType = DateTimeIntervalType.Days;
            axisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            axisX.LabelStyle.Angle = -45;
            axisX.IsLabelAutoFit = true;

            // Eğer tek veri varsa ekseni genişlet
            if (detaylar.Count == 1)
            {
                var tarih = detaylar[0].Tarih;
                axisX.Minimum = tarih.AddDays(-1).ToOADate();
                axisX.Maximum = tarih.AddDays(1).ToOADate();//tek veri için görünürlük sağlıyor
            }

            // Zoom ve scroll özellikleri
            var chartArea = cBoyG.ChartAreas[0];
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;

            // Y ekseni ayarları (Boy)
            var axisY = cBoyG.ChartAreas[0].AxisY;
            axisY.Title = "Boy (metre)";
            axisY.Minimum = 1.0;    // Min 1 metre 
            axisY.Maximum = 2.2;    // Max 2.2 metre
            axisY.Interval = 0.05;  // Her 5 cm'de bir çizgi
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
        private void btnKiloPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Dosyası|*.png";
                saveDialog.Title = "Grafiği Kaydet";
                saveDialog.FileName = "KiloDegisimiGrafik.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kullanıcının seçtiği dosya yoluna PNG olarak kaydet
                        cKiloG.SaveImage(saveDialog.FileName, ChartImageFormat.Png);
                        MessageBox.Show("Grafik başarıyla kaydedildi:\n" + saveDialog.FileName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnBoyPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Dosyası|*.png";
                saveDialog.Title = "Boy Grafiğini Kaydet";
                saveDialog.FileName = "BoyDegisimiGrafik.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Boy grafiğini PNG olarak kaydet
                        cBoyG.SaveImage(saveDialog.FileName, ChartImageFormat.Png);
                        MessageBox.Show("Boy grafiği başarıyla kaydedildi:\n" + saveDialog.FileName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
