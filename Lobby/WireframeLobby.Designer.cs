namespace BlowtorchesAndGunpowder
{
    partial class WireframeLobby
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.currentGamesLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loggedInPlayersLb = new System.Windows.Forms.ListBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.createLoginBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.editLoginBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.createGameBtn = new System.Windows.Forms.Button();
            this.joinGameBtn = new System.Windows.Forms.Button();
            this.refreshTim = new System.Windows.Forms.Timer(this.components);
            this.connectionFailedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(614, 305);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(103, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Starta spelet";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitBtn.Location = new System.Drawing.Point(12, 305);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(122, 23);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Avlsuta till desktop";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // currentGamesLb
            // 
            this.currentGamesLb.FormattingEnabled = true;
            this.currentGamesLb.Location = new System.Drawing.Point(391, 25);
            this.currentGamesLb.Name = "currentGamesLb";
            this.currentGamesLb.Size = new System.Drawing.Size(322, 173);
            this.currentGamesLb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skapade spel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inloggade spelare";
            // 
            // loggedInPlayersLb
            // 
            this.loggedInPlayersLb.FormattingEnabled = true;
            this.loggedInPlayersLb.Location = new System.Drawing.Point(12, 25);
            this.loggedInPlayersLb.Name = "loggedInPlayersLb";
            this.loggedInPlayersLb.Size = new System.Drawing.Size(348, 173);
            this.loggedInPlayersLb.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 208);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Logga in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createLoginBtn
            // 
            this.createLoginBtn.Location = new System.Drawing.Point(240, 208);
            this.createLoginBtn.Name = "createLoginBtn";
            this.createLoginBtn.Size = new System.Drawing.Size(120, 23);
            this.createLoginBtn.TabIndex = 7;
            this.createLoginBtn.Text = "Skapa inloggning";
            this.createLoginBtn.UseVisualStyleBackColor = true;
            this.createLoginBtn.Click += new System.EventHandler(this.createLoginBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsBtn.Location = new System.Drawing.Point(12, 276);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(122, 23);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.Text = "Inställningar";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // editLoginBtn
            // 
            this.editLoginBtn.Location = new System.Drawing.Point(240, 237);
            this.editLoginBtn.Name = "editLoginBtn";
            this.editLoginBtn.Size = new System.Drawing.Size(120, 23);
            this.editLoginBtn.TabIndex = 9;
            this.editLoginBtn.Text = "Redigera inloggning";
            this.editLoginBtn.UseVisualStyleBackColor = true;
            this.editLoginBtn.Click += new System.EventHandler(this.editLoginBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(614, 450);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(103, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(12, 237);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(103, 23);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logga ut";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // createGameBtn
            // 
            this.createGameBtn.Location = new System.Drawing.Point(391, 208);
            this.createGameBtn.Name = "createGameBtn";
            this.createGameBtn.Size = new System.Drawing.Size(120, 23);
            this.createGameBtn.TabIndex = 12;
            this.createGameBtn.Text = "Skapa spel";
            this.createGameBtn.UseVisualStyleBackColor = true;
            this.createGameBtn.Click += new System.EventHandler(this.createGameBtn_Click);
            // 
            // joinGameBtn
            // 
            this.joinGameBtn.Location = new System.Drawing.Point(391, 237);
            this.joinGameBtn.Name = "joinGameBtn";
            this.joinGameBtn.Size = new System.Drawing.Size(120, 23);
            this.joinGameBtn.TabIndex = 13;
            this.joinGameBtn.Text = "Gå med i spel";
            this.joinGameBtn.UseVisualStyleBackColor = true;
            this.joinGameBtn.Click += new System.EventHandler(this.joinGameBtn_Click);
            // 
            // refreshTim
            // 
            this.refreshTim.Enabled = true;
            this.refreshTim.Interval = 4000;
            this.refreshTim.Tick += new System.EventHandler(this.refreshTim_Tick);
            // 
            // connectionFailedLbl
            // 
            this.connectionFailedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionFailedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.connectionFailedLbl.Location = new System.Drawing.Point(240, 305);
            this.connectionFailedLbl.Name = "connectionFailedLbl";
            this.connectionFailedLbl.Size = new System.Drawing.Size(271, 23);
            this.connectionFailedLbl.TabIndex = 14;
            this.connectionFailedLbl.Text = "Connection failed";
            this.connectionFailedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectionFailedLbl.Visible = false;
            // 
            // WireframeLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 340);
            this.Controls.Add(this.connectionFailedLbl);
            this.Controls.Add(this.joinGameBtn);
            this.Controls.Add(this.createGameBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.editLoginBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.createLoginBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentGamesLb);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.loggedInPlayersLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "WireframeLobby";
            this.Text = "Wireframe Lobby";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WireframeLobby_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.ListBox currentGamesLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox loggedInPlayersLb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createLoginBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button editLoginBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.Button joinGameBtn;
        private System.Windows.Forms.Timer refreshTim;
        private System.Windows.Forms.Label connectionFailedLbl;
    }
}