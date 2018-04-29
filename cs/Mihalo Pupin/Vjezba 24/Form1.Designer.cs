namespace Vjezba_24
{
    partial class fclsMain
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
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtVelicinaFonta = new System.Windows.Forms.TextBox();
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBold
            // 
            this.btnBold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBold.Location = new System.Drawing.Point(71, 8);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(75, 23);
            this.btnBold.TabIndex = 0;
            this.btnBold.Text = "&Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItalic.Location = new System.Drawing.Point(159, 8);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(75, 23);
            this.btnItalic.TabIndex = 1;
            this.btnItalic.Text = "&Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnderline.Location = new System.Drawing.Point(247, 8);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(75, 23);
            this.btnUnderline.TabIndex = 2;
            this.btnUnderline.Text = "&Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCenter.Location = new System.Drawing.Point(335, 8);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 3;
            this.btnCenter.Text = "&Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(155, 240);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(251, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.Location = new System.Drawing.Point(400, 240);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "&Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            // 
            // txtVelicinaFonta
            // 
            this.txtVelicinaFonta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVelicinaFonta.Location = new System.Drawing.Point(244, 40);
            this.txtVelicinaFonta.Name = "txtVelicinaFonta";
            this.txtVelicinaFonta.Size = new System.Drawing.Size(40, 20);
            this.txtVelicinaFonta.TabIndex = 7;
            this.txtVelicinaFonta.Text = "8";
            // 
            // rtfText
            // 
            this.rtfText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfText.Location = new System.Drawing.Point(0, 64);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(480, 168);
            this.rtfText.TabIndex = 8;
            this.rtfText.Text = "";
            // 
            // fclsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.rtfText);
            this.Controls.Add(this.txtVelicinaFonta);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(486, 305);
            this.Name = "fclsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtVelicinaFonta;
        private System.Windows.Forms.RichTextBox rtfText;
    }
}

