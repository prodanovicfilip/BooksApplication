using BooksApplication.WebAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApplication.WebAPI.DataAccess
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EBPQHUK;Initial Catalog=BooksDB;Integrated Security=SSPI;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
