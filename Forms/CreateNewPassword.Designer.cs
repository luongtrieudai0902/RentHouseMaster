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
            panel3 = new Panel();
            container = new Panel();
            logoBox = new PictureBox();
            loginLinkLabel = new LinkLabel();
            labelMenu = new Label();
            newpswLabel = new Label();
            confirmBtn = new Button();
            newPswBox = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel3.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(container);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 10;
            // 
            // container
            // 
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Controls.Add(logoBox);
            container.Controls.Add(loginLinkLabel);
            container.Controls.Add(labelMenu);
            container.Controls.Add(newpswLabel);
            container.Controls.Add(confirmBtn);
            container.Controls.Add(newPswBox);
            container.Location = new Point(130, 165);
            container.Name = "container";
            container.Size = new Size(609, 497);
            container.TabIndex = 10;
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.Logo;
            logoBox.Location = new Point(270, 26);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(50, 50);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.Red;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.FromArgb(50, 105, 232);
            loginLinkLabel.Location = new Point(253, 437);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(95, 23);
            loginLinkLabel.TabIndex = 8;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Đăng nhập";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(225, 91);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(145, 23);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "RentHouseMaster";
            // 
            // newpswLabel
            // 
            newpswLabel.AutoSize = true;
            newpswLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpswLabel.Location = new Point(68, 184);
            newpswLabel.Name = "newpswLabel";
            newpswLabel.Size = new Size(157, 31);
            newpswLabel.TabIndex = 2;
            newpswLabel.Text = "Mật khẩu mới";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(50, 105, 232);
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(68, 326);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(445, 78);
            confirmBtn.TabIndex = 6;
            confirmBtn.Text = "Xác nhận";
            confirmBtn.UseVisualStyleBackColor = false;
            // 
            // newPswBox
            // 
            newPswBox.BorderStyle = BorderStyle.FixedSingle;
            newPswBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPswBox.Location = new Point(68, 244);
            newPswBox.Name = "newPswBox";
            newPswBox.PlaceholderText = "Tạo mật khẩu mới";
            newPswBox.Size = new Size(445, 38);
            newPswBox.TabIndex = 3;
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
            // CreateNewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "CreateNewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewPassword";
            panel3.ResumeLayout(false);
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel container;
        private PictureBox logoBox;
        private LinkLabel loginLinkLabel;
        private Label labelMenu;
        private Label newpswLabel;
        private Button confirmBtn;
        private TextBox newPswBox;
        private Panel panel2;
        private Panel panel1;
        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
    }
}