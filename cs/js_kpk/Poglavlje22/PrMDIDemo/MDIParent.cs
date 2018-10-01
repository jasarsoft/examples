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
    public partial class MDIParent : Form
    {
        private int childCount;

        public MDIParent()
        {
            InitializeComponent();

            childCount = 0;
        }

        private void exitItemClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newItemClick(object sender, EventArgs e)
        {
            MDIChild childForm = new MDIChild();
            childForm.MdiParent = this;
            childCount++;
            childForm.Text = childForm.Text + " " + childCount;
            childForm.Show();
        }

        private void cascadeItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeItemClick(object sender, EventArgs e)
        {
            Form childForm = this.ActiveMdiChild;
            if (childForm != null)
                childForm.Close();
        }

        private void aboutItemClick(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog();
        }
    }
}
