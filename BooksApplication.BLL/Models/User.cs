namespace BooksApplication.BLL.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
        public User()
        {
            
        }
    }
}
