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
