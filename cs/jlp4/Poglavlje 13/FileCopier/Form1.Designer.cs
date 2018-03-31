namespace FileCopier
{
    partial class frmFileCopier
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.tvwSource = new System.Windows.Forms.TreeView();
            this.tvwTargetDir = new System.Windows.Forms.TreeView();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 27);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(68, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source Files:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(285, 27);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(65, 13);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target Files:";
            // 
            // tvwSource
            // 
            this.tvwSource.CheckBoxes = true;
            this.tvwSource.Location = new System.Drawing.Point(15, 43);
            this.tvwSource.Name = "tvwSource";
            this.tvwSource.Size = new System.Drawing.Size(250, 238);
            this.tvwSource.TabIndex = 2;
            this.tvwSource.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwSource_AfterCheck);
            this.tvwSource.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwExpand);
            // 
            // tvwTargetDir
            // 
            this.tvwTargetDir.Location = new System.Drawing.Point(288, 69);
            this.tvwTargetDir.Name = "tvwTargetDir";
            this.tvwTargetDir.Size = new System.Drawing.Size(250, 212);
            this.tvwTargetDir.TabIndex = 3;
            this.tvwTargetDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwExpand);
            this.tvwTargetDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwTargetDir_AfterSelect);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(15, 287);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(75, 23);
            this.btnChar.TabIndex = 4;
            this.btnChar.Text = "Char";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(463, 287);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(463, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(288, 287);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(92, 17);
            this.chkOverwrite.TabIndex = 8;
            this.chkOverwrite.Text = "Overwrite files";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 326);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label3";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(288, 43);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.Size = new System.Drawing.Size(250, 20);
            this.txtTargetDir.TabIndex = 10;
            // 
            // frmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 422);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.tvwTargetDir);
            this.Controls.Add(this.tvwSource);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "frmFileCopier";
            this.Text = "FileCopier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TreeView tvwSource;
        private System.Windows.Forms.TreeView tvwTargetDir;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTargetDir;
    }
}

