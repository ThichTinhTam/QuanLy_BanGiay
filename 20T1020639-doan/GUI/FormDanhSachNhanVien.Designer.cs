﻿namespace _20T1020639_doan.GUI
{
    partial class FormDanhSachNhanVien
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
            btnKhoGiay = new Button();
            btnThongKe = new Button();
            btnDSNV = new Button();
            btnDangXuat = new Button();
            label1 = new Label();
            btnTrangChu = new Button();
            btnLoaiGiay = new Button();
            dgvNhanVien = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            chkGioiTinh = new CheckBox();
            txtManhanvien = new TextBox();
            txtDiachi = new TextBox();
            txtTennhanvien = new TextBox();
            mtbDienthoai = new MaskedTextBox();
            dtpNgaysinh = new DateTimePicker();
            chbNu = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(-7, 0);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(293, 88);
            btnKhoGiay.TabIndex = 21;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(-18, 175);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(304, 85);
            btnThongKe.TabIndex = 22;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(-18, 332);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(304, 82);
            btnDSNV.TabIndex = 23;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(-7, 577);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(293, 89);
            btnDangXuat.TabIndex = 24;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(27, 504);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 25;
            label1.Text = "Viết Shoe";
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(-18, 415);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(304, 79);
            btnTrangChu.TabIndex = 26;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click_1;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = SystemColors.ActiveCaption;
            btnLoaiGiay.Location = new Point(-7, 84);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(293, 93);
            btnLoaiGiay.TabIndex = 27;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(312, 255);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.RowTemplate.Height = 33;
            dgvNhanVien.Size = new Size(826, 330);
            dgvNhanVien.TabIndex = 28;
            dgvNhanVien.Click += dgvNhanVien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(618, 35);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 29;
            label2.Text = "Danh mục nhân viên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(349, 108);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 30;
            label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(346, 152);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 31;
            label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(346, 198);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 32;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(811, 108);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 33;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(811, 152);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 34;
            label7.Text = "Điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(811, 198);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 35;
            label8.Text = "Ngày sinh";
            // 
            // btnBoqua
            // 
            btnBoqua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnBoqua.ForeColor = SystemColors.ActiveCaption;
            btnBoqua.Image = Properties.Resources.Button_Next_icon;
            btnBoqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoqua.Location = new Point(940, 607);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(158, 53);
            btnBoqua.TabIndex = 40;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            btnBoqua.Click += btnBoqua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaption;
            btnLuu.Location = new Point(775, 607);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(134, 53);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaption;
            btnXoa.Image = Properties.Resources.Close_2_icon;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(618, 607);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 53);
            btnXoa.TabIndex = 38;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ActiveCaption;
            btnSua.Image = Properties.Resources.Button_Refresh_icon;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(474, 607);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 53);
            btnSua.TabIndex = 37;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaption;
            btnThem.Image = Properties.Resources.add_icon;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(312, 607);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 53);
            btnThem.TabIndex = 36;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new Point(514, 200);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(76, 29);
            chkGioiTinh.TabIndex = 41;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtManhanvien
            // 
            txtManhanvien.Location = new Point(514, 108);
            txtManhanvien.Name = "txtManhanvien";
            txtManhanvien.Size = new Size(185, 31);
            txtManhanvien.TabIndex = 42;
            txtManhanvien.TextChanged += textBox1_TextChanged;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(923, 102);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(215, 31);
            txtDiachi.TabIndex = 43;
            // 
            // txtTennhanvien
            // 
            txtTennhanvien.Location = new Point(514, 152);
            txtTennhanvien.Name = "txtTennhanvien";
            txtTennhanvien.Size = new Size(185, 31);
            txtTennhanvien.TabIndex = 44;
            txtTennhanvien.TextChanged += textBox2_TextChanged;
            // 
            // mtbDienthoai
            // 
            mtbDienthoai.Location = new Point(923, 146);
            mtbDienthoai.Mask = "(098) 000-0000";
            mtbDienthoai.Name = "mtbDienthoai";
            mtbDienthoai.Size = new Size(215, 31);
            mtbDienthoai.TabIndex = 45;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(923, 198);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(215, 31);
            dtpNgaysinh.TabIndex = 46;
            // 
            // chbNu
            // 
            chbNu.AutoSize = true;
            chbNu.Location = new Point(618, 200);
            chbNu.Name = "chbNu";
            chbNu.Size = new Size(61, 29);
            chbNu.TabIndex = 47;
            chbNu.Text = "Nu";
            chbNu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(-18, 255);
            button1.Name = "button1";
            button1.Size = new Size(304, 82);
            button1.TabIndex = 48;
            button1.Text = "Danh Sách Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDanhSachNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1143, 672);
            Controls.Add(button1);
            Controls.Add(chbNu);
            Controls.Add(dtpNgaysinh);
            Controls.Add(mtbDienthoai);
            Controls.Add(txtTennhanvien);
            Controls.Add(txtDiachi);
            Controls.Add(txtManhanvien);
            Controls.Add(chkGioiTinh);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnLoaiGiay);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormDanhSachNhanVien";
            Text = "Danh sách nhân viên";
            Load += FormDanhSachNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKhoGiay;
        private Button btnThongKe;
        private Button btnDSNV;
        private Button btnDangXuat;
        private Label label1;
        private Button btnTrangChu;
        private Button btnLoaiGiay;
        private DataGridView dgvNhanVien;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private CheckBox chkGioiTinh;
        private TextBox txtManhanvien;
        private TextBox txtDiachi;
        private TextBox txtTennhanvien;
        private MaskedTextBox mtbDienthoai;
        private DateTimePicker dtpNgaysinh;
        private CheckBox chbNu;
        private Button button1;
    }
}