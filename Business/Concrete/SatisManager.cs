using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SatisManager : ISatisService
    {
        ISatisDal _satisDal;

        public SatisManager(ISatisDal satisDal)
        {
            _satisDal = satisDal;
        }

        public bool Add(Satis satis)
        {
            try
            {
                _satisDal.Add(satis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Satis satis)
        {
            try
            {
                _satisDal.Delete(satis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Satis> GetAll()
        {
            var result = _satisDal.GetAll();
            return result;
        }

        public List<Satis> GetById(int id)
        {
            var result = _satisDal.GetAll(s => s.Id == id);
            return result;
        }
        public Satis LastData()
        {
            var result = _satisDal.GetAllOrderByDesc().FirstOrDefault();
            return result;
        }

       public bool Update(Satis satis)
        {
            try
            {
                _satisDal.Update(satis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
