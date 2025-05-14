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


namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciGrafikEkrani : Form
    {
        private Kullanici GirisYapanKullanici;
        private readonly KaloriTakipDbContext _context;
        string connectionString = "Server=CRNTK\\SQLEXPRESS;database=KaloriTakipDb;trusted_connection=true;trustservercertificate=true";
        public KullaniciGrafikEkrani(Kullanici girisYapanKullanici)
        {
            _context = new KaloriTakipDbContext();
            InitializeComponent();
            
            girisYapanKullanici = _context.Kullanicilar.FirstOrDefault(aaa => aaa.Id == 1);
            GirisYapanKullanici = girisYapanKullanici;
        }

        private void KullaniciGrafikEkrani_Load(object sender, EventArgs e)
        {
            BoyGrafigi();
            KiloGrafigi();
        }
        private void KiloGrafigi()
        {
            
            string query = "SELECT * FROM KullaniciDetaylari WHERE KullaniciId = @KullaniciId";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciId", GirisYapanKullanici.Id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            // Grafik ayarları
            cKiloG.Series.Clear();
            cKiloG.Titles.Clear();
            cKiloG.Titles.Add("Kilo Değişimi");

            var kiloSeri = new System.Windows.Forms.DataVisualization.Charting.Series("Kilo")
            {
                ChartType = SeriesChartType.Spline,
                Color = Color.SteelBlue,
                BorderWidth = 3,
                XValueType = ChartValueType.DateTime
            };

            foreach (DataRow row in dt.Rows)
            {
                DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                double kilo = Convert.ToDouble(row["Kilo"]);
                kiloSeri.Points.AddXY(tarih, kilo); // Direkt tarih olarak ekleniyor
            }

            cKiloG.Series.Add(kiloSeri);

            // Eksen ayarları (X ekseni)
            var axisX = cKiloG.ChartAreas[0].AxisX;
            axisX.Title = "Tarih";
            axisX.LabelStyle.Format = "dd.MM.yyyy";
            axisX.IntervalType = DateTimeIntervalType.Days;
            axisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            axisX.LabelStyle.Angle = -45;
            axisX.IsLabelAutoFit = true;

            // Eksen ayarları (Y ekseni)
            var axisY = cKiloG.ChartAreas[0].AxisY;
            axisY.Title = "Kilo (kg)";
            axisY.Minimum = 50;     // Başlangıç kilosu
            axisY.Maximum = 120;    // En yüksek kilo sınırı
            axisY.Interval = 5;     // Her 5 kg'de bir çizgi

        }
        private void BoyGrafigi()
        {
            string query2 = "SELECT * FROM KullaniciDetaylari WHERE KullaniciId = @KullaniciId";

            DataTable dt2 = new DataTable();

            using (SqlConnection conn2 = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query2, conn2);
                cmd.Parameters.AddWithValue("@KullaniciId", GirisYapanKullanici.Id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt2);
            }

            // Grafik ayarları
            cBoyG.Series.Clear();
            cBoyG.Titles.Clear();
            cBoyG.Titles.Add("Boy Değişimi");

            var boySeri = new System.Windows.Forms.DataVisualization.Charting.Series("Boy")
            {
                ChartType = SeriesChartType.Spline,
                Color = Color.SteelBlue,
                BorderWidth = 3,
                XValueType = ChartValueType.DateTime
            };

            // Boy verilerini ekle
            foreach (DataRow row in dt2.Rows)
            {
                DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                double boy = Convert.ToDouble(row["Boy"]); // Kilo yerine Boy
                boySeri.Points.AddXY(tarih, boy); // Boyu tarih ile ilişkilendirerek ekle
            }

            cBoyG.Series.Add(boySeri);

            // Eksen ayarları (X ekseni)
            var axisX = cBoyG.ChartAreas[0].AxisX;
            axisX.Title = "Tarih";
            axisX.LabelStyle.Format = "dd.MM.yyyy";
            axisX.IntervalType = DateTimeIntervalType.Days;
            axisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            axisX.LabelStyle.Angle = -45;
            axisX.IsLabelAutoFit = true;

            // Eksen ayarları (Y ekseni)
            var axisY = cBoyG.ChartAreas[0].AxisY;
            axisY.Title = "Boy (m)";
            axisY.Minimum = 1.50;    // Boyun minimum değeri (1.5 m örneği)
            axisY.Maximum = 2.10;    // Boyun maksimum değeri (2.1 m örneği)
            axisY.Interval = 0.05;   // Boy aralığı 5 cm
        }
   
    }
}
