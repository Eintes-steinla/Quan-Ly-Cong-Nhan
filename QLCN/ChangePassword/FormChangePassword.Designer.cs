namespace QLCN
{
    partial class FormChangePassword
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblOldPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private Button btnCancel;

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
            lblOldPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(30, 30);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(113, 25);
            lblOldPassword.TabIndex = 0;
            lblOldPassword.Text = "Mật khẩu cũ:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(30, 70);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(126, 25);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "Mật khẩu mới:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(30, 110);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(167, 25);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(220, 27);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(282, 31);
            txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(220, 64);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(282, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(220, 101);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(282, 31);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(220, 152);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(154, 44);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(402, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // FormChangePassword
            // 
            ClientSize = new Size(543, 247);
            Controls.Add(lblOldPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnChangePassword);
            Controls.Add(btnCancel);
            Name = "FormChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
