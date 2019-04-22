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
    public partial class WireframeLobby : Form
    {
        public WireframeLobby()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            WireframeGame theGame = new WireframeGame();
            this.ShowInTaskbar = false;
            theGame.ShowInTaskbar = true;
            theGame.ShowDialog();
            theGame.ShowInTaskbar = false;
            this.ShowInTaskbar = true;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WireframeLobby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();                        
        }
    }
}
