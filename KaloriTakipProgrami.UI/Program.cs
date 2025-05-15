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

             Kullanici kullanicim = new Kullanici();//kullan�c�bilgi g�ncellemede parametreye ihtiyac�m oldu�u i�in a�t�m

            // Application.Run(new KullaniciBilgiGuncelleEkrani(kullanicim));

            Application.Run(new KullaniciGirisEkrani());


            //  Application.Run(new KullaniciGrafikEkrani(kullanicim));

           // Application.Run(new KullaniciEkrani(kullanicim));










        }
    }
}