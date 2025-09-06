namespace QLCN
{
    partial class FormNhatKyHeThong
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvLogs;
        private Button btnRefresh, btnExport;
        private Label lblFilterUser, lblFilterDate;
        private TextBox txtFilterUser;
        private DateTimePicker dtpFilterDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvLogs = new DataGridView();
            btnRefresh = new Button();
            btnExport = new Button();
            lblFilterUser = new Label();
            lblFilterDate = new Label();
            txtFilterUser = new TextBox();
            dtpFilterDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.ColumnHeadersHeight = 34;
            dgvLogs.Location = new Point(30, 115);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(443, 315);
            dgvLogs.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(368, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 31);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(368, 30);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(105, 31);
            btnExport.TabIndex = 6;
            btnExport.Text = "Xuất Excel";
            btnExport.Click += btnExport_Click;
            // 
            // lblFilterUser
            // 
            lblFilterUser.Location = new Point(30, 30);
            lblFilterUser.Name = "lblFilterUser";
            lblFilterUser.Size = new Size(125, 31);
            lblFilterUser.TabIndex = 1;
            lblFilterUser.Text = "Người dùng:";
            // 
            // lblFilterDate
            // 
            lblFilterDate.Location = new Point(30, 67);
            lblFilterDate.Name = "lblFilterDate";
            lblFilterDate.Size = new Size(106, 31);
            lblFilterDate.TabIndex = 3;
            lblFilterDate.Text = "Ngày:";
            // 
            // txtFilterUser
            // 
            txtFilterUser.Location = new Point(161, 30);
            txtFilterUser.Name = "txtFilterUser";
            txtFilterUser.Size = new Size(169, 31);
            txtFilterUser.TabIndex = 2;
            txtFilterUser.TextChanged += txtFilterUser_TextChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(161, 67);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(169, 31);
            dtpFilterDate.TabIndex = 4;
            // 
            // FormNhatKyHeThong
            // 
            ClientSize = new Size(511, 450);
            Controls.Add(dgvLogs);
            Controls.Add(lblFilterUser);
            Controls.Add(txtFilterUser);
            Controls.Add(lblFilterDate);
            Controls.Add(dtpFilterDate);
            Controls.Add(btnRefresh);
            Controls.Add(btnExport);
            Name = "FormNhatKyHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật ký hệ thống";
            Load += FormNhatKyHeThong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
