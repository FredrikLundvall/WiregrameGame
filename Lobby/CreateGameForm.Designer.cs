namespace BlowtorchesAndGunpowder
{
    partial class CreateGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gamenameTxt = new System.Windows.Forms.TextBox();
            this.createGameBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pinCodeLbl = new System.Windows.Forms.Label();
            this.pincode1UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode2UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode3UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode4UpDwn = new System.Windows.Forms.NumericUpDown();
            this.usePincodeChb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pincode1UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode2UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode3UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode4UpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spelnamn";
            // 
            // gamenameTxt
            // 
            this.gamenameTxt.Location = new System.Drawing.Point(12, 25);
            this.gamenameTxt.Name = "gamenameTxt";
            this.gamenameTxt.Size = new System.Drawing.Size(231, 20);
            this.gamenameTxt.TabIndex = 1;
            // 
            // createGameBtn
            // 
            this.createGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createGameBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createGameBtn.Location = new System.Drawing.Point(161, 137);
            this.createGameBtn.Name = "createGameBtn";
            this.createGameBtn.Size = new System.Drawing.Size(83, 23);
            this.createGameBtn.TabIndex = 4;
            this.createGameBtn.Text = "Skapa spel";
            this.createGameBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 137);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Avbryt";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // pinCodeLbl
            // 
            this.pinCodeLbl.AutoSize = true;
            this.pinCodeLbl.Enabled = false;
            this.pinCodeLbl.Location = new System.Drawing.Point(9, 81);
            this.pinCodeLbl.Name = "pinCodeLbl";
            this.pinCodeLbl.Size = new System.Drawing.Size(40, 13);
            this.pinCodeLbl.TabIndex = 2;
            this.pinCodeLbl.Text = "Pinkod";
            // 
            // pincode1UpDwn
            // 
            this.pincode1UpDwn.Enabled = false;
            this.pincode1UpDwn.Location = new System.Drawing.Point(12, 97);
            this.pincode1UpDwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pincode1UpDwn.Name = "pincode1UpDwn";
            this.pincode1UpDwn.Size = new System.Drawing.Size(30, 20);
            this.pincode1UpDwn.TabIndex = 7;
            // 
            // pincode2UpDwn
            // 
            this.pincode2UpDwn.Enabled = false;
            this.pincode2UpDwn.Location = new System.Drawing.Point(48, 97);
            this.pincode2UpDwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pincode2UpDwn.Name = "pincode2UpDwn";
            this.pincode2UpDwn.Size = new System.Drawing.Size(30, 20);
            this.pincode2UpDwn.TabIndex = 8;
            // 
            // pincode3UpDwn
            // 
            this.pincode3UpDwn.Enabled = false;
            this.pincode3UpDwn.Location = new System.Drawing.Point(84, 97);
            this.pincode3UpDwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pincode3UpDwn.Name = "pincode3UpDwn";
            this.pincode3UpDwn.Size = new System.Drawing.Size(30, 20);
            this.pincode3UpDwn.TabIndex = 9;
            // 
            // pincode4UpDwn
            // 
            this.pincode4UpDwn.Enabled = false;
            this.pincode4UpDwn.Location = new System.Drawing.Point(120, 97);
            this.pincode4UpDwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pincode4UpDwn.Name = "pincode4UpDwn";
            this.pincode4UpDwn.Size = new System.Drawing.Size(30, 20);
            this.pincode4UpDwn.TabIndex = 10;
            // 
            // usePincodeChb
            // 
            this.usePincodeChb.AutoSize = true;
            this.usePincodeChb.Location = new System.Drawing.Point(12, 61);
            this.usePincodeChb.Name = "usePincodeChb";
            this.usePincodeChb.Size = new System.Drawing.Size(98, 17);
            this.usePincodeChb.TabIndex = 11;
            this.usePincodeChb.Text = "Använd pinkod";
            this.usePincodeChb.UseVisualStyleBackColor = true;
            this.usePincodeChb.CheckedChanged += new System.EventHandler(this.usePincodeChb_CheckedChanged);
            // 
            // CreateGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 172);
            this.Controls.Add(this.usePincodeChb);
            this.Controls.Add(this.pincode4UpDwn);
            this.Controls.Add(this.pincode3UpDwn);
            this.Controls.Add(this.pincode2UpDwn);
            this.Controls.Add(this.pincode1UpDwn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createGameBtn);
            this.Controls.Add(this.pinCodeLbl);
            this.Controls.Add(this.gamenameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skapa spel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateGameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pincode1UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode2UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode3UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode4UpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gamenameTxt;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label pinCodeLbl;
        private System.Windows.Forms.NumericUpDown pincode1UpDwn;
        private System.Windows.Forms.NumericUpDown pincode2UpDwn;
        private System.Windows.Forms.NumericUpDown pincode3UpDwn;
        private System.Windows.Forms.NumericUpDown pincode4UpDwn;
        private System.Windows.Forms.CheckBox usePincodeChb;
    }
}