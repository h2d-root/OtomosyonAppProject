using Autofac;
using Business.Abstract;
using Business.AutoFac;
using Business.Concrete;
using DataAccess;

namespace FormApp_Core
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var dbContext = new OtomasyonAppDBContext();
            SeedData.Start(dbContext);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //var builder = new ContainerBuilder();
            //builder.RegisterModule(new AutoFacBusinessModule());


            //var container = builder.Build();

            //var mainForm = container.Resolve<GirisForm>();

            Application.Run(new GirisForm());
        }
    }
}