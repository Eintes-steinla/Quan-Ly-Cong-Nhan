namespace QLCN
{
    partial class FormBaoCao : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLoai, lblFrom, lblTo;
        private ComboBox cboLoaiBaoCao;
        private DateTimePicker dtpFrom, dtpTo;
        private Button btnView, btnExport;
        private DataGridView dgvBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLoai = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            cboLoaiBaoCao = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnView = new Button();
            btnExport = new Button();
            dgvBaoCao = new DataGridView();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // lblLoai
            // 
            lblLoai.Location = new Point(36, 92);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(121, 31);
            lblLoai.TabIndex = 0;
            lblLoai.Text = "Loại báo cáo:";
            // 
            // lblFrom
            // 
            lblFrom.Location = new Point(36, 136);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(121, 31);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "Từ ngày:";
            // 
            // lblTo
            // 
            lblTo.Location = new Point(36, 176);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(100, 31);
            lblTo.TabIndex = 4;
            lblTo.Text = "Đến ngày:";
            // 
            // cboLoaiBaoCao
            // 
            cboLoaiBaoCao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiBaoCao.Location = new Point(163, 92);
            cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            cboLoaiBaoCao.Size = new Size(200, 33);
            cboLoaiBaoCao.TabIndex = 1;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(163, 136);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 31);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(163, 176);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 31);
            dtpTo.TabIndex = 5;
            // 
            // btnView
            // 
            btnView.Location = new Point(393, 92);
            btnView.Name = "btnView";
            btnView.Size = new Size(129, 33);
            btnView.TabIndex = 6;
            btnView.Text = "Xem báo cáo";
            btnView.Click += btnView_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(393, 136);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 31);
            btnExport.TabIndex = 7;
            btnExport.Text = "Xuất báo cáo";
            btnExport.Click += btnExport_Click;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeight = 34;
            dgvBaoCao.Location = new Point(36, 226);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.Size = new Size(486, 335);
            dgvBaoCao.TabIndex = 8;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(200, 30);
            title.Name = "title";
            title.Size = new Size(139, 45);
            title.TabIndex = 9;
            title.Text = "Báo cáo";
            // 
            // FormBaoCao
            // 
            ClientSize = new Size(571, 591);
            Controls.Add(title);
            Controls.Add(lblLoai);
            Controls.Add(cboLoaiBaoCao);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnView);
            Controls.Add(btnExport);
            Controls.Add(dgvBaoCao);
            Name = "FormBaoCao";
            Dock = DockStyle.Fill;
            Text = "Báo Cáo Thống Kê";
            Load += FormBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label title;
    }
}
