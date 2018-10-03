using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginFail(object sender, EventArgs e)
        {
            MessageBox.Show("Login failed", "Fail");
        }

        private void loginSuccess(object sender, EventArgs e)
        {
            MessageBox.Show("Login success", "Success");
        }
    }
}
