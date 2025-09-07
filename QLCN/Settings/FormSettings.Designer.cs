namespace QLCN
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCompanyName, lblAddress, lblPhone;
        private TextBox txtCompanyName, txtAddress, txtPhone;

        private Label lblServer, lblDatabase, lblDbUser, lblDbPassword;
        private TextBox txtServer, txtDatabase, txtDbUser, txtDbPassword;

        private Label lblLanguage, lblTheme;
        private ComboBox cboLanguage, cboTheme;

        private Button btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCompanyName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            txtCompanyName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            lblServer = new Label();
            lblDatabase = new Label();
            lblDbUser = new Label();
            lblDbPassword = new Label();
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            txtDbUser = new TextBox();
            txtDbPassword = new TextBox();
            lblLanguage = new Label();
            lblTheme = new Label();
            cboLanguage = new ComboBox();
            cboTheme = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.Location = new Point(30, 88);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(114, 31);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "Tên công ty:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(30, 125);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 31);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(30, 162);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(126, 31);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(162, 88);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(200, 31);
            txtCompanyName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(162, 125);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 31);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(162, 162);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 5;
            // 
            // lblServer
            // 
            lblServer.Location = new Point(30, 199);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(100, 31);
            lblServer.TabIndex = 6;
            lblServer.Text = "Server:";
            // 
            // lblDatabase
            // 
            lblDatabase.Location = new Point(30, 236);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(100, 31);
            lblDatabase.TabIndex = 8;
            lblDatabase.Text = "Database:";
            // 
            // lblDbUser
            // 
            lblDbUser.Location = new Point(30, 273);
            lblDbUser.Name = "lblDbUser";
            lblDbUser.Size = new Size(100, 31);
            lblDbUser.TabIndex = 10;
            lblDbUser.Text = "DB User:";
            // 
            // lblDbPassword
            // 
            lblDbPassword.Location = new Point(30, 310);
            lblDbPassword.Name = "lblDbPassword";
            lblDbPassword.Size = new Size(126, 31);
            lblDbPassword.TabIndex = 12;
            lblDbPassword.Text = "DB Password:";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(162, 199);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(200, 31);
            txtServer.TabIndex = 7;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(162, 236);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(200, 31);
            txtDatabase.TabIndex = 9;
            // 
            // txtDbUser
            // 
            txtDbUser.Location = new Point(162, 273);
            txtDbUser.Name = "txtDbUser";
            txtDbUser.Size = new Size(200, 31);
            txtDbUser.TabIndex = 11;
            // 
            // txtDbPassword
            // 
            txtDbPassword.Location = new Point(162, 310);
            txtDbPassword.Name = "txtDbPassword";
            txtDbPassword.PasswordChar = '*';
            txtDbPassword.Size = new Size(200, 31);
            txtDbPassword.TabIndex = 13;
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(30, 347);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(100, 33);
            lblLanguage.TabIndex = 14;
            lblLanguage.Text = "Ngôn ngữ:";
            // 
            // lblTheme
            // 
            lblTheme.Location = new Point(30, 386);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(100, 33);
            lblTheme.TabIndex = 16;
            lblTheme.Text = "Giao diện:";
            // 
            // cboLanguage
            // 
            cboLanguage.Items.AddRange(new object[] { "Tiếng Việt", "English" });
            cboLanguage.Location = new Point(162, 347);
            cboLanguage.Name = "cboLanguage";
            cboLanguage.Size = new Size(200, 33);
            cboLanguage.TabIndex = 15;
            // 
            // cboTheme
            // 
            cboTheme.Items.AddRange(new object[] { "Sáng", "Tối" });
            cboTheme.Location = new Point(162, 386);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(200, 33);
            cboTheme.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(162, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 33);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 33);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(140, 30);
            title.Name = "title";
            title.Size = new Size(124, 45);
            title.TabIndex = 20;
            title.Text = "Cài đặt";
            // 
            // FormSettings
            // 
            ClientSize = new Size(394, 486);
            Controls.Add(title);
            Controls.Add(lblCompanyName);
            Controls.Add(txtCompanyName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblServer);
            Controls.Add(txtServer);
            Controls.Add(lblDatabase);
            Controls.Add(txtDatabase);
            Controls.Add(lblDbUser);
            Controls.Add(txtDbUser);
            Controls.Add(lblDbPassword);
            Controls.Add(txtDbPassword);
            Controls.Add(lblLanguage);
            Controls.Add(cboLanguage);
            Controls.Add(lblTheme);
            Controls.Add(cboTheme);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cài đặt hệ thống";
            Load += FormSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
