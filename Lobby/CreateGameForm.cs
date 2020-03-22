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
    public partial class CreateGameForm : Form
    {
        public CreateGameForm(string aPlayername = "")
        {
            InitializeComponent();
            gamenameTxt.Text = "Spel skapat av "+ aPlayername;
        }

        private void CreateGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }

        public GameInfo getGameInfo()
        {
            return new GameInfo(gamenameTxt.Text, usePincodeChb.Checked, pincode1UpDwn.Value.ToString() + pincode2UpDwn.Value.ToString() + pincode3UpDwn.Value.ToString() + pincode4UpDwn.Value.ToString());
        }

        private void usePincodeChb_CheckedChanged(object sender, EventArgs e)
        {
            pincode1UpDwn.Enabled = usePincodeChb.Checked;
            pincode2UpDwn.Enabled = usePincodeChb.Checked;
            pincode3UpDwn.Enabled = usePincodeChb.Checked;
            pincode4UpDwn.Enabled = usePincodeChb.Checked;
            pinCodeLbl.Enabled = usePincodeChb.Checked;
        }
    }
}
