namespace WindowsFormsApplication1
{
    partial class MemberForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tower = new System.Windows.Forms.ComboBox();
            this.captain = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.meberSince = new System.Windows.Forms.DateTimePicker();
            this.experience = new System.Windows.Forms.GroupBox();
            this.accomplished = new System.Windows.Forms.RadioButton();
            this.experienced = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.novice = new System.Windows.Forms.RadioButton();
            this.methods = new System.Windows.Forms.CheckedListBox();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxClearItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experience.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.textBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.ContextMenuStrip = this.textBoxMenu;
            this.firstName.Location = new System.Drawing.Point(120, 20);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(170, 26);
            this.firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.ContextMenuStrip = this.textBoxMenu;
            this.lastName.Location = new System.Drawing.Point(400, 20);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(170, 26);
            this.lastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tower";
            // 
            // tower
            // 
            this.tower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tower.FormattingEnabled = true;
            this.tower.Location = new System.Drawing.Point(120, 72);
            this.tower.Name = "tower";
            this.tower.Size = new System.Drawing.Size(260, 28);
            this.tower.TabIndex = 5;
            // 
            // captain
            // 
            this.captain.AutoSize = true;
            this.captain.Location = new System.Drawing.Point(400, 72);
            this.captain.Name = "captain";
            this.captain.Size = new System.Drawing.Size(90, 24);
            this.captain.TabIndex = 6;
            this.captain.Text = "Captain";
            this.captain.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Meber Since";
            // 
            // meberSince
            // 
            this.meberSince.Location = new System.Drawing.Point(140, 128);
            this.meberSince.Name = "meberSince";
            this.meberSince.Size = new System.Drawing.Size(200, 26);
            this.meberSince.TabIndex = 8;
            // 
            // experience
            // 
            this.experience.Controls.Add(this.accomplished);
            this.experience.Controls.Add(this.experienced);
            this.experience.Controls.Add(this.radioButton2);
            this.experience.Controls.Add(this.novice);
            this.experience.Location = new System.Drawing.Point(10, 184);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(260, 163);
            this.experience.TabIndex = 9;
            this.experience.TabStop = false;
            this.experience.Text = "Experience";
            // 
            // accomplished
            // 
            this.accomplished.AutoSize = true;
            this.accomplished.Location = new System.Drawing.Point(16, 128);
            this.accomplished.Name = "accomplished";
            this.accomplished.Size = new System.Drawing.Size(161, 24);
            this.accomplished.TabIndex = 3;
            this.accomplished.TabStop = true;
            this.accomplished.Text = "10 or more years";
            this.accomplished.UseVisualStyleBackColor = true;
            // 
            // experienced
            // 
            this.experienced.AutoSize = true;
            this.experienced.Location = new System.Drawing.Point(16, 96);
            this.experienced.Name = "experienced";
            this.experienced.Size = new System.Drawing.Size(121, 24);
            this.experienced.TabIndex = 2;
            this.experienced.TabStop = true;
            this.experienced.Text = "5 to 9 years";
            this.experienced.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1 to 4 years";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // novice
            // 
            this.novice.AutoSize = true;
            this.novice.Location = new System.Drawing.Point(16, 32);
            this.novice.Name = "novice";
            this.novice.Size = new System.Drawing.Size(122, 24);
            this.novice.TabIndex = 0;
            this.novice.TabStop = true;
            this.novice.Text = "up to 1 year";
            this.novice.UseVisualStyleBackColor = true;
            // 
            // methods
            // 
            this.methods.FormattingEnabled = true;
            this.methods.Location = new System.Drawing.Point(300, 192);
            this.methods.Name = "methods";
            this.methods.Size = new System.Drawing.Size(270, 151);
            this.methods.Sorted = true;
            this.methods.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(190, 368);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 40);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.addClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.openItem,
            this.saveItem,
            this.toolStripMenuItem1,
            this.printItem,
            this.toolStripMenuItem2,
            this.exitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newItem
            // 
            this.newItem.Name = "newItem";
            this.newItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newItem.Size = new System.Drawing.Size(152, 22);
            this.newItem.Text = "&New";
            this.newItem.Click += new System.EventHandler(this.newClick);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItem.Size = new System.Drawing.Size(152, 22);
            this.openItem.Text = "&Open";
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveItem.Size = new System.Drawing.Size(152, 22);
            this.saveItem.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // printItem
            // 
            this.printItem.Enabled = false;
            this.printItem.Name = "printItem";
            this.printItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printItem.Size = new System.Drawing.Size(152, 22);
            this.printItem.Text = "&Print";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitItem.Size = new System.Drawing.Size(152, 22);
            this.exitItem.Text = "E&xit";
            this.exitItem.Click += new System.EventHandler(this.exitClick);
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxClearItem});
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // textBoxClearItem
            // 
            this.textBoxClearItem.Name = "textBoxClearItem";
            this.textBoxClearItem.Size = new System.Drawing.Size(152, 22);
            this.textBoxClearItem.Text = "Clear Text";
            this.textBoxClearItem.Click += new System.EventHandler(this.textBoxClearClick);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.methods);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.meberSince);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.captain);
            this.Controls.Add(this.tower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberForm";
            this.Text = "Middleshire Bell Ringers Association";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.memberFormClosing);
            this.experience.ResumeLayout(false);
            this.experience.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.textBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tower;
        private System.Windows.Forms.CheckBox captain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker meberSince;
        private System.Windows.Forms.GroupBox experience;
        private System.Windows.Forms.RadioButton accomplished;
        private System.Windows.Forms.RadioButton experienced;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton novice;
        private System.Windows.Forms.CheckedListBox methods;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ContextMenuStrip textBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem textBoxClearItem;
    }
}

