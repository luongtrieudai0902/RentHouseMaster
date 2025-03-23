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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            fullNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            registerBtn = new Guna.UI2.WinForms.Guna2Button();
            loginLinkLabel = new LinkLabel();
            pswBox = new Guna.UI2.WinForms.Guna2TextBox();
            emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            panel3.Controls.Add(guna2Panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 918);
            panel3.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.DimGray;
            guna2Panel1.BorderRadius = 14;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(fullNameBox);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(registerBtn);
            guna2Panel1.Controls.Add(loginLinkLabel);
            guna2Panel1.Controls.Add(pswBox);
            guna2Panel1.Controls.Add(emailBox);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(129, 142);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(9);
            guna2Panel1.Size = new Size(609, 698);
            guna2Panel1.TabIndex = 17;
            // 
            // fullNameBox
            // 
            fullNameBox.BorderColor = Color.DimGray;
            fullNameBox.BorderRadius = 7;
            fullNameBox.CustomizableEdges = customizableEdges1;
            fullNameBox.DefaultText = "";
            fullNameBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            fullNameBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            fullNameBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            fullNameBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            fullNameBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            fullNameBox.Font = new Font("Segoe UI", 9F);
            fullNameBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            fullNameBox.Location = new Point(58, 194);
            fullNameBox.Margin = new Padding(3, 4, 3, 4);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.PlaceholderText = "Nguyen Van A";
            fullNameBox.SelectedText = "";
            fullNameBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            fullNameBox.Size = new Size(489, 53);
            fullNameBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 150);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 19;
            label4.Text = "Họ và tên";
            // 
            // registerBtn
            // 
            registerBtn.BorderRadius = 9;
            registerBtn.CustomizableEdges = customizableEdges3;
            registerBtn.DisabledState.BorderColor = Color.DarkGray;
            registerBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            registerBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            registerBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            registerBtn.FillColor = Color.FromArgb(70, 197, 100);
            registerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(58, 564);
            registerBtn.Name = "registerBtn";
            registerBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            registerBtn.Size = new Size(489, 71);
            registerBtn.TabIndex = 18;
            registerBtn.Text = "Đăng ký";
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.Red;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.Black;
            loginLinkLabel.Location = new Point(232, 657);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(154, 23);
            loginLinkLabel.TabIndex = 12;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Tôi đã có tài khoản";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // pswBox
            // 
            pswBox.BorderColor = Color.DimGray;
            pswBox.BorderRadius = 7;
            pswBox.CustomizableEdges = customizableEdges5;
            pswBox.DefaultText = "";
            pswBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            pswBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            pswBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            pswBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            pswBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            pswBox.Font = new Font("Segoe UI", 9F);
            pswBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            pswBox.Location = new Point(58, 474);
            pswBox.Margin = new Padding(3, 4, 3, 4);
            pswBox.Name = "pswBox";
            pswBox.PasswordChar = '*';
            pswBox.PlaceholderText = "*******";
            pswBox.SelectedText = "";
            pswBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pswBox.Size = new Size(489, 53);
            pswBox.TabIndex = 17;
            // 
            // emailBox
            // 
            emailBox.BorderColor = Color.DimGray;
            emailBox.BorderRadius = 7;
            emailBox.CustomizableEdges = customizableEdges7;
            emailBox.DefaultText = "";
            emailBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Font = new Font("Segoe UI", 9F);
            emailBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Location = new Point(58, 335);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "vidu@gmail.com";
            emailBox.SelectedText = "";
            emailBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 76);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 11;
            label1.Text = "RentHouseMaster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 291);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 422);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
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
        private LinkLabel loginLinkLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2TextBox pswBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox fullNameBox;
        private Label label4;
    }
}