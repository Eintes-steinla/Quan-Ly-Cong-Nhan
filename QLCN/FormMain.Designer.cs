
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            tabControl = new TabControl();
            congTrinh = new TabPage();
            congTrinhControl = new QLCN.CongTrinh.CongTrinh();
            congNhan = new TabPage();
            chamCong = new TabPage();
            nghiPhep = new TabPage();
            phanCa = new TabPage();
            baoCao = new TabPage();
            nhatKyHeThong = new TabPage();
            tabControl.SuspendLayout();
            congTrinh.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(congTrinh);
            tabControl.Controls.Add(congNhan);
            tabControl.Controls.Add(chamCong);
            tabControl.Controls.Add(nghiPhep);
            tabControl.Controls.Add(phanCa);
            tabControl.Controls.Add(baoCao);
            tabControl.Controls.Add(nhatKyHeThong);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.ImageList = this.imageList1;
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1335, 537);
            tabControl.TabIndex = 0;
            // 
            // congTrinh
            // 
            congTrinh.Controls.Add(congTrinhControl);
            congTrinh.Dock = DockStyle.Fill;
            congTrinh.Location = new Point(4, 34);
            congTrinh.Margin = new Padding(4, 5, 4, 5);
            congTrinh.Name = "congTrinh";
            congTrinh.Padding = new Padding(3);
            congTrinh.ImageIndex = 0;
            congTrinh.Size = new Size(1327, 499);
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
            congTrinhControl.Size = new Size(1321, 493);
            congTrinhControl.TabIndex = 0;
            // 
            // congNhan
            // 
            congNhan.Dock = DockStyle.Fill;
            congNhan.Location = new Point(4, 29);
            congNhan.Margin = new Padding(4, 5, 4, 5);
            congNhan.Name = "congNhan";
            congNhan.Padding = new Padding(3);
            congNhan.ImageIndex = 1;
            congNhan.Size = new Size(1327, 504);
            congNhan.TabIndex = 0;
            congNhan.Text = "Công nhân";
            congNhan.UseVisualStyleBackColor = true;
            // 
            // chamCong
            // 
            chamCong.Dock = DockStyle.Fill;
            chamCong.Location = new Point(4, 29);
            chamCong.Margin = new Padding(4, 5, 4, 5);
            chamCong.Name = "chamCong";
            chamCong.Padding = new Padding(3);
            chamCong.ImageIndex = 2;
            chamCong.Size = new Size(1327, 504);
            chamCong.TabIndex = 1;
            chamCong.Text = "Chấm công";
            chamCong.UseVisualStyleBackColor = true;
            // 
            // nghiPhep
            // 
            nghiPhep.Dock = DockStyle.Fill;
            nghiPhep.Location = new Point(4, 29);
            nghiPhep.Margin = new Padding(4, 5, 4, 5);
            nghiPhep.Name = "nghiPhep";
            nghiPhep.Padding = new Padding(3);
            nghiPhep.ImageIndex = 3;
            nghiPhep.Size = new Size(1327, 504);
            nghiPhep.TabIndex = 2;
            nghiPhep.Text = "Nghỉ phép";
            nghiPhep.UseVisualStyleBackColor = true;
            // 
            // phanCa
            // 
            phanCa.Dock = DockStyle.Fill;
            phanCa.Location = new Point(4, 29);
            phanCa.Margin = new Padding(4, 5, 4, 5);
            phanCa.Name = "phanCa";
            phanCa.Padding = new Padding(3);
            phanCa.ImageIndex = 4;
            phanCa.Size = new Size(1327, 504);
            phanCa.TabIndex = 3;
            phanCa.Text = "Phân ca / Ca làm";
            phanCa.UseVisualStyleBackColor = true;
            // 
            // baoCao
            // 
            baoCao.Dock = DockStyle.Fill;
            baoCao.Location = new Point(4, 29);
            baoCao.Margin = new Padding(4, 5, 4, 5);
            baoCao.Name = "baoCao";
            baoCao.Padding = new Padding(3);
            baoCao.ImageIndex = 5;
            baoCao.Size = new Size(1327, 504);
            baoCao.TabIndex = 4;
            baoCao.Text = "Báo cáo";
            baoCao.UseVisualStyleBackColor = true;
            // 
            // nhatKyHeThong
            // 
            nhatKyHeThong.Dock = DockStyle.Fill;
            nhatKyHeThong.Location = new Point(4, 29);
            nhatKyHeThong.Margin = new Padding(4, 5, 4, 5);
            nhatKyHeThong.Name = "nhatKyHeThong";
            nhatKyHeThong.Padding = new Padding(3);
            nhatKyHeThong.ImageIndex = 6;
            nhatKyHeThong.Size = new Size(1327, 504);
            nhatKyHeThong.TabIndex = 5;
            nhatKyHeThong.Text = "Nhật ký hệ thống";
            nhatKyHeThong.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 537);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý công nhân";
            WindowState = FormWindowState.Maximized;
            //
            // imageList1
            //
            // Cấu hình ImageList trước khi sử dụng
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            
            // Thêm các hình ảnh từ Resources
            this.imageList1.Images.Add(Properties.Resources.icons8_hotel_bed_32);
            this.imageList1.Images.Add(Properties.Resources.icons8_people_3d_fluency_32);
            this.imageList1.Images.Add(Properties.Resources.icons8_countdown_clock_32);
            this.imageList1.Images.Add(Properties.Resources.icons8_exit_32);
            this.imageList1.Images.Add(Properties.Resources.icons8_time_321);
            this.imageList1.Images.Add(Properties.Resources.icons8_report_32);
            this.imageList1.Images.Add(Properties.Resources.icons8_copybook_32);
            tabControl.ResumeLayout(false);
            congTrinh.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
