using System;
using System.IO;
using System.Windows.Forms;

namespace PrMDIDemo
{
    public partial class MDIChild : Form
    {
        public MDIChild()
        {
            InitializeComponent();
        }

        private void saveItemClick(object sender, EventArgs e)
        {
            DialogResult buttonClicked = saveFileDialog.ShowDialog();
            if (buttonClicked.Equals(DialogResult.OK))
            {
                Stream saveStream = saveFileDialog.OpenFile();
                StreamWriter saveWriter = new StreamWriter(saveStream);
                foreach(string line in editData.Lines)
                {
                    saveWriter.WriteLine(line);
                }
                saveWriter.Close();
            }
        }
    }
}
