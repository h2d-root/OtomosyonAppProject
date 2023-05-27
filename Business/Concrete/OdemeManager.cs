using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OdemeManager : IOdemeService
    {
        IOdemeDal _odemeDal;

        public OdemeManager(IOdemeDal odemedal)
        {
            _odemeDal = odemedal;
        }

        public bool Add(Odeme odeme)
        {
            try
            {
                _odemeDal.Add(odeme);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Odeme odeme)
        {
            try
            {
                _odemeDal.Delete(odeme);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Odeme> GetAll()
        {
            var result = _odemeDal.GetAll();
            return result;
        }

        public bool Update(Odeme odeme)
        {
            try
            {
                _odemeDal.Update(odeme);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
