using FormApp_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_Core.DataAccess
{
    public class SatisTaksitOdemeDal
    {
        public static bool AddSatis(Satis satis)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    context.Satislar.Add(satis);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static List<Taksit> GetAllTaksit()
        {
            using (OtomasyonAppDBContext context =new OtomasyonAppDBContext())
            {
                var result = context.Taksitler.ToList();
                return result;
            }
        }

        public static bool UpdateTaksit(Taksit taksit)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var entity = context.Entry(taksit);
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

        public static bool AddTaksit(Taksit taksit, string date, Guid barkod)
        {
            using (OtomasyonAppDBContext context = new OtomasyonAppDBContext())
            {
                try
                {
                    var result = context.Satislar.Where(s => s.SatisTarihi == date && s.BarkodId == barkod && s.MusteriId == taksit.MusteriId).OrderByDescending(i=>i.Id).FirstOrDefault();
                    taksit.SatisId = result.Id;
                    context.Taksitler.Add(taksit);
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
