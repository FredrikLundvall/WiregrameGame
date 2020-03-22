using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlowtorchesAndGunpowder
{
    public partial class LoginForm : Form
    {
        public LoginForm(string aUsername = "", bool aAutomaticLogin = false)
        {
            InitializeComponent();
            usernameTxt.Text = aUsername;
            automaticLoginChb.Checked = aAutomaticLogin;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }

        public LoginInfo getLoginInfo()
        {
            return new LoginInfo(usernameTxt.Text, SecurePasswordHasher.RepeatableHashForTransfer(passwordTxt.Text, usernameTxt.Text), automaticLoginChb.Checked);
        }
    }
}
