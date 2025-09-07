namespace QLCN
{
    partial class FormTangCa
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMaCN, lblNgay, lblSoGio, lblLyDo;
        private ComboBox cbMaCN;
        private DateTimePicker dtpNgay;
        private TextBox txtSoGio, txtLyDo;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;
        private DataGridView dgvTangCa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaCN = new Label();
            lblNgay = new Label();
            lblSoGio = new Label();
            lblLyDo = new Label();
            cbMaCN = new ComboBox();
            dtpNgay = new DateTimePicker();
            txtSoGio = new TextBox();
            txtLyDo = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvTangCa = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTangCa).BeginInit();
            SuspendLayout();
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(31, 116);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 0;
            lblMaCN.Text = "Mã CN:";
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(31, 156);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(100, 23);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "Ngày:";
            // 
            // lblSoGio
            // 
            lblSoGio.Location = new Point(31, 196);
            lblSoGio.Name = "lblSoGio";
            lblSoGio.Size = new Size(100, 23);
            lblSoGio.TabIndex = 4;
            lblSoGio.Text = "Số giờ:";
            // 
            // lblLyDo
            // 
            lblLyDo.Location = new Point(349, 116);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(73, 23);
            lblLyDo.TabIndex = 6;
            lblLyDo.Text = "Lý do:";
            // 
            // cbMaCN
            // 
            cbMaCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCN.Location = new Point(137, 106);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(171, 33);
            cbMaCN.TabIndex = 1;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(137, 148);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(171, 31);
            dtpNgay.TabIndex = 3;
            // 
            // txtSoGio
            // 
            txtSoGio.Location = new Point(137, 188);
            txtSoGio.Name = "txtSoGio";
            txtSoGio.Size = new Size(171, 31);
            txtSoGio.TabIndex = 5;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(428, 106);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(313, 113);
            txtLyDo.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(307, 240);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(474, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(642, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 35);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvTangCa
            // 
            dgvTangCa.ColumnHeadersHeight = 34;
            dgvTangCa.Location = new Point(31, 316);
            dgvTangCa.Name = "dgvTangCa";
            dgvTangCa.RowHeadersWidth = 62;
            dgvTangCa.Size = new Size(710, 324);
            dgvTangCa.TabIndex = 12;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(255, 38);
            title.Name = "title";
            title.Size = new Size(252, 45);
            title.TabIndex = 13;
            title.Text = "Quản lý tăng ca";
            // 
            // FormTangCa
            // 
            ClientSize = new Size(784, 674);
            Controls.Add(title);
            Controls.Add(lblMaCN);
            Controls.Add(cbMaCN);
            Controls.Add(lblNgay);
            Controls.Add(dtpNgay);
            Controls.Add(lblSoGio);
            Controls.Add(txtSoGio);
            Controls.Add(lblLyDo);
            Controls.Add(txtLyDo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvTangCa);
            Name = "FormTangCa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Tăng Ca";
            Load += FormTangCa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTangCa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
