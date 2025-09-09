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
            title = new Label();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCongNhan).BeginInit();
            SuspendLayout();
            // 
            // dgvCongNhan
            // 
            dgvCongNhan.ColumnHeadersHeight = 34;
            dgvCongNhan.Location = new Point(400, 100);
            dgvCongNhan.Name = "dgvCongNhan";
            dgvCongNhan.RowHeadersWidth = 62;
            dgvCongNhan.Size = new Size(600, 468);
            dgvCongNhan.TabIndex = 0;
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(50, 100);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 31);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(50, 150);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 31);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(50, 200);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 31);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(50, 250);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 31);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblSDT
            // 
            lblSDT.Location = new Point(50, 300);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 31);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(50, 400);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 31);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblBoPhan
            // 
            lblBoPhan.Location = new Point(50, 450);
            lblBoPhan.Name = "lblBoPhan";
            lblBoPhan.Size = new Size(100, 31);
            lblBoPhan.TabIndex = 7;
            lblBoPhan.Text = "Bộ phận:";
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(150, 100);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(200, 31);
            txtMaCN.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(150, 150);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 31);
            txtHoTen.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(150, 300);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 31);
            txtSDT.TabIndex = 12;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 400);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 31);
            txtDiaChi.TabIndex = 13;
            // 
            // txtBoPhan
            // 
            txtBoPhan.Location = new Point(150, 450);
            txtBoPhan.Name = "txtBoPhan";
            txtBoPhan.Size = new Size(200, 31);
            txtBoPhan.TabIndex = 14;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(150, 200);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(200, 33);
            cbGioiTinh.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(150, 250);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 31);
            dtpNgaySinh.TabIndex = 11;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 500);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 31);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(250, 500);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 31);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(250, 537);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 31);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(370, 30);
            title.Name = "title";
            title.Size = new Size(317, 45);
            title.TabIndex = 19;
            title.Text = "Quản Lý Công Nhân";
            title.Click += label1_Click;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(50, 350);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(88, 25);
            lblCCCD.TabIndex = 20;
            lblCCCD.Text = "Số CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(150, 350);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(200, 31);
            txtCCCD.TabIndex = 21;
            // 
            // FormCongNhan
            // 
            ClientSize = new Size(1061, 613);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(title);
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
            Dock = DockStyle.Fill;
            Text = "Quản lý Công nhân";  
            Load += FormCongNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCongNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
        private Label lblCCCD;
        private TextBox txtCCCD;
    }
}
