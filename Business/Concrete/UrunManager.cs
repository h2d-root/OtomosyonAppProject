using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public bool Add(Urun urun)
        {
            try
            {
                _urunDal.Add(urun);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Urun urun)
        {
            try
            {
                _urunDal.Delete(urun);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Urun> GetAll()
        {
            var result = _urunDal.GetAll();
            return result;
        }
        public Urun GetFirstData()
        {
            var result = _urunDal.GetAll().FirstOrDefault();
            return result;
        }

        public Urun GetLastData()
        {
            var result = _urunDal.GetAllOrderByDesc().FirstOrDefault();
            return result;
        }

        public bool Update(Urun urun)
        {
            try
            {
                _urunDal.Update(urun);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
