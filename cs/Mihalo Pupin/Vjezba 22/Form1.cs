using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEngleski_Click(object sender, EventArgs e)
        {
            this.Text = "Do you speak English?";
        }

        private void btnDanski_Click(object sender, EventArgs e)
        {
            this.Text = "Taler do dansk?";
        }
    }
}
