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
            optionsBuilder.UseSqlServer("server=CRNTK\\SQLEXPRESS;database=KaloriTakipDb;trusted_connection=true;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.HasIndex(k => k.KullaniciAdi).IsUnique(); //Aynı kullanıcı adında başka bir kayıt olmayacak

                entity.HasIndex(k => k.Email).IsUnique(); //Email benzersizdir
            });
            
        }



    }
}
