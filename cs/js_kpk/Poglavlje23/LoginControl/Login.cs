using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginControl
{
    public partial class Login : UserControl
    {
        public event EventHandler loginSuccess;
        public event EventHandler loginFail;

        public Login()
        {
            InitializeComponent();
        }

        public string UserNameLabel
        {
            get { return userNameLabel.Text; }
            set { userNameLabel.Text = value; }
        }

        public string PasswordLabel
        {
            get { return passwordLabel.Text; }
            set { passwordLabel.Text = value; }
        }

        public string LoginBottonText
        {
            get { return loginButton.Text; }
            set { loginButton.Text = value; }
        }

        [Browsable(false)]
        public string UserName
        {
            set { userNameText.Text = value; }
        }

        [Browsable(false)] //nece se prikazivatu u prozoru properties
        public string Password
        {
            set { passwordText.Text = value; }
        }

        private void loginClick(object sender, EventArgs e)
        {
            if(userNameText.Text.Length == 0)
            {
                loginError.SetError(userNameText, "Please enter a user name");
                return;
            }
            if(passwordText.Text.Length == 0)
            {
                loginError.SetError(passwordText, "Please enter apassword");
                return;
            }
            if(UserNameAndPasswordAreValid(userNameText.Text, passwordText.Text))
            {
                if (loginSuccess != null)
                    loginSuccess(this, new EventArgs());
            }
            else
            {
                if (loginFail != null)
                    loginFail(this, new EventArgs());
            }
        }

        private bool UserNameAndPasswordAreValid(string userName, string password)
        {
            return password.Equals("TrustMe");
        }
    }
}
