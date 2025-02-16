namespace RentHouseMaster.Forms
{
    partial class MainMenuForm
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
            panelShadow = new Panel();
            panelMenu = new Panel();
            labelMenu = new Label();
            logoBox = new PictureBox();
            panelSidebar = new Panel();
            panelNav = new Panel();
            btnQuanlyDichVu = new Button();
            btnDangxuat = new Button();
            btnQuanlyDienNuoc = new Button();
            btnQuanlyPhong = new Button();
            btnDangkyLuuTru = new Button();
            btnQuanlyLuuTru = new Button();
            panelContent = new Panel();
            panelShadow.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.Gainsboro;
            panelShadow.Controls.Add(panelMenu);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(0, 0);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1240, 75);
            panelShadow.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Controls.Add(logoBox);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1240, 70);
            panelMenu.TabIndex = 1;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(116, 23);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(145, 23);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "RentHouseMaster";
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.Logo;
            logoBox.Location = new Point(47, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(45, 45);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(panelNav);
            panelSidebar.Controls.Add(btnQuanlyDichVu);
            panelSidebar.Controls.Add(btnDangxuat);
            panelSidebar.Controls.Add(btnQuanlyDienNuoc);
            panelSidebar.Controls.Add(btnQuanlyPhong);
            panelSidebar.Controls.Add(btnDangkyLuuTru);
            panelSidebar.Controls.Add(btnQuanlyLuuTru);
            panelSidebar.Location = new Point(30, 90);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 610);
            panelSidebar.TabIndex = 1;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(50, 105, 232);
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 50);
            panelNav.TabIndex = 0;
            // 
            // btnQuanlyDichVu
            // 
            btnQuanlyDichVu.Dock = DockStyle.Top;
            btnQuanlyDichVu.FlatAppearance.BorderSize = 0;
            btnQuanlyDichVu.FlatStyle = FlatStyle.Flat;
            btnQuanlyDichVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyDichVu.Location = new Point(0, 200);
            btnQuanlyDichVu.Name = "btnQuanlyDichVu";
            btnQuanlyDichVu.Size = new Size(250, 50);
            btnQuanlyDichVu.TabIndex = 5;
            btnQuanlyDichVu.Text = "Quản lý dịch vụ              ";
            btnQuanlyDichVu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyDichVu.UseVisualStyleBackColor = true;
            btnQuanlyDichVu.Click += btnQuanlyDichVu_Click;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(176, 176, 176);
            btnDangxuat.Dock = DockStyle.Bottom;
            btnDangxuat.FlatAppearance.BorderSize = 0;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.Image = Properties.Resources.Logout;
            btnDangxuat.Location = new Point(0, 560);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(250, 50);
            btnDangxuat.TabIndex = 4;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangxuat.UseVisualStyleBackColor = false;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // btnQuanlyDienNuoc
            // 
            btnQuanlyDienNuoc.Dock = DockStyle.Top;
            btnQuanlyDienNuoc.FlatAppearance.BorderSize = 0;
            btnQuanlyDienNuoc.FlatStyle = FlatStyle.Flat;
            btnQuanlyDienNuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyDienNuoc.Location = new Point(0, 150);
            btnQuanlyDienNuoc.Name = "btnQuanlyDienNuoc";
            btnQuanlyDienNuoc.Size = new Size(250, 50);
            btnQuanlyDienNuoc.TabIndex = 3;
            btnQuanlyDienNuoc.Text = "Quản lý chỉ số điện/nước";
            btnQuanlyDienNuoc.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyDienNuoc.UseVisualStyleBackColor = true;
            btnQuanlyDienNuoc.Click += btnQuanlyDienNuoc_Click;
            // 
            // btnQuanlyPhong
            // 
            btnQuanlyPhong.Dock = DockStyle.Top;
            btnQuanlyPhong.FlatAppearance.BorderSize = 0;
            btnQuanlyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanlyPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyPhong.Location = new Point(0, 100);
            btnQuanlyPhong.Name = "btnQuanlyPhong";
            btnQuanlyPhong.Size = new Size(250, 50);
            btnQuanlyPhong.TabIndex = 2;
            btnQuanlyPhong.Text = "Quản lý phòng               ";
            btnQuanlyPhong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyPhong.UseVisualStyleBackColor = true;
            btnQuanlyPhong.Click += btnQuanlyPhong_Click;
            // 
            // btnDangkyLuuTru
            // 
            btnDangkyLuuTru.BackColor = Color.FromArgb(50, 105, 232);
            btnDangkyLuuTru.Dock = DockStyle.Top;
            btnDangkyLuuTru.FlatAppearance.BorderSize = 0;
            btnDangkyLuuTru.FlatStyle = FlatStyle.Flat;
            btnDangkyLuuTru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangkyLuuTru.ForeColor = Color.White;
            btnDangkyLuuTru.Location = new Point(0, 50);
            btnDangkyLuuTru.Name = "btnDangkyLuuTru";
            btnDangkyLuuTru.Size = new Size(250, 50);
            btnDangkyLuuTru.TabIndex = 1;
            btnDangkyLuuTru.Text = "Đăng ký lưu trú              ";
            btnDangkyLuuTru.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDangkyLuuTru.UseVisualStyleBackColor = false;
            btnDangkyLuuTru.Visible = false;
            btnDangkyLuuTru.Click += btnDangkyLuuTru_Click;
            // 
            // btnQuanlyLuuTru
            // 
            btnQuanlyLuuTru.Dock = DockStyle.Top;
            btnQuanlyLuuTru.FlatAppearance.BorderSize = 0;
            btnQuanlyLuuTru.FlatStyle = FlatStyle.Flat;
            btnQuanlyLuuTru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyLuuTru.Image = Properties.Resources.Dropdown;
            btnQuanlyLuuTru.Location = new Point(0, 0);
            btnQuanlyLuuTru.Name = "btnQuanlyLuuTru";
            btnQuanlyLuuTru.Size = new Size(250, 50);
            btnQuanlyLuuTru.TabIndex = 0;
            btnQuanlyLuuTru.Text = "Quản lý lưu trú";
            btnQuanlyLuuTru.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyLuuTru.UseVisualStyleBackColor = true;
            btnQuanlyLuuTru.Click += btnQuanlyLuuTru_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Location = new Point(311, 90);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(905, 610);
            panelContent.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 720);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelShadow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            panelShadow.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelShadow;
        private Panel panelMenu;
        private PictureBox logoBox;
        private Label labelMenu;
        private Panel panelSidebar;
        private Button btnQuanlyLuuTru;
        private Panel panelContent;
        private Button btnQuanlyDichVu;
        private Button btnDangxuat;
        private Button btnQuanlyDienNuoc;
        private Button btnQuanlyPhong;
        private Button btnDangkyLuuTru;
        private Panel panelNav;
    }
}