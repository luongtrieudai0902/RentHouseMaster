namespace RentHouseMaster.Forms
{
    partial class AddRoom
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhong = new TextBox();
            txtChiPhi = new TextBox();
            txtHanHopDong = new TextBox();
            btnThem = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 111);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Chi phí";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 181);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Hạn hợp đồng";
            // 
            // txtPhong
            // 
            txtPhong.Location = new Point(205, 41);
            txtPhong.Name = "txtPhong";
            txtPhong.Size = new Size(335, 27);
            txtPhong.TabIndex = 3;
            // 
            // txtChiPhi
            // 
            txtChiPhi.Location = new Point(205, 108);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(335, 27);
            txtChiPhi.TabIndex = 4;
            // 
            // txtHanHopDong
            // 
            txtHanHopDong.Location = new Point(205, 177);
            txtHanHopDong.Name = "txtHanHopDong";
            txtHanHopDong.Size = new Size(335, 27);
            txtHanHopDong.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(166, 294);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(190, 100);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(428, 295);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(190, 100);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(txtHanHopDong);
            Controls.Add(txtChiPhi);
            Controls.Add(txtPhong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRoom";
            Text = "Thêm phòng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPhong;
        private TextBox txtChiPhi;
        private TextBox txtHanHopDong;
        private Button btnThem;
        private Button btnHuy;
    }
}