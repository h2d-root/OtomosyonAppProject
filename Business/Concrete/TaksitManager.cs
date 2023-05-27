using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TaksitManager : ITaksitService
    {
        ITaksitDal _taksitDal;

        public TaksitManager(ITaksitDal taksitDal)
        {
            _taksitDal = taksitDal;
        }

        public bool Add(Taksit taksit)
        {
            try
            {
                _taksitDal.Add(taksit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Taksit taksit)
        {
            try
            {
                _taksitDal.Delete(taksit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Taksit> GetAll()
        {
            var result = _taksitDal.GetAll();
            return result;
        }

        public Taksit GetById(int id)
        {
            var result = _taksitDal.Get(t => t.Id == id);
            return result;
        }
        public List<Taksit> GetByMusteriId(int id)
        {
            var result = _taksitDal.GetAll(t => t.MusteriId == id);
            return result;
        }
        public bool Update(Taksit taksit)
        {
            try
            {
                _taksitDal.Update(taksit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
