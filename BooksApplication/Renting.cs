using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksApplication.DataAccess.Entities;
using BooksApplication.DataAccess.Infrastructure;
using BooksApplication.Utilities;

namespace BooksApplication
{
    public partial class Renting : Form
    {
        private readonly IClientRepository _clientRepository;
        private readonly IBookRepository _bookRepository;
        private IEnumerable<Book> _books;
        public Renting(IClientRepository clientRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _bookRepository = bookRepository;
        }

        private void Renting_Load(object sender, EventArgs e)
        {
            _books = _bookRepository.GetAll().ToList();
            if (_books == null || _books.Count() == 0)
            {
                MessageBox.Show("There are no books available");
                return;
            }
            GV_Books.DataSource = _books;
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if (!Utils.IsValidString(BT_Search.Text))
            {
                GV_Books.DataSource = _books;
                return;
            }
            GV_Books.DataSource = _books.Where(b => b.Title.Contains(TB_Search.Text)|| b.Author.Contains(TB_Search.Text)).ToList();
        }
    }
}
