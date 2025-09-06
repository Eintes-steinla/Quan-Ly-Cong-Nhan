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
            ((System.ComponentModel.ISupportInitialize)dgvTangCa).BeginInit();
            SuspendLayout();
            // 
            // lblMaCN
            // 
            lblMaCN.Location = new Point(30, 30);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(100, 23);
            lblMaCN.TabIndex = 0;
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
            // lblSoGio
            // 
            lblSoGio.Location = new Point(30, 110);
            lblSoGio.Name = "lblSoGio";
            lblSoGio.Size = new Size(100, 23);
            lblSoGio.TabIndex = 4;
            lblSoGio.Text = "Số giờ:";
            // 
            // lblLyDo
            // 
            lblLyDo.Location = new Point(348, 30);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(73, 23);
            lblLyDo.TabIndex = 6;
            lblLyDo.Text = "Lý do:";
            // 
            // cbMaCN
            // 
            cbMaCN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCN.Location = new Point(136, 20);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(171, 33);
            cbMaCN.TabIndex = 1;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(136, 62);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(171, 31);
            dtpNgay.TabIndex = 3;
            // 
            // txtSoGio
            // 
            txtSoGio.Location = new Point(136, 102);
            txtSoGio.Name = "txtSoGio";
            txtSoGio.Size = new Size(171, 31);
            txtSoGio.TabIndex = 5;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(427, 20);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(313, 113);
            txtLyDo.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(136, 154);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(306, 154);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(473, 154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(641, 154);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 35);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvTangCa
            // 
            dgvTangCa.ColumnHeadersHeight = 34;
            dgvTangCa.Location = new Point(30, 230);
            dgvTangCa.Name = "dgvTangCa";
            dgvTangCa.RowHeadersWidth = 62;
            dgvTangCa.Size = new Size(710, 250);
            dgvTangCa.TabIndex = 12;
            // 
            // FormTangCa
            // 
            ClientSize = new Size(784, 500);
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
            ((System.ComponentModel.ISupportInitialize)dgvTangCa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
