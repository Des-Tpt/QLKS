namespace QuanlykhachSan
{
    partial class frmMain
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
            mnuTongQuat = new MenuStrip();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuPhong = new ToolStripMenuItem();
            mnuDatPhong = new ToolStripMenuItem();
            mnuDichVu = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuChiTietHoaDon = new ToolStripMenuItem();
            pnlChung = new Panel();
            mnuTongQuat.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTongQuat
            // 
            mnuTongQuat.Items.AddRange(new ToolStripItem[] { mnuKhachHang, mnuNhanVien, mnuPhong, mnuDatPhong, mnuDichVu, mnuHoaDon, mnuChiTietHoaDon });
            mnuTongQuat.Location = new Point(0, 0);
            mnuTongQuat.Name = "mnuTongQuat";
            mnuTongQuat.Size = new Size(850, 24);
            mnuTongQuat.TabIndex = 0;
            mnuTongQuat.Text = "menuStrip1";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(82, 20);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(73, 20);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuPhong
            // 
            mnuPhong.Name = "mnuPhong";
            mnuPhong.Size = new Size(54, 20);
            mnuPhong.Text = "Phòng";
            mnuPhong.Click += mnuPhong_Click;
            // 
            // mnuDatPhong
            // 
            mnuDatPhong.Name = "mnuDatPhong";
            mnuDatPhong.Size = new Size(75, 20);
            mnuDatPhong.Text = "Đặt phòng";
            mnuDatPhong.Click += mnuDatPhong_Click;
            // 
            // mnuDichVu
            // 
            mnuDichVu.Name = "mnuDichVu";
            mnuDichVu.Size = new Size(59, 20);
            mnuDichVu.Text = "Dịch vụ";
            mnuDichVu.Click += mnuDichVu_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(65, 20);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuChiTietHoaDon
            // 
            mnuChiTietHoaDon.Name = "mnuChiTietHoaDon";
            mnuChiTietHoaDon.Size = new Size(104, 20);
            mnuChiTietHoaDon.Text = "Chi tiết hóa đơn";
            mnuChiTietHoaDon.Click += mnuChiTietHoaDon_Click;
            // 
            // pnlChung
            // 
            pnlChung.BackColor = SystemColors.Control;
            pnlChung.Location = new Point(0, 27);
            pnlChung.Name = "pnlChung";
            pnlChung.Size = new Size(850, 461);
            pnlChung.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(850, 490);
            Controls.Add(pnlChung);
            Controls.Add(mnuTongQuat);
            MainMenuStrip = mnuTongQuat;
            Name = "frmMain";
            Text = "Quản lý khách sạn";
            mnuTongQuat.ResumeLayout(false);
            mnuTongQuat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTongQuat;
        private ToolStripMenuItem mnuNhanVien;
        private Panel pnlChung;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuPhong;
        private ToolStripMenuItem mnuDatPhong;
        private ToolStripMenuItem mnuDichVu;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuChiTietHoaDon;
    }
}