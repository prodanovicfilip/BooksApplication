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
        private enum FormState
        {
            Normal,
            Client
        }
        private readonly IClientRepository _clientRepository;
        private readonly IBookRepository _bookRepository;
        private IEnumerable<Book> _books;
        private Book _selectedBook;
        private Client _selectedClient;
        private bool _isDirty;
        private FormState _formState = FormState.Normal;
        public bool IsDirty
        {
            get { return _isDirty; }
            set 
            { 
                _isDirty = value;
                BT_SaveClient.Enabled = value;
            }
        }

        public Renting(IClientRepository clientRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _bookRepository = bookRepository;
            LB_Client.Text = "Please select client";
            IsDirty = false;
        }
        public void SetClient(Client client)
        {
            if (client == null) return;
            _selectedClient = client;
            LB_Client.Text = _selectedClient.FirstName + " " + _selectedClient.LastName;
            LB_BooksCount.Text = _selectedClient.Books.Count.ToString();
            BT_SaveClient.Visible = false;
            _formState = FormState.Client;
        }
        private void Renting_Load(object sender, EventArgs e)
        {
            _books = _bookRepository.GetAll().ToList();
            if (_books == null || _books.Count() == 0)
            {
                MessageBox.Show("There are no books available");
                return;
            }
            if (_selectedClient == null)
                GV_Books.DataSource = _books;
            else
            {
                GV_Books.DataSource = _selectedClient.Books.ToList();
            }  
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if (_formState == FormState.Client)
            {
                if (!Utils.IsValidString(BT_Search.Text))
                {
                    GV_Books.DataSource = _selectedClient.Books.ToList();
                    return;
                }
                GV_Books.DataSource = _selectedClient.Books.Where(b => b.Title.Contains(TB_Search.Text) || b.Author.Contains(TB_Search.Text)).ToList();
            }
            else
            {
                if (!Utils.IsValidString(BT_Search.Text))
                {
                    GV_Books.DataSource = _books;
                    return;
                }
                GV_Books.DataSource = _books.Where(b => b.Title.Contains(TB_Search.Text) || b.Author.Contains(TB_Search.Text)).ToList();
            }
        }

        private void TS_Rent_Click(object sender, EventArgs e)
        {
            if (_selectedClient == null)
            {
                var form = Program.GetService<SearchClient>();
                form.EditForm();
                if (form.DialogResult == DialogResult.OK)
                {
                    _selectedClient = (Client)form.Tag;
                    LB_Client.Text = _selectedClient.FirstName + " " + _selectedClient.LastName;
                    if (_selectedClient.Books == null)
                    {
                        _selectedClient.Books = new List<Book>();
                    }
                    _selectedClient.Books.Add(_selectedBook);
                    IsDirty = true;
                }
            }
            else
            {
                if (_selectedClient.Books == null)
                {
                    _selectedClient.Books = new List<Book>();
                }
                _selectedClient.Books.Add(_selectedBook);
                IsDirty = true;
            }
            if (_selectedClient != null)
                LB_BooksCount.Text = _selectedClient.Books.Count.ToString();
        }

        private void TS_Delete_Click(object sender, EventArgs e)
        {

            _bookRepository.Delete(_selectedBook.Id);
            RentingRefresh();
        }

        private void TS_Edit_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddBook>();
            form.SetBook(_selectedBook);
            form.ShowDialog();
            RentingRefresh();
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
                        var hit = GV_Books.HitTest(e.X, e.Y);
                        GV_Books.ClearSelection();
                        GV_Books.Rows[hit.RowIndex].Selected = true;
                        _selectedBook = _books.ToList()[hit.RowIndex];
                        CT_Context.Show(this, new Point(e.X, e.Y));
                    }
                    break;
            }
        }
        private void RentingRefresh()
        {
            _books = _bookRepository.GetAll().ToList();
            GV_Books.DataSource = _books;
        }

        private void BT_SaveClient_Click(object sender, EventArgs e)
        {
            if (_selectedClient == null)
            {
                MessageBox.Show("Please select a client");
                return;
            }
            if (_isDirty)
            {
                _clientRepository.SaveChanges();
                IsDirty = false;
            }

        }
    }
}
