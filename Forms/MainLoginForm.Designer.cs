namespace RentHouseMaster.Forms
{
    partial class MainLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblRole = new Label();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            pswBox = new Guna.UI2.WinForms.Guna2TextBox();
            emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            registerLinkLabel = new LinkLabel();
            label1 = new Label();
            forgotpswLinkLabel = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelMenu.TabIndex = 2;
            
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
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1132, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 918);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(guna2Panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.DimGray;
            guna2Panel1.BorderRadius = 14;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(lblRole);
            guna2Panel1.Controls.Add(loginBtn);
            guna2Panel1.Controls.Add(pswBox);
            guna2Panel1.Controls.Add(emailBox);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(registerLinkLabel);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(forgotpswLinkLabel);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Location = new Point(131, 163);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(9);
            guna2Panel1.Size = new Size(609, 609);
            guna2Panel1.TabIndex = 16;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(174, 124);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(230, 20);
            lblRole.TabIndex = 19;
            lblRole.Text = "Bạn đang đăng nhập với vai trò ...";
            // 
            // loginBtn
            // 
            loginBtn.BorderRadius = 9;
            loginBtn.CustomizableEdges = customizableEdges9;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.FromArgb(50, 105, 232);
            loginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(58, 454);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            loginBtn.Size = new Size(489, 71);
            loginBtn.TabIndex = 18;
            loginBtn.Text = "Đăng nhập";
            loginBtn.Click += loginBtn_Click;
            // 
            // pswBox
            // 
            pswBox.BorderColor = Color.DimGray;
            pswBox.BorderRadius = 7;
            pswBox.CustomizableEdges = customizableEdges11;
            pswBox.DefaultText = "";
            pswBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            pswBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            pswBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            pswBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            pswBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            pswBox.Font = new Font("Segoe UI", 9F);
            pswBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            pswBox.Location = new Point(58, 359);
            pswBox.Margin = new Padding(3, 4, 3, 4);
            pswBox.Name = "pswBox";
            pswBox.PasswordChar = '*';
            pswBox.PlaceholderText = "*******";
            pswBox.SelectedText = "";
            pswBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pswBox.Size = new Size(489, 53);
            pswBox.TabIndex = 17;
            // 
            // emailBox
            // 
            emailBox.BorderColor = Color.DimGray;
            emailBox.BorderRadius = 7;
            emailBox.CustomizableEdges = customizableEdges13;
            emailBox.DefaultText = "";
            emailBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Font = new Font("Segoe UI", 9F);
            emailBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Location = new Point(58, 211);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "vidu@gmail.com";
            emailBox.SelectedText = "";
            emailBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            emailBox.Size = new Size(489, 53);
            emailBox.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(276, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.ActiveLinkColor = Color.Red;
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLinkLabel.LinkColor = Color.FromArgb(30, 200, 0);
            registerLinkLabel.Location = new Point(475, 552);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(72, 23);
            registerLinkLabel.TabIndex = 15;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Đăng ký";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 89);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 11;
            label1.Text = "RentHouseMaster";
            // 
            // forgotpswLinkLabel
            // 
            forgotpswLinkLabel.ActiveLinkColor = Color.Red;
            forgotpswLinkLabel.AutoSize = true;
            forgotpswLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotpswLinkLabel.LinkColor = Color.Black;
            forgotpswLinkLabel.Location = new Point(58, 552);
            forgotpswLinkLabel.Name = "forgotpswLinkLabel";
            forgotpswLinkLabel.Size = new Size(137, 23);
            forgotpswLinkLabel.TabIndex = 14;
            forgotpswLinkLabel.TabStop = true;
            forgotpswLinkLabel.Text = "Quên mật khẩu?";
            forgotpswLinkLabel.LinkClicked += forgotpswLinkLabel_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 167);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 307);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
            // 
            // MainLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "MainLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox pictureBox1;
        private LinkLabel registerLinkLabel;
        private Label label1;
        private LinkLabel forgotpswLinkLabel;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox pswBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Label lblRole;
    }
}