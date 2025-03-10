namespace RentHouseMaster.Forms
{
    partial class QuanLyDichVuKhac
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
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dgvDichVu = new DataGridView();
            txtMaDichVu = new TextBox();
            txtTenDichVu = new TextBox();
            txtGiaDichVu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cboLoaiDichVu = new ComboBox();
            btnXemPhi = new Button();
            lblPhiDichVu = new Label();
            cboKhachHang = new ComboBox();
            cboDichVu = new ComboBox();
            txtSoLuong = new TextBox();
            lblTongTien = new Label();
            btnTinhToan = new Button();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1300, 720);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnXoa);
            tabPage1.Controls.Add(btnSua);
            tabPage1.Controls.Add(btnThem);
            tabPage1.Controls.Add(txtGiaDichVu);
            tabPage1.Controls.Add(txtTenDichVu);
            tabPage1.Controls.Add(txtMaDichVu);
            tabPage1.Controls.Add(dgvDichVu);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1284, 666);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Dịch Vụ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblPhiDichVu);
            tabPage2.Controls.Add(btnXemPhi);
            tabPage2.Controls.Add(cboLoaiDichVu);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1284, 666);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xem Phí Dịch Vụ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnTinhToan);
            tabPage3.Controls.Add(lblTongTien);
            tabPage3.Controls.Add(txtSoLuong);
            tabPage3.Controls.Add(cboDichVu);
            tabPage3.Controls.Add(cboKhachHang);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1284, 666);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Thu Phí";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDichVu
            // 
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Dock = DockStyle.Top;
            dgvDichVu.Location = new Point(3, 3);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 82;
            dgvDichVu.Size = new Size(1278, 300);
            dgvDichVu.TabIndex = 0;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtMaDichVu.Location = new Point(87, 342);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.PlaceholderText = "Mã dịch vụ";
            txtMaDichVu.Size = new Size(393, 39);
            txtMaDichVu.TabIndex = 1;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtTenDichVu.Location = new Point(87, 427);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.PlaceholderText = "Tên dịch vụ";
            txtTenDichVu.Size = new Size(393, 39);
            txtTenDichVu.TabIndex = 3;
            // 
            // txtGiaDichVu
            // 
            txtGiaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtGiaDichVu.Location = new Point(87, 512);
            txtGiaDichVu.Name = "txtGiaDichVu";
            txtGiaDichVu.PlaceholderText = "Giá dịch vụ";
            txtGiaDichVu.Size = new Size(393, 39);
            txtGiaDichVu.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(677, 423);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(863, 423);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 44);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1045, 423);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 44);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // cboLoaiDichVu
            // 
            cboLoaiDichVu.Dock = DockStyle.Top;
            cboLoaiDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiDichVu.FormattingEnabled = true;
            cboLoaiDichVu.Location = new Point(3, 3);
            cboLoaiDichVu.Name = "cboLoaiDichVu";
            cboLoaiDichVu.Size = new Size(1278, 40);
            cboLoaiDichVu.TabIndex = 0;
            // 
            // btnXemPhi
            // 
            btnXemPhi.Location = new Point(6, 213);
            btnXemPhi.Name = "btnXemPhi";
            btnXemPhi.Size = new Size(150, 46);
            btnXemPhi.TabIndex = 1;
            btnXemPhi.Text = "Xem Phí";
            btnXemPhi.UseVisualStyleBackColor = true;
            // 
            // lblPhiDichVu
            // 
            lblPhiDichVu.AutoSize = true;
            lblPhiDichVu.Location = new Point(376, 220);
            lblPhiDichVu.Name = "lblPhiDichVu";
            lblPhiDichVu.Size = new Size(220, 32);
            lblPhiDichVu.TabIndex = 2;
            lblPhiDichVu.Text = "Phí Dịch Vụ: 0 VNĐ";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Dock = DockStyle.Top;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(3, 3);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(1278, 40);
            cboKhachHang.TabIndex = 0;
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(3, 49);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(1278, 40);
            cboDichVu.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(3, 95);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng";
            txtSoLuong.Size = new Size(200, 39);
            txtSoLuong.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(294, 250);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(204, 32);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng Tiền: 0 VNĐ";
            // 
            // btnTinhToan
            // 
            btnTinhToan.Location = new Point(3, 236);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(150, 46);
            btnTinhToan.TabIndex = 4;
            btnTinhToan.Text = "Tính Toán";
            btnTinhToan.UseVisualStyleBackColor = true;
            // 
            // QuanLyDichVuKhac
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(tabControlMain);
            Name = "QuanLyDichVuKhac";
            Text = "QuanLyDichVuKhac";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvDichVu;
        private TextBox txtGiaDichVu;
        private TextBox txtTenDichVu;
        private TextBox txtMaDichVu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboLoaiDichVu;
        private Label lblPhiDichVu;
        private Button btnXemPhi;
        private ComboBox cboDichVu;
        private ComboBox cboKhachHang;
        private TextBox txtSoLuong;
        private Button btnTinhToan;
        private Label lblTongTien;
    }
}