using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Concrete
{
    public class TaksitDal: EFEntityRepositoryBase<Taksit, OtomasyonAppDBContext>,ITaksitDal
    {
    }
}
