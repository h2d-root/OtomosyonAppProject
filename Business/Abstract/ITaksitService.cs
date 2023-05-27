using Entities.Concrete;
namespace Business.Abstract
{
    public interface ITaksitService
    {
        List<Taksit> GetAll();
        Taksit GetById(int id);
        List<Taksit> GetByMusteriId(int id);
        bool Add(Taksit taksit);
        bool Update(Taksit taksit);
        bool Delete(Taksit taksit);
    }


}
