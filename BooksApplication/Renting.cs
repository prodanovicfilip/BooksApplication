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
        private Book _selectedBook;
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
            GV_Books.DataSource = _books.Where(b => b.Title.Contains(TB_Search.Text) || b.Author.Contains(TB_Search.Text)).ToList();
        }

        private void TS_Rent_Click(object sender, EventArgs e)
        {

        }

        private void TS_Delete_Click(object sender, EventArgs e)
        {

        }

        private void TS_Edit_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddBook>();
            form.SetBook(_selectedBook);
            form.ShowDialog();
        }

        private void GV_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBook = _books.ToList()[e.RowIndex];
        }

        private void GV_Books_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        CT_Context.Show(this, new Point(e.X, e.Y));
                    }
                    break;
            }
        }

        private void GV_Books_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
