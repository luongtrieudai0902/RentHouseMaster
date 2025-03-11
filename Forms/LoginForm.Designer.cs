using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picLogo = new PictureBox();
            lbName = new Label();
            lblSdtEmail = new Label();
            txtSdtEmail = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            lnkQuenMK = new LinkLabel();
            lnkDangKy = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(354, 48);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(82, 104);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(309, 166);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(178, 30);
            lbName.TabIndex = 1;
            lbName.Text = "RentHouseMaster";
            // 
            // lblSdtEmail
            // 
            lblSdtEmail.AutoSize = true;
            lblSdtEmail.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSdtEmail.Location = new Point(125, 238);
            lblSdtEmail.Margin = new Padding(6, 0, 6, 0);
            lblSdtEmail.Name = "lblSdtEmail";
            lblSdtEmail.Size = new Size(150, 37);
            lblSdtEmail.TabIndex = 2;
            lblSdtEmail.Text = "SĐT/Email";
            // 
            // txtSdtEmail
            // 
            txtSdtEmail.Anchor = AnchorStyles.Left;
            txtSdtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSdtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSdtEmail.Location = new Point(125, 286);
            txtSdtEmail.Margin = new Padding(0);
            txtSdtEmail.Name = "txtSdtEmail";
            txtSdtEmail.PlaceholderText = " vd@gmail.com";
            txtSdtEmail.Size = new Size(540, 50);
            txtSdtEmail.TabIndex = 3;
            txtSdtEmail.Tag = "";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(125, 399);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(138, 37);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.BackColor = SystemColors.HighlightText;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(125, 451);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = " *******";
            txtMatKhau.Size = new Size(540, 50);
            txtMatKhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.Highlight;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(321, 575);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(166, 73);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lnkQuenMK
            // 
            lnkQuenMK.AutoSize = true;
            lnkQuenMK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkQuenMK.LinkColor = Color.Black;
            lnkQuenMK.Location = new Point(125, 710);
            lnkQuenMK.Name = "lnkQuenMK";
            lnkQuenMK.Size = new Size(198, 32);
            lnkQuenMK.TabIndex = 7;
            lnkQuenMK.TabStop = true;
            lnkQuenMK.Text = "Quên mật khẩu ?";
            lnkQuenMK.TextAlign = ContentAlignment.MiddleLeft;
            lnkQuenMK.LinkClicked += linkLbQuenMK_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkDangKy.LinkColor = Color.LimeGreen;
            lnkDangKy.Location = new Point(563, 710);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(102, 32);
            lnkDangKy.TabIndex = 8;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Đăng ký";
            lnkDangKy.TextAlign = ContentAlignment.MiddleRight;
            lnkDangKy.LinkClicked += linkLbDangKy_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 776);
            Controls.Add(lnkDangKy);
            Controls.Add(lnkQuenMK);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtSdtEmail);
            Controls.Add(lblSdtEmail);
            Controls.Add(lbName);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblSdtEmail;
        private TextBox txtSdtEmail;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private LinkLabel lnkQuenMK;
        private LinkLabel lnkDangKy;
    }
}

