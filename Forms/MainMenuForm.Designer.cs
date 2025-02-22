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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            panelShadow = new Panel();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnMaximize = new Button();
            labelMenu = new Label();
            logoBox = new PictureBox();
            panelSidebar = new Panel();
            btnQuanlyDichVu = new Button();
            btnQuanlyDienNuoc = new Button();
            btnQuanlyPhong = new Button();
            panelNav = new Panel();
            btnDangxuat = new Button();
            btnDangkyLuuTru = new Button();
            btnQuanlyLuuTru = new Button();
            panelContent = new Panel();
            panelShadow.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
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
            panelShadow.Size = new Size(1240, 70);
            panelShadow.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(panelMenuBtn);
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Controls.Add(logoBox);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1240, 65);
            panelMenu.TabIndex = 1;
            panelMenu.MouseDown += mouse_Down;
            panelMenu.MouseMove += mouse_Move;
            // 
            // panelMenuBtn
            // 
            panelMenuBtn.Controls.Add(btnMinimize);
            panelMenuBtn.Controls.Add(btnClose);
            panelMenuBtn.Controls.Add(btnMaximize);
            panelMenuBtn.Dock = DockStyle.Right;
            panelMenuBtn.Location = new Point(1007, 0);
            panelMenuBtn.Name = "panelMenuBtn";
            panelMenuBtn.Size = new Size(233, 65);
            panelMenuBtn.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(49, 22);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(178, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(119, 24);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(20, 20);
            btnMaximize.TabIndex = 4;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(94, 22);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(145, 23);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "RentHouseMaster";
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.Logo;
            logoBox.Location = new Point(32, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(40, 40);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(btnQuanlyDichVu);
            panelSidebar.Controls.Add(btnQuanlyDienNuoc);
            panelSidebar.Controls.Add(btnQuanlyPhong);
            panelSidebar.Controls.Add(panelNav);
            panelSidebar.Controls.Add(btnDangxuat);
            panelSidebar.Controls.Add(btnDangkyLuuTru);
            panelSidebar.Controls.Add(btnQuanlyLuuTru);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 70);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 650);
            panelSidebar.TabIndex = 1;
            // 
            // btnQuanlyDichVu
            // 
            btnQuanlyDichVu.BackColor = Color.White;
            btnQuanlyDichVu.Dock = DockStyle.Top;
            btnQuanlyDichVu.FlatAppearance.BorderSize = 0;
            btnQuanlyDichVu.FlatStyle = FlatStyle.Flat;
            btnQuanlyDichVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyDichVu.ForeColor = Color.Black;
            btnQuanlyDichVu.Location = new Point(0, 200);
            btnQuanlyDichVu.Name = "btnQuanlyDichVu";
            btnQuanlyDichVu.Size = new Size(250, 50);
            btnQuanlyDichVu.TabIndex = 7;
            btnQuanlyDichVu.Text = "Quản lý dịch vụ              ";
            btnQuanlyDichVu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyDichVu.UseVisualStyleBackColor = false;
            btnQuanlyDichVu.Visible = false;
            btnQuanlyDichVu.Click += btnQuanlyDichVu_Click;
            // 
            // btnQuanlyDienNuoc
            // 
            btnQuanlyDienNuoc.BackColor = Color.White;
            btnQuanlyDienNuoc.Dock = DockStyle.Top;
            btnQuanlyDienNuoc.FlatAppearance.BorderSize = 0;
            btnQuanlyDienNuoc.FlatStyle = FlatStyle.Flat;
            btnQuanlyDienNuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyDienNuoc.ForeColor = Color.Black;
            btnQuanlyDienNuoc.Location = new Point(0, 150);
            btnQuanlyDienNuoc.Name = "btnQuanlyDienNuoc";
            btnQuanlyDienNuoc.Size = new Size(250, 50);
            btnQuanlyDienNuoc.TabIndex = 6;
            btnQuanlyDienNuoc.Text = "Quản lý chỉ số điện/nước";
            btnQuanlyDienNuoc.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyDienNuoc.UseVisualStyleBackColor = false;
            btnQuanlyDienNuoc.Visible = false;
            btnQuanlyDienNuoc.Click += btnQuanlyDienNuoc_Click;
            // 
            // btnQuanlyPhong
            // 
            btnQuanlyPhong.BackColor = Color.White;
            btnQuanlyPhong.Dock = DockStyle.Top;
            btnQuanlyPhong.FlatAppearance.BorderSize = 0;
            btnQuanlyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanlyPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanlyPhong.ForeColor = Color.Black;
            btnQuanlyPhong.Location = new Point(0, 100);
            btnQuanlyPhong.Name = "btnQuanlyPhong";
            btnQuanlyPhong.Size = new Size(250, 50);
            btnQuanlyPhong.TabIndex = 5;
            btnQuanlyPhong.Text = "Quản lý phòng                ";
            btnQuanlyPhong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuanlyPhong.UseVisualStyleBackColor = false;
            btnQuanlyPhong.Visible = false;
            btnQuanlyPhong.Click += btnQuanlyPhong_Click;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(50, 105, 232);
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 50);
            panelNav.TabIndex = 0;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(176, 176, 176);
            btnDangxuat.Dock = DockStyle.Bottom;
            btnDangxuat.FlatAppearance.BorderSize = 0;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.Image = Properties.Resources.Logout;
            btnDangxuat.Location = new Point(0, 600);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(250, 50);
            btnDangxuat.TabIndex = 4;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangxuat.UseVisualStyleBackColor = false;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // btnDangkyLuuTru
            // 
            btnDangkyLuuTru.BackColor = Color.White;
            btnDangkyLuuTru.Dock = DockStyle.Top;
            btnDangkyLuuTru.FlatAppearance.BorderSize = 0;
            btnDangkyLuuTru.FlatStyle = FlatStyle.Flat;
            btnDangkyLuuTru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangkyLuuTru.ForeColor = Color.Black;
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
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(990, 650);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            panelShadow.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelMenuBtn.ResumeLayout(false);
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
        private Button btnDangxuat;
        private Button btnDangkyLuuTru;
        private Panel panelNav;
        private Button btnQuanlyDichVu;
        private Button btnQuanlyDienNuoc;
        private Button btnQuanlyPhong;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Panel panelMenuBtn;
    }
}