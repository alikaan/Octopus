using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CreateAccountMetroLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

    }
}
