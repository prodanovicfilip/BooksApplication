using BooksApplication.BLL.Models;
using BooksApplication.DataAccess;
using BooksApplication.DataAccess.Infrastructure;
using Mapster;

namespace BooksApplication
{
    public partial class Form1 : Form
    {
        //LOGIN
        private readonly IUserRepository _userRepository;
        public Form1(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
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
            try
            {
                var exist = _userRepository.UsernameExists(username);
                if (!exist)
                {
                    MessageBox.Show("Error");
                    return;

                }

                var success = _userRepository.Login(username, password);
                if(!success)
                {
                    MessageBox.Show("Cannot login!");
                    return;
                }

                var f = new Main();
                this.Hide();
                f.ShowDialog();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Loguje error
            }
          

        }
        private bool CheckIfAnyUsers()
        {
            return _userRepository.GetAll().Any();
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
