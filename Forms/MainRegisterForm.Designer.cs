namespace RentHouseMaster.Forms
{
    partial class MainRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRegisterForm));
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            nameLabel = new Label();
            txtName = new TextBox();
            logoBox = new PictureBox();
            labelMenu = new Label();
            loginLinkLabel = new LinkLabel();
            emalLabel = new Label();
            registerBtn = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            pswLabel = new Label();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblRole);
            panel4.Controls.Add(cbRole);
            panel4.Controls.Add(lblPhone);
            panel4.Controls.Add(txtPhone);
            panel4.Controls.Add(txtConfirmPassword);
            panel4.Controls.Add(lblConfirmPassword);
            panel4.Controls.Add(nameLabel);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(logoBox);
            panel4.Controls.Add(labelMenu);
            panel4.Controls.Add(loginLinkLabel);
            panel4.Controls.Add(emalLabel);
            panel4.Controls.Add(registerBtn);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(pswLabel);
            panel4.Location = new Point(132, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(609, 807);
            panel4.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(70, 597);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(130, 28);
            lblRole.TabIndex = 16;
            lblRole.Text = "Vai trò (Role)";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Chủ Nhà (Owner)", "Nhân Viên Quản Lý (Manager)", "Khách Thuê (Tenant)" });
            cbRole.Location = new Point(70, 628);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(445, 28);
            cbRole.TabIndex = 15;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(70, 331);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(293, 28);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Số điện thoại (Phone Number)";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(70, 372);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "0123456789";
            txtPhone.Size = new Size(445, 34);
            txtPhone.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(70, 552);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "*******";
            txtConfirmPassword.Size = new Size(445, 34);
            txtConfirmPassword.TabIndex = 12;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(70, 505);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(371, 28);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Xác nhận mật khẩu (Confirm Password)";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(70, 150);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(219, 28);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Họ và tên (User name)";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(70, 196);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nguyễn Van Ví Vụ";
            txtName.Size = new Size(445, 34);
            txtName.TabIndex = 10;
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
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.Red;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.Black;
            loginLinkLabel.Location = new Point(216, 773);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(154, 23);
            loginLinkLabel.TabIndex = 7;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Tôi đã có tài khoản";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // emalLabel
            // 
            emalLabel.AutoSize = true;
            emalLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emalLabel.Location = new Point(70, 233);
            emalLabel.Name = "emalLabel";
            emalLabel.Size = new Size(60, 28);
            emalLabel.TabIndex = 2;
            emalLabel.Text = "Email";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(70, 197, 100);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(70, 679);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(445, 78);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Đăng ký";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(70, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "vidu@gmail.com";
            txtEmail.Size = new Size(445, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(70, 459);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "*******";
            txtPassword.Size = new Size(445, 34);
            txtPassword.TabIndex = 5;
            // 
            // pswLabel
            // 
            pswLabel.AutoSize = true;
            pswLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswLabel.Location = new Point(70, 428);
            pswLabel.Name = "pswLabel";
            pswLabel.Size = new Size(203, 28);
            pswLabel.TabIndex = 4;
            pswLabel.Text = "Mật khẩu (Password)";
            // 
            // MainRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "MainRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainRegisterForm";
            panelMenu.ResumeLayout(false);
            panelMenuBtn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel4;
        private Label nameLabel;
        private TextBox txtName;
        private PictureBox logoBox;
        private Label labelMenu;
        private LinkLabel loginLinkLabel;
        private Label emalLabel;
        private Button registerBtn;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label pswLabel;
        private TextBox txtConfirmPassword;
        private Label lblPhone;
        private TextBox txtPhone;
        private ComboBox cbRole;
        private Label lblRole;
        private Label lblConfirmPassword;
    }
}