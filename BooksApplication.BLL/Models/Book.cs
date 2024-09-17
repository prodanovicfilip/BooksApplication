using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApplication.BLL.Models
{
    public class Book : BaseModel
    {
        public Book(string author, string title, string description, int count, string year)
        {
            Author = author;
            Title = title;
            Description = description;
            Count = count;
            Year = year;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string Year { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} - Author: {Author} - Year: {Year} - Count: {Count}";
        }
    }
}
