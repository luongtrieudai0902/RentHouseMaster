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
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            labelMenu = new Label();
            logoBox = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            registerLinkLabel = new LinkLabel();
            forgotpswLinkLabel = new LinkLabel();
            emailLabel = new Label();
            loginBtn = new Button();
            emailBox = new TextBox();
            pswBox = new TextBox();
            pswLabel = new Label();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(logoBox);
            panel4.Controls.Add(registerLinkLabel);
            panel4.Controls.Add(labelMenu);
            panel4.Controls.Add(forgotpswLinkLabel);
            panel4.Controls.Add(emailLabel);
            panel4.Controls.Add(loginBtn);
            panel4.Controls.Add(emailBox);
            panel4.Controls.Add(pswBox);
            panel4.Controls.Add(pswLabel);
            panel4.Location = new Point(105, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(609, 609);
            panel4.TabIndex = 9;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.ActiveLinkColor = Color.Red;
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLinkLabel.LinkColor = Color.FromArgb(30, 200, 0);
            registerLinkLabel.Location = new Point(441, 531);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(72, 23);
            registerLinkLabel.TabIndex = 8;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Đăng ký";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // forgotpswLinkLabel
            // 
            forgotpswLinkLabel.ActiveLinkColor = Color.Red;
            forgotpswLinkLabel.AutoSize = true;
            forgotpswLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotpswLinkLabel.LinkColor = Color.Black;
            forgotpswLinkLabel.Location = new Point(68, 531);
            forgotpswLinkLabel.Name = "forgotpswLinkLabel";
            forgotpswLinkLabel.Size = new Size(137, 23);
            forgotpswLinkLabel.TabIndex = 7;
            forgotpswLinkLabel.TabStop = true;
            forgotpswLinkLabel.Text = "Quên mật khẩu?";
            forgotpswLinkLabel.LinkClicked += forgotpswLinkLabel_LinkClicked;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(68, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(50, 105, 232);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(68, 425);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(445, 78);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
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
            // pswBox
            // 
            pswBox.BorderStyle = BorderStyle.FixedSingle;
            pswBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pswBox.Location = new Point(68, 360);
            pswBox.Name = "pswBox";
            pswBox.PasswordChar = '*';
            pswBox.PlaceholderText = "*******";
            pswBox.Size = new Size(445, 38);
            pswBox.TabIndex = 5;
            // 
            // pswLabel
            // 
            pswLabel.AutoSize = true;
            pswLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswLabel.Location = new Point(68, 304);
            pswLabel.Name = "pswLabel";
            pswLabel.Size = new Size(111, 31);
            pswLabel.TabIndex = 4;
            pswLabel.Text = "Mật khẩu";
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
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMenuBtn;
        private Button btnMinimize;
        private Button btnClose;
        private Label labelMenu;
        private PictureBox logoBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox emailBox;
        private Label emailLabel;
        private Button loginBtn;
        private TextBox pswBox;
        private Label pswLabel;
        private LinkLabel registerLinkLabel;
        private LinkLabel forgotpswLinkLabel;
        private Panel panel4;
    }
}