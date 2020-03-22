namespace BlowtorchesAndGunpowder
{
    partial class CreateLoginForm
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createLoginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användarnamn";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(12, 25);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(231, 20);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(12, 64);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(231, 20);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord";
            // 
            // createLoginBtn
            // 
            this.createLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createLoginBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createLoginBtn.Location = new System.Drawing.Point(137, 205);
            this.createLoginBtn.Name = "createLoginBtn";
            this.createLoginBtn.Size = new System.Drawing.Size(106, 23);
            this.createLoginBtn.TabIndex = 4;
            this.createLoginBtn.Text = "Skapa inloggning";
            this.createLoginBtn.UseVisualStyleBackColor = true;
            this.createLoginBtn.Click += new System.EventHandler(this.createLoginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 205);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Avbryt";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(12, 103);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(231, 20);
            this.confirmPasswordTxt.TabIndex = 8;
            this.confirmPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bekräfta lösenord";
            // 
            // playernameTxt
            // 
            this.playernameTxt.Location = new System.Drawing.Point(12, 158);
            this.playernameTxt.Name = "playernameTxt";
            this.playernameTxt.Size = new System.Drawing.Size(231, 20);
            this.playernameTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Spelarnamn";
            // 
            // CreateLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 240);
            this.Controls.Add(this.playernameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createLoginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skapa inloggning";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createLoginBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playernameTxt;
        private System.Windows.Forms.Label label4;
    }
}