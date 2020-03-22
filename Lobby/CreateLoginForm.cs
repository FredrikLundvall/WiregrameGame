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
    public partial class CreateLoginForm : Form
    {
        private LoginSession _loginSession;

        public CreateLoginForm(LoginSession aLoginSessionForEdit = null)
        {
            InitializeComponent();
            if(aLoginSessionForEdit != null)
            {
                _loginSession = aLoginSessionForEdit;

                this.Text = "Redigera inloggning";
                this.createLoginBtn.Text = "Spara inloggning";
                this.usernameTxt.Text = _loginSession.Username;
                this.playernameTxt.Text = _loginSession.Playername;
                this.usernameTxt.ReadOnly = true;
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }

        private void createLoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, "Användarnamn saknas!");
                return;
            }
            if (passwordTxt.Text == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, "Lösenord saknas!");
                return;
            }
            if (passwordTxt.Text != confirmPasswordTxt.Text)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, "Lösenorden matchar inte varandra!");
                return;
            }
        }
        public LoginAccount getLoginAccount()
        {
            if (_loginSession == null)
            {
                return new LoginAccount(usernameTxt.Text, SecurePasswordHasher.RepeatableHashForTransfer(passwordTxt.Text, usernameTxt.Text), playernameTxt.Text);
            }
            else
            {
                return new LoginAccount(_loginSession.Username, SecurePasswordHasher.RepeatableHashForTransfer(passwordTxt.Text, _loginSession.Username), playernameTxt.Text);
            }
        }
        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if(playernameTxt.Text == "")
                playernameTxt.Text = usernameTxt.Text;
        }
    }
}
