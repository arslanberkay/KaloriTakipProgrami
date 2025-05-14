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
        public KullaniciGrafikEkrani(Kullanici girisYapanKullanici)
        {
            _context = new KaloriTakipDbContext();
            InitializeComponent();
            
            girisYapanKullanici = _context.Kullanicilar.FirstOrDefault(aaa => aaa.Id == 1);
            GirisYapanKullanici = girisYapanKullanici;
        }

        private void KullaniciGrafikEkrani_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=CRNTK\\SQLEXPRESS;database=KaloriTakipDb;trusted_connection=true;trustservercertificate=true";
            string query = "SELECT * FROM KullaniciDetaylari WHERE KullaniciId = @KullaniciId";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Doğru: SqlCommand kullanılıyor ve parametre ekleniyor
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciId", GirisYapanKullanici.Id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // cmd üzerinden adapter oluştur
                adapter.Fill(dt);
            }

            // Grafik ayarları
            cKiloG.Series.Clear();
            cKiloG.Titles.Clear();
            cKiloG.Titles.Add("Kilo Değişimi");

            System.Windows.Forms.DataVisualization.Charting.Series seri = new System.Windows.Forms.DataVisualization.Charting.Series("Kilo");
            seri.ChartType = SeriesChartType.Spline;
            seri.Color = Color.SteelBlue;
            seri.BorderWidth = 3;

            foreach (DataRow row in dt.Rows)
            {
                DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                double kilo = Convert.ToDouble(row["Kilo"]);
                seri.Points.AddXY(tarih.ToString("dd.MM.yyyy"), kilo);
            }

            cKiloG.Series.Add(seri);
            cKiloG.ChartAreas[0].AxisX.Title = "Tarih";
            cKiloG.ChartAreas[0].AxisY.Title = "Kilo (kg)";
            cKiloG.ChartAreas[0].AxisX.Interval = 1;
            this.cKiloG = new System.Windows.Forms.DataVisualization.Charting.Chart();
        }
    }
}
