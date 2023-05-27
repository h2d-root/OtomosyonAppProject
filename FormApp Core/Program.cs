using Autofac;
using Business.AutoFac;
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

            var builder = new ContainerBuilder();
            builder.RegisterModule(new MyModule());

            var container = builder.Build();

            var mainForm = container.Resolve<MainForm>(); // Ana formunuzun türünü belirtin
            var mainForm2 = container.Resolve<MainForm2>();

            Application.Run(new GirisForm());
        }
    }
}