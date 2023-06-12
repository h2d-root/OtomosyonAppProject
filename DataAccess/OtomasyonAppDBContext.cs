using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace DataAccess
{
    public class OtomasyonAppDBContext:DbContext
    {
        internal object entity;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=77.92.151.188;Port=5432;Database=OtomasyonDb;Username=postgres;Password=Hasanvemustafa.");
        }
        //;
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Taksit> Taksitler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
    public static class SeedData
    {
        public static void Start(OtomasyonAppDBContext context)
        {
            if (context.Musteriler.Count() == 0)
            {
                List<Musteri> musteris = new List<Musteri>()
                    {
                        new Musteri()
                        {
                            Ad = "Hasan Hüseyin",
                            Soyad = "Dursun",
                            Eposta = "h2dw1@gmail.com",
                            Telefon = "05372063686",
                            Adres = "çukur mahallesi karaböğet caddesi No:9 Afyonkarahisar - İscehisar"
                        },
                        new Musteri()
                        {
                            Ad = "Hasan Hüseyin",
                            Soyad = "Dursun",
                            Eposta = "h2dw1@gmail.com",
                            Telefon = "05372063686",
                            Adres = "çukur mahallesi karaböğet caddesi No:9 Afyonkarahisar - İscehisar"
                        },
                        new Musteri()
                        {
                            Ad = "Hasan Hüseyin",
                            Soyad = "Dursun",
                            Eposta = "h2dw1@gmail.com",
                            Telefon = "05372063686",
                            Adres = "çukur mahallesi karaböğet caddesi No:9 Afyonkarahisar - İscehisar"
                        }
                    };
                context.Musteriler.AddRange(musteris);
                context.SaveChanges();
            }
            if (context.Urunler.Count() == 0)
            {
                List<Urun> uruns = new List<Urun>()
                    {
                         new Urun()
                    {
                        Isim = "ürün 1",
                        Marka = "Asus",
                        Model = "ROG",
                        Renk = "Gümüş",
                        Stok = 10,
                        AlisTutar = Convert.ToDecimal("20.000,00"),
                        SatisTutar = Convert.ToDecimal("24.000,00"),
                        Satilan = Convert.ToInt32(0)
                    },
                              new Urun()
                    {
                        Isim = "ürün 2",
                        Marka = "Asus",
                        Model = "TUF",
                        Renk = "Siyah",
                        Stok = 10,
                        AlisTutar = Convert.ToDecimal("20.000,00"),
                        SatisTutar = Convert.ToDecimal("24.000,00"),
                        Satilan = Convert.ToInt32(0)
                    },
                                   new Urun()
                    {
                        Isim = "ürün 1",
                        Marka = "Monster",
                        Model = "Abra",
                        Renk = "Siyah",
                        Stok = 10,
                        AlisTutar = Convert.ToDecimal("20.000,00"),
                        SatisTutar = Convert.ToDecimal("25.000,00"),
                        Satilan = Convert.ToInt32(0)
                    }
                };
                context.Urunler.AddRange(uruns);
                context.SaveChanges();
            }
        }
    }
}
