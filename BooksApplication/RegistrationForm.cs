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
    public partial class RegistrationForm : Form
    {
        private readonly BooksContext _context;
        public RegistrationForm(BooksContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BT_Register_Click(object sender, EventArgs e)
        {
            var username = TB_Username.Text;
            var password = TB_Password.Text;
            var user = new User();
            user.Username = username;
            user.Password = password;
            user.DateCreated = DateTime.Now;
            user.DateModified = DateTime.Now;

            _context.Users.Add(user);
            _context.SaveChanges();
            MessageBox.Show("Success");
            this.Close();
        }
    }
}
