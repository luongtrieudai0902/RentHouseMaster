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
            lbRHM = new Label();
            lbSDTEmail = new Label();
            txtSDTEmail = new TextBox();
            btnDangNhap = new Button();
            llbDangNhap = new LinkLabel();
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
            // lbRHM
            // 
            lbRHM.AutoSize = true;
            lbRHM.Location = new Point(201, 107);
            lbRHM.Name = "lbRHM";
            lbRHM.Size = new Size(203, 32);
            lbRHM.TabIndex = 1;
            lbRHM.Text = "RentHouseMaster";
            // 
            // lbSDTEmail
            // 
            lbSDTEmail.AutoSize = true;
            lbSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSDTEmail.Location = new Point(68, 206);
            lbSDTEmail.Name = "lbSDTEmail";
            lbSDTEmail.Size = new Size(176, 45);
            lbSDTEmail.TabIndex = 2;
            lbSDTEmail.Text = "SĐT/Email";
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
            // llbDangNhap
            // 
            llbDangNhap.AutoSize = true;
            llbDangNhap.LinkColor = Color.DodgerBlue;
            llbDangNhap.Location = new Point(235, 442);
            llbDangNhap.Name = "llbDangNhap";
            llbDangNhap.Size = new Size(132, 32);
            llbDangNhap.TabIndex = 5;
            llbDangNhap.TabStop = true;
            llbDangNhap.Text = "Đăng nhập";
            llbDangNhap.LinkClicked += llbDangNhap_LinkClicked;
            // 
            // SendCodeForm
            // 
            ClientSize = new Size(616, 516);
            Controls.Add(llbDangNhap);
            Controls.Add(btnDangNhap);
            Controls.Add(txtSDTEmail);
            Controls.Add(lbSDTEmail);
            Controls.Add(lbRHM);
            Controls.Add(picLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SendCodeForm";
            Text = "Forgot Password";
            ((ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbSDTEmail;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel llbDangNhap;
        private System.Windows.Forms.Label lbRHM;
    }
}