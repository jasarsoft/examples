namespace Test
{
    partial class Form1
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
            this.login1 = new LoginControl.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(20, 20);
            this.login1.LoginBottonText = "Valdate";
            this.login1.Name = "login1";
            this.login1.PasswordLabel = "Password";
            this.login1.Size = new System.Drawing.Size(400, 300);
            this.login1.TabIndex = 0;
            this.login1.UserNameLabel = "Name";
            this.login1.loginSuccess += new System.EventHandler(this.loginSuccess);
            this.login1.loginFail += new System.EventHandler(this.loginFail);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(440, 321);
            this.Controls.Add(this.login1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl.Login login1;
    }
}

