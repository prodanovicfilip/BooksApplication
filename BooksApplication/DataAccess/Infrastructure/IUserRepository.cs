using BooksApplication.DataAccess.Entities;

namespace BooksApplication.DataAccess.Infrastructure;
// CRUD
// CREATE , READ, UPDATE, DELETE
public interface IUserRepository
{
    public int Add(User user);
    public IEnumerable<User> GetAll();
    public User GetById(int id);
    public User Update(int id, User user);
    public void DeleteById(int id);
    public bool UsernameExists(string username);
    public bool Login(string username, string password);
}