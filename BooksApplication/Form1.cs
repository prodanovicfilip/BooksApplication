using BooksApplication.BLL.Models;
using BooksApplication.DataAccess;
using Mapster;

namespace BooksApplication
{
    public partial class Form1 : Form
    {
        //LOGIN
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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error!");
                return;
            }
            var exist = _context.Users.Where(u => u.Username == username).FirstOrDefault();
            if (exist == null)
            {
                MessageBox.Show("Credentials error");
                return;
            }
            if (exist.Password != password)
            {
                MessageBox.Show("Credentials error");
                return;
            }
            var f = new Main();
            this.Hide();
            f.ShowDialog();

        }
        private bool CheckIfAnyUsers()
        {
            return _context.Users.Any();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!CheckIfAnyUsers())
            {
                var form = Program.GetService<RegistrationForm>();
                form.ShowDialog();
            }
        }
    }
}
