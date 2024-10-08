﻿using System;
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
        public ICollection<Client> Clients {  get; set; }
        public override string ToString()
        {
            return $"Title: {Title} - Author: {Author} - Year: {Year} - Count: {Count}";
        }
    }
}
