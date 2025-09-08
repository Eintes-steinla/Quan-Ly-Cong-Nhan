namespace QLCN
{
    partial class FormChamCong
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvChamCong;
        private Label lblMaCN, lblNgay, lblTrangThai;
        private ComboBox cbMaCN, cbTrangThai;
        private DateTimePicker dtpNgay;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvChamCong = new DataGridView();
            lblMaCN = new Label();
            lblNgay = new Label();
            lblTrangThai = new Label();
            cbMaCN = new ComboBox();
            cbTrangThai = new ComboBox();
            dtpNgay = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // dgvChamCong
            // 
            dgvChamCong.ColumnHeadersHeight = 34;
            dgvChamCong.Location = new Point(31, 252);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 62;
            dgvChamCong.Size = new Size(569, 322);
            dgvChamCong.TabIndex = 0;
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(31, 112);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(31, 152);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(100, 23);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "Ngày:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(31, 192);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cbMaCN
            // 
            cbMaCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCN.Location = new Point(137, 102);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(180, 33);
            cbMaCN.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Items.AddRange(new object[] { "Đi làm", "Nghỉ phép", "Nghỉ không phép", "Làm thêm" });
            cbTrangThai.Location = new Point(137, 189);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(180, 33);
            cbTrangThai.TabIndex = 6;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(137, 147);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(180, 31);
            dtpNgay.TabIndex = 5;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(372, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(498, 100);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 35);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(372, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(498, 147);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 31);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(156, 27);
            title.Name = "title";
            title.Size = new Size(306, 45);
            title.TabIndex = 11;
            title.Text = "Quản lý chấm công";
            // 
            // FormChamCong
            // 
            ClientSize = new Size(636, 605);
            Controls.Add(title);
            Controls.Add(dgvChamCong);
            Controls.Add(lblMaCN);
            Controls.Add(lblNgay);
            Controls.Add(lblTrangThai);
            Controls.Add(cbMaCN);
            Controls.Add(dtpNgay);
            Controls.Add(cbTrangThai);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Name = "FormChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Chấm Công";
            Load += FormChamCong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
