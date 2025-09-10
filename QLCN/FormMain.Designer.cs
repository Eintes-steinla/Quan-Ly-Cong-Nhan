namespace QLCN
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage congNhan;
        private TabPage congTrinh;
        private TabPage chamCong;
        private TabPage hopDong;
        private TabPage nghiPhep;
        private ImageList imageList1;

        private QLCN.CongTrinh.CongTrinh congTrinhControl;
        private QLCN.CongNhan.CongNhan congNhanControl;
        private QLCN.ChamCong.ChamCong chamCongControl;
        private QLCN.HopDong.HopDong hopDongControl;
        private QLCN.NghiPhep.NghiPhep nghiPhepControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            imageList1 = new ImageList(components);
            tabControl = new TabControl();
            congNhan = new TabPage();
            congNhanControl = new QLCN.CongNhan.CongNhan();
            congTrinh = new TabPage();
            congTrinhControl = new QLCN.CongTrinh.CongTrinh();
            chamCong = new TabPage();
            chamCongControl = new QLCN.ChamCong.ChamCong();
            hopDong = new TabPage();
            hopDongControl = new QLCN.HopDong.HopDong();
            nghiPhep = new TabPage();
            tabControl.SuspendLayout();
            congNhan.SuspendLayout();
            congTrinh.SuspendLayout();
            chamCong.SuspendLayout();
            hopDong.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-people-3d-fluency-32.png");
            imageList1.Images.SetKeyName(1, "icons8-structural-32.png");
            imageList1.Images.SetKeyName(2, "icons8-time-32.png");
            imageList1.Images.SetKeyName(3, "icons8-copybook-32.png");
            imageList1.Images.SetKeyName(4, "icons8-hotel-bed-32.png");
            // 
            // tabControl
            // 
            tabControl.Controls.Add(congNhan);
            tabControl.Controls.Add(congTrinh);
            tabControl.Controls.Add(chamCong);
            tabControl.Controls.Add(hopDong);
            tabControl.Controls.Add(nghiPhep);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1407, 537);
            tabControl.TabIndex = 0;
            // 
            // congNhan
            // 
            congNhan.Controls.Add(congNhanControl);
            congNhan.ImageIndex = 0;
            congNhan.Location = new Point(4, 38);
            congNhan.Name = "congNhan";
            congNhan.Size = new Size(1399, 495);
            congNhan.TabIndex = 0;
            congNhan.Text = "Công nhân";
            congNhan.UseVisualStyleBackColor = true;
            // 
            // congNhanControl
            // 
            congNhanControl.Dock = DockStyle.Fill;
            congNhanControl.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            congNhanControl.Location = new Point(0, 0);
            congNhanControl.Margin = new Padding(4, 5, 4, 5);
            congNhanControl.Name = "congNhanControl";
            congNhanControl.Size = new Size(1399, 495);
            congNhanControl.TabIndex = 0;
            // 
            // congTrinh
            // 
            congTrinh.Controls.Add(congTrinhControl);
            congTrinh.ImageIndex = 1;
            congTrinh.Location = new Point(4, 34);
            congTrinh.Name = "congTrinh";
            congTrinh.Size = new Size(1399, 499);
            congTrinh.TabIndex = 1;
            congTrinh.Text = "Công trình";
            congTrinh.UseVisualStyleBackColor = true;
            // 
            // congTrinhControl
            // 
            congTrinhControl.Dock = DockStyle.Fill;
            congTrinhControl.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            congTrinhControl.Location = new Point(0, 0);
            congTrinhControl.Margin = new Padding(4, 5, 4, 5);
            congTrinhControl.Name = "congTrinhControl";
            congTrinhControl.Size = new Size(1399, 499);
            congTrinhControl.TabIndex = 0;
            // 
            // chamCong
            // 
            chamCong.Controls.Add(chamCongControl);
            chamCong.ImageIndex = 2;
            chamCong.Location = new Point(4, 38);
            chamCong.Name = "chamCong";
            chamCong.Size = new Size(1399, 495);
            chamCong.TabIndex = 2;
            chamCong.Text = "Chấm công";
            chamCong.UseVisualStyleBackColor = true;
            // 
            // chamCongControl
            // 
            chamCongControl.Dock = DockStyle.Fill;
            chamCongControl.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chamCongControl.Location = new Point(0, 0);
            chamCongControl.Margin = new Padding(4, 5, 4, 5);
            chamCongControl.Name = "chamCongControl";
            chamCongControl.Size = new Size(1399, 495);
            chamCongControl.TabIndex = 0;
            // 
            // hopDong
            // 
            hopDong.Controls.Add(hopDongControl);
            hopDong.ImageIndex = 3;
            hopDong.Location = new Point(4, 34);
            hopDong.Name = "hopDong";
            hopDong.Size = new Size(1399, 499);
            hopDong.TabIndex = 2;
            hopDong.Text = "Hợp đồng";
            hopDong.UseVisualStyleBackColor = true;
            // 
            // hopDongControl
            // 
            hopDongControl.Dock = DockStyle.Fill;
            hopDongControl.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hopDongControl.Location = new Point(0, 0);
            hopDongControl.Margin = new Padding(4, 5, 4, 5);
            hopDongControl.Name = "hopDongControl";
            hopDongControl.Size = new Size(1399, 499);
            hopDongControl.TabIndex = 0;
            // 
            // nghiPhep
            // 
            nghiPhep.ImageIndex = 4;
            nghiPhep.Location = new Point(4, 34);
            nghiPhep.Name = "nghiPhep";
            nghiPhep.Size = new Size(1399, 499);
            nghiPhep.TabIndex = 2;
            nghiPhep.Text = "Nghỉ phép";
            nghiPhep.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 537);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý công nhân";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            congNhan.ResumeLayout(false);
            congTrinh.ResumeLayout(false);
            chamCong.ResumeLayout(false);
            hopDong.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
