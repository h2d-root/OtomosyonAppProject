using FormApp_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_Core.DataAccess
{
    public class MusteriDal
    {
        public static List<Musteri> GetByIsim(string isim)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                var result = context.Musteriler.Where(m=> m.Ad.Contains(isim)).ToList();
                return result;
            }
        }
        public static List<Musteri> GetAll()
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                var result = context.Musteriler.ToList();
                return result;
            }
        }
        public static bool Add(Musteri musteri)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    context.Musteriler.Add(musteri);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool Update(Musteri musteri)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var entity = context.Entry(musteri);
                    entity.State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
     
        }
        public static bool Delete(Musteri musteri)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var entity = context.Entry(musteri);
                    entity.State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static void StartData()
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                if (GetAll().Count == 0)
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
            }
        }
    }
}
