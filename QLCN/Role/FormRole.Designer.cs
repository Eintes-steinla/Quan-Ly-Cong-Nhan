namespace QLCN
{
    partial class FormRole
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRoleName, lblDescription;
        private TextBox txtRoleName, txtDescription;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRoleName = new Label();
            lblDescription = new Label();
            txtRoleName = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvRole = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRole).BeginInit();
            SuspendLayout();
            // 
            // lblRoleName
            // 
            lblRoleName.Location = new Point(30, 30);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(100, 23);
            lblRoleName.TabIndex = 0;
            lblRoleName.Text = "Tên vai trò:";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(30, 70);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Mô tả:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(150, 30);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(200, 31);
            txtRoleName.TabIndex = 1;
            txtRoleName.TextChanged += txtRoleName_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 70);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(380, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(380, 67);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(500, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(500, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 31);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvRole
            // 
            dgvRole.ColumnHeadersHeight = 34;
            dgvRole.Location = new Point(30, 160);
            dgvRole.Name = "dgvRole";
            dgvRole.RowHeadersWidth = 62;
            dgvRole.Size = new Size(570, 300);
            dgvRole.TabIndex = 8;
            // 
            // FormRole
            // 
            ClientSize = new Size(639, 500);
            Controls.Add(lblRoleName);
            Controls.Add(txtRoleName);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvRole);
            Name = "FormRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Vai Trò";
            Load += FormRole_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
