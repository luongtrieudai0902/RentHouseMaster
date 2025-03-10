using System.ComponentModel;

namespace RentHouseMaster.Forms
{
    partial class SendCodeForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SendCodeForm));
            picLogo = new PictureBox();
            lblRHM = new Label();
            lblSDTEmail = new Label();
            txtSDTEmail = new TextBox();
            btnDangNhap = new Button();
            lnkDangNhap = new LinkLabel();
            ((ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(261, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(81, 81);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblRHM
            // 
            lblRHM.AutoSize = true;
            lblRHM.Location = new Point(201, 107);
            lblRHM.Name = "lblRHM";
            lblRHM.Size = new Size(203, 32);
            lblRHM.TabIndex = 1;
            lblRHM.Text = "RentHouseMaster";
            // 
            // lblSDTEmail
            // 
            lblSDTEmail.AutoSize = true;
            lblSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDTEmail.Location = new Point(68, 206);
            lblSDTEmail.Name = "lblSDTEmail";
            lblSDTEmail.Size = new Size(176, 45);
            lblSDTEmail.TabIndex = 2;
            lblSDTEmail.Text = "SĐT/Email";
            // 
            // txtSDTEmail
            // 
            txtSDTEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDTEmail.Location = new Point(68, 266);
            txtSDTEmail.Name = "txtSDTEmail";
            txtSDTEmail.PlaceholderText = " nguyenvana@gmail.com";
            txtSDTEmail.Size = new Size(467, 50);
            txtSDTEmail.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DodgerBlue;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ControlLightLight;
            btnDangNhap.Location = new Point(192, 384);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(223, 46);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Gửi mã xác thực";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lnkDangNhap
            // 
            lnkDangNhap.AutoSize = true;
            lnkDangNhap.LinkColor = Color.DodgerBlue;
            lnkDangNhap.Location = new Point(235, 442);
            lnkDangNhap.Name = "lnkDangNhap";
            lnkDangNhap.Size = new Size(132, 32);
            lnkDangNhap.TabIndex = 5;
            lnkDangNhap.TabStop = true;
            lnkDangNhap.Text = "Đăng nhập";
            lnkDangNhap.LinkClicked += llbDangNhap_LinkClicked;
            // 
            // SendCodeForm
            // 
            ClientSize = new Size(616, 516);
            Controls.Add(lnkDangNhap);
            Controls.Add(btnDangNhap);
            Controls.Add(txtSDTEmail);
            Controls.Add(lblSDTEmail);
            Controls.Add(lblRHM);
            Controls.Add(picLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SendCodeForm";
            Text = "Forgot Password";
            FormClosing += SendCodeForm_FormClosing;
            ((ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSDTEmail;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel lnkDangNhap;
        private System.Windows.Forms.Label lblRHM;
    }
}