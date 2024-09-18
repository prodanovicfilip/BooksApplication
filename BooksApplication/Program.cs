using BooksApplication.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BooksApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Services.AddDbContext<BooksContext>();
            Services.AddSingleton<Form1>();
            Services.AddTransient<RegistrationForm>();
            Services.AddTransient<AddClient>();
            ServiceProvider = Services.BuildServiceProvider();
            var form = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form);
            //var f = new Form1();
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();
        private static ServiceProvider ServiceProvider { get; set; }
        public static T GetService<T>()
        {
            return (T)ServiceProvider.GetRequiredService<T>();
        }
    }
}