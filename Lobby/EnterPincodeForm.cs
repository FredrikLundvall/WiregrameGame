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
    public partial class EnterPincodeForm : Form
    {
        public EnterPincodeForm()
        {
            InitializeComponent();
        }

        public string getPincode()
        {
            return pincode1UpDwn.Value.ToString() + pincode2UpDwn.Value.ToString() + pincode3UpDwn.Value.ToString() + pincode4UpDwn.Value.ToString();
        }

        private void CreateGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }
     }
}
