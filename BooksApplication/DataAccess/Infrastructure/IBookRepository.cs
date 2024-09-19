
using BooksApplication.DataAccess.Entities;

namespace BooksApplication.DataAccess.Infrastructure
{
    public interface IBookRepository
    {
        public int Add(Book book);
        public IEnumerable<Book> GetAll();
        public Book GetById(int id);
        public Book Update(int id, Book book);

        public bool Delete(int id);
    }
}
