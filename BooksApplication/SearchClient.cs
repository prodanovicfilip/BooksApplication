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
    public partial class SearchClient : Form
    {
        private readonly IClientRepository _clientRepository;
        private List<Client> _clients;
        public SearchClient(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            _clients = _clientRepository.GetAll().ToList();
            if (_clients == null)
            {
                MessageBox.Show("Error");
                return;
            }
            DG_Clients.DataSource = _clients;
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if(!Utils.IsValidString(TB_Search.Text))
            {
                DG_Clients.DataSource = _clients;
                return;
            }
            DG_Clients.DataSource = _clients.Where(c => c.FirstName.Contains(TB_Search.Text) || c.LastName.Contains(TB_Search.Text)).ToList();
        }
    }
}
