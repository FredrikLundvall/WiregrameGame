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
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.currentGamesLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loggedInPlayersLb = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(725, 417);
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
            this.quitBtn.Location = new System.Drawing.Point(12, 417);
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
            this.currentGamesLb.Location = new System.Drawing.Point(12, 30);
            this.currentGamesLb.Name = "currentGamesLb";
            this.currentGamesLb.Size = new System.Drawing.Size(322, 173);
            this.currentGamesLb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pågående spel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inloggade spelare";
            // 
            // loggedInPlayersLb
            // 
            this.loggedInPlayersLb.FormattingEnabled = true;
            this.loggedInPlayersLb.Location = new System.Drawing.Point(384, 30);
            this.loggedInPlayersLb.Name = "loggedInPlayersLb";
            this.loggedInPlayersLb.Size = new System.Drawing.Size(322, 173);
            this.loggedInPlayersLb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(384, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logga in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WireframeLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loggedInPlayersLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentGamesLb);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
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
        private System.Windows.Forms.Button button1;
    }
}