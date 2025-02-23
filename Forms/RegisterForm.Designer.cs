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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtHovaTen = new TextBox();
            label3 = new Label();
            txtSDTEmail = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(275, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 81);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 1;
            label1.Text = "RentHouseMaster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 125);
            label2.Name = "label2";
            label2.Size = new Size(165, 45);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // txtHovaTen
            // 
            txtHovaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHovaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHovaTen.Location = new Point(60, 173);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.PlaceholderText = " Nguyễn Văn A";
            txtHovaTen.Size = new Size(509, 50);
            txtHovaTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 275);
            label3.Name = "label3";
            label3.Size = new Size(176, 45);
            label3.TabIndex = 4;
            label3.Text = "SĐT/Email";
            // 
            // txtSDTEmail
            // 
            txtSDTEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSDTEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDTEmail.Location = new Point(60, 323);
            txtSDTEmail.Name = "txtSDTEmail";
            txtSDTEmail.PlaceholderText = " nguyenvana@gmail.com";
            txtSDTEmail.Size = new Size(509, 50);
            txtSDTEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 418);
            label4.Name = "label4";
            label4.Size = new Size(162, 45);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(60, 466);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = " ******";
            txtMatKhau.Size = new Size(509, 50);
            txtMatKhau.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(210, 558);
            button1.Name = "button1";
            button1.Size = new Size(155, 49);
            button1.TabIndex = 8;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_DangKy;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(158, 628);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(267, 41);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tôi đã có tài khoản";
            linkLabel1.LinkClicked += LinkLbDangNhap;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 730);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(txtMatKhau);
            Controls.Add(label4);
            Controls.Add(txtSDTEmail);
            Controls.Add(label3);
            Controls.Add(txtHovaTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

