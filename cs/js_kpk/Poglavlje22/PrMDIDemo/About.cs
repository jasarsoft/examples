using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrMDIDemo
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void okClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
