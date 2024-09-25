using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication.WebAPI.DataAccess.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }      
        
        public override string ToString()
        {
            return $"{FirstName} {LastName} - Address: {Address} - Phone: {Phone} - Email: {Email}";
        }
    }
}
