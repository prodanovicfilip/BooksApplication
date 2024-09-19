using BooksApplication.DataAccess.Entities;
using BooksApplication.DataAccess.Infrastructure;
using BooksApplication.Exceptions;
using Mapster;
namespace BooksApplication.DataAccess.Repositories;

public class UserRepository : IUserRepository
{

    private readonly BooksContext _context;

    public UserRepository(BooksContext context)
    {
        _context = context;
    }

    public int Add(User user)
    {
        if (user == null) throw new ArgumentNullException("user");

        _context.Users.Add(user);
        return _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        if(id <= 0) throw new ArgumentException("id");
        // 1. Naci entitet pod ID
        var entity = _context.Users.FirstOrDefault(u=> u.Id == id);
        // Proveravamo da li je entitet NULL zbog -> DEFAULT
        if(entity == null)
        {
            throw new EntityDoesNotExistException("Entity does not exist");
        }

        _context.Users.Remove(entity);
        _context.SaveChangesAsync();
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public User GetById(int id)
    {
        if(id <= 0) throw new Exception("id");
        var entity = _context.Users.FirstOrDefault(u  => u.Id == id);

        if (entity == null) throw new EntityDoesNotExistException("Entity not found");

        return entity;
    }

    public bool Login(string username, string password)
    {
        return _context.Users.FirstOrDefault(s=> s.Username ==  username && s.Password == password) != null;
    }

    public User Update(int id, User user)
    {
        if (id <= 0) throw new Exception("id");
        // Uzimamo usera po ID
        // Ovaj user je sad pod trackingom samog contexta
        var dbUser = _context.Users.FirstOrDefault(u => u.Id == id);
        if (dbUser == null) throw new Exception();
        // Adapt user(SOURCE).Adapt(DESTINACIJU) Mapira -> dbUser
        user.Adapt(dbUser);
        _context.SaveChanges();
        return dbUser;
    }

    public bool UsernameExists(string username)
    {
        return _context.Users.FirstOrDefault(s => s.Username == username) != null;
    }

}