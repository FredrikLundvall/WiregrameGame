namespace BlowtorchesAndGunpowder
{
    partial class EnterPincodeForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pinCodeLbl = new System.Windows.Forms.Label();
            this.pincode1UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode2UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode3UpDwn = new System.Windows.Forms.NumericUpDown();
            this.pincode4UpDwn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pincode1UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode2UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode3UpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode4UpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(84, 64);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(67, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 64);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(66, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Avbryt";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // pinCodeLbl
            // 
            this.pinCodeLbl.AutoSize = true;
            this.pinCodeLbl.Location = new System.Drawing.Point(9, 9);
            this.pinCodeLbl.Name = "pinCodeLbl";
            this.pinCodeLbl.Size = new System.Drawing.Size(40, 13);
            this.pinCodeLbl.TabIndex = 2;
            this.pinCodeLbl.Text = "Pinkod";
            // 
            // pincode1UpDwn
            // 
            this.pincode1UpDwn.Location = new System.Drawing.Point(12, 25);
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
            this.pincode2UpDwn.Location = new System.Drawing.Point(48, 25);
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
            this.pincode3UpDwn.Location = new System.Drawing.Point(84, 25);
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
            this.pincode4UpDwn.Location = new System.Drawing.Point(120, 25);
            this.pincode4UpDwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pincode4UpDwn.Name = "pincode4UpDwn";
            this.pincode4UpDwn.Size = new System.Drawing.Size(30, 20);
            this.pincode4UpDwn.TabIndex = 10;
            // 
            // EnterPincodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 99);
            this.Controls.Add(this.pincode4UpDwn);
            this.Controls.Add(this.pincode3UpDwn);
            this.Controls.Add(this.pincode2UpDwn);
            this.Controls.Add(this.pincode1UpDwn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.pinCodeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterPincodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mata in pinkod";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateGameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pincode1UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode2UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode3UpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincode4UpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label pinCodeLbl;
        private System.Windows.Forms.NumericUpDown pincode1UpDwn;
        private System.Windows.Forms.NumericUpDown pincode2UpDwn;
        private System.Windows.Forms.NumericUpDown pincode3UpDwn;
        private System.Windows.Forms.NumericUpDown pincode4UpDwn;
    }
}