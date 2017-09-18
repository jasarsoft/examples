using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primjer_03
{
    public partial class DeclarativeDB : Form
    {
        public DeclarativeDB()
        {
            InitializeComponent();
        }

        private void DeclarativeDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

        }
    }
}
