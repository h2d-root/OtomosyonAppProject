using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public bool Delete(Musteri musteri)
        {
            try
            {
                _musteriDal.Delete(musteri);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Add(Musteri musteri)
        {
            try
            {
                _musteriDal.Add(musteri);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Musteri GetFirstData()
        {
            var result = _musteriDal.GetAll().FirstOrDefault();
            return result;
        }

        public List<Musteri> GetAll()
        {
            var result = _musteriDal.GetAll();
            return result;
        }

        public Musteri GetById(int id)
        {
            var result = _musteriDal.Get(m => m.Id == id);
            return result;
        }

        public List<Musteri> GetByString(string keyWord)
        {
            var result = _musteriDal.GetAll(m=>m.Ad == keyWord);
            return result;
        }

        public Musteri GetLastData()
        {
            var result = _musteriDal.GetAllOrderByDesc().FirstOrDefault();
            return result;
        }

        public bool Update(Musteri musteri)
        {
            try
            {
                _musteriDal.Update(musteri);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
