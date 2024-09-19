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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BooksApplication
{
    public partial class AddClient : Form
    {
        private readonly BooksContext _context;
        public AddClient(BooksContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            string firstname = TB_Firstname.Text;
            string lastname = TB_Lastname.Text;
            string address = TB_Address.Text;
            if (!int.TryParse(TB_Phone.Text, out int phone))
            {
                MessageBox.Show("Error: Phone number");
                return;
            }
            //int phone = int.Parse(TB_Phone.Text);
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Missing fields");
                return;
            }

            var client = new Client();
            client.FirstName = firstname;
            client.LastName = lastname;
            client.Address = address;
            client.Phone = phone;
; 
            _context.Clients.Add(client);
            _context.SaveChanges();
            MessageBox.Show("Successful client processing");
            this.Close();
        }
    }
}
