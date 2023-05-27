using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISatisService
    {
        List<Satis> GetAll();
        List<Satis> GetById(int id);
        bool Add(Satis satis);
        bool Update(Satis satis);
        bool Delete(Satis satis);
        Satis LastData();
    }


}
