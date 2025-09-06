namespace QLCN
{
    partial class FormCongNhan
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvCongNhan;
        private Label lblMaCN, lblHoTen, lblGioiTinh, lblNgaySinh, lblSDT, lblDiaChi, lblBoPhan;
        private TextBox txtMaCN, txtHoTen, txtSDT, txtDiaChi, txtBoPhan;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCongNhan = new DataGridView();
            lblMaCN = new Label();
            lblHoTen = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblSDT = new Label();
            lblDiaChi = new Label();
            lblBoPhan = new Label();
            txtMaCN = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtBoPhan = new TextBox();
            cbGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCongNhan).BeginInit();
            SuspendLayout();
            // 
            // dgvCongNhan
            // 
            dgvCongNhan.ColumnHeadersHeight = 34;
            dgvCongNhan.Location = new Point(30, 250);
            dgvCongNhan.Name = "dgvCongNhan";
            dgvCongNhan.RowHeadersWidth = 62;
            dgvCongNhan.Size = new Size(576, 200);
            dgvCongNhan.TabIndex = 0;
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(30, 30);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(30, 70);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(30, 110);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(30, 150);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblSDT
            // 
            lblSDT.Location = new Point(400, 30);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 23);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(400, 70);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblBoPhan
            // 
            lblBoPhan.Location = new Point(400, 110);
            lblBoPhan.Name = "lblBoPhan";
            lblBoPhan.Size = new Size(100, 23);
            lblBoPhan.TabIndex = 7;
            lblBoPhan.Text = "Bộ phận:";
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(141, 22);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(200, 31);
            txtMaCN.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(141, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 31);
            txtHoTen.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(506, 22);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(100, 31);
            txtSDT.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(506, 62);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(100, 31);
            txtDiaChi.TabIndex = 13;
            // 
            // txtBoPhan
            // 
            txtBoPhan.Location = new Point(506, 102);
            txtBoPhan.Name = "txtBoPhan";
            txtBoPhan.Size = new Size(100, 31);
            txtBoPhan.TabIndex = 14;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(141, 99);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(200, 33);
            cbGioiTinh.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(141, 142);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 31);
            dtpNgaySinh.TabIndex = 11;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(266, 191);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 32);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(391, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(501, 191);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 32);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormCongNhan
            // 
            ClientSize = new Size(648, 500);
            Controls.Add(dgvCongNhan);
            Controls.Add(lblMaCN);
            Controls.Add(lblHoTen);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblSDT);
            Controls.Add(lblDiaChi);
            Controls.Add(lblBoPhan);
            Controls.Add(txtMaCN);
            Controls.Add(txtHoTen);
            Controls.Add(cbGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtBoPhan);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Name = "FormCongNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Công nhân";
            Load += FormCongNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCongNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
