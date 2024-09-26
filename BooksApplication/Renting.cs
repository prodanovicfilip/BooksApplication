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
using BooksApplication.Services;
using BooksApplication.Services.Api;
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
        //private readonly IBookRepository _bookRepository;
        private readonly IApiService _apiService;
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

        public Renting(IClientRepository clientRepository, IApiService apiService)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _apiService = apiService;
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
        private async void Renting_Load(object sender, EventArgs e)
        {
            _books = (await _apiService.GetAll<Book>(nameof(Book))).ToList();
            if (_books == null || _books.Count() == 0)
            {
                MessageBox.Show("There are no books available");
                return;
            }
            if (_selectedClient == null)
            {
                GV_Books.DataSource = _books;
            }
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

            _apiService.Delete<Book>(_selectedBook.Id);
            RentingRefresh();
        }

        private void TS_Edit_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddBook>();
            form.SetBook(_selectedBook);
            form.ShowDialog();
            RentingRefresh();
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
        private async void RentingRefresh()
        {
            _books = (await _apiService.GetAll<Book>(nameof(Book))).ToList();
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

        private void BT_Export_Click(object sender, EventArgs e)
        {
            var dialog = Program.GetService<ExportDialog>();
            dialog.ShowDialog();
            if (dialog == null || dialog.State == ExportDialog.States.None) return;
            if (dialog.State == ExportDialog.States.Json)
            {
                var fileDialog = new SaveFileDialog();
                var exportService = Program.GetService<IExportService>();
                DialogResult dialogResult = fileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    exportService.ExportJson(_books, fileDialog.FileName);
                }
            }
            if (dialog.State == ExportDialog.States.Text)
            {
                var fileDialog = new SaveFileDialog();
                var exportService = Program.GetService<IExportService>();
                DialogResult dialogResult = fileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    exportService.ExportTxt(_books, fileDialog.FileName);
                }
            }
            
        }

        private async void BT_Import_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            var exportService = Program.GetService<IExportService>();
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) 
            { 
                var newBooks = exportService.ImportFromJson<Book>(fileDialog.FileName);
                if (newBooks != null)
                {
                    ResetId(newBooks);
                    _apiService.Create(newBooks);
                    _books = (await _apiService.GetAll<Book>(nameof(Book))).ToList();
                }
            }
        }

        private static void ResetId(IEnumerable<Book> newBooks)
        {
            foreach (var book in newBooks)
            {
                book.Id = 0;
            }
        }
    }
}
