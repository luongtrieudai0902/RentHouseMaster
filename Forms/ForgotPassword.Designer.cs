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
            llblMXT = new LinkLabel();
            btnLogin = new LinkLabel();
            lblRHM = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(295, 29);
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
            label1.Location = new Point(78, 202);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 1;
            label1.Text = "SĐT/Email";
            // 
            // txtPhoneOrEmail
            // 
            txtPhoneOrEmail.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneOrEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneOrEmail.Location = new Point(78, 263);
            txtPhoneOrEmail.Margin = new Padding(6, 7, 6, 7);
            txtPhoneOrEmail.Name = "txtPhoneOrEmail";
            txtPhoneOrEmail.PlaceholderText = " nguyenvana@gmail.com";
            txtPhoneOrEmail.Size = new Size(542, 50);
            txtPhoneOrEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 363);
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
            txtValidCode.Location = new Point(78, 424);
            txtValidCode.Margin = new Padding(6, 7, 6, 7);
            txtValidCode.MaxLength = 6;
            txtValidCode.Name = "txtValidCode";
            txtValidCode.PlaceholderText = " Hãy nhập mã tại đây";
            txtValidCode.Size = new Size(542, 47);
            txtValidCode.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(265, 533);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(171, 74);
            button1.TabIndex = 5;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Tieptuc;
            // 
            // llblMXT
            // 
            llblMXT.AutoSize = true;
            llblMXT.LinkColor = Color.Black;
            llblMXT.Location = new Point(65, 662);
            llblMXT.Margin = new Padding(6, 0, 6, 0);
            llblMXT.Name = "llblMXT";
            llblMXT.Size = new Size(216, 32);
            llblMXT.TabIndex = 6;
            llblMXT.TabStop = true;
            llblMXT.Text = "Gửi lại mã xác thực";
            llblMXT.LinkClicked += llblMXT_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.LinkColor = Color.DodgerBlue;
            btnLogin.Location = new Point(488, 662);
            btnLogin.Margin = new Padding(6, 0, 6, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 32);
            btnLogin.TabIndex = 7;
            btnLogin.TabStop = true;
            btnLogin.Text = "Đăng nhập";
            btnLogin.LinkClicked += linkLabelDN;
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
            Controls.Add(btnLogin);
            Controls.Add(llblMXT);
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
        private System.Windows.Forms.LinkLabel llblMXT;
        private System.Windows.Forms.LinkLabel btnLogin;
        private TextBox txtValidCode;
        private Label lblRHM;
    }
}

