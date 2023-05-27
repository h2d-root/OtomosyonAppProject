using Entities.Concrete;
namespace Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        bool Add(Urun urun);
        Urun GetLastData();
        Urun GetFirstData();
        bool Update(Urun urun);
        bool Delete(Urun urun);

    }


}
