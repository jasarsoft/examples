using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MemberForm : Form
    {
        MenuItem[] formMenuItemList;

        public MemberForm()
        {
            InitializeComponent();

            Reset();

            formMenuItemList = new MenuItem[2];
            formMenuItemList[0] = new MenuItem("&Save");

            MenuItem clearItem = new MenuItem("&Clear", new EventHandler(clearClick));
            formMenuItemList[1] = clearItem;

            ContextMenu formMenu = new ContextMenu(formMenuItemList);
            this.ContextMenu = formMenu;
        }

        public void Reset()
        {
            firstName.Text = "";
            lastName.Text = "";

            tower.Items.Clear();
            tower.Items.Add("Great Shevington");
            tower.Items.Add("Little Mudford");
            tower.Items.Add("Upper Gumthee");
            tower.Items.Add("Downley Hatch");

            meberSince.Value = DateTime.Today;

            captain.Checked = false;

            novice.Checked = true;

            methods.Items.Clear();
            methods.Items.Add("Andover Bob Minor");
            methods.Items.Add("Antelope Place Doubles");
            methods.Items.Add("Hayfield Royal");
            methods.Items.Add("West Chiltington Doubles");
            methods.Items.Add("Brandon Parva Maximus");
            methods.Items.Add("Buckfast Abbey Triples");
            methods.Items.Add("Shelwith Bridge Minor");
            methods.Items.Add("Action Trussel Bob Royal");

            printItem.Enabled = true;
        }

        private void clearClick(object sender, EventArgs e)
        {
            Reset();
        }

        private void addClick(object sender, EventArgs e)
        {
            string details;

            details = "Member since " + firstName.Text + " " + lastName.Text + " form the tower at " + tower.Text;
            MessageBox.Show(details, "Member Information");

        }

        private void memberFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("Are you sure you want to quit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (key == DialogResult.No);
        }

        private void newClick(object sender, EventArgs e)
        {
            Reset();
        }

        private void exitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxClearClick(object sender, EventArgs e)
        {
            if (textBoxMenu.SourceControl == firstName)//textBoxMenu.SourceControl.Equals(firstName)
                firstName.Clear();
            else
                lastName.Clear();
        }
    }
}
