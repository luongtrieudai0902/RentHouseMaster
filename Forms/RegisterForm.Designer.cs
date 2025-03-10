namespace RentHouseMaster.Forms

{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            picLogo = new PictureBox();
            lblRHM = new Label();
            lblHoVaTen = new Label();
            txtHovaTen = new TextBox();
            lblSDTEmail = new Label();
            txtSDTEmail = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangKy = new Button();
            lnkCoTK = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(253, 44);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(95, 91);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblRHM
            // 
            lblRHM.AutoSize = true;
            lblRHM.Location = new Point(207, 138);
            lblRHM.Name = "lblRHM";
            lblRHM.Size = new Size(178, 30);
            lblRHM.TabIndex = 1;
            lblRHM.Text = "RentHouseMaster";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(56, 194);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(165, 45);
            lblHoVaTen.TabIndex = 2;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // txtHovaTen
            // 
            txtHovaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHovaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHovaTen.Location = new Point(56, 252);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.PlaceholderText = " Nguyễn Văn A";
            txtHovaTen.Size = new Size(509, 50);
            txtHovaTen.TabIndex = 3;
            // 
            // lblSDTEmail
            // 
            lblSDTEmail.AutoSize = true;
            lblSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDTEmail.Location = new Point(56, 338);
            lblSDTEmail.Name = "lblSDTEmail";
            lblSDTEmail.Size = new Size(176, 45);
            lblSDTEmail.TabIndex = 4;
            lblSDTEmail.Text = "SĐT/Email";
            // 
            // txtSDTEmail
            // 
            txtSDTEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDTEmail.Location = new Point(56, 397);
            txtSDTEmail.Name = "txtSDTEmail";
            txtSDTEmail.PlaceholderText = " nguyenvana@gmail.com";
            txtSDTEmail.Size = new Size(509, 50);
            txtSDTEmail.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(56, 475);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(162, 45);
            lblMatKhau.TabIndex = 6;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(56, 533);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = " ******";
            txtMatKhau.Size = new Size(509, 50);
            txtMatKhau.TabIndex = 7;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Chartreuse;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = SystemColors.ControlLightLight;
            btnDangKy.Location = new Point(207, 628);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(155, 49);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lnkCoTK
            // 
            lnkCoTK.AutoSize = true;
            lnkCoTK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkCoTK.LinkColor = Color.Black;
            lnkCoTK.Location = new Point(156, 680);
            lnkCoTK.Name = "lnkCoTK";
            lnkCoTK.Size = new Size(267, 41);
            lnkCoTK.TabIndex = 9;
            lnkCoTK.TabStop = true;
            lnkCoTK.Text = "Tôi đã có tài khoản";
            lnkCoTK.Click += lnkCoTK_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 730);
            Controls.Add(lnkCoTK);
            Controls.Add(btnDangKy);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtSDTEmail);
            Controls.Add(lblSDTEmail);
            Controls.Add(txtHovaTen);
            Controls.Add(lblHoVaTen);
            Controls.Add(lblRHM);
            Controls.Add(picLogo);
            Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RegisterForm";
            Text = "Register";
            FormClosing += RegisterForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRHM;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Label lblSDTEmail;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.LinkLabel lnkCoTK;
    }
}

