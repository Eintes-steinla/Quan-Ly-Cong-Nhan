namespace QLCN
{
    partial class LichSuChamCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            congTrinh = new Label();
            tenCN = new Label();
            maCN = new Label();
            dataGridView1 = new DataGridView();
            dgvColGioQuet = new DataGridViewTextBoxColumn();
            dgvColGhiChu = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            btnXuatExcel = new Button();
            dtpFilterGioQuetTu = new DateTimePicker();
            dtpFilterGioQuetDen = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1194, 602);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(congTrinh);
            panel1.Controls.Add(tenCN);
            panel1.Controls.Add(maCN);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 114);
            panel1.TabIndex = 1;
            // 
            // congTrinh
            // 
            congTrinh.AutoSize = true;
            congTrinh.Font = new Font("Segoe UI", 12F);
            congTrinh.Location = new Point(800, 50);
            congTrinh.Name = "congTrinh";
            congTrinh.Size = new Size(120, 32);
            congTrinh.TabIndex = 2;
            congTrinh.Text = "congTrinh";
            // 
            // tenCN
            // 
            tenCN.AutoSize = true;
            tenCN.Font = new Font("Segoe UI", 12F);
            tenCN.Location = new Point(400, 50);
            tenCN.Name = "tenCN";
            tenCN.Size = new Size(82, 32);
            tenCN.TabIndex = 1;
            tenCN.Text = "tenCN";
            // 
            // maCN
            // 
            maCN.AutoSize = true;
            maCN.Font = new Font("Segoe UI", 12F);
            maCN.Location = new Point(50, 50);
            maCN.Name = "maCN";
            maCN.Size = new Size(80, 32);
            maCN.TabIndex = 0;
            maCN.Text = "maCN";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvColGioQuet, dgvColGhiChu });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1188, 355);
            dataGridView1.TabIndex = 0;
            // 
            // dgvColGioQuet
            // 
            dgvColGioQuet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvColGioQuet.HeaderText = "Giờ quét";
            dgvColGioQuet.MinimumWidth = 8;
            dgvColGioQuet.Name = "dgvColGioQuet";
            // 
            // dgvColGhiChu
            // 
            dgvColGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvColGhiChu.HeaderText = "Ghi chú";
            dgvColGhiChu.MinimumWidth = 8;
            dgvColGhiChu.Name = "dgvColGhiChu";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpFilterGioQuetDen);
            panel2.Controls.Add(dtpFilterGioQuetTu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(1188, 54);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXuatExcel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 544);
            panel3.Name = "panel3";
            panel3.Size = new Size(1188, 55);
            panel3.TabIndex = 3;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(50, 15);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(112, 34);
            btnXuatExcel.TabIndex = 0;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // dtpFilterGioQuetTu
            // 
            dtpFilterGioQuetTu.Format = DateTimePickerFormat.Custom;
            dtpFilterGioQuetTu.Location = new Point(62, 23);
            dtpFilterGioQuetTu.Name = "dtpFilterGioQuetTu";
            dtpFilterGioQuetTu.Size = new Size(200, 31);
            dtpFilterGioQuetTu.TabIndex = 0;
            // 
            // dtpFilterGioQuetDen
            // 
            dtpFilterGioQuetDen.Format = DateTimePickerFormat.Custom;
            dtpFilterGioQuetDen.Location = new Point(268, 23);
            dtpFilterGioQuetDen.Name = "dtpFilterGioQuetDen";
            dtpFilterGioQuetDen.Size = new Size(200, 31);
            dtpFilterGioQuetDen.TabIndex = 1;
            // 
            // LichSuChamCong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 602);
            Controls.Add(tableLayoutPanel1);
            Name = "LichSuChamCong";
            Text = "LichSuChamCong";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvColGioQuet;
        private DataGridViewTextBoxColumn dgvColGhiChu;
        private Panel panel1;
        private Label congTrinh;
        private Label tenCN;
        private Label maCN;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dtpFilterGioQuetDen;
        private DateTimePicker dtpFilterGioQuetTu;
        private Button btnXuatExcel;
    }
}