namespace QLCN
{
    partial class FormUser
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername, lblPassword, lblRole;
        private TextBox txtUsername, txtPassword;
        private ComboBox cboRole;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvUser;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cboRole = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvUser = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(140, 31);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 31);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(30, 186);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 33);
            lblRole.TabIndex = 4;
            lblRole.Text = "Vai trò:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 3;
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Location = new Point(176, 186);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(200, 33);
            cboRole.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(405, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(534, 112);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 31);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(405, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(534, 149);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(106, 31);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeight = 34;
            dgvUser.Location = new Point(30, 246);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.Size = new Size(610, 359);
            dgvUser.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(176, 36);
            title.Name = "title";
            title.Size = new Size(319, 45);
            title.TabIndex = 11;
            title.Text = "Quản lý người dùng";
            // 
            // FormUser
            // 
            ClientSize = new Size(673, 633);
            Controls.Add(title);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvUser);
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý User";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
