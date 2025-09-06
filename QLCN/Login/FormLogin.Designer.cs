// FormLogin.Designer.cs
namespace QLCN
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblForgotPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblForgotPassword = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(102, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(369, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập hệ thống QLCN";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(102, 87);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tài khoản:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(102, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(208, 79);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(257, 31);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Location = new Point(310, 171);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(155, 36);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "Nhớ tài khoản";
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(208, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(348, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.ForeColor = Color.Blue;
            lblForgotPassword.Location = new Point(323, 267);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(142, 25);
            lblForgotPassword.TabIndex = 8;
            lblForgotPassword.Text = "Quên mật khẩu?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // FormLogin
            // 
            ClientSize = new Size(568, 342);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkRememberMe);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(lblForgotPassword);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - QLCN";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
