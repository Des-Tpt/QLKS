namespace QuanlykhachSan
{
    partial class frmNhanVien
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
            lblNhanVien = new Label();
            dgvNhanVien = new DataGridView();
            lblTenNhanVien = new Label();
            txtTenNhanVien = new TextBox();
            lblChucVu = new Label();
            txtChucVu = new TextBox();
            lblSdt = new Label();
            txtSdt = new TextBox();
            grpThongTin = new GroupBox();
            txtNgayVaoLam = new TextBox();
            lblNgayVaoLam = new Label();
            txtLuong = new TextBox();
            lblLuong = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            grpThaoTac = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            grpThongTin.SuspendLayout();
            grpThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(243, 9);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(256, 30);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(12, 190);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(726, 221);
            dgvNhanVien.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new Point(21, 28);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(88, 15);
            lblTenNhanVien.TabIndex = 2;
            lblTenNhanVien.Text = "-Tên nhân viên:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTenNhanVien.Location = new Point(115, 25);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(272, 23);
            txtTenNhanVien.TabIndex = 3;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(21, 57);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(59, 15);
            lblChucVu.TabIndex = 4;
            lblChucVu.Text = "-Chức vụ:";
            // 
            // txtChucVu
            // 
            txtChucVu.BorderStyle = BorderStyle.FixedSingle;
            txtChucVu.Location = new Point(86, 54);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(114, 23);
            txtChucVu.TabIndex = 5;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new Point(208, 59);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(84, 15);
            lblSdt.TabIndex = 6;
            lblSdt.Text = "-Số điện thoại:";
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Location = new Point(298, 54);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(89, 23);
            txtSdt.TabIndex = 7;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtNgayVaoLam);
            grpThongTin.Controls.Add(lblNgayVaoLam);
            grpThongTin.Controls.Add(txtLuong);
            grpThongTin.Controls.Add(lblLuong);
            grpThongTin.Controls.Add(txtSdt);
            grpThongTin.Controls.Add(lblSdt);
            grpThongTin.Controls.Add(txtChucVu);
            grpThongTin.Controls.Add(lblChucVu);
            grpThongTin.Controls.Add(txtTenNhanVien);
            grpThongTin.Controls.Add(lblTenNhanVien);
            grpThongTin.Location = new Point(12, 53);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(416, 124);
            grpThongTin.TabIndex = 8;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtNgayVaoLam
            // 
            txtNgayVaoLam.BorderStyle = BorderStyle.FixedSingle;
            txtNgayVaoLam.Location = new Point(298, 83);
            txtNgayVaoLam.Name = "txtNgayVaoLam";
            txtNgayVaoLam.Size = new Size(89, 23);
            txtNgayVaoLam.TabIndex = 11;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.AutoSize = true;
            lblNgayVaoLam.Location = new Point(206, 88);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new Size(88, 15);
            lblNgayVaoLam.TabIndex = 10;
            lblNgayVaoLam.Text = "-Ngày vào làm:";
            // 
            // txtLuong
            // 
            txtLuong.BorderStyle = BorderStyle.FixedSingle;
            txtLuong.Location = new Point(76, 83);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(114, 23);
            txtLuong.TabIndex = 9;
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Location = new Point(21, 88);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(49, 15);
            lblLuong.TabIndex = 8;
            lblLuong.Text = "-Lương:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(162, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(162, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(47, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnTimKiem);
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(434, 53);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(304, 124);
            grpThaoTac.TabIndex = 13;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 423);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblNhanVien);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNhanVien";
            Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpThaoTac.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhanVien;
        private DataGridView dgvNhanVien;
        private Label lblTenNhanVien;
        private TextBox txtTenNhanVien;
        private Label lblChucVu;
        private TextBox txtChucVu;
        private Label lblSdt;
        private TextBox txtSdt;
        private GroupBox grpThongTin;
        private Label lblLuong;
        private TextBox txtLuong;
        private Label lblNgayVaoLam;
        private TextBox txtNgayVaoLam;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTimKiem;
        private Button btnSua;
        private GroupBox grpThaoTac;
    }
}