using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFUnlocker
{
    public partial class PasswordInputDialog : Form
    {
        public PasswordInputDialog()
        {
            InitializeComponent();
        }
        public string EnteredPassword
        {
            get { return TxtPassword.Text; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
