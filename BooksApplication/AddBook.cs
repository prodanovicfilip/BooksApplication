using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksApplication.DataAccess;
using BooksApplication.DataAccess.Entities;
using BooksApplication.Utilities;

namespace BooksApplication
{

    public partial class AddBook : Form
    {
        private readonly BooksContext _context;
        public AddBook(BooksContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            string title = TB_Title.Text;
            string author = TB_Author.Text;
            string year = TB_Year.Text;
            string description = TB_Desc.Text;
            if (!int.TryParse(TB_Count.Text, out int count))
            {
                MessageBox.Show("Error: Count number");
                return;
            }
            
            //if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(description))
            if(!Utils.IsValidString(title,author,year,description))
            {
                MessageBox.Show("Missing fields");
                return;
            }

            var book = new Book();
            book.Title = title;
            book.Author = author;
            book.Year = year;
            book.Description = description;
            book.Count = count;

            _context.Books.Add(book);
            _context.SaveChanges();
            MessageBox.Show("Added book");
            this.Close();
        }
    }
}
