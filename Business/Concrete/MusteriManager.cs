﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Musteri FirstData()
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

        public Musteri GetByString(string keyWord)
        {
            throw new NotImplementedException();
        }

        public Musteri LastData()
        {
            throw new NotImplementedException();
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
