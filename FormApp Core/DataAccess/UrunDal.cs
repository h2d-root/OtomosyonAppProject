using FormApp_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_Core.DataAccess
{
    public class UrunDal
    {
        public static List<Urun> GetAll()
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                var result = context.Urunler.ToList();
                return result;
            }
        }
        public static void StartData()
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                if (GetAll().Count == 0)
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

        public static bool Add(Urun urun)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    context.Urunler.Add(urun);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool Update(Urun urun)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var entity = context.Entry(urun);
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

        public static bool Updateid(Guid id, int satildi)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                var urun = context.Urunler.Where(u => u.Id == id).FirstOrDefault();
                urun.Stok -= satildi;
                urun.Satilan += satildi;
                try
                {
                    var entity = context.Entry(urun);
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

        public static bool Delete(Urun urun)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var entity = context.Entry(urun);
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
    }
}
