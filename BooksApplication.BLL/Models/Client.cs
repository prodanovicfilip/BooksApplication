using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication.BLL.Models
{
    internal class Client : BaseModel
    {
        public Client(string firstName, string lastName, string address, int phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Address: {Address} - Phone: {Phone} - Email: {Email}";
        }

    }
}
