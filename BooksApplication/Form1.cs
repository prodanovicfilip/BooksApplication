using BooksApplication.BLL.Models;
using BooksApplication.DataAccess;

namespace BooksApplication
{
    public partial class Form1 : Form
    {
        private readonly BooksContext _context;
        public Form1(BooksContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text; 
            User user = new User(username,password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Error!");
                return;
            }
            var f = new Main();
            this.Hide();
            f.ShowDialog();
            
        }
    }
}
