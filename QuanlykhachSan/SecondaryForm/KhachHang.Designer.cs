namespace QuanlykhachSan
{
    partial class frmKhachHang
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
            grpThaoTac = new GroupBox();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            grpThongTin = new GroupBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtCMND = new TextBox();
            lblSdt = new Label();
            txtIDKhangHang = new TextBox();
            lblIDKhachHang = new Label();
            txtTenKhachHang = new TextBox();
            lblTenKhachHang = new Label();
            dgvKhachHang = new DataGridView();
            lblKhachHang = new Label();
            grpThaoTac.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnTimKiem);
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(496, 68);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(267, 124);
            grpThaoTac.TabIndex = 17;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(41, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(140, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(140, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtCMND);
            grpThongTin.Controls.Add(lblSdt);
            grpThongTin.Controls.Add(txtIDKhangHang);
            grpThongTin.Controls.Add(lblIDKhachHang);
            grpThongTin.Controls.Add(txtTenKhachHang);
            grpThongTin.Controls.Add(lblTenKhachHang);
            grpThongTin.Location = new Point(37, 68);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(453, 124);
            grpThongTin.TabIndex = 16;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(77, 82);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(356, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(20, 85);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(51, 15);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "-Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(272, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(222, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "-Email:";
            // 
            // txtCMND
            // 
            txtCMND.BorderStyle = BorderStyle.FixedSingle;
            txtCMND.Location = new Point(342, 25);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(91, 23);
            txtCMND.TabIndex = 7;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new Point(285, 28);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(51, 15);
            lblSdt.TabIndex = 6;
            lblSdt.Text = "-CMND:";
            // 
            // txtIDKhangHang
            // 
            txtIDKhangHang.BorderStyle = BorderStyle.FixedSingle;
            txtIDKhangHang.Location = new Point(117, 54);
            txtIDKhangHang.Name = "txtIDKhangHang";
            txtIDKhangHang.Size = new Size(82, 23);
            txtIDKhangHang.TabIndex = 5;
            // 
            // lblIDKhachHang
            // 
            lblIDKhachHang.AutoSize = true;
            lblIDKhachHang.Location = new Point(20, 57);
            lblIDKhachHang.Name = "lblIDKhachHang";
            lblIDKhachHang.Size = new Size(91, 15);
            lblIDKhachHang.TabIndex = 4;
            lblIDKhachHang.Text = "-ID khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Location = new Point(124, 25);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(143, 23);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(20, 28);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(98, 15);
            lblTenKhachHang.TabIndex = 2;
            lblTenKhachHang.Text = "-Tên khách hàng:";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(37, 198);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(726, 240);
            dgvKhachHang.TabIndex = 15;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhachHang.Location = new Point(256, 23);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(279, 30);
            lblKhachHang.TabIndex = 14;
            lblKhachHang.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(dgvKhachHang);
            Controls.Add(lblKhachHang);
            Name = "frmKhachHang";
            Text = "KhachHang";
            grpThaoTac.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThaoTac;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox grpThongTin;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCMND;
        private Label lblSdt;
        private TextBox txtIDKhangHang;
        private Label lblIDKhachHang;
        private TextBox txtTenKhachHang;
        private Label lblTenKhachHang;
        private DataGridView dgvKhachHang;
        private Label lblKhachHang;
    }
}