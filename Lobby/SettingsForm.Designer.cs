namespace BlowtorchesAndGunpowder
{
    partial class SettingsForm
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
            this.quitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serverIpTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverPortTxt = new System.Windows.Forms.TextBox();
            this.checkConnectionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.quitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitBtn.Location = new System.Drawing.Point(12, 125);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(81, 23);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "Avbryt";
            this.quitBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(176, 125);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(83, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Spara";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serverIpTxt
            // 
            this.serverIpTxt.BackColor = System.Drawing.SystemColors.Window;
            this.serverIpTxt.Location = new System.Drawing.Point(12, 25);
            this.serverIpTxt.Name = "serverIpTxt";
            this.serverIpTxt.Size = new System.Drawing.Size(127, 20);
            this.serverIpTxt.TabIndex = 3;
            this.serverIpTxt.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server port";
            // 
            // serverPortTxt
            // 
            this.serverPortTxt.BackColor = System.Drawing.SystemColors.Window;
            this.serverPortTxt.Location = new System.Drawing.Point(12, 64);
            this.serverPortTxt.Name = "serverPortTxt";
            this.serverPortTxt.Size = new System.Drawing.Size(127, 20);
            this.serverPortTxt.TabIndex = 5;
            this.serverPortTxt.Text = "4567";
            // 
            // checkConnectionBtn
            // 
            this.checkConnectionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkConnectionBtn.BackColor = System.Drawing.SystemColors.Control;
            this.checkConnectionBtn.Location = new System.Drawing.Point(155, 62);
            this.checkConnectionBtn.Name = "checkConnectionBtn";
            this.checkConnectionBtn.Size = new System.Drawing.Size(104, 23);
            this.checkConnectionBtn.TabIndex = 7;
            this.checkConnectionBtn.Text = "Testa anslutning";
            this.checkConnectionBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(271, 160);
            this.Controls.Add(this.checkConnectionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverPortTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverIpTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.quitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inställningar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox serverIpTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverPortTxt;
        private System.Windows.Forms.Button checkConnectionBtn;
    }
}