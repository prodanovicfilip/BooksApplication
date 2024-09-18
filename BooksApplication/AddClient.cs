using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksApplication.DataAccess;
using BooksApplication.DataAccess.Entities;

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

        private void button1_Click(object sender, EventArgs e)
        {
            //kao register
            var client = new Client();
            client.FirstName = this.textBox1.Text; //...



            _context.Clients.Add(client);
            _context.SaveChanges();
        }
    }
}
