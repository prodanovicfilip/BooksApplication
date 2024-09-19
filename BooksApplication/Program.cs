using BooksApplication.DataAccess;
using BooksApplication.DataAccess.Infrastructure;
using BooksApplication.DataAccess.Repositories;
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


            Form1 form = null; // Prvo declare varijablu
            RegisterServices(); // DRY Principle Dont repeat your self

            BuildServiceProvider(out form); // Registruje service u Dependency Injection Container
            // out keyword stavlja vrednost u form variablu
            Application.Run(form);
            
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();
        private static ServiceProvider ServiceProvider { get; set; }

        public static void RegisterServices()
        {
            Services.AddDbContext<BooksContext>();
            Services.AddTransient<Form1>();
            Services.AddTransient<RegistrationForm>();
            Services.AddTransient<AddClient>();
            Services.AddTransient<AddBook>();

            Services.AddSingleton<IUserRepository, UserRepository>(); // REpository Pattern
            Services.AddSingleton<IClientRepository, ClientRepository>();
            Services.AddSingleton<IBookRepository, BookRepository>();
        }
        public static void BuildServiceProvider(out Form1 form)
        {
            ServiceProvider = Services.BuildServiceProvider();
            form = ServiceProvider.GetRequiredService<Form1>();
        }
        ///
        /// Get Service 
        /// var t = ServiceProvider.GetRequiredService<Form1>(); (Form1)System.Object
        /// T -> Tip <Genericki></Genericki>
        public static T GetService<T>()
        {
            return (T)ServiceProvider.GetRequiredService<T>();
        }
    }
}