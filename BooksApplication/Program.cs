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
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<BooksContext>();
            serviceCollection.AddSingleton<Form1>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var form = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form);
            //var f = new Form1();
        }
    }
}