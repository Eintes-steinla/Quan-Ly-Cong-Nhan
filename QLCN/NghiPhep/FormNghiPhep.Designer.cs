namespace QLCN
{
    partial class FormNghiPhep
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMaCN, lblNgayBD, lblNgayKT, lblLyDo;
        private ComboBox cbMaCN;
        private DateTimePicker dtpNgayBD, dtpNgayKT;
        private TextBox txtLyDo;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvNghiPhep;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaCN = new Label();
            lblNgayBD = new Label();
            lblNgayKT = new Label();
            lblLyDo = new Label();
            cbMaCN = new ComboBox();
            dtpNgayBD = new DateTimePicker();
            dtpNgayKT = new DateTimePicker();
            txtLyDo = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvNghiPhep = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).BeginInit();
            SuspendLayout();
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(34, 123);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 0;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblNgayBD
            // 
            lblNgayBD.Location = new Point(34, 163);
            lblNgayBD.Name = "lblNgayBD";
            lblNgayBD.Size = new Size(131, 23);
            lblNgayBD.TabIndex = 2;
            lblNgayBD.Text = "Ngày bắt đầu:";
            // 
            // lblNgayKT
            // 
            lblNgayKT.Location = new Point(34, 203);
            lblNgayKT.Name = "lblNgayKT";
            lblNgayKT.Size = new Size(131, 23);
            lblNgayKT.TabIndex = 4;
            lblNgayKT.Text = "Ngày kết thúc:";
            // 
            // lblLyDo
            // 
            lblLyDo.Location = new Point(34, 237);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(66, 28);
            lblLyDo.TabIndex = 6;
            lblLyDo.Text = "Lý do:";
            // 
            // cbMaCN
            // 
            cbMaCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCN.Location = new Point(171, 123);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(163, 33);
            cbMaCN.TabIndex = 1;
            // 
            // dtpNgayBD
            // 
            dtpNgayBD.Format = DateTimePickerFormat.Short;
            dtpNgayBD.Location = new Point(171, 163);
            dtpNgayBD.Name = "dtpNgayBD";
            dtpNgayBD.Size = new Size(163, 31);
            dtpNgayBD.TabIndex = 3;
            // 
            // dtpNgayKT
            // 
            dtpNgayKT.Format = DateTimePickerFormat.Short;
            dtpNgayKT.Location = new Point(171, 200);
            dtpNgayKT.Name = "dtpNgayKT";
            dtpNgayKT.Size = new Size(163, 31);
            dtpNgayKT.TabIndex = 5;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(171, 237);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(163, 86);
            txtLyDo.TabIndex = 7;
            txtLyDo.TextChanged += txtLyDo_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(59, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(234, 342);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(59, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(234, 392);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 34);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvNghiPhep
            // 
            dgvNghiPhep.ColumnHeadersHeight = 34;
            dgvNghiPhep.Location = new Point(366, 123);
            dgvNghiPhep.Name = "dgvNghiPhep";
            dgvNghiPhep.RowHeadersWidth = 62;
            dgvNghiPhep.Size = new Size(521, 303);
            dgvNghiPhep.TabIndex = 12;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(299, 31);
            title.Name = "title";
            title.Size = new Size(295, 45);
            title.TabIndex = 13;
            title.Text = "Quản lý nghỉ phép";
            // 
            // FormNghiPhep
            // 
            ClientSize = new Size(929, 473);
            Controls.Add(title);
            Controls.Add(lblMaCN);
            Controls.Add(cbMaCN);
            Controls.Add(lblNgayBD);
            Controls.Add(dtpNgayBD);
            Controls.Add(lblNgayKT);
            Controls.Add(dtpNgayKT);
            Controls.Add(lblLyDo);
            Controls.Add(txtLyDo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvNghiPhep);
            Name = "FormNghiPhep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nghỉ Phép";
            Load += FormNghiPhep_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
