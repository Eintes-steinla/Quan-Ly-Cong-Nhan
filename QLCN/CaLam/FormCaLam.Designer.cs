namespace QLCN
{
    partial class FormCaLam
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMaCa, lblTenCa, lblGioBD, lblGioKT;
        private TextBox txtMaCa, txtTenCa;
        private DateTimePicker dtpGioBD, dtpGioKT;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvCaLam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaCa = new Label();
            lblTenCa = new Label();
            lblGioBD = new Label();
            lblGioKT = new Label();
            txtMaCa = new TextBox();
            txtTenCa = new TextBox();
            dtpGioBD = new DateTimePicker();
            dtpGioKT = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvCaLam = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).BeginInit();
            SuspendLayout();
            // 
            // lblMaCa
            // 
            lblMaCa.Location = new Point(36, 124);
            lblMaCa.Name = "lblMaCa";
            lblMaCa.Size = new Size(83, 23);
            lblMaCa.TabIndex = 0;
            lblMaCa.Text = "Mã ca:";
            // 
            // lblTenCa
            // 
            lblTenCa.Location = new Point(36, 164);
            lblTenCa.Name = "lblTenCa";
            lblTenCa.Size = new Size(83, 23);
            lblTenCa.TabIndex = 2;
            lblTenCa.Text = "Tên ca:";
            // 
            // lblGioBD
            // 
            lblGioBD.Location = new Point(363, 124);
            lblGioBD.Name = "lblGioBD";
            lblGioBD.Size = new Size(115, 23);
            lblGioBD.TabIndex = 4;
            lblGioBD.Text = "Giờ bắt đầu:";
            // 
            // lblGioKT
            // 
            lblGioKT.Location = new Point(363, 164);
            lblGioKT.Name = "lblGioKT";
            lblGioKT.Size = new Size(115, 23);
            lblGioKT.TabIndex = 6;
            lblGioKT.Text = "Giờ kết thúc:";
            // 
            // txtMaCa
            // 
            txtMaCa.Location = new Point(125, 116);
            txtMaCa.Name = "txtMaCa";
            txtMaCa.Size = new Size(167, 31);
            txtMaCa.TabIndex = 1;
            txtMaCa.TextChanged += txtMaCa_TextChanged;
            // 
            // txtTenCa
            // 
            txtTenCa.Location = new Point(125, 156);
            txtTenCa.Name = "txtTenCa";
            txtTenCa.Size = new Size(167, 31);
            txtTenCa.TabIndex = 3;
            txtTenCa.TextChanged += txtTenCa_TextChanged;
            // 
            // dtpGioBD
            // 
            dtpGioBD.Format = DateTimePickerFormat.Time;
            dtpGioBD.Location = new Point(484, 116);
            dtpGioBD.Name = "dtpGioBD";
            dtpGioBD.ShowUpDown = true;
            dtpGioBD.Size = new Size(200, 31);
            dtpGioBD.TabIndex = 5;
            // 
            // dtpGioKT
            // 
            dtpGioKT.Format = DateTimePickerFormat.Time;
            dtpGioKT.Location = new Point(484, 156);
            dtpGioKT.Name = "dtpGioKT";
            dtpGioKT.ShowUpDown = true;
            dtpGioKT.Size = new Size(200, 31);
            dtpGioKT.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(430, 212);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(286, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(564, 212);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 30);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvCaLam
            // 
            dgvCaLam.ColumnHeadersHeight = 34;
            dgvCaLam.Location = new Point(36, 276);
            dgvCaLam.Name = "dgvCaLam";
            dgvCaLam.RowHeadersWidth = 62;
            dgvCaLam.Size = new Size(648, 279);
            dgvCaLam.TabIndex = 12;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(239, 38);
            title.Name = "title";
            title.Size = new Size(239, 45);
            title.TabIndex = 13;
            title.Text = "Quản lý ca làm";
            // 
            // FormCaLam
            // 
            ClientSize = new Size(733, 588);
            Controls.Add(title);
            Controls.Add(lblMaCa);
            Controls.Add(txtMaCa);
            Controls.Add(lblTenCa);
            Controls.Add(txtTenCa);
            Controls.Add(lblGioBD);
            Controls.Add(dtpGioBD);
            Controls.Add(lblGioKT);
            Controls.Add(dtpGioKT);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCaLam);
            Name = "FormCaLam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Ca Làm";
            Load += FormCaLam_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
