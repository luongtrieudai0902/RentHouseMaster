namespace RentHouseMaster.Forms
{
    partial class CreateNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPassword));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            loginLinkLabel = new LinkLabel();
            newpswLabel = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            logoBox = new PictureBox();
            labelMenu = new Label();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1132, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 918);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 918);
            panel1.TabIndex = 8;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(panelMenuBtn);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1422, 59);
            panelMenu.TabIndex = 7;
            panelMenu.MouseDown += mouse_Down;
            panelMenu.MouseMove += mouse_Move;
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
            // confirmBtn
            // 
            confirmBtn.BorderRadius = 9;
            confirmBtn.CustomizableEdges = customizableEdges1;
            confirmBtn.DisabledState.BorderColor = Color.DarkGray;
            confirmBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            confirmBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            confirmBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            confirmBtn.FillColor = Color.FromArgb(50, 105, 232);
            confirmBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(59, 312);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            confirmBtn.Size = new Size(489, 71);
            confirmBtn.TabIndex = 27;
            confirmBtn.Text = "Xác nhận";
            // 
            // emailBox
            // 
            emailBox.BorderColor = Color.DimGray;
            emailBox.BorderRadius = 7;
            emailBox.CustomizableEdges = customizableEdges3;
            emailBox.DefaultText = "";
            emailBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Font = new Font("Segoe UI", 9F);
            emailBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Location = new Point(59, 230);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Tạo mật khẩu mới";
            emailBox.SelectedText = "";
            emailBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            emailBox.Size = new Size(489, 53);
            emailBox.TabIndex = 26;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.Red;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.FromArgb(50, 105, 232);
            loginLinkLabel.Location = new Point(268, 419);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(95, 23);
            loginLinkLabel.TabIndex = 25;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Đăng nhập";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // newpswLabel
            // 
            newpswLabel.AutoSize = true;
            newpswLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpswLabel.Location = new Point(59, 168);
            newpswLabel.Name = "newpswLabel";
            newpswLabel.Size = new Size(157, 31);
            newpswLabel.TabIndex = 24;
            newpswLabel.Text = "Mật khẩu mới";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.Black;
            guna2Panel1.BorderRadius = 14;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(loginLinkLabel);
            guna2Panel1.Controls.Add(confirmBtn);
            guna2Panel1.Controls.Add(emailBox);
            guna2Panel1.Controls.Add(logoBox);
            guna2Panel1.Controls.Add(newpswLabel);
            guna2Panel1.Controls.Add(labelMenu);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(407, 243);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(609, 490);
            guna2Panel1.TabIndex = 15;
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.Logo;
            logoBox.Location = new Point(279, 28);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(50, 50);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 12;
            logoBox.TabStop = false;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(234, 93);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(145, 23);
            labelMenu.TabIndex = 13;
            labelMenu.Text = "RentHouseMaster";
            // 
            // CreateNewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(guna2Panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "CreateNewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewPassword";
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private LinkLabel loginLinkLabel;
        private Label newpswLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox logoBox;
        private Label labelMenu;
    }
}