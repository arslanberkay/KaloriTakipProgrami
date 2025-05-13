using KaloriTakipProgrami.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Context
{
    public class KaloriTakipDbContext : DbContext //Veri tabanı (Database) ile bağlantı kurulacak olan sınıf
    {
        //Database de tablolara karşılık gelecekler : 
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<KullaniciDetay> KullaniciDetaylari { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<OgunYemek> OgunYemekler { get; set; }
        public DbSet<Talep> Talepler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            optionsBuilder.UseSqlServer("server=AYGÜN\\SQLEXPRESS;database=KaloriTakipDb;trusted_connection=true;trustservercertificate=true");



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kullanici kuralları
            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.HasIndex(k => k.KullaniciAdi).IsUnique();
                entity.HasIndex(k => k.Email).IsUnique();
            });





            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Yonetici>().HasData(
                new Yonetici { Id = 1, KullaniciAdi = "furkydream", Sifre = "12345furky" },
                new Yonetici { Id = 2, KullaniciAdi = "efe31", Sifre = "efe3131" },
                new Yonetici { Id = 3, KullaniciAdi = "berkay62", Sifre = "berko6262" },
                new Yonetici { Id = 4, KullaniciAdi = "ceren", Sifre = "cero1234" },
                new Yonetici { Id = 5, KullaniciAdi = "burakAsker", Sifre = "vatanmilletsakarya" });


            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id = 1, KategoriAdi = "Çorbalar" },
                new Kategori { Id = 2, KategoriAdi = "Ana Yemekler" },
                new Kategori { Id = 3, KategoriAdi = "Tatlılar" },
                new Kategori { Id = 4, KategoriAdi = "Kahvaltılıklar" },

                new Kategori { Id = 7, KategoriAdi = "Salatalar" },
                new Kategori { Id = 8, KategoriAdi = "Atıştırmalıklar" }
            );
            modelBuilder.Entity<Kullanici>().HasData(
   new Kullanici { Id = 1, KullaniciAdi = "aliyilmaz", Sifre = "Pass123!", Isim = "Ali", Soyisim = "Yılmaz", DogumTarihi = new DateTime(1985, 2, 15), Email = "aliyilmaz@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 2, KullaniciAdi = "aysedemir", Sifre = "Pass123!", Isim = "Ayşe", Soyisim = "Demir", DogumTarihi = new DateTime(1992, 3, 22), Email = "aysedemir@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 3, KullaniciAdi = "mehmetozturk", Sifre = "Pass123!", Isim = "Mehmet", Soyisim = "Öztürk", DogumTarihi = new DateTime(1988, 11, 5), Email = "mehmetozturk@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 4, KullaniciAdi = "fatmakaya", Sifre = "Pass123!", Isim = "Fatma", Soyisim = "Kaya", DogumTarihi = new DateTime(1990, 6, 18), Email = "fatmakaya@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 5, KullaniciAdi = "ahmetcelik", Sifre = "Pass123!", Isim = "Ahmet", Soyisim = "Çelik", DogumTarihi = new DateTime(1987, 9, 30), Email = "ahmetcelik@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 6, KullaniciAdi = "elifsahin", Sifre = "Pass123!", Isim = "Elif", Soyisim = "Şahin", DogumTarihi = new DateTime(1993, 12, 2), Email = "elifsahin@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 7, KullaniciAdi = "mustafayildiz", Sifre = "Pass123!", Isim = "Mustafa", Soyisim = "Yıldız", DogumTarihi = new DateTime(1986, 4, 10), Email = "mustafayildiz@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 8, KullaniciAdi = "zeynepacar", Sifre = "Pass123!", Isim = "Zeynep", Soyisim = "Acar", DogumTarihi = new DateTime(1991, 8, 14), Email = "zeynepacar@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 9, KullaniciAdi = "muratkoc", Sifre = "Pass123!", Isim = "Murat", Soyisim = "Koç", DogumTarihi = new DateTime(1989, 1, 27), Email = "muratkoc@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 10, KullaniciAdi = "haticeyildirim", Sifre = "Pass123!", Isim = "Hatice", Soyisim = "Yıldırım", DogumTarihi = new DateTime(1994, 10, 8), Email = "haticeyildirim@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },

   new Kullanici { Id = 11, KullaniciAdi = "emrecetin", Sifre = "Pass123!", Isim = "Emre", Soyisim = "Çetin", DogumTarihi = new DateTime(1990, 12, 25), Email = "emrecetin@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 12, KullaniciAdi = "esrakaplan", Sifre = "Pass123!", Isim = "Esra", Soyisim = "Kaplan", DogumTarihi = new DateTime(1995, 5, 9), Email = "esrakaplan@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 13, KullaniciAdi = "hasanarslan", Sifre = "Pass123!", Isim = "Hasan", Soyisim = "Arslan", DogumTarihi = new DateTime(1985, 7, 16), Email = "hasanarslan@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 14, KullaniciAdi = "aylinaksoy", Sifre = "Pass123!", Isim = "Aylin", Soyisim = "Aksoy", DogumTarihi = new DateTime(1992, 9, 1), Email = "aylinaksoy@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 15, KullaniciAdi = "serkankilic", Sifre = "Pass123!", Isim = "Serkan", Soyisim = "Kılıç", DogumTarihi = new DateTime(1987, 3, 3), Email = "serkankilic@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 16, KullaniciAdi = "deryaozkan", Sifre = "Pass123!", Isim = "Derya", Soyisim = "Özkan", DogumTarihi = new DateTime(1989, 11, 20), Email = "deryaozkan@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 17, KullaniciAdi = "omersimsek", Sifre = "Pass123!", Isim = "Ömer", Soyisim = "Şimşek", DogumTarihi = new DateTime(1991, 2, 28), Email = "omersimsek@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 18, KullaniciAdi = "meltemdogan", Sifre = "Pass123!", Isim = "Meltem", Soyisim = "Doğan", DogumTarihi = new DateTime(1993, 6, 5), Email = "meltemdogan@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 19, KullaniciAdi = "canucar", Sifre = "Pass123!", Isim = "Can", Soyisim = "Uçar", DogumTarihi = new DateTime(1994, 1, 15), Email = "canucar@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 20, KullaniciAdi = "gamzesen", Sifre = "Pass123!", Isim = "Gamze", Soyisim = "Şen", DogumTarihi = new DateTime(1990, 4, 21), Email = "gamzesen@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },

   new Kullanici { Id = 21, KullaniciAdi = "yusufkaraca", Sifre = "Pass123!", Isim = "Yusuf", Soyisim = "Karaca", DogumTarihi = new DateTime(1988, 5, 30), Email = "yusufkaraca@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 22, KullaniciAdi = "ozlembal", Sifre = "Pass123!", Isim = "Özlem", Soyisim = "Bal", DogumTarihi = new DateTime(1989, 7, 7), Email = "ozlembal@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 23, KullaniciAdi = "keremtas", Sifre = "Pass123!", Isim = "Kerem", Soyisim = "Taş", DogumTarihi = new DateTime(1992, 8, 19), Email = "keremtas@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 24, KullaniciAdi = "sibelkorkmaz", Sifre = "Pass123!", Isim = "Sibel", Soyisim = "Korkmaz", DogumTarihi = new DateTime(1991, 9, 25), Email = "sibelkorkmaz@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 25, KullaniciAdi = "enginpolat", Sifre = "Pass123!", Isim = "Engin", Soyisim = "Polat", DogumTarihi = new DateTime(1986, 10, 11), Email = "enginpolat@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 26, KullaniciAdi = "pinarakin", Sifre = "Pass123!", Isim = "Pınar", Soyisim = "Akın", DogumTarihi = new DateTime(1993, 12, 17), Email = "pinarakin@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 27, KullaniciAdi = "hakanyavuz", Sifre = "Pass123!", Isim = "Hakan", Soyisim = "Yavuz", DogumTarihi = new DateTime(1987, 2, 9), Email = "hakanyavuz@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 28, KullaniciAdi = "nazliavci", Sifre = "Pass123!", Isim = "Nazlı", Soyisim = "Avcı", DogumTarihi = new DateTime(1994, 3, 13), Email = "nazliavci@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 29, KullaniciAdi = "onuraydin", Sifre = "Pass123!", Isim = "Onur", Soyisim = "Aydın", DogumTarihi = new DateTime(1990, 6, 2), Email = "onuraydin@gmail.com", Cinsiyet = "Erkek", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) },
   new Kullanici { Id = 30, KullaniciAdi = "sedasonmez", Sifre = "Pass123!", Isim = "Seda", Soyisim = "Sönmez", DogumTarihi = new DateTime(1995, 5, 27), Email = "sedasonmez@gmail.com", Cinsiyet = "Kadın", FotografYolu = null, Durum = true, KayitTarihi = new DateTime(2025, 5, 13) }
);



            modelBuilder.Entity<KullaniciDetay>().HasData(
    new KullaniciDetay { Id = 1, Boy = 198.3m, Kilo = 78.2m, Tarih = new DateTime(2022, 7, 14), KullaniciId = 1 },
    new KullaniciDetay { Id = 2, Boy = 178.1m, Kilo = 56.5m, Tarih = new DateTime(2024, 10, 26), KullaniciId = 2 },
    new KullaniciDetay { Id = 3, Boy = 191.1m, Kilo = 70.5m, Tarih = new DateTime(2024, 7, 2), KullaniciId = 3 },
    new KullaniciDetay { Id = 4, Boy = 173.9m, Kilo = 54.2m, Tarih = new DateTime(2025, 3, 6), KullaniciId = 4 },
    new KullaniciDetay { Id = 5, Boy = 180.1m, Kilo = 58.9m, Tarih = new DateTime(2021, 4, 14), KullaniciId = 5 },
    new KullaniciDetay { Id = 6, Boy = 150.5m, Kilo = 89.3m, Tarih = new DateTime(2025, 3, 7), KullaniciId = 6 },
    new KullaniciDetay { Id = 7, Boy = 190.0m, Kilo = 81.8m, Tarih = new DateTime(2025, 1, 9), KullaniciId = 7 },
    new KullaniciDetay { Id = 8, Boy = 198.9m, Kilo = 71.5m, Tarih = new DateTime(2021, 11, 6), KullaniciId = 8 },
    new KullaniciDetay { Id = 9, Boy = 178.7m, Kilo = 63.1m, Tarih = new DateTime(2023, 3, 22), KullaniciId = 9 },
    new KullaniciDetay { Id = 10, Boy = 179.2m, Kilo = 82.7m, Tarih = new DateTime(2021, 10, 15), KullaniciId = 10 },
    new KullaniciDetay { Id = 11, Boy = 185.2m, Kilo = 88.6m, Tarih = new DateTime(2023, 7, 27), KullaniciId = 11 },
    new KullaniciDetay { Id = 12, Boy = 177.8m, Kilo = 90.2m, Tarih = new DateTime(2024, 12, 19), KullaniciId = 12 },
    new KullaniciDetay { Id = 13, Boy = 198.1m, Kilo = 67.8m, Tarih = new DateTime(2022, 3, 20), KullaniciId = 13 },
    new KullaniciDetay { Id = 14, Boy = 190.4m, Kilo = 84.7m, Tarih = new DateTime(2021, 6, 28), KullaniciId = 14 },
    new KullaniciDetay { Id = 15, Boy = 186.2m, Kilo = 99.0m, Tarih = new DateTime(2023, 5, 21), KullaniciId = 15 }
   
);
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Ogun>().HasData(
                    new Ogun { Id = 1, OgunAdi = "Kahvaltı" },
                    new Ogun { Id = 2, OgunAdi = "Öğle Yemeği" },
                    new Ogun { Id = 3, OgunAdi = "Akşam Yemeği" },
                    new Ogun { Id = 4, OgunAdi = "Ara Öğün" },
                    new Ogun { Id = 5, OgunAdi = "Gece Atıştırması" }
                );
            }
            modelBuilder.Entity<Yemek>().HasData(
    // Çorbalar (KategoriId = 1)
    new Yemek { Id = 1, YemekAdi = "Mercimek Çorbası", Kalori = 120m, KategoriId = 1 },
    new Yemek { Id = 2, YemekAdi = "Domates Çorbası", Kalori = 85m, KategoriId = 1 },
    new Yemek { Id = 3, YemekAdi = "Yayla Çorbası", Kalori = 95m, KategoriId = 1 },
    new Yemek { Id = 4, YemekAdi = "Tarhana Çorbası", Kalori = 110m, KategoriId = 1 },
    new Yemek { Id = 5, YemekAdi = "Ezogelin Çorbası", Kalori = 130m, KategoriId = 1 },
    new Yemek { Id = 6, YemekAdi = "İşkembe Çorbası", Kalori = 200m, KategoriId = 1 },
    new Yemek { Id = 7, YemekAdi = "Patates Çorbası", Kalori = 140m, KategoriId = 1 },
    new Yemek { Id = 8, YemekAdi = "Sebze Çorbası", Kalori = 100m, KategoriId = 1 },
    new Yemek { Id = 9, YemekAdi = "Tavuk Suyu Çorbası", Kalori = 80m, KategoriId = 1 },
    new Yemek { Id = 10, YemekAdi = "Şehriye Çorbası", Kalori = 90m, KategoriId = 1 },
    new Yemek { Id = 11, YemekAdi = "Balık Çorbası", Kalori = 150m, KategoriId = 1 },
    new Yemek { Id = 12, YemekAdi = "Yoğurtlu Çorba", Kalori = 105m, KategoriId = 1 },
    new Yemek { Id = 13, YemekAdi = "Yoğurtlu Ispanak Çorbası", Kalori = 115m, KategoriId = 1 },
    new Yemek { Id = 14, YemekAdi = "Kelle Paça Çorbası", Kalori = 220m, KategoriId = 1 },
    new Yemek { Id = 15, YemekAdi = "Kereviz Çorbası", Kalori = 125m, KategoriId = 1 },
    new Yemek { Id = 16, YemekAdi = "Kabak Çorbası", Kalori = 110m, KategoriId = 1 },
    new Yemek { Id = 17, YemekAdi = "Bezelye Çorbası", Kalori = 130m, KategoriId = 1 },
    new Yemek { Id = 18, YemekAdi = "Pırasa Çorbası", Kalori = 95m, KategoriId = 1 },
    new Yemek { Id = 19, YemekAdi = "Mantar Çorbası", Kalori = 140m, KategoriId = 1 },
    new Yemek { Id = 20, YemekAdi = "Brokoli Çorbası", Kalori = 100m, KategoriId = 1 },
    new Yemek { Id = 21, YemekAdi = "Sütlü Mısır Çorbası", Kalori = 125m, KategoriId = 1 },
    new Yemek { Id = 22, YemekAdi = "Havuç Çorbası", Kalori = 115m, KategoriId = 1 },
    new Yemek { Id = 23, YemekAdi = "Kıymalı Çorba", Kalori = 150m, KategoriId = 1 },
    new Yemek { Id = 24, YemekAdi = "Bulgur Çorbası", Kalori = 135m, KategoriId = 1 },
    new Yemek { Id = 25, YemekAdi = "Karnabahar Çorbası", Kalori = 120m, KategoriId = 1 },
    new Yemek { Id = 26, YemekAdi = "Soğan Çorbası", Kalori = 130m, KategoriId = 1 },
    new Yemek { Id = 27, YemekAdi = "Ispanak Çorbası", Kalori = 95m, KategoriId = 1 },
    new Yemek { Id = 28, YemekAdi = "Köz Patlıcan Çorbası", Kalori = 140m, KategoriId = 1 },
    new Yemek { Id = 29, YemekAdi = "Yufkalı Çorba", Kalori = 160m, KategoriId = 1 },
    new Yemek { Id = 30, YemekAdi = "Arabaşı Çorbası", Kalori = 190m, KategoriId = 1 },

    // Ana Yemekler (KategoriId = 2)
    new Yemek { Id = 31, YemekAdi = "İskender Kebap", Kalori = 520m, KategoriId = 2 },
    new Yemek { Id = 32, YemekAdi = "Adana Kebap", Kalori = 480m, KategoriId = 2 },
    new Yemek { Id = 33, YemekAdi = "Urfa Kebap", Kalori = 460m, KategoriId = 2 },
    new Yemek { Id = 34, YemekAdi = "Tavuk Şiş Kebap", Kalori = 350m, KategoriId = 2 },
    new Yemek { Id = 35, YemekAdi = "Beyti Kebap", Kalori = 500m, KategoriId = 2 },
    new Yemek { Id = 36, YemekAdi = "Çöp Şiş Kebap", Kalori = 420m, KategoriId = 2 },
    new Yemek { Id = 37, YemekAdi = "Şiş Kebap", Kalori = 430m, KategoriId = 2 },
    new Yemek { Id = 38, YemekAdi = "Patlıcan Kebabı", Kalori = 410m, KategoriId = 2 },
    new Yemek { Id = 39, YemekAdi = "Testi Kebabı", Kalori = 550m, KategoriId = 2 },
    new Yemek { Id = 40, YemekAdi = "Tas Kebabı", Kalori = 470m, KategoriId = 2 },
    new Yemek { Id = 41, YemekAdi = "Hünkar Beğendi", Kalori = 460m, KategoriId = 2 },
    new Yemek { Id = 42, YemekAdi = "Ali Nazik", Kalori = 430m, KategoriId = 2 },
    new Yemek { Id = 43, YemekAdi = "Kuzu Tandır", Kalori = 600m, KategoriId = 2 },
    new Yemek { Id = 44, YemekAdi = "Etli Nohut", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 45, YemekAdi = "Kuru Fasulye", Kalori = 360m, KategoriId = 2 },
    new Yemek { Id = 46, YemekAdi = "Etli Bezelye", Kalori = 340m, KategoriId = 2 },
    new Yemek { Id = 47, YemekAdi = "Etli Bamya", Kalori = 330m, KategoriId = 2 },
    new Yemek { Id = 48, YemekAdi = "Etli Türlü", Kalori = 320m, KategoriId = 2 },
    new Yemek { Id = 49, YemekAdi = "Zeytinyağlı Taze Fasulye", Kalori = 250m, KategoriId = 2 },
    new Yemek { Id = 50, YemekAdi = "Zeytinyağlı Enginar", Kalori = 240m, KategoriId = 2 },
    new Yemek { Id = 51, YemekAdi = "Zeytinyağlı Yaprak Sarma", Kalori = 260m, KategoriId = 2 },
    new Yemek { Id = 52, YemekAdi = "Etli Yaprak Sarma", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 53, YemekAdi = "Kabak Dolması", Kalori = 300m, KategoriId = 2 },
    new Yemek { Id = 54, YemekAdi = "Biber Dolması", Kalori = 310m, KategoriId = 2 },
    new Yemek { Id = 55, YemekAdi = "Lahana Sarması", Kalori = 350m, KategoriId = 2 },
    new Yemek { Id = 56, YemekAdi = "İçli Köfte", Kalori = 420m, KategoriId = 2 },
    new Yemek { Id = 57, YemekAdi = "Mantı", Kalori = 450m, KategoriId = 2 },
    new Yemek { Id = 58, YemekAdi = "Su Böreği", Kalori = 400m, KategoriId = 2 },
    new Yemek { Id = 59, YemekAdi = "Kol Böreği", Kalori = 410m, KategoriId = 2 },
    new Yemek { Id = 60, YemekAdi = "Tepsi Böreği", Kalori = 430m, KategoriId = 2 },
    new Yemek { Id = 61, YemekAdi = "Paçanga Böreği", Kalori = 390m, KategoriId = 2 },
    new Yemek { Id = 62, YemekAdi = "Peynirli Börek", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 63, YemekAdi = "Ispanaklı Börek", Kalori = 370m, KategoriId = 2 },
    new Yemek { Id = 64, YemekAdi = "Sigara Böreği", Kalori = 360m, KategoriId = 2 },
    new Yemek { Id = 65, YemekAdi = "Gözleme", Kalori = 340m, KategoriId = 2 },
    new Yemek { Id = 66, YemekAdi = "Kıymalı Pide", Kalori = 450m, KategoriId = 2 },
    new Yemek { Id = 67, YemekAdi = "Peynirli Pide", Kalori = 420m, KategoriId = 2 },
    new Yemek { Id = 68, YemekAdi = "Karışık Pide", Kalori = 500m, KategoriId = 2 },
    new Yemek { Id = 69, YemekAdi = "Lahmacun", Kalori = 300m, KategoriId = 2 },
    new Yemek { Id = 70, YemekAdi = "Etli Sac Kavurma", Kalori = 440m, KategoriId = 2 },
    new Yemek { Id = 71, YemekAdi = "Tavuklu Sac Kavurma", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 72, YemekAdi = "Pilav Üstü Et", Kalori = 460m, KategoriId = 2 },
    new Yemek { Id = 73, YemekAdi = "Tavuklu Pilav", Kalori = 350m, KategoriId = 2 },
    new Yemek { Id = 74, YemekAdi = "Etli Pilav", Kalori = 370m, KategoriId = 2 },
    new Yemek { Id = 75, YemekAdi = "Şehriyeli Pilav", Kalori = 340m, KategoriId = 2 },
    new Yemek { Id = 76, YemekAdi = "Nohutlu Pilav", Kalori = 330m, KategoriId = 2 },
    new Yemek { Id = 77, YemekAdi = "Fırın Makarna", Kalori = 410m, KategoriId = 2 },
    new Yemek { Id = 78, YemekAdi = "Karnıyarık", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 79, YemekAdi = "İmam Bayıldı", Kalori = 290m, KategoriId = 2 },
    new Yemek { Id = 80, YemekAdi = "Musakka", Kalori = 400m, KategoriId = 2 },
    new Yemek { Id = 81, YemekAdi = "Et Sote", Kalori = 420m, KategoriId = 2 },
    new Yemek { Id = 82, YemekAdi = "Tavuk Sote", Kalori = 360m, KategoriId = 2 },
    new Yemek { Id = 83, YemekAdi = "Mantar Sote", Kalori = 320m, KategoriId = 2 },
    new Yemek { Id = 84, YemekAdi = "Kekikli Tavuk", Kalori = 340m, KategoriId = 2 },
    new Yemek { Id = 85, YemekAdi = "Tavuk Pirzola", Kalori = 350m, KategoriId = 2 },
    new Yemek { Id = 86, YemekAdi = "Tavuk Kanat", Kalori = 360m, KategoriId = 2 },
    new Yemek { Id = 87, YemekAdi = "Kuzu Pirzola", Kalori = 580m, KategoriId = 2 },
    new Yemek { Id = 88, YemekAdi = "Kuzu But", Kalori = 590m, KategoriId = 2 },
    new Yemek { Id = 89, YemekAdi = "Dana Antrikot", Kalori = 620m, KategoriId = 2 },
    new Yemek { Id = 90, YemekAdi = "Biftek", Kalori = 600m, KategoriId = 2 },
    new Yemek { Id = 91, YemekAdi = "Köfte", Kalori = 410m, KategoriId = 2 },
    new Yemek { Id = 92, YemekAdi = "Izgara Köfte", Kalori = 430m, KategoriId = 2 },
    new Yemek { Id = 93, YemekAdi = "İzmir Köfte", Kalori = 450m, KategoriId = 2 },
    new Yemek { Id = 94, YemekAdi = "İnegöl Köfte", Kalori = 440m, KategoriId = 2 },
    new Yemek { Id = 95, YemekAdi = "Tekirdağ Köfte", Kalori = 430m, KategoriId = 2 },
    new Yemek { Id = 96, YemekAdi = "Sivas Köfte", Kalori = 420m, KategoriId = 2 },
    new Yemek { Id = 97, YemekAdi = "Kuşbaşı Et Sote", Kalori = 400m, KategoriId = 2 },
    new Yemek { Id = 98, YemekAdi = "Köfteli Sebze Yemeği", Kalori = 350m, KategoriId = 2 },
    new Yemek { Id = 99, YemekAdi = "Etli Sebze Güveç", Kalori = 380m, KategoriId = 2 },
    new Yemek { Id = 100, YemekAdi = "–", Kalori = 0m, KategoriId = 2 }, // Placeholder if needed

    // Tatlılar (KategoriId = 3)
    new Yemek { Id = 101, YemekAdi = "Baklava", Kalori = 450m, KategoriId = 3 },
    new Yemek { Id = 102, YemekAdi = "Künefe", Kalori = 480m, KategoriId = 3 },
    new Yemek { Id = 103, YemekAdi = "Kadayıf", Kalori = 430m, KategoriId = 3 },
    new Yemek { Id = 104, YemekAdi = "Şekerpare", Kalori = 320m, KategoriId = 3 },
    new Yemek { Id = 105, YemekAdi = "Revani", Kalori = 300m, KategoriId = 3 },
    new Yemek { Id = 106, YemekAdi = "Tulumba Tatlısı", Kalori = 350m, KategoriId = 3 },
    new Yemek { Id = 107, YemekAdi = "Sütlaç", Kalori = 200m, KategoriId = 3 },
    new Yemek { Id = 108, YemekAdi = "Fırın Sütlaç", Kalori = 220m, KategoriId = 3 },
    new Yemek { Id = 109, YemekAdi = "Kazandibi", Kalori = 230m, KategoriId = 3 },
    new Yemek { Id = 110, YemekAdi = "Tavuk Göğsü", Kalori = 240m, KategoriId = 3 },
    new Yemek { Id = 111, YemekAdi = "Höşmerim", Kalori = 260m, KategoriId = 3 },
    new Yemek { Id = 112, YemekAdi = "Aşure", Kalori = 310m, KategoriId = 3 },
    new Yemek { Id = 113, YemekAdi = "İrmik Helvası", Kalori = 280m, KategoriId = 3 },
    new Yemek { Id = 114, YemekAdi = "Un Helvası", Kalori = 290m, KategoriId = 3 },
    new Yemek { Id = 115, YemekAdi = "Ekmek Kadayıfı", Kalori = 330m, KategoriId = 3 },
    new Yemek { Id = 116, YemekAdi = "Güllaç", Kalori = 180m, KategoriId = 3 },
    new Yemek { Id = 117, YemekAdi = "Trileçe", Kalori = 300m, KategoriId = 3 },
    new Yemek { Id = 118, YemekAdi = "Ayva Tatlısı", Kalori = 250m, KategoriId = 3 },
    new Yemek { Id = 119, YemekAdi = "Lokma", Kalori = 270m, KategoriId = 3 },
    new Yemek { Id = 120, YemekAdi = "Lokum", Kalori = 300m, KategoriId = 3 },
    new Yemek { Id = 121, YemekAdi = "Pestil", Kalori = 260m, KategoriId = 3 },
    new Yemek { Id = 122, YemekAdi = "Cevizli Sucuk", Kalori = 350m, KategoriId = 3 },
    new Yemek { Id = 123, YemekAdi = "Çöven Helvası", Kalori = 240m, KategoriId = 3 },
    new Yemek { Id = 124, YemekAdi = "Kestane Şekeri", Kalori = 290m, KategoriId = 3 },
    new Yemek { Id = 125, YemekAdi = "Meyveli Tatlı", Kalori = 220m, KategoriId = 3 },
    new Yemek { Id = 126, YemekAdi = "Meyve Salatası", Kalori = 180m, KategoriId = 3 },
    new Yemek { Id = 127, YemekAdi = "Kabak Tatlısı", Kalori = 210m, KategoriId = 3 },
    new Yemek { Id = 128, YemekAdi = "Badem Ezmesi", Kalori = 320m, KategoriId = 3 },
    new Yemek { Id = 129, YemekAdi = "Fıstık Ezmesi", Kalori = 330m, KategoriId = 3 },
    new Yemek { Id = 130, YemekAdi = "Maraş Dondurması", Kalori = 250m, KategoriId = 3 },
    new Yemek { Id = 131, YemekAdi = "Kaymaklı Ekmek Kadayıfı", Kalori = 340m, KategoriId = 3 },
    new Yemek { Id = 132, YemekAdi = "Dondurmalı İrmik Helvası", Kalori = 360m, KategoriId = 3 },
    new Yemek { Id = 133, YemekAdi = "Çikolatalı Sufle", Kalori = 400m, KategoriId = 3 },
    new Yemek { Id = 134, YemekAdi = "Muzlu Rulo Pasta", Kalori = 380m, KategoriId = 3 },
    new Yemek { Id = 135, YemekAdi = "Şeftalili Tatlı", Kalori = 200m, KategoriId = 3 },
    new Yemek { Id = 136, YemekAdi = "Çilekli Tatlı", Kalori = 190m, KategoriId = 3 },
    new Yemek { Id = 137, YemekAdi = "Çikolatalı Pasta", Kalori = 420m, KategoriId = 3 },
    new Yemek { Id = 138, YemekAdi = "Mandalinalı Jöle", Kalori = 160m, KategoriId = 3 },
    new Yemek { Id = 139, YemekAdi = "Sütlü Nuriye", Kalori = 310m, KategoriId = 3 },
    new Yemek { Id = 140, YemekAdi = "–", Kalori = 0m, KategoriId = 3 }, // Placeholder if needed

    // Kahvaltılıklar (KategoriId = 4)
    new Yemek { Id = 141, YemekAdi = "Simit", Kalori = 270m, KategoriId = 4 },
    new Yemek { Id = 142, YemekAdi = "Poğaça", Kalori = 320m, KategoriId = 4 },
    new Yemek { Id = 143, YemekAdi = "Açma", Kalori = 300m, KategoriId = 4 },
    new Yemek { Id = 144, YemekAdi = "Çörek", Kalori = 310m, KategoriId = 4 },
    new Yemek { Id = 145, YemekAdi = "Menemen", Kalori = 250m, KategoriId = 4 },
    new Yemek { Id = 146, YemekAdi = "Sucuklu Yumurta", Kalori = 330m, KategoriId = 4 },
    new Yemek { Id = 147, YemekAdi = "Pastırmalı Yumurta", Kalori = 350m, KategoriId = 4 },
    new Yemek { Id = 148, YemekAdi = "Sahanda Yumurta", Kalori = 200m, KategoriId = 4 },
    new Yemek { Id = 149, YemekAdi = "Omlet", Kalori = 220m, KategoriId = 4 },
    new Yemek { Id = 150, YemekAdi = "Tost", Kalori = 260m, KategoriId = 4 },
    new Yemek { Id = 151, YemekAdi = "Kaşarlı Tost", Kalori = 280m, KategoriId = 4 },
    new Yemek { Id = 152, YemekAdi = "Bal-Kaymak", Kalori = 360m, KategoriId = 4 },
    new Yemek { Id = 153, YemekAdi = "Reçel Tabağı", Kalori = 180m, KategoriId = 4 },
    new Yemek { Id = 154, YemekAdi = "Beyaz Peynir", Kalori = 120m, KategoriId = 4 },
    new Yemek { Id = 155, YemekAdi = "Ezine Peyniri", Kalori = 130m, KategoriId = 4 },
    new Yemek { Id = 156, YemekAdi = "Tulum Peyniri", Kalori = 140m, KategoriId = 4 },
    new Yemek { Id = 157, YemekAdi = "Zeytin Tabağı", Kalori = 80m, KategoriId = 4 },
    new Yemek { Id = 158, YemekAdi = "Domates-Salatalık", Kalori = 50m, KategoriId = 4 },
    new Yemek { Id = 159, YemekAdi = "Tahin-Pekmez", Kalori = 340m, KategoriId = 4 },
    new Yemek { Id = 160, YemekAdi = "Nutella", Kalori = 330m, KategoriId = 4 },
    new Yemek { Id = 161, YemekAdi = "Ceviz", Kalori = 180m, KategoriId = 4 },
    new Yemek { Id = 162, YemekAdi = "Badem", Kalori = 170m, KategoriId = 4 },
    new Yemek { Id = 163, YemekAdi = "Taze Ekmek", Kalori = 260m, KategoriId = 4 },
    new Yemek { Id = 164, YemekAdi = "Tereyağı", Kalori = 180m, KategoriId = 4 },
    new Yemek { Id = 165, YemekAdi = "Çılbır", Kalori = 240m, KategoriId = 4 },
    new Yemek { Id = 166, YemekAdi = "Karışık Kahvaltı Tabağı", Kalori = 400m, KategoriId = 4 },
    new Yemek { Id = 167, YemekAdi = "Lorlu Gözleme", Kalori = 350m, KategoriId = 4 },
    new Yemek { Id = 168, YemekAdi = "Sucuklu Gözleme", Kalori = 380m, KategoriId = 4 },
    new Yemek { Id = 169, YemekAdi = "Peynirli Gözleme", Kalori = 360m, KategoriId = 4 },
    new Yemek { Id = 170, YemekAdi = "Patatesli Gözleme", Kalori = 340m, KategoriId = 4 },



    // Salatalar (KategoriId = 7)
    new Yemek { Id = 191, YemekAdi = "Çoban Salatası", Kalori = 120m, KategoriId = 7 },
    new Yemek { Id = 192, YemekAdi = "Gavurdağı Salatası", Kalori = 140m, KategoriId = 7 },
    new Yemek { Id = 193, YemekAdi = "Roka Salatası", Kalori = 100m, KategoriId = 7 },
    new Yemek { Id = 194, YemekAdi = "Akdeniz Salatası", Kalori = 130m, KategoriId = 7 },
    new Yemek { Id = 195, YemekAdi = "Tavuklu Salata", Kalori = 220m, KategoriId = 7 },
    new Yemek { Id = 196, YemekAdi = "Ton Balıklı Salata", Kalori = 200m, KategoriId = 7 },
    new Yemek { Id = 197, YemekAdi = "Enginar Salatası", Kalori = 180m, KategoriId = 7 },
    new Yemek { Id = 198, YemekAdi = "Patlıcan Salatası", Kalori = 160m, KategoriId = 7 },
    new Yemek { Id = 199, YemekAdi = "Şakşuka", Kalori = 150m, KategoriId = 7 },
    new Yemek { Id = 200, YemekAdi = "Yoğurtlu Semizotu Salatası", Kalori = 170m, KategoriId = 7 },
    new Yemek { Id = 201, YemekAdi = "Yeşil Mercimek Salatası", Kalori = 190m, KategoriId = 7 },
    new Yemek { Id = 202, YemekAdi = "Nohut Salatası", Kalori = 200m, KategoriId = 7 },
    new Yemek { Id = 203, YemekAdi = "Kısır", Kalori = 210m, KategoriId = 7 },
    new Yemek { Id = 204, YemekAdi = "Patates Salatası", Kalori = 230m, KategoriId = 7 },
    new Yemek { Id = 205, YemekAdi = "Makarna Salatası", Kalori = 240m, KategoriId = 7 },
    new Yemek { Id = 206, YemekAdi = "Pancar Salatası", Kalori = 180m, KategoriId = 7 },
    new Yemek { Id = 207, YemekAdi = "Turp Salatası", Kalori = 170m, KategoriId = 7 },
    new Yemek { Id = 208, YemekAdi = "Bulgur Pilavı Salatası", Kalori = 200m, KategoriId = 7 },
    new Yemek { Id = 209, YemekAdi = "Peynirli Salata", Kalori = 220m, KategoriId = 7 },
    new Yemek { Id = 210, YemekAdi = "Sebze Salatası", Kalori = 150m, KategoriId = 7 },

    // Atıştırmalıklar (KategoriId = 8)
    new Yemek { Id = 211, YemekAdi = "Midye Dolma", Kalori = 180m, KategoriId = 8 },
    new Yemek { Id = 212, YemekAdi = "Midye Tava", Kalori = 220m, KategoriId = 8 },
    new Yemek { Id = 213, YemekAdi = "Ciğer Tava", Kalori = 250m, KategoriId = 8 },
    new Yemek { Id = 214, YemekAdi = "Çiğ Köfte", Kalori = 200m, KategoriId = 8 },
    new Yemek { Id = 215, YemekAdi = "Patates Kızartması", Kalori = 300m, KategoriId = 8 },
    new Yemek { Id = 216, YemekAdi = "Soğan Halkası", Kalori = 280m, KategoriId = 8 },
    new Yemek { Id = 217, YemekAdi = "Patates Kroket", Kalori = 260m, KategoriId = 8 },
    new Yemek { Id = 218, YemekAdi = "Parmak Patates", Kalori = 290m, KategoriId = 8 },
    new Yemek { Id = 219, YemekAdi = "Peynirli Çubuk", Kalori = 240m, KategoriId = 8 },
    new Yemek { Id = 220, YemekAdi = "Humus", Kalori = 180m, KategoriId = 8 },
    new Yemek { Id = 221, YemekAdi = "Cacık", Kalori = 80m, KategoriId = 8 },
    new Yemek { Id = 222, YemekAdi = "Kısır Topları", Kalori = 150m, KategoriId = 8 },
    new Yemek { Id = 223, YemekAdi = "Patlıcan Mücveri", Kalori = 210m, KategoriId = 8 },
    new Yemek { Id = 224, YemekAdi = "Mücver", Kalori = 200m, KategoriId = 8 },
    new Yemek { Id = 225, YemekAdi = "Sigara Böreği", Kalori = 360m, KategoriId = 8 },
    new Yemek { Id = 226, YemekAdi = "Peynirli Börek", Kalori = 380m, KategoriId = 8 },
    new Yemek { Id = 227, YemekAdi = "Ispanaklı Börek", Kalori = 370m, KategoriId = 8 },
    new Yemek { Id = 228, YemekAdi = "Paçanga Böreği", Kalori = 390m, KategoriId = 8 },
    new Yemek { Id = 229, YemekAdi = "Lavaş Pizza", Kalori = 330m, KategoriId = 8 },
    new Yemek { Id = 230, YemekAdi = "Kumpir", Kalori = 500m, KategoriId = 8 },
    new Yemek { Id = 231, YemekAdi = "Tavuk Nugget", Kalori = 450m, KategoriId = 8 },
    new Yemek { Id = 232, YemekAdi = "Mini Börek Çeşitleri", Kalori = 340m, KategoriId = 8 },
    new Yemek { Id = 233, YemekAdi = "Mini Köfte", Kalori = 250m, KategoriId = 8 },
    new Yemek { Id = 234, YemekAdi = "Mozzarella Stick", Kalori = 300m, KategoriId = 8 },
    new Yemek { Id = 235, YemekAdi = "Soğan Halkası", Kalori = 280m, KategoriId = 8 },
    new Yemek { Id = 236, YemekAdi = "Patates Cipsi", Kalori = 320m, KategoriId = 8 },
    new Yemek { Id = 237, YemekAdi = "Tuzlu Çekirdek", Kalori = 250m, KategoriId = 8 },
    new Yemek { Id = 238, YemekAdi = "Kabak Çekirdeği", Kalori = 260m, KategoriId = 8 },
    new Yemek { Id = 239, YemekAdi = "Antep Fıstığı", Kalori = 300m, KategoriId = 8 },
    new Yemek { Id = 240, YemekAdi = "Ceviz", Kalori = 185m, KategoriId = 8 },
    new Yemek { Id = 241, YemekAdi = "Badem", Kalori = 165m, KategoriId = 8 },
    new Yemek { Id = 242, YemekAdi = "Fındık", Kalori = 180m, KategoriId = 8 },
    new Yemek { Id = 243, YemekAdi = "Cips", Kalori = 310m, KategoriId = 8 },
    new Yemek { Id = 244, YemekAdi = "Patlamış Mısır", Kalori = 100m, KategoriId = 8 },
    new Yemek { Id = 245, YemekAdi = "Simit", Kalori = 270m, KategoriId = 8 },
    new Yemek { Id = 246, YemekAdi = "Poğaça", Kalori = 320m, KategoriId = 8 },
    new Yemek { Id = 247, YemekAdi = "Mini Pizza", Kalori = 410m, KategoriId = 8 },
    new Yemek { Id = 248, YemekAdi = "Mini Hamburger", Kalori = 450m, KategoriId = 8 },
    new Yemek { Id = 249, YemekAdi = "Atıştırmalık Tabağı", Kalori = 360m, KategoriId = 8 },
    new Yemek { Id = 250, YemekAdi = "Çerez Tabağı", Kalori = 340m, KategoriId = 8 }
);
           



            base.OnModelCreating(modelBuilder);





        }
    }
}

