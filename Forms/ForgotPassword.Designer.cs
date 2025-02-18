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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPhoneOrEmail = new TextBox();
            label2 = new Label();
            txtValidCode = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            btnLogin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(290, 30);
            pictureBox1.Margin = new Padding(6, 7, 6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 190);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 1;
            label1.Text = "SĐT/Email";
            // 
            // txtPhoneOrEmail
            // 
            txtPhoneOrEmail.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneOrEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneOrEmail.Location = new Point(78, 249);
            txtPhoneOrEmail.Margin = new Padding(6, 7, 6, 7);
            txtPhoneOrEmail.Multiline = true;
            txtPhoneOrEmail.Name = "txtPhoneOrEmail";
            txtPhoneOrEmail.Size = new Size(542, 71);
            txtPhoneOrEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 389);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 45);
            label2.TabIndex = 3;
            label2.Text = "Mã xác thực";
            // 
            // txtValidCode
            // 
            txtValidCode.BorderStyle = BorderStyle.FixedSingle;
            txtValidCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValidCode.Location = new Point(78, 448);
            txtValidCode.Margin = new Padding(6, 7, 6, 7);
            txtValidCode.MaxLength = 6;
            txtValidCode.Multiline = true;
            txtValidCode.Name = "txtValidCode";
            txtValidCode.Size = new Size(542, 71);
            txtValidCode.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(260, 564);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(171, 74);
            button1.TabIndex = 5;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Tieptuc;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(72, 711);
            linkLabel1.Margin = new Padding(6, 0, 6, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(216, 32);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gửi lại mã xác thực";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.LinkColor = Color.DodgerBlue;
            btnLogin.Location = new Point(503, 711);
            btnLogin.Margin = new Padding(6, 0, 6, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 32);
            btnLogin.TabIndex = 7;
            btnLogin.TabStop = true;
            btnLogin.Text = "Đăng nhập";
            btnLogin.LinkClicked += linkLabelDN;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 822);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(txtValidCode);
            Controls.Add(label2);
            Controls.Add(txtPhoneOrEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "ForgotPassword";
            Text = "Password Recovery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneOrEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel btnLogin;
        private TextBox txtValidCode;
    }
}

