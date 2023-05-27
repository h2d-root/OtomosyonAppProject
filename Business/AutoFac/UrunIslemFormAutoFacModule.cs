using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.AutoFac
{
    public class UrunIslemFormAutoFacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<UrunManager>().As<IUrunService>();
            builder.RegisterType<UrunDal>().As<IUrunDal>();
            
        }
    }
}
