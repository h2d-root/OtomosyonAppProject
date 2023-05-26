using Entities.Concrete;
namespace Business.Abstract
{
    public interface IOdemeService
    {
        List<Odeme> GetAll();
        //Odeme GetById(int id);
        //List<Odeme> GetByString(string keyWord);
        bool Add(Odeme odeme);
        bool Update(Odeme odeme);
        bool Delete(Odeme odeme);
    }


}
