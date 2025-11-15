namespace WinFormsAppLogin
{
    partial class Modau
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel lineEmail;
        private System.Windows.Forms.Panel linePassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modau));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lineEmail = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linePassword = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.lblRegTitle = new System.Windows.Forms.Label();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.lineRegUser = new System.Windows.Forms.Panel();
            this.lblRegGmail = new System.Windows.Forms.Label();
            this.txtRegGmail = new System.Windows.Forms.TextBox();
            this.lineRegGmail = new System.Windows.Forms.Panel();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.lineRegPass = new System.Windows.Forms.Panel();
            this.btnConfirmRegister = new System.Windows.Forms.Button();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.lblTitle);
            this.panelContainer.Controls.Add(this.lblSubtitle);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.txtEmail);
            this.panelContainer.Controls.Add(this.lineEmail);
            this.panelContainer.Controls.Add(this.lblPassword);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.linePassword);
            this.panelContainer.Controls.Add(this.btnLogin);
            this.panelContainer.Controls.Add(this.btnRegister);
            this.panelContainer.Location = new System.Drawing.Point(414, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(374, 400);
            this.panelContainer.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng Nhập";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(100, 23);
            this.lblSubtitle.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.lblEmail.Location = new System.Drawing.Point(24, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(157, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Tên người dùng / Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(28, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lineEmail
            // 
            this.lineEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.lineEmail.Location = new System.Drawing.Point(28, 140);
            this.lineEmail.Name = "lineEmail";
            this.lineEmail.Size = new System.Drawing.Size(320, 2);
            this.lineEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.lblPassword.Location = new System.Drawing.Point(24, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(28, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // linePassword
            // 
            this.linePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.linePassword.Location = new System.Drawing.Point(28, 210);
            this.linePassword.Name = "linePassword";
            this.linePassword.Size = new System.Drawing.Size(320, 2);
            this.linePassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(28, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập ";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(28, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(320, 45);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 281);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(30, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giao dịch thông minh, \r\nquyết định chính xác";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.lblRegTitle);
            this.panelRegister.Controls.Add(this.lblRegUser);
            this.panelRegister.Controls.Add(this.txtRegUser);
            this.panelRegister.Controls.Add(this.lineRegUser);
            this.panelRegister.Controls.Add(this.lblRegGmail);
            this.panelRegister.Controls.Add(this.txtRegGmail);
            this.panelRegister.Controls.Add(this.lineRegGmail);
            this.panelRegister.Controls.Add(this.lblRegPass);
            this.panelRegister.Controls.Add(this.txtRegPass);
            this.panelRegister.Controls.Add(this.lineRegPass);
            this.panelRegister.Controls.Add(this.btnConfirmRegister);
            this.panelRegister.Controls.Add(this.btnGoToLogin);
            this.panelRegister.Location = new System.Drawing.Point(414, 12);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(374, 420);
            this.panelRegister.TabIndex = 3;
            // 
            // lblRegTitle
            // 
            this.lblRegTitle.AutoSize = true;
            this.lblRegTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegTitle.ForeColor = System.Drawing.Color.White;
            this.lblRegTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRegTitle.Name = "lblRegTitle";
            this.lblRegTitle.Size = new System.Drawing.Size(146, 45);
            this.lblRegTitle.TabIndex = 0;
            this.lblRegTitle.Text = "Đăng Ký";
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.lblRegUser.Location = new System.Drawing.Point(24, 90);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(109, 19);
            this.lblRegUser.TabIndex = 1;
            this.lblRegUser.Text = "Tên người dùng";
            // 
            // txtRegUser
            // 
            this.txtRegUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtRegUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegUser.ForeColor = System.Drawing.Color.White;
            this.txtRegUser.Location = new System.Drawing.Point(28, 115);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(320, 22);
            this.txtRegUser.TabIndex = 2;
            // 
            // lineRegUser
            // 
            this.lineRegUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.lineRegUser.Location = new System.Drawing.Point(28, 140);
            this.lineRegUser.Name = "lineRegUser";
            this.lineRegUser.Size = new System.Drawing.Size(320, 2);
            this.lineRegUser.TabIndex = 3;
            // 
            // lblRegGmail
            // 
            this.lblRegGmail.AutoSize = true;
            this.lblRegGmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.lblRegGmail.Location = new System.Drawing.Point(24, 160);
            this.lblRegGmail.Name = "lblRegGmail";
            this.lblRegGmail.Size = new System.Drawing.Size(46, 19);
            this.lblRegGmail.TabIndex = 4;
            this.lblRegGmail.Text = "Gmail";
            // 
            // txtRegGmail
            // 
            this.txtRegGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtRegGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegGmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegGmail.ForeColor = System.Drawing.Color.White;
            this.txtRegGmail.Location = new System.Drawing.Point(28, 185);
            this.txtRegGmail.Name = "txtRegGmail";
            this.txtRegGmail.Size = new System.Drawing.Size(320, 22);
            this.txtRegGmail.TabIndex = 5;
            // 
            // lineRegGmail
            // 
            this.lineRegGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.lineRegGmail.Location = new System.Drawing.Point(28, 210);
            this.lineRegGmail.Name = "lineRegGmail";
            this.lineRegGmail.Size = new System.Drawing.Size(320, 2);
            this.lineRegGmail.TabIndex = 6;
            // 
            // lblRegPass
            // 
            this.lblRegPass.AutoSize = true;
            this.lblRegPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.lblRegPass.Location = new System.Drawing.Point(24, 230);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(68, 19);
            this.lblRegPass.TabIndex = 7;
            this.lblRegPass.Text = "Password";
            // 
            // txtRegPass
            // 
            this.txtRegPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtRegPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegPass.ForeColor = System.Drawing.Color.White;
            this.txtRegPass.Location = new System.Drawing.Point(28, 255);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(320, 22);
            this.txtRegPass.TabIndex = 8;
            this.txtRegPass.UseSystemPasswordChar = true;
            // 
            // lineRegPass
            // 
            this.lineRegPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.lineRegPass.Location = new System.Drawing.Point(28, 280);
            this.lineRegPass.Name = "lineRegPass";
            this.lineRegPass.Size = new System.Drawing.Size(320, 2);
            this.lineRegPass.TabIndex = 9;
            // 
            // btnConfirmRegister
            // 
            this.btnConfirmRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnConfirmRegister.FlatAppearance.BorderSize = 0;
            this.btnConfirmRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmRegister.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmRegister.Location = new System.Drawing.Point(28, 310);
            this.btnConfirmRegister.Name = "btnConfirmRegister";
            this.btnConfirmRegister.Size = new System.Drawing.Size(320, 45);
            this.btnConfirmRegister.TabIndex = 10;
            this.btnConfirmRegister.Text = "Xác nhận Đăng ký";
            this.btnConfirmRegister.UseVisualStyleBackColor = false;
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.btnGoToLogin.FlatAppearance.BorderSize = 0;
            this.btnGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToLogin.ForeColor = System.Drawing.Color.White;
            this.btnGoToLogin.Location = new System.Drawing.Point(28, 365);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(320, 45);
            this.btnGoToLogin.TabIndex = 11;
            this.btnGoToLogin.Text = "Quay lại Đăng nhập";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            // 
            // Modau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelRegister);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Modau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Fight";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblRegTitle;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.Panel lineRegUser;
        private System.Windows.Forms.Label lblRegGmail;
        private System.Windows.Forms.TextBox txtRegGmail;
        private System.Windows.Forms.Panel lineRegGmail;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Panel lineRegPass;
        private System.Windows.Forms.Button btnConfirmRegister;
        private System.Windows.Forms.Button btnGoToLogin;
    }
}