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
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).BeginInit();
            SuspendLayout();
            // 
            // lblMaCa
            // 
            lblMaCa.Location = new Point(30, 30);
            lblMaCa.Name = "lblMaCa";
            lblMaCa.Size = new Size(100, 23);
            lblMaCa.TabIndex = 0;
            lblMaCa.Text = "Mã ca:";
            // 
            // lblTenCa
            // 
            lblTenCa.Location = new Point(30, 70);
            lblTenCa.Name = "lblTenCa";
            lblTenCa.Size = new Size(100, 23);
            lblTenCa.TabIndex = 2;
            lblTenCa.Text = "Tên ca:";
            // 
            // lblGioBD
            // 
            lblGioBD.Location = new Point(372, 30);
            lblGioBD.Name = "lblGioBD";
            lblGioBD.Size = new Size(100, 23);
            lblGioBD.TabIndex = 4;
            lblGioBD.Text = "Giờ bắt đầu:";
            // 
            // lblGioKT
            // 
            lblGioKT.Location = new Point(372, 70);
            lblGioKT.Name = "lblGioKT";
            lblGioKT.Size = new Size(100, 23);
            lblGioKT.TabIndex = 6;
            lblGioKT.Text = "Giờ kết thúc:";
            // 
            // txtMaCa
            // 
            txtMaCa.Location = new Point(136, 22);
            txtMaCa.Name = "txtMaCa";
            txtMaCa.Size = new Size(150, 31);
            txtMaCa.TabIndex = 1;
            // 
            // txtTenCa
            // 
            txtTenCa.Location = new Point(136, 62);
            txtTenCa.Name = "txtTenCa";
            txtTenCa.Size = new Size(150, 31);
            txtTenCa.TabIndex = 3;
            txtTenCa.TextChanged += txtTenCa_TextChanged;
            // 
            // dtpGioBD
            // 
            dtpGioBD.Format = DateTimePickerFormat.Time;
            dtpGioBD.Location = new Point(478, 22);
            dtpGioBD.Name = "dtpGioBD";
            dtpGioBD.ShowUpDown = true;
            dtpGioBD.Size = new Size(200, 31);
            dtpGioBD.TabIndex = 5;
            // 
            // dtpGioKT
            // 
            dtpGioKT.Format = DateTimePickerFormat.Time;
            dtpGioKT.Location = new Point(478, 62);
            dtpGioKT.Name = "dtpGioKT";
            dtpGioKT.ShowUpDown = true;
            dtpGioKT.Size = new Size(200, 31);
            dtpGioKT.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(136, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(424, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 41);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(558, 118);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 41);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvCaLam
            // 
            dgvCaLam.ColumnHeadersHeight = 34;
            dgvCaLam.Location = new Point(30, 200);
            dgvCaLam.Name = "dgvCaLam";
            dgvCaLam.RowHeadersWidth = 62;
            dgvCaLam.Size = new Size(648, 250);
            dgvCaLam.TabIndex = 12;
            // 
            // FormCaLam
            // 
            ClientSize = new Size(733, 500);
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
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
