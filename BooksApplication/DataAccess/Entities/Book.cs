using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication.DataAccess.Entities
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string Year { get; set; }
    }
}
