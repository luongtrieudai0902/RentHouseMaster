namespace RentHouseMaster.Forms
{
    partial class RoleSelection
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
            btnChuNha = new Button();
            btnNhanVien = new Button();
            btnKhachThue = new Button();
            label1 = new Label();
            lblChuaCoTaiKhoan = new LinkLabel();
            SuspendLayout();
            // 
            // btnChuNha
            // 
            btnChuNha.Location = new Point(111, 190);
            btnChuNha.Name = "btnChuNha";
            btnChuNha.Size = new Size(94, 29);
            btnChuNha.TabIndex = 0;
            btnChuNha.Text = "Chủ Nhà";
            btnChuNha.UseVisualStyleBackColor = true;
            btnChuNha.Click += btnChuNha_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(327, 190);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(94, 29);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachThue
            // 
            btnKhachThue.Location = new Point(558, 190);
            btnKhachThue.Name = "btnKhachThue";
            btnKhachThue.Size = new Size(94, 29);
            btnKhachThue.TabIndex = 2;
            btnKhachThue.Text = "Khách Thuê";
            btnKhachThue.UseVisualStyleBackColor = true;
            btnKhachThue.Click += btnKhachThue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 70);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Bạn là ...";
            // 
            // lblChuaCoTaiKhoan
            // 
            lblChuaCoTaiKhoan.AutoSize = true;
            lblChuaCoTaiKhoan.Location = new Point(279, 316);
            lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            lblChuaCoTaiKhoan.Size = new Size(153, 20);
            lblChuaCoTaiKhoan.TabIndex = 4;
            lblChuaCoTaiKhoan.TabStop = true;
            lblChuaCoTaiKhoan.Text = "Tôi chưa có tài khoản.";
            lblChuaCoTaiKhoan.LinkClicked += lblChuaCoTaiKhoan_LinkClicked;
            // 
            // RoleSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(lblChuaCoTaiKhoan);
            Controls.Add(label1);
            Controls.Add(btnKhachThue);
            Controls.Add(btnNhanVien);
            Controls.Add(btnChuNha);
            Name = "RoleSelection";
            Text = "RoleSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChuNha;
        private Button btnNhanVien;
        private Button btnKhachThue;
        private Label label1;
        private LinkLabel lblChuaCoTaiKhoan;
    }
}