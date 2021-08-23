using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kitap.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<CiltTipi> CiltTipleri { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kondisyon> Kondisyonlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Resim> Resimler { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}