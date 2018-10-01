namespace PrMDIDemo
{
    partial class MDIChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editData = new System.Windows.Forms.TextBox();
            this.childMenu = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.childMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // editData
            // 
            this.editData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editData.Location = new System.Drawing.Point(0, 24);
            this.editData.Multiline = true;
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(284, 237);
            this.editData.TabIndex = 0;
            // 
            // childMenu
            // 
            this.childMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.saveItem});
            this.childMenu.Location = new System.Drawing.Point(0, 0);
            this.childMenu.Name = "childMenu";
            this.childMenu.Size = new System.Drawing.Size(284, 24);
            this.childMenu.TabIndex = 1;
            this.childMenu.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(37, 20);
            this.fileItem.Text = "&File";
            // 
            // saveItem
            // 
            this.saveItem.MergeIndex = 1;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(43, 20);
            this.saveItem.Text = "&Save";
            this.saveItem.Click += new System.EventHandler(this.saveItemClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.Title = "MDI Text Editor";
            // 
            // MDIChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.editData);
            this.Controls.Add(this.childMenu);
            this.MainMenuStrip = this.childMenu;
            this.Name = "MDIChild";
            this.Text = "MDIChild";
            this.childMenu.ResumeLayout(false);
            this.childMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editData;
        private System.Windows.Forms.MenuStrip childMenu;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}