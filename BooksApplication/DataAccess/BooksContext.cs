using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksApplication.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApplication.DataAccess
{
    public class BooksContext : DbContext
    { 
        public BooksContext()
        {
            
        }


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
