namespace Vjezba_29
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
            this.tbcKontrola = new System.Windows.Forms.TabControl();
            this.TabControl1 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabPage();
            this.btnMessage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tbcKontrola.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcKontrola
            // 
            this.tbcKontrola.Controls.Add(this.TabControl1);
            this.tbcKontrola.Controls.Add(this.TabControl2);
            this.tbcKontrola.Location = new System.Drawing.Point(0, 0);
            this.tbcKontrola.Name = "tbcKontrola";
            this.tbcKontrola.SelectedIndex = 0;
            this.tbcKontrola.Size = new System.Drawing.Size(280, 216);
            this.tbcKontrola.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.comboBox1);
            this.TabControl1.Controls.Add(this.btnMessage);
            this.TabControl1.Location = new System.Drawing.Point(4, 22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl1.Size = new System.Drawing.Size(272, 190);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.Text = "Prvi Tab";
            this.TabControl1.UseVisualStyleBackColor = true;
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.txtMessage);
            this.TabControl2.Location = new System.Drawing.Point(4, 22);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl2.Size = new System.Drawing.Size(272, 190);
            this.TabControl2.TabIndex = 1;
            this.TabControl2.Text = "Drugi Tab";
            this.TabControl2.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(150, 149);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(116, 35);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Prikazi poruku";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(56, 56);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(152, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // fclsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 267);
            this.Controls.Add(this.tbcKontrola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fclsMain";
            this.Text = "Kontrola TabControl";
            this.tbcKontrola.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcKontrola;
        private System.Windows.Forms.TabPage TabControl1;
        private System.Windows.Forms.TabPage TabControl2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

