namespace RentHouseMaster.Forms
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            picLogo = new PictureBox();
            lblSDTEmail = new Label();
            txtSDTEmail = new TextBox();
            lblMaXacThuc = new Label();
            txtMaXacThuc = new TextBox();
            btnTiepTuc = new Button();
            lnkGuiLai = new LinkLabel();
            lnkDangNhap = new LinkLabel();
            lblRHM = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(295, 29);
            picLogo.Margin = new Padding(6, 7, 6, 7);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 106);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblSDTEmail
            // 
            lblSDTEmail.AutoSize = true;
            lblSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDTEmail.Location = new Point(78, 202);
            lblSDTEmail.Margin = new Padding(6, 0, 6, 0);
            lblSDTEmail.Name = "lblSDTEmail";
            lblSDTEmail.Size = new Size(176, 45);
            lblSDTEmail.TabIndex = 1;
            lblSDTEmail.Text = "SĐT/Email";
            // 
            // txtSDTEmail
            // 
            txtSDTEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDTEmail.Location = new Point(78, 263);
            txtSDTEmail.Margin = new Padding(6, 7, 6, 7);
            txtSDTEmail.Name = "txtSDTEmail";
            txtSDTEmail.PlaceholderText = " nguyenvana@gmail.com";
            txtSDTEmail.Size = new Size(542, 50);
            txtSDTEmail.TabIndex = 2;
            // 
            // lblMaXacThuc
            // 
            lblMaXacThuc.AutoSize = true;
            lblMaXacThuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaXacThuc.Location = new Point(78, 363);
            lblMaXacThuc.Margin = new Padding(6, 0, 6, 0);
            lblMaXacThuc.Name = "lblMaXacThuc";
            lblMaXacThuc.Size = new Size(203, 45);
            lblMaXacThuc.TabIndex = 3;
            lblMaXacThuc.Text = "Mã xác thực";
            // 
            // txtMaXacThuc
            // 
            txtMaXacThuc.BorderStyle = BorderStyle.FixedSingle;
            txtMaXacThuc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXacThuc.Location = new Point(78, 424);
            txtMaXacThuc.Margin = new Padding(6, 7, 6, 7);
            txtMaXacThuc.MaxLength = 6;
            txtMaXacThuc.Name = "txtMaXacThuc";
            txtMaXacThuc.PlaceholderText = " Hãy nhập mã tại đây";
            txtMaXacThuc.Size = new Size(542, 47);
            txtMaXacThuc.TabIndex = 4;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.DodgerBlue;
            btnTiepTuc.FlatStyle = FlatStyle.Flat;
            btnTiepTuc.ForeColor = SystemColors.ControlLightLight;
            btnTiepTuc.Location = new Point(265, 533);
            btnTiepTuc.Margin = new Padding(6, 7, 6, 7);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(171, 74);
            btnTiepTuc.TabIndex = 5;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btn_Tieptuc;
            // 
            // lnkGuiLai
            // 
            lnkGuiLai.AutoSize = true;
            lnkGuiLai.LinkColor = Color.Black;
            lnkGuiLai.Location = new Point(65, 662);
            lnkGuiLai.Margin = new Padding(6, 0, 6, 0);
            lnkGuiLai.Name = "lnkGuiLai";
            lnkGuiLai.Size = new Size(216, 32);
            lnkGuiLai.TabIndex = 6;
            lnkGuiLai.TabStop = true;
            lnkGuiLai.Text = "Gửi lại mã xác thực";
            lnkGuiLai.LinkClicked += llblMXT_LinkClicked;
            // 
            // lnkDangNhap
            // 
            lnkDangNhap.AutoSize = true;
            lnkDangNhap.LinkColor = Color.DodgerBlue;
            lnkDangNhap.Location = new Point(488, 662);
            lnkDangNhap.Margin = new Padding(6, 0, 6, 0);
            lnkDangNhap.Name = "lnkDangNhap";
            lnkDangNhap.Size = new Size(132, 32);
            lnkDangNhap.TabIndex = 7;
            lnkDangNhap.TabStop = true;
            lnkDangNhap.Text = "Đăng nhập";
            lnkDangNhap.LinkClicked += linkLabelDN;
            // 
            // lblRHM
            // 
            lblRHM.AutoSize = true;
            lblRHM.Location = new Point(248, 142);
            lblRHM.Name = "lblRHM";
            lblRHM.Size = new Size(203, 32);
            lblRHM.TabIndex = 8;
            lblRHM.Text = "RentHouseMaster";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 738);
            Controls.Add(lblRHM);
            Controls.Add(lnkDangNhap);
            Controls.Add(lnkGuiLai);
            Controls.Add(btnTiepTuc);
            Controls.Add(txtMaXacThuc);
            Controls.Add(lblMaXacThuc);
            Controls.Add(txtSDTEmail);
            Controls.Add(lblSDTEmail);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            Name = "ForgotPassword";
            Text = "Password Recovery";
            FormClosing += ForgotPassword_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSDTEmail;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Label lblMaXacThuc;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.LinkLabel lnkGuiLai;
        private System.Windows.Forms.LinkLabel lnkDangNhap;
        private TextBox txtMaXacThuc;
        private Label lblRHM;
    }
}

