using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FotografYolu",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Çorbalar" },
                    { 2, "Ana Yemekler" },
                    { 3, "Tatlılar" },
                    { 4, "Kahvaltılıklar" },
                    { 7, "Salatalar" },
                    { 8, "Atıştırmalıklar" }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Cinsiyet", "DogumTarihi", "Durum", "Email", "FotografYolu", "Isim", "KayitTarihi", "KullaniciAdi", "Sifre", "Soyisim" },
                values: new object[,]
                {
                    { 1, "Erkek", new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "aliyilmaz@gmail.com", null, "Ali", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliyilmaz", "Pass123!", "Yılmaz" },
                    { 2, "Kadın", new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "aysedemir@gmail.com", null, "Ayşe", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysedemir", "Pass123!", "Demir" },
                    { 3, "Erkek", new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "mehmetozturk@gmail.com", null, "Mehmet", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmetozturk", "Pass123!", "Öztürk" },
                    { 4, "Kadın", new DateTime(1990, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "fatmakaya@gmail.com", null, "Fatma", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatmakaya", "Pass123!", "Kaya" },
                    { 5, "Erkek", new DateTime(1987, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ahmetcelik@gmail.com", null, "Ahmet", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmetcelik", "Pass123!", "Çelik" },
                    { 6, "Kadın", new DateTime(1993, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "elifsahin@gmail.com", null, "Elif", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "elifsahin", "Pass123!", "Şahin" },
                    { 7, "Erkek", new DateTime(1986, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "mustafayildiz@gmail.com", null, "Mustafa", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mustafayildiz", "Pass123!", "Yıldız" },
                    { 8, "Kadın", new DateTime(1991, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "zeynepacar@gmail.com", null, "Zeynep", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynepacar", "Pass123!", "Acar" },
                    { 9, "Erkek", new DateTime(1989, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "muratkoc@gmail.com", null, "Murat", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "muratkoc", "Pass123!", "Koç" },
                    { 10, "Kadın", new DateTime(1994, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "haticeyildirim@gmail.com", null, "Hatice", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "haticeyildirim", "Pass123!", "Yıldırım" },
                    { 11, "Erkek", new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "emrecetin@gmail.com", null, "Emre", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "emrecetin", "Pass123!", "Çetin" },
                    { 12, "Kadın", new DateTime(1995, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "esrakaplan@gmail.com", null, "Esra", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "esrakaplan", "Pass123!", "Kaplan" },
                    { 13, "Erkek", new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "hasanarslan@gmail.com", null, "Hasan", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hasanarslan", "Pass123!", "Arslan" },
                    { 14, "Kadın", new DateTime(1992, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "aylinaksoy@gmail.com", null, "Aylin", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "aylinaksoy", "Pass123!", "Aksoy" },
                    { 15, "Erkek", new DateTime(1987, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "serkankilic@gmail.com", null, "Serkan", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "serkankilic", "Pass123!", "Kılıç" },
                    { 16, "Kadın", new DateTime(1989, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "deryaozkan@gmail.com", null, "Derya", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "deryaozkan", "Pass123!", "Özkan" },
                    { 17, "Erkek", new DateTime(1991, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "omersimsek@gmail.com", null, "Ömer", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "omersimsek", "Pass123!", "Şimşek" },
                    { 18, "Kadın", new DateTime(1993, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "meltemdogan@gmail.com", null, "Meltem", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "meltemdogan", "Pass123!", "Doğan" },
                    { 19, "Erkek", new DateTime(1994, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "canucar@gmail.com", null, "Can", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "canucar", "Pass123!", "Uçar" },
                    { 20, "Kadın", new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "gamzesen@gmail.com", null, "Gamze", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "gamzesen", "Pass123!", "Şen" },
                    { 21, "Erkek", new DateTime(1988, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "yusufkaraca@gmail.com", null, "Yusuf", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "yusufkaraca", "Pass123!", "Karaca" },
                    { 22, "Kadın", new DateTime(1989, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ozlembal@gmail.com", null, "Özlem", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ozlembal", "Pass123!", "Bal" },
                    { 23, "Erkek", new DateTime(1992, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "keremtas@gmail.com", null, "Kerem", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "keremtas", "Pass123!", "Taş" },
                    { 24, "Kadın", new DateTime(1991, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "sibelkorkmaz@gmail.com", null, "Sibel", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "sibelkorkmaz", "Pass123!", "Korkmaz" },
                    { 25, "Erkek", new DateTime(1986, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "enginpolat@gmail.com", null, "Engin", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "enginpolat", "Pass123!", "Polat" },
                    { 26, "Kadın", new DateTime(1993, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "pinarakin@gmail.com", null, "Pınar", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "pinarakin", "Pass123!", "Akın" },
                    { 27, "Erkek", new DateTime(1987, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "hakanyavuz@gmail.com", null, "Hakan", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hakanyavuz", "Pass123!", "Yavuz" },
                    { 28, "Kadın", new DateTime(1994, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "nazliavci@gmail.com", null, "Nazlı", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "nazliavci", "Pass123!", "Avcı" },
                    { 29, "Erkek", new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "onuraydin@gmail.com", null, "Onur", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "onuraydin", "Pass123!", "Aydın" },
                    { 30, "Kadın", new DateTime(1995, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "sedasonmez@gmail.com", null, "Seda", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "sedasonmez", "Pass123!", "Sönmez" }
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "OgunAdi" },
                values: new object[,]
                {
                    { 1, "Kahvaltı" },
                    { 2, "Öğle Yemeği" },
                    { 3, "Akşam Yemeği" },
                    { 4, "Ara Öğün" },
                    { 5, "Gece Atıştırması" }
                });

            migrationBuilder.InsertData(
                table: "Yoneticiler",
                columns: new[] { "Id", "KullaniciAdi", "Sifre" },
                values: new object[,]
                {
                    { 1, "furkydream", "12345furky" },
                    { 2, "efe31", "efe3131" },
                    { 3, "berkay62", "berko6262" },
                    { 4, "ceren", "cero1234" },
                    { 5, "burakAsker", "vatanmilletsakarya" }
                });

            migrationBuilder.InsertData(
                table: "KullaniciDetaylari",
                columns: new[] { "Id", "Boy", "Kilo", "KullaniciId", "Tarih" },
                values: new object[,]
                {
                    { 1, 198.3m, 78.2m, 1, new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 178.1m, 56.5m, 2, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 191.1m, 70.5m, 3, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 173.9m, 54.2m, 4, new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 180.1m, 58.9m, 5, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 150.5m, 89.3m, 6, new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 190.0m, 81.8m, 7, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 198.9m, 71.5m, 8, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 178.7m, 63.1m, 9, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 179.2m, 82.7m, 10, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 185.2m, 88.6m, 11, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 177.8m, 90.2m, 12, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 198.1m, 67.8m, 13, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 190.4m, 84.7m, 14, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 186.2m, 99.0m, 15, new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Kalori", "KategoriId", "YemekAdi" },
                values: new object[,]
                {
                    { 1, 120m, 1, "Mercimek Çorbası" },
                    { 2, 85m, 1, "Domates Çorbası" },
                    { 3, 95m, 1, "Yayla Çorbası" },
                    { 4, 110m, 1, "Tarhana Çorbası" },
                    { 5, 130m, 1, "Ezogelin Çorbası" },
                    { 6, 200m, 1, "İşkembe Çorbası" },
                    { 7, 140m, 1, "Patates Çorbası" },
                    { 8, 100m, 1, "Sebze Çorbası" },
                    { 9, 80m, 1, "Tavuk Suyu Çorbası" },
                    { 10, 90m, 1, "Şehriye Çorbası" },
                    { 11, 150m, 1, "Balık Çorbası" },
                    { 12, 105m, 1, "Yoğurtlu Çorba" },
                    { 13, 115m, 1, "Yoğurtlu Ispanak Çorbası" },
                    { 14, 220m, 1, "Kelle Paça Çorbası" },
                    { 15, 125m, 1, "Kereviz Çorbası" },
                    { 16, 110m, 1, "Kabak Çorbası" },
                    { 17, 130m, 1, "Bezelye Çorbası" },
                    { 18, 95m, 1, "Pırasa Çorbası" },
                    { 19, 140m, 1, "Mantar Çorbası" },
                    { 20, 100m, 1, "Brokoli Çorbası" },
                    { 21, 125m, 1, "Sütlü Mısır Çorbası" },
                    { 22, 115m, 1, "Havuç Çorbası" },
                    { 23, 150m, 1, "Kıymalı Çorba" },
                    { 24, 135m, 1, "Bulgur Çorbası" },
                    { 25, 120m, 1, "Karnabahar Çorbası" },
                    { 26, 130m, 1, "Soğan Çorbası" },
                    { 27, 95m, 1, "Ispanak Çorbası" },
                    { 28, 140m, 1, "Köz Patlıcan Çorbası" },
                    { 29, 160m, 1, "Yufkalı Çorba" },
                    { 30, 190m, 1, "Arabaşı Çorbası" },
                    { 31, 520m, 2, "İskender Kebap" },
                    { 32, 480m, 2, "Adana Kebap" },
                    { 33, 460m, 2, "Urfa Kebap" },
                    { 34, 350m, 2, "Tavuk Şiş Kebap" },
                    { 35, 500m, 2, "Beyti Kebap" },
                    { 36, 420m, 2, "Çöp Şiş Kebap" },
                    { 37, 430m, 2, "Şiş Kebap" },
                    { 38, 410m, 2, "Patlıcan Kebabı" },
                    { 39, 550m, 2, "Testi Kebabı" },
                    { 40, 470m, 2, "Tas Kebabı" },
                    { 41, 460m, 2, "Hünkar Beğendi" },
                    { 42, 430m, 2, "Ali Nazik" },
                    { 43, 600m, 2, "Kuzu Tandır" },
                    { 44, 380m, 2, "Etli Nohut" },
                    { 45, 360m, 2, "Kuru Fasulye" },
                    { 46, 340m, 2, "Etli Bezelye" },
                    { 47, 330m, 2, "Etli Bamya" },
                    { 48, 320m, 2, "Etli Türlü" },
                    { 49, 250m, 2, "Zeytinyağlı Taze Fasulye" },
                    { 50, 240m, 2, "Zeytinyağlı Enginar" },
                    { 51, 260m, 2, "Zeytinyağlı Yaprak Sarma" },
                    { 52, 380m, 2, "Etli Yaprak Sarma" },
                    { 53, 300m, 2, "Kabak Dolması" },
                    { 54, 310m, 2, "Biber Dolması" },
                    { 55, 350m, 2, "Lahana Sarması" },
                    { 56, 420m, 2, "İçli Köfte" },
                    { 57, 450m, 2, "Mantı" },
                    { 58, 400m, 2, "Su Böreği" },
                    { 59, 410m, 2, "Kol Böreği" },
                    { 60, 430m, 2, "Tepsi Böreği" },
                    { 61, 390m, 2, "Paçanga Böreği" },
                    { 62, 380m, 2, "Peynirli Börek" },
                    { 63, 370m, 2, "Ispanaklı Börek" },
                    { 64, 360m, 2, "Sigara Böreği" },
                    { 65, 340m, 2, "Gözleme" },
                    { 66, 450m, 2, "Kıymalı Pide" },
                    { 67, 420m, 2, "Peynirli Pide" },
                    { 68, 500m, 2, "Karışık Pide" },
                    { 69, 300m, 2, "Lahmacun" },
                    { 70, 440m, 2, "Etli Sac Kavurma" },
                    { 71, 380m, 2, "Tavuklu Sac Kavurma" },
                    { 72, 460m, 2, "Pilav Üstü Et" },
                    { 73, 350m, 2, "Tavuklu Pilav" },
                    { 74, 370m, 2, "Etli Pilav" },
                    { 75, 340m, 2, "Şehriyeli Pilav" },
                    { 76, 330m, 2, "Nohutlu Pilav" },
                    { 77, 410m, 2, "Fırın Makarna" },
                    { 78, 380m, 2, "Karnıyarık" },
                    { 79, 290m, 2, "İmam Bayıldı" },
                    { 80, 400m, 2, "Musakka" },
                    { 81, 420m, 2, "Et Sote" },
                    { 82, 360m, 2, "Tavuk Sote" },
                    { 83, 320m, 2, "Mantar Sote" },
                    { 84, 340m, 2, "Kekikli Tavuk" },
                    { 85, 350m, 2, "Tavuk Pirzola" },
                    { 86, 360m, 2, "Tavuk Kanat" },
                    { 87, 580m, 2, "Kuzu Pirzola" },
                    { 88, 590m, 2, "Kuzu But" },
                    { 89, 620m, 2, "Dana Antrikot" },
                    { 90, 600m, 2, "Biftek" },
                    { 91, 410m, 2, "Köfte" },
                    { 92, 430m, 2, "Izgara Köfte" },
                    { 93, 450m, 2, "İzmir Köfte" },
                    { 94, 440m, 2, "İnegöl Köfte" },
                    { 95, 430m, 2, "Tekirdağ Köfte" },
                    { 96, 420m, 2, "Sivas Köfte" },
                    { 97, 400m, 2, "Kuşbaşı Et Sote" },
                    { 98, 350m, 2, "Köfteli Sebze Yemeği" },
                    { 99, 380m, 2, "Etli Sebze Güveç" },
                    { 100, 0m, 2, "–" },
                    { 101, 450m, 3, "Baklava" },
                    { 102, 480m, 3, "Künefe" },
                    { 103, 430m, 3, "Kadayıf" },
                    { 104, 320m, 3, "Şekerpare" },
                    { 105, 300m, 3, "Revani" },
                    { 106, 350m, 3, "Tulumba Tatlısı" },
                    { 107, 200m, 3, "Sütlaç" },
                    { 108, 220m, 3, "Fırın Sütlaç" },
                    { 109, 230m, 3, "Kazandibi" },
                    { 110, 240m, 3, "Tavuk Göğsü" },
                    { 111, 260m, 3, "Höşmerim" },
                    { 112, 310m, 3, "Aşure" },
                    { 113, 280m, 3, "İrmik Helvası" },
                    { 114, 290m, 3, "Un Helvası" },
                    { 115, 330m, 3, "Ekmek Kadayıfı" },
                    { 116, 180m, 3, "Güllaç" },
                    { 117, 300m, 3, "Trileçe" },
                    { 118, 250m, 3, "Ayva Tatlısı" },
                    { 119, 270m, 3, "Lokma" },
                    { 120, 300m, 3, "Lokum" },
                    { 121, 260m, 3, "Pestil" },
                    { 122, 350m, 3, "Cevizli Sucuk" },
                    { 123, 240m, 3, "Çöven Helvası" },
                    { 124, 290m, 3, "Kestane Şekeri" },
                    { 125, 220m, 3, "Meyveli Tatlı" },
                    { 126, 180m, 3, "Meyve Salatası" },
                    { 127, 210m, 3, "Kabak Tatlısı" },
                    { 128, 320m, 3, "Badem Ezmesi" },
                    { 129, 330m, 3, "Fıstık Ezmesi" },
                    { 130, 250m, 3, "Maraş Dondurması" },
                    { 131, 340m, 3, "Kaymaklı Ekmek Kadayıfı" },
                    { 132, 360m, 3, "Dondurmalı İrmik Helvası" },
                    { 133, 400m, 3, "Çikolatalı Sufle" },
                    { 134, 380m, 3, "Muzlu Rulo Pasta" },
                    { 135, 200m, 3, "Şeftalili Tatlı" },
                    { 136, 190m, 3, "Çilekli Tatlı" },
                    { 137, 420m, 3, "Çikolatalı Pasta" },
                    { 138, 160m, 3, "Mandalinalı Jöle" },
                    { 139, 310m, 3, "Sütlü Nuriye" },
                    { 140, 0m, 3, "–" },
                    { 141, 270m, 4, "Simit" },
                    { 142, 320m, 4, "Poğaça" },
                    { 143, 300m, 4, "Açma" },
                    { 144, 310m, 4, "Çörek" },
                    { 145, 250m, 4, "Menemen" },
                    { 146, 330m, 4, "Sucuklu Yumurta" },
                    { 147, 350m, 4, "Pastırmalı Yumurta" },
                    { 148, 200m, 4, "Sahanda Yumurta" },
                    { 149, 220m, 4, "Omlet" },
                    { 150, 260m, 4, "Tost" },
                    { 151, 280m, 4, "Kaşarlı Tost" },
                    { 152, 360m, 4, "Bal-Kaymak" },
                    { 153, 180m, 4, "Reçel Tabağı" },
                    { 154, 120m, 4, "Beyaz Peynir" },
                    { 155, 130m, 4, "Ezine Peyniri" },
                    { 156, 140m, 4, "Tulum Peyniri" },
                    { 157, 80m, 4, "Zeytin Tabağı" },
                    { 158, 50m, 4, "Domates-Salatalık" },
                    { 159, 340m, 4, "Tahin-Pekmez" },
                    { 160, 330m, 4, "Nutella" },
                    { 161, 180m, 4, "Ceviz" },
                    { 162, 170m, 4, "Badem" },
                    { 163, 260m, 4, "Taze Ekmek" },
                    { 164, 180m, 4, "Tereyağı" },
                    { 165, 240m, 4, "Çılbır" },
                    { 166, 400m, 4, "Karışık Kahvaltı Tabağı" },
                    { 167, 350m, 4, "Lorlu Gözleme" },
                    { 168, 380m, 4, "Sucuklu Gözleme" },
                    { 169, 360m, 4, "Peynirli Gözleme" },
                    { 170, 340m, 4, "Patatesli Gözleme" },
                    { 191, 120m, 7, "Çoban Salatası" },
                    { 192, 140m, 7, "Gavurdağı Salatası" },
                    { 193, 100m, 7, "Roka Salatası" },
                    { 194, 130m, 7, "Akdeniz Salatası" },
                    { 195, 220m, 7, "Tavuklu Salata" },
                    { 196, 200m, 7, "Ton Balıklı Salata" },
                    { 197, 180m, 7, "Enginar Salatası" },
                    { 198, 160m, 7, "Patlıcan Salatası" },
                    { 199, 150m, 7, "Şakşuka" },
                    { 200, 170m, 7, "Yoğurtlu Semizotu Salatası" },
                    { 201, 190m, 7, "Yeşil Mercimek Salatası" },
                    { 202, 200m, 7, "Nohut Salatası" },
                    { 203, 210m, 7, "Kısır" },
                    { 204, 230m, 7, "Patates Salatası" },
                    { 205, 240m, 7, "Makarna Salatası" },
                    { 206, 180m, 7, "Pancar Salatası" },
                    { 207, 170m, 7, "Turp Salatası" },
                    { 208, 200m, 7, "Bulgur Pilavı Salatası" },
                    { 209, 220m, 7, "Peynirli Salata" },
                    { 210, 150m, 7, "Sebze Salatası" },
                    { 211, 180m, 8, "Midye Dolma" },
                    { 212, 220m, 8, "Midye Tava" },
                    { 213, 250m, 8, "Ciğer Tava" },
                    { 214, 200m, 8, "Çiğ Köfte" },
                    { 215, 300m, 8, "Patates Kızartması" },
                    { 216, 280m, 8, "Soğan Halkası" },
                    { 217, 260m, 8, "Patates Kroket" },
                    { 218, 290m, 8, "Parmak Patates" },
                    { 219, 240m, 8, "Peynirli Çubuk" },
                    { 220, 180m, 8, "Humus" },
                    { 221, 80m, 8, "Cacık" },
                    { 222, 150m, 8, "Kısır Topları" },
                    { 223, 210m, 8, "Patlıcan Mücveri" },
                    { 224, 200m, 8, "Mücver" },
                    { 225, 360m, 8, "Sigara Böreği" },
                    { 226, 380m, 8, "Peynirli Börek" },
                    { 227, 370m, 8, "Ispanaklı Börek" },
                    { 228, 390m, 8, "Paçanga Böreği" },
                    { 229, 330m, 8, "Lavaş Pizza" },
                    { 230, 500m, 8, "Kumpir" },
                    { 231, 450m, 8, "Tavuk Nugget" },
                    { 232, 340m, 8, "Mini Börek Çeşitleri" },
                    { 233, 250m, 8, "Mini Köfte" },
                    { 234, 300m, 8, "Mozzarella Stick" },
                    { 235, 280m, 8, "Soğan Halkası" },
                    { 236, 320m, 8, "Patates Cipsi" },
                    { 237, 250m, 8, "Tuzlu Çekirdek" },
                    { 238, 260m, 8, "Kabak Çekirdeği" },
                    { 239, 300m, 8, "Antep Fıstığı" },
                    { 240, 185m, 8, "Ceviz" },
                    { 241, 165m, 8, "Badem" },
                    { 242, 180m, 8, "Fındık" },
                    { 243, 310m, 8, "Cips" },
                    { 244, 100m, 8, "Patlamış Mısır" },
                    { 245, 270m, 8, "Simit" },
                    { 246, 320m, 8, "Poğaça" },
                    { 247, 410m, 8, "Mini Pizza" },
                    { 248, 450m, 8, "Mini Hamburger" },
                    { 249, 360m, 8, "Atıştırmalık Tabağı" },
                    { 250, 340m, 8, "Çerez Tabağı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FotografYolu",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
