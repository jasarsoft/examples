using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba_29
{
    public partial class fclsMain : Form
    {
        public fclsMain()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtMessage.Text);
        }
    }
}
