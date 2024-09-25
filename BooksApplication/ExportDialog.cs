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
    public partial class ExportDialog : Form
    {
        public enum States
        {
            Text,
            Json,
            None
        }
        public States State = States.None;
        public ExportDialog()
        {
            InitializeComponent();
        }

        private void BT_Txt_Click(object sender, EventArgs e)
        {
            State = States.Text;
            this.Close();
        }

        private void BT_Json_Click(object sender, EventArgs e)
        {
            State = States.Json;
            this.Close();
        }
    }
}
