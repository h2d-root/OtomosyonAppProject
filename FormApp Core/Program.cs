using Business.Abstract;
using Business.Concrete;
using Business.Service;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FormApp_Core
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            
            var dbContext = new OtomasyonAppDBContext();
            SeedData.Start(dbContext);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;


            Application.Run(ServiceProvider.GetRequiredService<GirisForm>());
        }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IMusteriService, MusteriManager>();
                    services.AddTransient<IUrunService, UrunManager>();
                    services.AddTransient<ITaksitService, TaksitManager>();
                    services.AddTransient<ISatisService, SatisManager>();
                    services.AddTransient<IOdemeService, OdemeManager>();
                    services.AddTransient<IMusteriDal, MusteriDal>();
                    services.AddTransient<IUrunDal, UrunDal>();
                    services.AddTransient<ITaksitDal, TaksitDal>();
                    services.AddTransient<ISatisDal, SatisDal>();
                    services.AddTransient<IOdemeDal, OdemeDal>();
                    services.AddTransient<GirisForm>();
                    services.AddTransient<Form1>();
                    services.AddTransient<OdemeForm>();
                    services.AddTransient<SatisForm>();
                    services.AddTransient<UrunIslemForm>();
                });
        }
    }
}