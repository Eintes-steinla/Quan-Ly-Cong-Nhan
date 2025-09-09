using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;

namespace QLCN.CongNhan
{
    partial class CongNhan
    {
        private Label? lblHo;
        private TextBox txtHo;
        private Label? lblTenDem;
        private TextBox txtTenDem;
        private Label? lblTen;
        private TextBox txtTen;
        private Label? lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label? lblGioiTinh;
        private ComboBox cbGioiTinh;
        private Label? lblSDT;
        private TextBox txtSDT;
        private Label? lblCCCD;
        private TextBox txtCCCD;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private Panel? panelFilter;
        private DataGridView dgvWorker;
        private Label lblMessage;
        private TextBox txtFilterName;
        private TextBox txtFilterSDT;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip? toolTip;
        private DataGridViewTextBoxColumn? dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn? dataGridViewColumnHoTen;
        private DataGridViewTextBoxColumn? dataGridViewColumnNgaySinh;
        private DataGridViewTextBoxColumn? dataGridViewColumnGioiTinh;
        private DataGridViewTextBoxColumn? dataGridViewColumnSDT;
        private DataGridViewTextBoxColumn? dataGridViewColumnCCCD;
        private DataGridViewTextBoxColumn? dataGridViewColumnID;
        private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
        private System.ComponentModel.Container? components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            components = new();
            lblMessage = new();
            btnExport = new();
            btnDelete = new();
            btnEdit = new();
            btnAdd = new();
            btnRefresh = new();
            dgvWorker = new();
            panelFilter = new();
            txtFilterName = new();
            txtFilterSDT = new();
            pictureBoxRemoveFilter = new();
            toolTip = new(components);

            dataGridViewColumnSTT = new();
            dataGridViewColumnHoTen = new();
            dataGridViewColumnNgaySinh = new();
            dataGridViewColumnGioiTinh = new();
            dataGridViewColumnSDT = new();
            dataGridViewColumnCCCD = new();
            dataGridViewColumnID = new();
            dataGridViewColumnCheckBox = new();

            lblHo = new();
            txtHo = new();
            lblTenDem = new();
            txtTenDem = new();
            lblTen = new();
            txtTen = new();
            lblNgaySinh = new();
            dtpNgaySinh = new();
            lblGioiTinh = new();
            cbGioiTinh = new();
            lblSDT = new();
            txtSDT = new();
            lblCCCD = new();
            txtCCCD = new();

            ((System.ComponentModel.ISupportInitialize)dgvWorker).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            SuspendLayout();


            // lblMessage
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new(669, 20);
            lblMessage.MaximumSize = new(500, 0);
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;

            // Nút Xuất Excel
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new(1043, 744);
            btnExport.Size = new(151, 36);
            btnExport.Text = "Xuất Excel";

            // CRUD Buttons
            btnAdd.Location = new(32, 175);
            btnAdd.Size = new(160, 36);
            btnAdd.Text = "Thêm";

            btnEdit.Location = new(192, 175);
            btnEdit.Size = new(160, 36);
            btnEdit.Text = "Sửa";

            btnDelete.Location = new(352, 175);
            btnDelete.Size = new(160, 36);
            btnDelete.Text = "Xóa";

            btnRefresh.Location = new(513, 175);
            btnRefresh.Size = new(130, 36);
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");

            // TextBox nhập liệu
            lblHo.Text = "Họ:";
            lblHo.Location = new(31, 25);
            txtHo.Location = new(195, 20);
            txtHo.Size = new(200, 33);

            lblTenDem.Text = "Tên đệm:";
            lblTenDem.Location = new(420, 25);
            txtTenDem.Location = new(520, 20);
            txtTenDem.Size = new(200, 33);

            lblTen.Text = "Tên:";
            lblTen.Location = new(31, 75);
            txtTen.Location = new(195, 70);
            txtTen.Size = new(200, 33);

