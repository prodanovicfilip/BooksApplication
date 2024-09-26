//#define BookInitialization
//#define ClientInitialization
using BooksApplication.DataAccess;
using BooksApplication.DataAccess.Entities;
using BooksApplication.DataAccess.Infrastructure;
using BooksApplication.DataAccess.Repositories;
using BooksApplication.Services;
using BooksApplication.Services.Api;
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
#if BookInitialization
    InitializeBooksDb();
#endif
#if ClientInitialization
    InitializeClientsDb();
#endif

            // out keyword stavlja vrednost u form variablu
            Application.Run(form);
            
        }
        private static IServiceCollection services { get; set; } = new ServiceCollection();
        private static ServiceProvider serviceProvider { get; set; }

        public static void InitializeBooksDb()
        {
            var context = GetService<BooksContext>();

            for(int i = 0; i < 30; i++)
            {
                context.Books.Add(new Book() { Author = "F" + i, Title = "GOT" + i, Description = "Something", Year = "180" + i, Count = 1 + i });
            }
            context.SaveChanges();
        }
        public static void InitializeClientsDb()
        {
            var context = GetService<BooksContext>();

            for (int i = 0; i < 30; i++)
            {
                context.Clients.Add(new Client() { FirstName = "A" + i, LastName = "Z" + i, Address = "Street "+i, Phone = 1 + i, Email = i + "@" });
            }
            context.SaveChanges();
        }


        public static void RegisterServices()
        {
            services.AddDbContext<BooksContext>();
            services.AddTransient<Form1>();
            services.AddTransient<RegistrationForm>();
            services.AddTransient<AddClient>();
            services.AddTransient<AddBook>();
            services.AddTransient<Renting>();
            services.AddTransient<SearchClient>();
            services.AddTransient<ExportDialog>();

            services.AddSingleton<IUserRepository, UserRepository>(); // REpository Pattern
            services.AddSingleton<IClientRepository, ClientRepository>();
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<IExportService, ExportService>();
            services.AddSingleton<HttpClient>();
            services.AddSingleton<IApiService, ApiService>();
        }

        public static void BuildServiceProvider(out Form1 form)
        {
            serviceProvider = services.BuildServiceProvider();
            form = serviceProvider.GetRequiredService<Form1>();
        }
        ///
        /// Get Service 
        /// var t = ServiceProvider.GetRequiredService<Form1>(); (Form1)System.Object
        /// T -> Tip <Genericki></Genericki>
        public static T GetService<T>()
        {
            return (T)serviceProvider.GetRequiredService<T>();
        }
    }
}