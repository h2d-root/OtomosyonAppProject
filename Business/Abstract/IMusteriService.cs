using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        Musteri GetById(int id);
        Musteri GetByString(string keyWord);
        bool Add(Musteri musteri);
       bool Update(Musteri musteri);
        bool Delete(Musteri musteri);
        Musteri FirstData();
        Musteri LastData();
    }


}
