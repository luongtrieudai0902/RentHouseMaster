namespace RentHouseMaster.Forms
{
    partial class RoleSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSelection));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ownerLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            customerLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            staffLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            lblChuaCoTaiKhoan = new LinkLabel();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(255, 240, 217);
            panelMenu.Controls.Add(panelMenuBtn);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1422, 59);
            panelMenu.TabIndex = 3;
            // 
            // panelMenuBtn
            // 
            panelMenuBtn.Controls.Add(btnMinimize);
            panelMenuBtn.Controls.Add(btnClose);
            panelMenuBtn.Dock = DockStyle.Right;
            panelMenuBtn.Location = new Point(1189, 0);
            panelMenuBtn.Name = "panelMenuBtn";
            panelMenuBtn.Size = new Size(233, 59);
            panelMenuBtn.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(122, 22);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 217);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 918);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 240, 217);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1132, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 918);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(689, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(644, 262);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 13;
            label1.Text = "RentHouseMaster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 317);
            label2.Name = "label2";
            label2.Size = new Size(456, 31);
            label2.TabIndex = 14;
            label2.Text = "Chào mừng bạn đến với RentHouseMaster,";
            // 
            // ownerLoginBtn
            // 
            ownerLoginBtn.BorderRadius = 9;
            ownerLoginBtn.CustomizableEdges = customizableEdges1;
            ownerLoginBtn.DisabledState.BorderColor = Color.DarkGray;
            ownerLoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ownerLoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ownerLoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ownerLoginBtn.FillColor = Color.FromArgb(50, 105, 232);
            ownerLoginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ownerLoginBtn.ForeColor = Color.White;
            ownerLoginBtn.Location = new Point(398, 472);
            ownerLoginBtn.Name = "ownerLoginBtn";
            ownerLoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ownerLoginBtn.Size = new Size(195, 54);
            ownerLoginBtn.TabIndex = 19;
            ownerLoginBtn.Text = "Chủ nhà";
            ownerLoginBtn.Click += ownerLoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(524, 371);
            label3.Name = "label3";
            label3.Size = new Size(369, 31);
            label3.TabIndex = 20;
            label3.Text = "xin hãy cho chúng tôi biết bạn là...";
            // 
            // customerLoginBtn
            // 
            customerLoginBtn.BorderRadius = 9;
            customerLoginBtn.CustomizableEdges = customizableEdges3;
            customerLoginBtn.DisabledState.BorderColor = Color.DarkGray;
            customerLoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            customerLoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            customerLoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            customerLoginBtn.FillColor = Color.FromArgb(86, 213, 63);
            customerLoginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerLoginBtn.ForeColor = Color.White;
            customerLoginBtn.Location = new Point(620, 472);
            customerLoginBtn.Name = "customerLoginBtn";
            customerLoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            customerLoginBtn.Size = new Size(195, 54);
            customerLoginBtn.TabIndex = 21;
            customerLoginBtn.Text = "Khách hàng";
            customerLoginBtn.Click += customerLoginBtn_Click;
            // 
            // staffLoginBtn
            // 
            staffLoginBtn.BorderRadius = 9;
            staffLoginBtn.CustomizableEdges = customizableEdges5;
            staffLoginBtn.DisabledState.BorderColor = Color.DarkGray;
            staffLoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            staffLoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            staffLoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            staffLoginBtn.FillColor = Color.FromArgb(238, 124, 42);
            staffLoginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffLoginBtn.ForeColor = Color.White;
            staffLoginBtn.Location = new Point(839, 472);
            staffLoginBtn.Name = "staffLoginBtn";
            staffLoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            staffLoginBtn.Size = new Size(195, 54);
            staffLoginBtn.TabIndex = 22;
            staffLoginBtn.Text = "Nhân viên";
            staffLoginBtn.Click += staffLoginBtn_Click;
            // 
            // lblChuaCoTaiKhoan
            // 
            lblChuaCoTaiKhoan.AutoSize = true;
            lblChuaCoTaiKhoan.Location = new Point(653, 572);
            lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            lblChuaCoTaiKhoan.Size = new Size(153, 20);
            lblChuaCoTaiKhoan.TabIndex = 23;
            lblChuaCoTaiKhoan.TabStop = true;
            lblChuaCoTaiKhoan.Text = "Tôi chưa có tài khoản.";
            lblChuaCoTaiKhoan.LinkClicked += lblChuaCoTaiKhoan_LinkClicked;
            // 
            // RoleSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 217);
            ClientSize = new Size(1422, 977);
            Controls.Add(lblChuaCoTaiKhoan);
            Controls.Add(staffLoginBtn);
            Controls.Add(customerLoginBtn);
            Controls.Add(label3);
            Controls.Add(ownerLoginBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "RoleSelection";
            Text = "RoleSelection";
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button ownerLoginBtn;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button customerLoginBtn;
        private Guna.UI2.WinForms.Guna2Button staffLoginBtn;
        private LinkLabel lblChuaCoTaiKhoan;
    }
}