﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class MusteriDal:EFEntityRepositoryBase<Musteri, OtomasyonAppDBContext>,IMusteriDal
    {
    }
}
