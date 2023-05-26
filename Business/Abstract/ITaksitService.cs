using Entities.Concrete;
namespace Business.Abstract
{
    public interface ITaksitService
    {
        List<Taksit> GetAll();
        Taksit GetById(int id);
        bool Add(Satis satis);
        bool Update(Satis satis);
        bool Delete(Satis satis);
    }


}
