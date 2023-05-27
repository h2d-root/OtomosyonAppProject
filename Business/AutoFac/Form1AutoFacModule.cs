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
    public class Form1AutoFacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<MusteriManager>().As<IMusteriService>();
            builder.RegisterType<MusteriDal>().As<IMusteriDal>();
            
        }
    }

}

