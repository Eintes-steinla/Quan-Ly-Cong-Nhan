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
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // dgvChamCong
            // 
            dgvChamCong.ColumnHeadersHeight = 34;
            dgvChamCong.Location = new Point(30, 200);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 62;
            dgvChamCong.Size = new Size(569, 250);
            dgvChamCong.TabIndex = 0;
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(30, 30);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(30, 70);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(100, 23);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "Ngày:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(30, 110);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cbMaCN
            // 
            cbMaCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCN.Location = new Point(136, 20);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(180, 33);
            cbMaCN.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Items.AddRange(new object[] { "Đi làm", "Nghỉ phép", "Nghỉ không phép", "Làm thêm" });
            cbTrangThai.Location = new Point(136, 107);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(180, 33);
            cbTrangThai.TabIndex = 6;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(136, 65);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(180, 31);
            dtpNgay.TabIndex = 5;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(371, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(497, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 35);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 65);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(497, 65);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 31);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormChamCong
            // 
            ClientSize = new Size(636, 500);
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
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
        }
    }
}
