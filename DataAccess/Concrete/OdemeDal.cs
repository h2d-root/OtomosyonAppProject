using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
namespace DataAccess.Concrete
{
    public class OdemeDal : EFEntityRepositoryBase<Odeme, OtomasyonAppDBContext>, IOdemeDal
    {
    }
}
