namespace QuanlykhachSan.SecondaryForm
{
    partial class frmDichVu
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
            txtIDDichVu = new TextBox();
            lblIDDichVu = new Label();
            txtGiaDichVu = new TextBox();
            lblGiaDichVu = new Label();
            txtTenDichVu = new TextBox();
            lblTenDichVu = new Label();
            dgvNhanVien = new DataGridView();
            lblDichVu = new Label();
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
            grpThaoTac.Location = new Point(459, 67);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(304, 124);
            grpThaoTac.TabIndex = 21;
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
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtIDDichVu);
            grpThongTin.Controls.Add(lblIDDichVu);
            grpThongTin.Controls.Add(txtGiaDichVu);
            grpThongTin.Controls.Add(lblGiaDichVu);
            grpThongTin.Controls.Add(txtTenDichVu);
            grpThongTin.Controls.Add(lblTenDichVu);
            grpThongTin.Location = new Point(37, 67);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(416, 124);
            grpThongTin.TabIndex = 20;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtIDDichVu
            // 
            txtIDDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtIDDichVu.Location = new Point(297, 72);
            txtIDDichVu.Name = "txtIDDichVu";
            txtIDDichVu.Size = new Size(81, 23);
            txtIDDichVu.TabIndex = 11;
            // 
            // lblIDDichVu
            // 
            lblIDDichVu.AutoSize = true;
            lblIDDichVu.Location = new Point(223, 74);
            lblIDDichVu.Name = "lblIDDichVu";
            lblIDDichVu.Size = new Size(68, 15);
            lblIDDichVu.TabIndex = 10;
            lblIDDichVu.Text = "-ID dịch vụ:";
            // 
            // txtGiaDichVu
            // 
            txtGiaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtGiaDichVu.Location = new Point(117, 72);
            txtGiaDichVu.Name = "txtGiaDichVu";
            txtGiaDichVu.Size = new Size(100, 23);
            txtGiaDichVu.TabIndex = 5;
            // 
            // lblGiaDichVu
            // 
            lblGiaDichVu.AutoSize = true;
            lblGiaDichVu.Location = new Point(37, 74);
            lblGiaDichVu.Name = "lblGiaDichVu";
            lblGiaDichVu.Size = new Size(74, 15);
            lblGiaDichVu.TabIndex = 4;
            lblGiaDichVu.Text = "-Giá dịch vụ:";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtTenDichVu.Location = new Point(118, 43);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(260, 23);
            txtTenDichVu.TabIndex = 3;
            // 
            // lblTenDichVu
            // 
            lblTenDichVu.AutoSize = true;
            lblTenDichVu.Location = new Point(37, 45);
            lblTenDichVu.Name = "lblTenDichVu";
            lblTenDichVu.Size = new Size(75, 15);
            lblTenDichVu.TabIndex = 2;
            lblTenDichVu.Text = "-Tên dịch vụ:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(37, 197);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(726, 241);
            dgvNhanVien.TabIndex = 19;
            // 
            // lblDichVu
            // 
            lblDichVu.AutoSize = true;
            lblDichVu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDichVu.Location = new Point(295, 25);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(222, 30);
            lblDichVu.TabIndex = 18;
            lblDichVu.Text = "DANH MỤC DỊCH VỤ";
            // 
            // frmDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblDichVu);
            Name = "frmDichVu";
            Text = "DichVu";
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
        private GroupBox grpThongTin;
        private TextBox txtIDDichVu;
        private Label lblIDDichVu;
        private TextBox txtGiaDichVu;
        private Label lblGiaDichVu;
        private TextBox txtTenDichVu;
        private Label lblTenDichVu;
        private DataGridView dgvNhanVien;
        private Label lblDichVu;
    }
}