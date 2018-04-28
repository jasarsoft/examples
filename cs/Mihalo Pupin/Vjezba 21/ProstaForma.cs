using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Prosti.Editor
{
    public partial class frmMain : Form
    {
        private string fileName;
        private int linesPrinted;
        private string[] lines;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string fileName) : this()
        {
            if(fileName != null)
            {
                this.fileName = fileName;
                OpenFile();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            SetFormTitle();
            textBox1.Clear();
        }

        protected void OpenFile()
        {
            try
            {
                using (StreamReader reader = File.OpenText(fileName))
                {
                    textBox1.Clear();
                    textBox1.Text = reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Prosti Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                SetFormTitle();
                OpenFile();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgSaveFile.FileName;
                SetFormTitle();
                SaveFile();
            }
        }

        protected void SaveFile()
        {
            try
            {
                Stream stream = File.OpenWrite(fileName);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(textBox1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Prosti Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileName == "Untitled")
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveFile();
            }
        }

        protected void SetFormTitle()
        {
            FileInfo fileInfo = new FileInfo(fileName);
            this.Text = fileInfo.Name + " - Prosti Editor";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Bottom;

            while(linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++], new Font("Arial", 10), Brushes.Black, x, y);
                y += 15;
                if(y >= e.PageBounds.Height - 80)
                {
                    e.HasMorePages = true;
                    return;
                }

                linesPrinted = 0;
                e.HasMorePages = false;
            }

            /*char[] param = { '\n' };
            string[] lines = textBox1.Text.Split(param);

            int i = 0;
            char[] trimParam = { '\r' };
            foreach(string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }

            int x = 20;
            int y = 20;

            foreach(string line in lines)
            {
                e.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, x, y);
                y += 15;
            }*/
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectedText != "")
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            char[] param = { '\n' };
            lines = textBox1.SelectedText.Split(param);

            int i = 0;
            char[] trimParam = { '\r' };
            foreach(string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgPageSetup.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
        }
    }
}
