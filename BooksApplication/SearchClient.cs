﻿using System;
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
        private enum FormState
        {
            Normal,
            Edit
        }
        private readonly IClientRepository _clientRepository;
        private List<Client> _clients;
        private FormState _formState = FormState.Normal;
        private Client _selectedClient;
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
            if (!Utils.IsValidString(TB_Search.Text))
            {
                DG_Clients.DataSource = _clients;
                return;
            }
            DG_Clients.DataSource = _clients.Where(c => c.FirstName.Contains(TB_Search.Text) || c.LastName.Contains(TB_Search.Text)).ToList();
        }

        private void BT_Select_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Tag = _selectedClient;
            this.Close();
        }
        public void EditForm()
        {
            _formState = FormState.Edit;
            BT_Select.Visible = true;
            this.ShowDialog();
        }

        private void DG_Clients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = DG_Clients.SelectedRows[0].Index;
                _selectedClient = _clients[selectedIndex];
            }
            catch (Exception ex) { }

        }

        private void DG_Clients_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        var hit = DG_Clients.HitTest(e.X, e.Y);
                        DG_Clients.ClearSelection();
                        DG_Clients.Rows[hit.RowIndex].Selected = true;
                        _selectedClient = _clients.ToList()[hit.RowIndex];
                        CT_Context.Show(this, new Point(e.X, e.Y));
                    }
                    break;
            }
        }

        private void TS_SeeBooks_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<Renting>();
            form.SetClient(_selectedClient);
            form.ShowDialog();
        }
    }
}
