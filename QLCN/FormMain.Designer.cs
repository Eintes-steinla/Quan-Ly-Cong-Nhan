
namespace QLCN
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage baoCao;
        private TabPage chamCong;
        private TabPage nghiPhep;
        private TabPage phanCa;
        private TabPage nhatKyHeThong;
        private TabPage congNhan;
        private TabPage congTrinh;
        private System.Windows.Forms.ImageList imageList1;

        private QLCN.CongTrinh.CongTrinh congTrinhControl;
        private QLCN.CongNhan.CongNhan congNhanControl;
        private QLCN.ChamCong.ChamCong chamCongControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            tabControl = new TabControl();
            congNhan = new TabPage();
            congNhanControl = new QLCN.CongNhan.CongNhan();
            congTrinh = new TabPage();
            congTrinhControl = new QLCN.CongTrinh.CongTrinh();
            chamCong = new TabPage();
            chamCongControl = new QLCN.ChamCong.ChamCong();
            nghiPhep = new TabPage();
            phanCa = new TabPage();
            baoCao = new TabPage();
            nhatKyHeThong = new TabPage();
            tabControl.SuspendLayout();
            congNhan.SuspendLayout();
            congTrinh.SuspendLayout();
            chamCong.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(24, 24);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(congNhan);
            tabControl.Controls.Add(congTrinh);
            tabControl.Controls.Add(chamCong);
            tabControl.Controls.Add(nghiPhep);
            tabControl.Controls.Add(phanCa);
            tabControl.Controls.Add(baoCao);
            tabControl.Controls.Add(nhatKyHeThong);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1407, 537);
            tabControl.TabIndex = 0;
            // 
            // congNhan
            // 
            congNhan.Controls.Add(congNhanControl);
            congNhan.Dock = DockStyle.Fill;
            congNhan.ImageIndex = 1;
            congNhan.Location = new Point(4, 38);
            congNhan.Margin = new Padding(4, 5, 4, 5);
            congNhan.Name = "congNhan";
            congNhan.Padding = new Padding(3);
            congNhan.Size = new Size(1399, 495);
            congNhan.TabIndex = 0;
            congNhan.Text = "Công nhân";
            congNhan.UseVisualStyleBackColor = true;
            // 
            // congNhanControl
            // 
            congNhanControl.Dock = DockStyle.Fill;
            congNhanControl.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            congNhanControl.Location = new Point(3, 3);
            congNhanControl.Margin = new Padding(4, 5, 4, 5);
            congNhanControl.Name = "congNhanControl";
            congNhanControl.Size = new Size(1393, 489);
            congNhanControl.TabIndex = 0;
            // 
            // congTrinh
            // 
            congTrinh.Controls.Add(congTrinhControl);
            congTrinh.Dock = DockStyle.Fill;
            congTrinh.ImageIndex = 0;
            congTrinh.Location = new Point(4, 38);
            congTrinh.Margin = new Padding(4, 5, 4, 5);
            congTrinh.Name = "congTrinh";
            congTrinh.Padding = new Padding(3);
            congTrinh.Size = new Size(1399, 495);
            congTrinh.TabIndex = 5;
            congTrinh.Text = "Công trình";
            congTrinh.UseVisualStyleBackColor = true;
            // 
            // congTrinhControl
            // 
            congTrinhControl.Dock = DockStyle.Fill;
            congTrinhControl.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            congTrinhControl.Location = new Point(3, 3);
            congTrinhControl.Margin = new Padding(4, 5, 4, 5);
            congTrinhControl.Name = "congTrinhControl";
            congTrinhControl.Size = new Size(1393, 489);
            congTrinhControl.TabIndex = 0;
            // 
            // chamCong
            // 
            chamCong.Controls.Add(chamCongControl);
            chamCong.Dock = DockStyle.Fill;
            chamCong.ImageIndex = 2;
            chamCong.Location = new Point(4, 38);
            chamCong.Margin = new Padding(4, 5, 4, 5);
            chamCong.Name = "chamCong";
            chamCong.Padding = new Padding(3);
            chamCong.Size = new Size(1399, 495);
            chamCong.TabIndex = 1;
            chamCong.Text = "Chấm công";
            chamCong.UseVisualStyleBackColor = true;
            // 
            // chamCongControl
            // 
            chamCongControl.Dock = DockStyle.Fill;
            chamCongControl.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chamCongControl.Location = new Point(3, 3);
            chamCongControl.Margin = new Padding(4, 5, 4, 5);
            chamCongControl.Name = "chamCongControl";
            chamCongControl.Size = new Size(1393, 489);
            chamCongControl.TabIndex = 0;
            // 
            // nghiPhep
            // 
            nghiPhep.Dock = DockStyle.Fill;
            nghiPhep.ImageIndex = 3;
            nghiPhep.Location = new Point(4, 34);
            nghiPhep.Margin = new Padding(4, 5, 4, 5);
            nghiPhep.Name = "nghiPhep";
            nghiPhep.Padding = new Padding(3);
            nghiPhep.Size = new Size(1399, 499);
            nghiPhep.TabIndex = 2;
            nghiPhep.Text = "Nghỉ phép";
            nghiPhep.UseVisualStyleBackColor = true;
            // 
            // phanCa
            // 
            phanCa.Dock = DockStyle.Fill;
            phanCa.ImageIndex = 4;
            phanCa.Location = new Point(4, 34);
            phanCa.Margin = new Padding(4, 5, 4, 5);
            phanCa.Name = "phanCa";
            phanCa.Padding = new Padding(3);
            phanCa.Size = new Size(1399, 499);
            phanCa.TabIndex = 3;
            phanCa.Text = "Phân ca / Ca làm";
            phanCa.UseVisualStyleBackColor = true;
            // 
            // baoCao
            // 
            baoCao.Dock = DockStyle.Fill;
            baoCao.ImageIndex = 5;
            baoCao.Location = new Point(4, 34);
            baoCao.Margin = new Padding(4, 5, 4, 5);
            baoCao.Name = "baoCao";
            baoCao.Padding = new Padding(3);
            baoCao.Size = new Size(1399, 499);
            baoCao.TabIndex = 4;
            baoCao.Text = "Báo cáo";
            baoCao.UseVisualStyleBackColor = true;
            // 
            // nhatKyHeThong
            // 
            nhatKyHeThong.Dock = DockStyle.Fill;
            nhatKyHeThong.ImageIndex = 6;
            nhatKyHeThong.Location = new Point(4, 34);
            nhatKyHeThong.Margin = new Padding(4, 5, 4, 5);
            nhatKyHeThong.Name = "nhatKyHeThong";
            nhatKyHeThong.Padding = new Padding(3);
            nhatKyHeThong.Size = new Size(1399, 499);
            nhatKyHeThong.TabIndex = 5;
            nhatKyHeThong.Text = "Nhật ký hệ thống";
            nhatKyHeThong.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 537);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý công nhân";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            congNhan.ResumeLayout(false);
            congTrinh.ResumeLayout(false);
            chamCong.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
