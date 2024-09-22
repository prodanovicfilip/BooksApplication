using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BT_AddClient_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddClient>();
            form.ShowDialog();
        }

        private void BT_AddBook_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddBook>();
            form.ShowDialog();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Renting_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<Renting>();
            form.ShowDialog();
        }
    }
}
