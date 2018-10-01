namespace PrMDIDemo
{
    partial class MDIParent
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
            this.mdiMenu = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMenu
            // 
            this.mdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.windowItem,
            this.helpItem});
            this.mdiMenu.Location = new System.Drawing.Point(0, 0);
            this.mdiMenu.Name = "mdiMenu";
            this.mdiMenu.Size = new System.Drawing.Size(484, 24);
            this.mdiMenu.TabIndex = 1;
            this.mdiMenu.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.closeItem,
            this.exitItem});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(37, 20);
            this.fileItem.Text = "&File";
            // 
            // newItem
            // 
            this.newItem.MergeIndex = 0;
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(152, 22);
            this.newItem.Text = "&New";
            this.newItem.Click += new System.EventHandler(this.newItemClick);
            // 
            // closeItem
            // 
            this.closeItem.MergeIndex = 0;
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(152, 22);
            this.closeItem.Text = "&Close";
            this.closeItem.Click += new System.EventHandler(this.closeItemClick);
            // 
            // exitItem
            // 
            this.exitItem.MergeIndex = 2;
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(152, 22);
            this.exitItem.Text = "&Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItemClose);
            // 
            // windowItem
            // 
            this.windowItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeItem,
            this.horizontalItem,
            this.verticalItem});
            this.windowItem.Name = "windowItem";
            this.windowItem.Size = new System.Drawing.Size(63, 20);
            this.windowItem.Text = "&Window";
            // 
            // cascadeItem
            // 
            this.cascadeItem.Name = "cascadeItem";
            this.cascadeItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeItem.Text = "&Cascade";
            this.cascadeItem.Click += new System.EventHandler(this.cascadeItem_Click);
            // 
            // horizontalItem
            // 
            this.horizontalItem.Name = "horizontalItem";
            this.horizontalItem.Size = new System.Drawing.Size(152, 22);
            this.horizontalItem.Text = "Tile &Horizontal";
            this.horizontalItem.Click += new System.EventHandler(this.horizontalItemClick);
            // 
            // verticalItem
            // 
            this.verticalItem.Name = "verticalItem";
            this.verticalItem.Size = new System.Drawing.Size(152, 22);
            this.verticalItem.Text = "Tile &Vertical";
            this.verticalItem.Click += new System.EventHandler(this.verticalItemClick);
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(44, 20);
            this.helpItem.Text = "&Help";
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(167, 22);
            this.aboutItem.Text = "&About MDI Demo";
            this.aboutItem.Click += new System.EventHandler(this.aboutItemClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.Title = "MDI Text Editor";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.mdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenu;
            this.Name = "MDIParent";
            this.Text = "MDI Parent Form";
            this.mdiMenu.ResumeLayout(false);
            this.mdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mdiMenu;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripMenuItem closeItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem windowItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalItem;
        private System.Windows.Forms.ToolStripMenuItem verticalItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

