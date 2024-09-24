using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksApplication.DataAccess.Entities;
using BooksApplication.DataAccess.Infrastructure;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BooksApplication.DataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly BooksContext _context;
        public ClientRepository(BooksContext context)
        {
            _context = context;
        }
        public int Add(Client client)
        {
            if (client == null) throw new ArgumentNullException("client");
            _context.Clients.Add(client);
            return _context.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException("id");
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);
            if (client == null) throw new Exception();
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.Include(x => x.Books).ToList();
        }

        public Client GetById(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException("id");
            var client = _context.Clients.Include(x => x.Books).FirstOrDefault(c => c.Id == id);
            if (client == null) throw new Exception();
            return client;
        }

        public Client Update(int id, Client client)
        {
            if (id <= 0) throw new ArgumentException("id");
            if (client == null) throw new ArgumentNullException();
            var entity = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (entity == null) throw new Exception();
            client.Adapt(entity);
            _context.SaveChanges();
            return entity;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
