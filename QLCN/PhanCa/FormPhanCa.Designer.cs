namespace QLCN
{
    partial class FormPhanCa
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCongNhan, lblCaLam, lblNgay;
        private ComboBox cboCongNhan, cboCaLam;
        private DateTimePicker dtpNgay;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvPhanCa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCongNhan = new Label();
            lblCaLam = new Label();
            lblNgay = new Label();
            cboCongNhan = new ComboBox();
            cboCaLam = new ComboBox();
            dtpNgay = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvPhanCa = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCa).BeginInit();
            SuspendLayout();
            // 
            // lblCongNhan
            // 
            lblCongNhan.Location = new Point(28, 106);
            lblCongNhan.Name = "lblCongNhan";
            lblCongNhan.Size = new Size(115, 23);
            lblCongNhan.TabIndex = 0;
            lblCongNhan.Text = "Công nhân:";
            // 
            // lblCaLam
            // 
            lblCaLam.Location = new Point(28, 146);
            lblCaLam.Name = "lblCaLam";
            lblCaLam.Size = new Size(100, 23);
            lblCaLam.TabIndex = 2;
            lblCaLam.Text = "Ca làm:";
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(28, 186);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(100, 23);
            lblNgay.TabIndex = 4;
            lblNgay.Text = "Ngày làm:";
            // 
            // cboCongNhan
            // 
            cboCongNhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCongNhan.Location = new Point(149, 96);
            cboCongNhan.Name = "cboCongNhan";
            cboCongNhan.Size = new Size(200, 33);
            cboCongNhan.TabIndex = 1;
            cboCongNhan.SelectedIndexChanged += cboCongNhan_SelectedIndexChanged;
            // 
            // cboCaLam
            // 
            cboCaLam.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCaLam.Location = new Point(149, 139);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(200, 33);
            cboCaLam.TabIndex = 3;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(149, 181);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(200, 31);
            dtpNgay.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(381, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(381, 139);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 33);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(522, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 33);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(522, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 33);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvPhanCa
            // 
            dgvPhanCa.ColumnHeadersHeight = 34;
            dgvPhanCa.Location = new Point(28, 240);
            dgvPhanCa.Name = "dgvPhanCa";
            dgvPhanCa.RowHeadersWidth = 62;
            dgvPhanCa.Size = new Size(601, 342);
            dgvPhanCa.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(253, 21);
            title.Name = "title";
            title.Size = new Size(136, 45);
            title.TabIndex = 11;
            title.Text = "Phân ca";
            // 
            // FormPhanCa
            // 
            ClientSize = new Size(661, 613);
            Controls.Add(title);
            Controls.Add(lblCongNhan);
            Controls.Add(cboCongNhan);
            Controls.Add(lblCaLam);
            Controls.Add(cboCaLam);
            Controls.Add(lblNgay);
            Controls.Add(dtpNgay);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPhanCa);
            Name = "FormPhanCa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Ca";
            Load += FormPhanCa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhanCa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