            lblNgaySinh.Text = "Ngày sinh:";
            lblNgaySinh.Location = new(420, 75);
            dtpNgaySinh.Location = new(520, 70);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;

            lblGioiTinh.Text = "Giới tính:";
            lblGioiTinh.Location = new(31, 125);
            cbGioiTinh.Location = new(195, 120);
            cbGioiTinh.Size = new(150, 33);
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            lblSDT.Text = "Số điện thoại:";
            lblSDT.Location = new(420, 125);
            txtSDT.Location = new(550, 120);
            txtSDT.Size = new(170, 33);

            lblCCCD.Text = "CCCD:";
            lblCCCD.Location = new(740, 125);
            txtCCCD.Location = new(810, 120);
            txtCCCD.Size = new(200, 33);

            // DataGridView
            dgvWorker.AllowUserToAddRows = false;
            dgvWorker.AllowUserToDeleteRows = false;
            dgvWorker.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvWorker.BackgroundColor = Color.White;
            dgvWorker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorker.Columns.AddRange(new DataGridViewColumn[]
            {
                dataGridViewColumnSTT, dataGridViewColumnHoTen, dataGridViewColumnNgaySinh,
                dataGridViewColumnGioiTinh, dataGridViewColumnSDT, dataGridViewColumnCCCD,
                dataGridViewColumnID, dataGridViewColumnCheckBox
            });
            dgvWorker.Location = new(31, 275);
            dgvWorker.ReadOnly = true;
            dgvWorker.Size = new(1163, 449);

            // Định nghĩa cột
            dataGridViewColumnSTT.HeaderText = "STT";
            dataGridViewColumnSTT.Width = 80;

            dataGridViewColumnHoTen.HeaderText = "Họ và tên";
            dataGridViewColumnHoTen.MinimumWidth = 250;

            dataGridViewColumnNgaySinh.HeaderText = "Ngày sinh";
            dataGridViewColumnNgaySinh.MinimumWidth = 150;

            dataGridViewColumnGioiTinh.HeaderText = "Giới tính";
            dataGridViewColumnGioiTinh.MinimumWidth = 100;

            dataGridViewColumnSDT.HeaderText = "SĐT";
            dataGridViewColumnSDT.MinimumWidth = 150;

            dataGridViewColumnCCCD.HeaderText = "CCCD";
            dataGridViewColumnCCCD.MinimumWidth = 150;

            dataGridViewColumnID.Visible = false;

            dataGridViewColumnCheckBox.HeaderText = "✅";
            dataGridViewColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Panel Filter
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(txtFilterName);
            panelFilter.Controls.Add(txtFilterSDT);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new(31, 230);
            panelFilter.Size = new(1163, 45);

            txtFilterName.Font = new("Times New Roman", 13.2F);
            txtFilterName.Location = new(130, 5);
            txtFilterName.PlaceholderText = "Tìm theo tên...";
            txtFilterName.Size = new(405, 33);

            txtFilterSDT.Font = new("Times New Roman", 13.2F);
            txtFilterSDT.Location = new(550, 5);
            txtFilterSDT.PlaceholderText = "Tìm theo SĐT...";
            txtFilterSDT.Size = new(250, 33);

            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Image = Properties.Resources.images;
            pictureBoxRemoveFilter.Location = new(0, 5);
            pictureBoxRemoveFilter.Size = new(33, 33);
            pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");

            // CongNhan UserControl
            AutoScaleDimensions = new(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(lblHo);
            Controls.Add(txtHo);
            Controls.Add(lblTenDem);
            Controls.Add(txtTenDem);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(cbGioiTinh);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
            Controls.Add(dgvWorker);
            Controls.Add(panelFilter);

            Font = new("Times New Roman", 13.2F);
            Name = "CongNhan";
            Size = new(1228, 780);

            ((System.ComponentModel.ISupportInitialize)dgvWorker).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
