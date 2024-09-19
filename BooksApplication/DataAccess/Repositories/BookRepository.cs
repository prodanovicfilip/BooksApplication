using BooksApplication.DataAccess.Entities;
using BooksApplication.DataAccess.Infrastructure;
using Mapster;

namespace BooksApplication.DataAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BooksContext _context;
        public BookRepository(BooksContext context)
        {
            _context = context;
        }
        public int Add(Book book)
        {
            // Check da li je book null
            if (book == null) throw new ArgumentNullException();
            // Add
            _context.Books.Add(book);
            return _context.SaveChanges();
            // SaveChanges
        }

        public bool Delete(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException();
            var entity = _context.Books.FirstOrDefault(b=>b.Id == id);
            if (entity == null) throw new Exception();
            _context.Books.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException();
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) throw new Exception();
            return book;
        }

        public Book Update(int id, Book book)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException();
            var dbBook = _context.Books.FirstOrDefault(b => b.Id == id);
            if (dbBook == null) throw new Exception();
            book.Adapt(dbBook);
            _context.SaveChanges();
            return dbBook;
        }
    }
}
