using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.AutoFac
{
    public class OdemeFormAutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MusteriManager>().As<IMusteriService>();
            builder.RegisterType<TaksitManager>().As<ITaksitService>();
            builder.RegisterType<SatisManager>().As<ISatisService>();
            builder.RegisterType<OdemeManager>().As<IOdemeService>();

            builder.RegisterType<MusteriDal>().As<IMusteriDal>();
            builder.RegisterType<OdemeDal>().As<IOdemeDal>();
            builder.RegisterType<TaksitDal>().As<ITaksitDal>();
            builder.RegisterType<SatisDal>().As<ISatisDal>();

        }
    }

}
