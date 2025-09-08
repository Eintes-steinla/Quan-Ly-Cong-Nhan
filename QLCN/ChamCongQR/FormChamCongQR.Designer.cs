namespace QLCN
{
    partial class FormChamCongQR
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            picCamera = new PictureBox();
            lblResult = new Label();
            btnStart = new Button();
            btnStop = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 85);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hệ thống Chấm Công Bằng QR";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.Black;
            picCamera.BorderStyle = BorderStyle.FixedSingle;
            picCamera.Location = new Point(49, 88);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(500, 350);
            picCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCamera.TabIndex = 1;
            picCamera.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.ForeColor = Color.Green;
            lblResult.Location = new Point(49, 448);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(500, 40);
            lblResult.TabIndex = 2;
            lblResult.Text = "Đưa mã QR công nhân vào camera để chấm công...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(149, 498);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 35);
            btnStart.TabIndex = 3;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(349, 498);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 35);
            btnStop.TabIndex = 4;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 558);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(600, 32);
            statusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(278, 25);
            toolStripStatusLabel.Text = "Trạng thái: Chưa kích hoạt camera";
            // 
            // FormChamCongQR
            // 
            ClientSize = new Size(600, 590);
            Controls.Add(lblTitle);
            Controls.Add(picCamera);
            Controls.Add(lblResult);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormChamCongQR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm Công QR - QLCN";
            Load += FormChamCongQR_Load;
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
