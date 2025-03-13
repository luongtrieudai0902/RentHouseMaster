namespace RentHouseMaster.Forms
{
    partial class AfterSendingCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterSendingCodeForm));
            panel3 = new Panel();
            container = new Panel();
            sendCodeAgainLinkLabel = new LinkLabel();
            codeLabel = new Label();
            codeBox = new TextBox();
            logoBox = new PictureBox();
            loginLinkLabel = new LinkLabel();
            labelMenu = new Label();
            emailLabel = new Label();
            continueBtn = new Button();
            emailBox = new TextBox();
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
            container.Controls.Add(sendCodeAgainLinkLabel);
            container.Controls.Add(codeLabel);
            container.Controls.Add(codeBox);
            container.Controls.Add(logoBox);
            container.Controls.Add(loginLinkLabel);
            container.Controls.Add(labelMenu);
            container.Controls.Add(emailLabel);
            container.Controls.Add(continueBtn);
            container.Controls.Add(emailBox);
            container.Location = new Point(133, 133);
            container.Name = "container";
            container.Size = new Size(609, 643);
            container.TabIndex = 10;
            // 
            // sendCodeAgainLinkLabel
            // 
            sendCodeAgainLinkLabel.ActiveLinkColor = Color.Red;
            sendCodeAgainLinkLabel.AutoSize = true;
            sendCodeAgainLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendCodeAgainLinkLabel.LinkColor = Color.Black;
            sendCodeAgainLinkLabel.Location = new Point(68, 574);
            sendCodeAgainLinkLabel.Name = "sendCodeAgainLinkLabel";
            sendCodeAgainLinkLabel.Size = new Size(156, 23);
            sendCodeAgainLinkLabel.TabIndex = 11;
            sendCodeAgainLinkLabel.TabStop = true;
            sendCodeAgainLinkLabel.Text = "Gửi lại mã xác thực";
            sendCodeAgainLinkLabel.LinkClicked += sendCodeAgainLinkLabel_LinkClicked;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codeLabel.Location = new Point(68, 319);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(140, 31);
            codeLabel.TabIndex = 9;
            codeLabel.Text = "Mã xác thực";
            // 
            // codeBox
            // 
            codeBox.BorderStyle = BorderStyle.FixedSingle;
            codeBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeBox.Location = new Point(68, 369);
            codeBox.Name = "codeBox";
            codeBox.PlaceholderText = "Nhập mã xác thực";
            codeBox.Size = new Size(445, 38);
            codeBox.TabIndex = 10;
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
            loginLinkLabel.Location = new Point(418, 574);
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
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(68, 183);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.FromArgb(50, 105, 232);
            continueBtn.FlatAppearance.BorderSize = 0;
            continueBtn.FlatStyle = FlatStyle.Flat;
            continueBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.ForeColor = Color.White;
            continueBtn.Location = new Point(68, 451);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(445, 78);
            continueBtn.TabIndex = 6;
            continueBtn.Text = "Tiếp tục";
            continueBtn.UseVisualStyleBackColor = false;
            continueBtn.Click += continueBtn_Click;
            // 
            // emailBox
            // 
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(68, 233);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "vidu@gmail.com";
            emailBox.Size = new Size(445, 38);
            emailBox.TabIndex = 3;
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
            // AfterSendingCodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "AfterSendingCodeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AfterSendingCodeForm";
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
        private Label emailLabel;
        private Button continueBtn;
        private TextBox emailBox;
        private Panel panel2;
        private Panel panel1;
        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
        private Label codeLabel;
        private TextBox codeBox;
        private LinkLabel sendCodeAgainLinkLabel;
    }
}