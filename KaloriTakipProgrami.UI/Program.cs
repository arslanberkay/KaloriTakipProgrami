using KaloriTakipProgrami.UI.Models;

namespace KaloriTakipProgrami.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            KullaniciEkrani ekrani = new KullaniciEkrani(); 
             Kullanici kullanicim = new Kullanici();//kullan�c�bilgi g�ncellemede parametreye ihtiyac�m oldu�u i�in a�t�m


            // Application.Run(new KullaniciBilgiGuncelleEkrani(ekrani,kullanicim));

            // Application.Run(new KullaniciBilgiGuncelleEkrani(kullanicim));
            GeciciEkran splash = new GeciciEkran();
            splash.Show();
            splash.Refresh(); // Ekranı dondurmamak için


            // 3 saniye bekle
            System.Threading.Thread.Sleep(1500);

            splash.Close(); // Splash ekranı kapat


            //  Application.Run(new KullaniciGirisEkrani());


            //Application.Run(new KullaniciGrafikEkrani(kullanicim));

         Application.Run(new KullaniciGirisEkrani());


            //Application.Run(new KullaniciGrafikEkrani(kullanicim));


            // Application.Run(new KullaniciEkrani(kullanicim));
            











        }
    }
}