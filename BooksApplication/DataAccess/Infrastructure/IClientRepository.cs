using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksApplication.DataAccess.Entities;

namespace BooksApplication.DataAccess.Infrastructure
{
    public interface IClientRepository
    {
        public int Add(Client client);
        public IEnumerable<Client> GetAll();
        public Client GetById(int id);
        public Client Update(int id, Client client);

        public void Delete(int id);
    }
}
