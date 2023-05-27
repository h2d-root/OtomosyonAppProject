using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Form1>().AsSelf();
            builder.RegisterType<MusteriManager>().As<IMusteriService>().PreserveExistingDefaults();


            builder.RegisterType<UrunIslemForm>().AsSelf();
            builder.RegisterType<UrunManager>().As<IUrunService>().PreserveExistingDefaults();
            //builder.RegisterType<TaksitManager>().As<ITaksitService>();
            //builder.RegisterType<SatisManager>().As<ISatisService>();
            //builder.RegisterType<OdemeManager>().As<IOdemeService>();

            builder.RegisterType<MusteriDal>().As<IMusteriDal>();
            builder.RegisterType<UrunDal>().As<IUrunDal>();
            builder.RegisterType<OdemeDal>().As<IOdemeDal>();
            builder.RegisterType<TaksitDal>().As<ITaksitDal>();
            builder.RegisterType<SatisDal>().As<ISatisDal>();
        }
    }
}
