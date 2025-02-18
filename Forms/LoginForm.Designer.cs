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
            lbSdtEmail = new Label();
            txtSdtEmail = new TextBox();
            lbMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            linkLbQuenMK = new LinkLabel();
            linkLbDangKy = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(338, 77);
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
            lbName.Location = new Point(284, 184);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(178, 30);
            lbName.TabIndex = 1;
            lbName.Text = "RentHouseMaster";
            // 
            // lbSdtEmail
            // 
            lbSdtEmail.AutoSize = true;
            lbSdtEmail.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSdtEmail.Location = new Point(117, 241);
            lbSdtEmail.Margin = new Padding(6, 0, 6, 0);
            lbSdtEmail.Name = "lbSdtEmail";
            lbSdtEmail.Size = new Size(150, 37);
            lbSdtEmail.TabIndex = 2;
            lbSdtEmail.Text = "SĐT/Email";
            // 
            // txtSdtEmail
            // 
            txtSdtEmail.Anchor = AnchorStyles.Left;
            txtSdtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSdtEmail.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSdtEmail.Location = new Point(125, 303);
            txtSdtEmail.Margin = new Padding(5, 4, 3, 4);
            txtSdtEmail.Multiline = true;
            txtSdtEmail.Name = "txtSdtEmail";
            txtSdtEmail.Size = new Size(540, 79);
            txtSdtEmail.TabIndex = 3;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMatKhau.Location = new Point(117, 428);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(138, 37);
            lbMatKhau.TabIndex = 4;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.BackColor = SystemColors.HighlightText;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(125, 498);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(540, 83);
            txtMatKhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.Highlight;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(300, 648);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(166, 73);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // linkLbQuenMK
            // 
            linkLbQuenMK.AutoSize = true;
            linkLbQuenMK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbQuenMK.LinkColor = Color.Black;
            linkLbQuenMK.Location = new Point(118, 783);
            linkLbQuenMK.Name = "linkLbQuenMK";
            linkLbQuenMK.Size = new Size(198, 32);
            linkLbQuenMK.TabIndex = 7;
            linkLbQuenMK.TabStop = true;
            linkLbQuenMK.Text = "Quên mật khẩu ?";
            linkLbQuenMK.TextAlign = ContentAlignment.MiddleLeft;
            linkLbQuenMK.LinkClicked += linkLbQuenMK_Click;
            // 
            // linkLbDangKy
            // 
            linkLbDangKy.AutoSize = true;
            linkLbDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbDangKy.LinkColor = Color.LimeGreen;
            linkLbDangKy.Location = new Point(555, 783);
            linkLbDangKy.Name = "linkLbDangKy";
            linkLbDangKy.Size = new Size(102, 32);
            linkLbDangKy.TabIndex = 8;
            linkLbDangKy.TabStop = true;
            linkLbDangKy.Text = "Đăng ký";
            linkLbDangKy.TextAlign = ContentAlignment.MiddleRight;
            linkLbDangKy.LinkClicked += linkLbDangKy_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 899);
            Controls.Add(linkLbDangKy);
            Controls.Add(linkLbQuenMK);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(lbMatKhau);
            Controls.Add(txtSdtEmail);
            Controls.Add(lbSdtEmail);
            Controls.Add(lbName);
            Controls.Add(picLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSdtEmail;
        private TextBox txtSdtEmail;
        private Label lbMatKhau;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private LinkLabel linkLbQuenMK;
        private LinkLabel linkLbDangKy;
    }
}

