namespace RentHouseMaster.Forms
{
    partial class MainForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForgotPassword));
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            container = new Panel();
            logoBox = new PictureBox();
            loginLinkLabel = new LinkLabel();
            labelMenu = new Label();
            label1 = new Label();
            sendCodeBtn = new Button();
            emailBox = new TextBox();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            panel3.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(panelMenuBtn);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1422, 59);
            panelMenu.TabIndex = 3;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 918);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1132, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 918);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(container);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 6;
            // 
            // container
            // 
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Controls.Add(logoBox);
            container.Controls.Add(loginLinkLabel);
            container.Controls.Add(labelMenu);
            container.Controls.Add(label1);
            container.Controls.Add(sendCodeBtn);
            container.Controls.Add(emailBox);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 184);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // sendCodeBtn
            // 
            sendCodeBtn.BackColor = Color.FromArgb(50, 105, 232);
            sendCodeBtn.FlatAppearance.BorderSize = 0;
            sendCodeBtn.FlatStyle = FlatStyle.Flat;
            sendCodeBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendCodeBtn.ForeColor = Color.White;
            sendCodeBtn.Location = new Point(68, 326);
            sendCodeBtn.Name = "sendCodeBtn";
            sendCodeBtn.Size = new Size(445, 78);
            sendCodeBtn.TabIndex = 6;
            sendCodeBtn.Text = "Gửi mã xác thực";
            sendCodeBtn.UseVisualStyleBackColor = false;
            sendCodeBtn.Click += sendCodeBtn_Click;
            // 
            // emailBox
            // 
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(68, 234);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "vidu@gmail.com";
            emailBox.Size = new Size(445, 38);
            emailBox.TabIndex = 3;
            // 
            // MainForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "MainForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForgotPassword";
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel container;
        private PictureBox logoBox;
        private LinkLabel loginLinkLabel;
        private Label labelMenu;
        private Label label1;
        private Button sendCodeBtn;
        private TextBox emailBox;
    }
}