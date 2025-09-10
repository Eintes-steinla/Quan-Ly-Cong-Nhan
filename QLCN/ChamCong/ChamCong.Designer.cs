using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;
namespace QLCN.ChamCong
{
    partial class ChamCong
    {
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterMaCN;
        private TextBox txtFilterCongTrinh;
        private TextBox txtFilterTenCN;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn dataGridViewColumnName;
        private DataGridViewTextBoxColumn dataGridViewColumnYear;
        private DataGridViewTextBoxColumn dataGridViewColumnLocation;
        private DataGridViewTextBoxColumn dataGridViewColumnID;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblMessage = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvConstruction = new DataGridView();
            dgvColSTT = new DataGridViewTextBoxColumn();
            dgvColMaCN = new DataGridViewTextBoxColumn();
            dgvColTenCN = new DataGridViewTextBoxColumn();
            dgvColCongTrinh = new DataGridViewTextBoxColumn();
            dgvColGioQuet = new DataGridViewTextBoxColumn();
            dgvColGhiChu = new DataGridViewTextBoxColumn();
            dataGridViewColumnCheckBox = new DataGridViewCheckBoxColumn();
            btnRefresh = new Button();
            panelFilter = new Panel();
            dtpFilterGioQuet = new DateTimePicker();
            txtFilterGhiChu = new TextBox();
            txtFilterMaCN = new TextBox();
            txtFilterCongTrinh = new TextBox();
            txtFilterTenCN = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            panel2 = new Panel();
            btnExport = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            lblGioQuet = new Label();
            dtpGioQuet = new DateTimePicker();
            lblCongTrinh = new Label();
            txtCongTrinh = new TextBox();
            txtGhiChu = new TextBox();
            lblTenCN = new Label();
            lblGhiChu = new Label();
            txtTenCN = new TextBox();
            lblMaCN = new Label();
            txtMaCN = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(50, 10);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.MaximumSize = new Size(1800, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1800, 30);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "test";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(550, 23);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(300, 23);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConstruction.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange(new DataGridViewColumn[] { dgvColSTT, dgvColMaCN, dgvColTenCN, dgvColCongTrinh, dgvColGioQuet, dgvColGhiChu, dataGridViewColumnCheckBox });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConstruction.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConstruction.Location = new Point(0, 38);
            dgvConstruction.Margin = new Padding(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.RowHeadersWidth = 51;
            dgvConstruction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConstruction.Size = new Size(1884, 463);
            dgvConstruction.TabIndex = 19;
            // 
            // dgvColSTT
            // 
            dgvColSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColSTT.HeaderText = "STT";
            dgvColSTT.MinimumWidth = 8;
            dgvColSTT.Name = "dgvColSTT";
            dgvColSTT.ReadOnly = true;
            dgvColSTT.Width = 60;
            // 
            // dgvColMaCN
            // 
            dgvColMaCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColMaCN.HeaderText = "Mã CN";
            dgvColMaCN.MinimumWidth = 8;
            dgvColMaCN.Name = "dgvColMaCN";
            dgvColMaCN.ReadOnly = true;
            dgvColMaCN.Width = 150;
            // 
            // dgvColTenCN
            // 
            dgvColTenCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTenCN.HeaderText = "Tên CN";
            dgvColTenCN.MinimumWidth = 8;
            dgvColTenCN.Name = "dgvColTenCN";
            dgvColTenCN.ReadOnly = true;
            dgvColTenCN.Width = 250;
            // 
            // dgvColCongTrinh
            // 
            dgvColCongTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColCongTrinh.HeaderText = "Công Trình";
            dgvColCongTrinh.MinimumWidth = 8;
            dgvColCongTrinh.Name = "dgvColCongTrinh";
            dgvColCongTrinh.ReadOnly = true;
            dgvColCongTrinh.Width = 300;
            // 
            // dgvColGioQuet
            // 
            dgvColGioQuet.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGioQuet.HeaderText = "Giờ quét";
            dgvColGioQuet.MinimumWidth = 8;
            dgvColGioQuet.Name = "dgvColGioQuet";
            dgvColGioQuet.ReadOnly = true;
            dgvColGioQuet.Width = 250;
            // 
            // dgvColGhiChu
            // 
            dgvColGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGhiChu.HeaderText = "Ghi chú";
            dgvColGhiChu.MinimumWidth = 8;
            dgvColGhiChu.Name = "dgvColGhiChu";
            dgvColGhiChu.ReadOnly = true;
            dgvColGhiChu.Width = 150;
            // 
            // dataGridViewColumnCheckBox
            // 
            dataGridViewColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewColumnCheckBox.HeaderText = "✅";
            dataGridViewColumnCheckBox.MinimumWidth = 6;
            dataGridViewColumnCheckBox.Name = "dataGridViewColumnCheckBox";
            dataGridViewColumnCheckBox.ReadOnly = true;
            dataGridViewColumnCheckBox.Width = 52;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(800, 23);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 50);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(dtpFilterGioQuet);
            panelFilter.Controls.Add(txtFilterGhiChu);
            panelFilter.Controls.Add(txtFilterMaCN);
            panelFilter.Controls.Add(txtFilterCongTrinh);
            panelFilter.Controls.Add(txtFilterTenCN);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1884, 38);
            panelFilter.TabIndex = 20;
            // 
            // dtpFilterGioQuet
            // 
            dtpFilterGioQuet.CustomFormat = " ";
            dtpFilterGioQuet.Format = DateTimePickerFormat.Short;
            dtpFilterGioQuet.Location = new Point(810, 0);
            dtpFilterGioQuet.Name = "dtpFilterGioQuet";
            dtpFilterGioQuet.Size = new Size(250, 38);
            dtpFilterGioQuet.TabIndex = 17;
            dtpFilterGioQuet.Value = new DateTime(2025, 9, 9, 22, 20, 12, 0);
            // 
            // txtFilterGhiChu
            // 
            txtFilterGhiChu.Location = new Point(1060, 0);
            txtFilterGhiChu.Name = "txtFilterGhiChu";
            txtFilterGhiChu.PlaceholderText = "GhiChu";
            txtFilterGhiChu.Size = new Size(150, 38);
            txtFilterGhiChu.TabIndex = 16;
            txtFilterGhiChu.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterMaCN
            // 
            txtFilterMaCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterMaCN.Location = new Point(110, 0);
            txtFilterMaCN.Name = "txtFilterMaCN";
            txtFilterMaCN.PlaceholderText = "MaCN";
            txtFilterMaCN.Size = new Size(150, 38);
            txtFilterMaCN.TabIndex = 7;
            txtFilterMaCN.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterCongTrinh
            // 
            txtFilterCongTrinh.Font = new Font("Times New Roman", 13.2F);
            txtFilterCongTrinh.Location = new Point(510, 0);
            txtFilterCongTrinh.Name = "txtFilterCongTrinh";
            txtFilterCongTrinh.PlaceholderText = "CongTrinh";
            txtFilterCongTrinh.Size = new Size(300, 38);
            txtFilterCongTrinh.TabIndex = 9;
            txtFilterCongTrinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterTenCN
            // 
            txtFilterTenCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterTenCN.Location = new Point(260, 0);
            txtFilterTenCN.Name = "txtFilterTenCN";
            txtFilterTenCN.PlaceholderText = "TenCN";
            txtFilterTenCN.Size = new Size(250, 38);
            txtFilterTenCN.TabIndex = 8;
            txtFilterTenCN.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxRemoveFilter
            // 
            pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Location = new Point(0, 0);
            pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
            pictureBoxRemoveFilter.Size = new Size(38, 38);
            pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRemoveFilter.TabIndex = 10;
            pictureBoxRemoveFilter.TabStop = false;
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRefresh);
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(1881, 100);
            panel2.TabIndex = 22;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(1050, 23);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 50);
            btnExport.TabIndex = 19;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvConstruction);
            panel3.Controls.Add(panelFilter);
            panel3.Location = new Point(0, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(1884, 540);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMessage);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1900, 50);
            panel4.TabIndex = 24;
            // 
            // lblGioQuet
            // 
            lblGioQuet.AutoSize = true;
            lblGioQuet.Location = new Point(50, 173);
            lblGioQuet.Margin = new Padding(4, 0, 4, 0);
            lblGioQuet.Name = "lblGioQuet";
            lblGioQuet.Size = new Size(120, 31);
            lblGioQuet.TabIndex = 4;
            lblGioQuet.Text = "Giờ Quét:";
            // 
            // dtpGioQuet
            // 
            dtpGioQuet.Format = DateTimePickerFormat.Short;
            dtpGioQuet.Location = new Point(300, 173);
            dtpGioQuet.Margin = new Padding(4, 5, 4, 5);
            dtpGioQuet.Name = "dtpGioQuet";
            dtpGioQuet.Size = new Size(300, 38);
            dtpGioQuet.TabIndex = 6;
            // 
            // lblCongTrinh
            // 
            lblCongTrinh.AutoSize = true;
            lblCongTrinh.Location = new Point(50, 123);
            lblCongTrinh.Margin = new Padding(4, 0, 4, 0);
            lblCongTrinh.Name = "lblCongTrinh";
            lblCongTrinh.Size = new Size(144, 31);
            lblCongTrinh.TabIndex = 3;
            lblCongTrinh.Text = "Công Trình:";
            // 
            // txtCongTrinh
            // 
            txtCongTrinh.Location = new Point(300, 123);
            txtCongTrinh.Margin = new Padding(4, 5, 4, 5);
            txtCongTrinh.Name = "txtCongTrinh";
            txtCongTrinh.Size = new Size(300, 38);
            txtCongTrinh.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(900, 23);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(300, 38);
            txtGhiChu.TabIndex = 10;
            // 
            // lblTenCN
            // 
            lblTenCN.AutoSize = true;
            lblTenCN.Location = new Point(50, 73);
            lblTenCN.Margin = new Padding(4, 0, 4, 0);
            lblTenCN.Name = "lblTenCN";
            lblTenCN.Size = new Size(182, 31);
            lblTenCN.TabIndex = 2;
            lblTenCN.Text = "Tên công nhân:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(700, 23);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(107, 31);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtTenCN
            // 
            txtTenCN.Location = new Point(300, 73);
            txtTenCN.Margin = new Padding(4, 5, 4, 5);
            txtTenCN.Name = "txtTenCN";
            txtTenCN.Size = new Size(300, 38);
            txtTenCN.TabIndex = 4;
            // 
            // lblMaCN
            // 
            lblMaCN.AutoSize = true;
            lblMaCN.Location = new Point(50, 23);
            lblMaCN.Margin = new Padding(4, 0, 4, 0);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(176, 31);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã công nhân:";
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(300, 23);
            txtMaCN.Margin = new Padding(4, 5, 4, 5);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(300, 38);
            txtMaCN.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaCN);
            panel1.Controls.Add(lblMaCN);
            panel1.Controls.Add(txtTenCN);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTenCN);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(txtCongTrinh);
            panel1.Controls.Add(lblCongTrinh);
            panel1.Controls.Add(dtpGioQuet);
            panel1.Controls.Add(lblGioQuet);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1881, 260);
            panel1.TabIndex = 21;
            // 
            // ChamCong
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChamCong";
            Size = new Size(1884, 981);
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private Panel panel2;
        private Panel panel3;
        private Button btnExport;
        private Panel panel4;
        private TextBox txtFilterGhiChu;
        private DateTimePicker dtpFilterGioQuet;
        private Label lblGioQuet;
        private DateTimePicker dtpGioQuet;
        private Label lblCongTrinh;
        private TextBox txtCongTrinh;
        private TextBox txtGhiChu;
        private Label lblTenCN;
        private Label lblGhiChu;
        private TextBox txtTenCN;
        private Label lblMaCN;
        private TextBox txtMaCN;
        private Panel panel1;
        private DataGridViewTextBoxColumn dgvColSTT;
        private DataGridViewTextBoxColumn dgvColMaCN;
        private DataGridViewTextBoxColumn dgvColTenCN;
        private DataGridViewTextBoxColumn dgvColCongTrinh;
        private DataGridViewTextBoxColumn dgvColGioQuet;
        private DataGridViewTextBoxColumn dgvColGhiChu;
        private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
    }
}