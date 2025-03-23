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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            sendCodeAgainLinkLabel = new LinkLabel();
            loginLinkLabel = new LinkLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            continueBtn = new Guna.UI2.WinForms.Guna2Button();
            emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            logoBox = new PictureBox();
            labelMenu = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(guna2Panel1);
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
            // sendCodeAgainLinkLabel
            // 
            sendCodeAgainLinkLabel.ActiveLinkColor = Color.Red;
            sendCodeAgainLinkLabel.AutoSize = true;
            sendCodeAgainLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendCodeAgainLinkLabel.LinkColor = Color.Black;
            sendCodeAgainLinkLabel.Location = new Point(59, 563);
            sendCodeAgainLinkLabel.Name = "sendCodeAgainLinkLabel";
            sendCodeAgainLinkLabel.Size = new Size(156, 23);
            sendCodeAgainLinkLabel.TabIndex = 13;
            sendCodeAgainLinkLabel.TabStop = true;
            sendCodeAgainLinkLabel.Text = "Gửi lại mã xác thực";
            sendCodeAgainLinkLabel.LinkClicked += sendCodeAgainLinkLabel_LinkClicked;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.Red;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.FromArgb(50, 105, 232);
            loginLinkLabel.Location = new Point(444, 563);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(95, 23);
            loginLinkLabel.TabIndex = 12;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Đăng nhập";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Black;
            guna2Panel1.BorderRadius = 14;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(guna2TextBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(continueBtn);
            guna2Panel1.Controls.Add(loginLinkLabel);
            guna2Panel1.Controls.Add(sendCodeAgainLinkLabel);
            guna2Panel1.Controls.Add(emailBox);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(logoBox);
            guna2Panel1.Controls.Add(labelMenu);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(117, 214);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(609, 613);
            guna2Panel1.TabIndex = 15;
            // 
            // continueBtn
            // 
            continueBtn.BorderRadius = 9;
            continueBtn.CustomizableEdges = customizableEdges3;
            continueBtn.DisabledState.BorderColor = Color.DarkGray;
            continueBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            continueBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            continueBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            continueBtn.FillColor = Color.FromArgb(50, 105, 232);
            continueBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.ForeColor = Color.White;
            continueBtn.Location = new Point(59, 446);
            continueBtn.Name = "continueBtn";
            continueBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            continueBtn.Size = new Size(489, 71);
            continueBtn.TabIndex = 19;
            continueBtn.Text = "Tiếp tục";
            continueBtn.Click += continueBtn_Click;
            // 
            // emailBox
            // 
            emailBox.BorderColor = Color.DimGray;
            emailBox.BorderRadius = 7;
            emailBox.CustomizableEdges = customizableEdges5;
            emailBox.DefaultText = "";
            emailBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Font = new Font("Segoe UI", 9F);
            emailBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Location = new Point(59, 224);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "vidu@gmail.com";
            emailBox.SelectedText = "";
            emailBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            emailBox.Size = new Size(489, 53);
            emailBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 17;
            label2.Text = "Email";
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
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.DimGray;
            guna2TextBox1.BorderRadius = 7;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(59, 365);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Nhập mã xác thực";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(489, 53);
            guna2TextBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 309);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 20;
            label1.Text = "Mã xác thực";
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
        private LinkLabel sendCodeAgainLinkLabel;
        private LinkLabel loginLinkLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button continueBtn;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Label label2;
        private PictureBox logoBox;
        private Label labelMenu;
    }
}