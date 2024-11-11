namespace QuanlykhachSan
{
    partial class frmPhong
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
            txtGiaPhong = new TextBox();
            lblGiaPhong = new Label();
            grpThongTin = new GroupBox();
            txtTinhTrang = new TextBox();
            lblTinhTrang = new Label();
            txtLoaiPhong = new TextBox();
            lblLoaiPhong = new Label();
            txtIDPhong = new TextBox();
            lblIDPhong = new Label();
            dgvNhanVien = new DataGridView();
            lblPhong = new Label();
            grpThaoTac.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnTimKiem);
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(459, 68);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(304, 124);
            grpThaoTac.TabIndex = 17;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
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
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(162, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
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
            // btnXoa
            // 
            btnXoa.Location = new Point(162, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtGiaPhong.Location = new Point(287, 71);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(81, 23);
            txtGiaPhong.TabIndex = 9;
            // 
            // lblGiaPhong
            // 
            lblGiaPhong.AutoSize = true;
            lblGiaPhong.Location = new Point(211, 74);
            lblGiaPhong.Name = "lblGiaPhong";
            lblGiaPhong.Size = new Size(70, 15);
            lblGiaPhong.TabIndex = 8;
            lblGiaPhong.Text = "-Giá phòng:";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtTinhTrang);
            grpThongTin.Controls.Add(lblTinhTrang);
            grpThongTin.Controls.Add(txtGiaPhong);
            grpThongTin.Controls.Add(lblGiaPhong);
            grpThongTin.Controls.Add(txtLoaiPhong);
            grpThongTin.Controls.Add(lblLoaiPhong);
            grpThongTin.Controls.Add(txtIDPhong);
            grpThongTin.Controls.Add(lblIDPhong);
            grpThongTin.Location = new Point(37, 68);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(416, 124);
            grpThongTin.TabIndex = 16;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.BorderStyle = BorderStyle.FixedSingle;
            txtTinhTrang.Location = new Point(287, 43);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(81, 23);
            txtTinhTrang.TabIndex = 11;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(211, 45);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(69, 15);
            lblTinhTrang.TabIndex = 10;
            lblTinhTrang.Text = "-Tình trạng:";
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            txtLoaiPhong.Location = new Point(114, 71);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(81, 23);
            txtLoaiPhong.TabIndex = 5;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location = new Point(38, 74);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(75, 15);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "-Loại phòng:";
            // 
            // txtIDPhong
            // 
            txtIDPhong.BorderStyle = BorderStyle.FixedSingle;
            txtIDPhong.Location = new Point(114, 43);
            txtIDPhong.Name = "txtIDPhong";
            txtIDPhong.Size = new Size(81, 23);
            txtIDPhong.TabIndex = 3;
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Location = new Point(38, 45);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(70, 15);
            lblIDPhong.TabIndex = 2;
            lblIDPhong.Text = "-Mã phòng:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(37, 198);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(726, 240);
            dgvNhanVien.TabIndex = 15;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhong.Location = new Point(295, 26);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(213, 30);
            lblPhong.TabIndex = 14;
            lblPhong.Text = "DANH MỤC PHÒNG";
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblPhong);
            Name = "frmPhong";
            Text = "Phong";
            grpThaoTac.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThaoTac;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private TextBox txtGiaPhong;
        private Label lblGiaPhong;
        private GroupBox grpThongTin;
        private TextBox txtLoaiPhong;
        private Label lblLoaiPhong;
        private TextBox txtIDPhong;
        private Label lblIDPhong;
        private DataGridView dgvNhanVien;
        private Label lblPhong;
        private Label lblTinhTrang;
        private TextBox txtTinhTrang;
    }
}