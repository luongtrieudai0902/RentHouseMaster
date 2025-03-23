namespace RentHouseMaster.Forms
{
    partial class HouseDetailPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseDetailPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            spacePanel = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            searchBarPanel = new Panel();
            searchPic = new PictureBox();
            searchBox = new TextBox();
            AtoZbox = new ComboBox();
            arrangeBox = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            returnBtn = new Button();
            button2 = new Button();
            roomDataGridView = new DataGridView();
            panel1.SuspendLayout();
            searchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            SuspendLayout();
            // 
            // spacePanel
            // 
            spacePanel.Dock = DockStyle.Left;
            spacePanel.Location = new Point(0, 0);
            spacePanel.Name = "spacePanel";
            spacePanel.Size = new Size(56, 865);
            spacePanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(searchBarPanel);
            panel1.Controls.Add(AtoZbox);
            panel1.Controls.Add(arrangeBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(56, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 131);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 234, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(70, 119, 197);
            button1.Image = Properties.Resources.alert;
            button1.Location = new Point(336, 12);
            button1.Name = "button1";
            button1.Size = new Size(236, 57);
            button1.TabIndex = 3;
            button1.Text = "Nhắc thanh toán";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // searchBarPanel
            // 
            searchBarPanel.BorderStyle = BorderStyle.FixedSingle;
            searchBarPanel.Controls.Add(searchPic);
            searchBarPanel.Controls.Add(searchBox);
            searchBarPanel.Location = new Point(10, 12);
            searchBarPanel.Name = "searchBarPanel";
            searchBarPanel.Size = new Size(305, 57);
            searchBarPanel.TabIndex = 0;
            // 
            // searchPic
            // 
            searchPic.Image = (Image)resources.GetObject("searchPic.Image");
            searchPic.Location = new Point(12, 15);
            searchPic.Name = "searchPic";
            searchPic.Size = new Size(25, 25);
            searchPic.SizeMode = PictureBoxSizeMode.Zoom;
            searchPic.TabIndex = 1;
            searchPic.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(43, 15);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Tìm cơ sở lưu trú";
            searchBox.Size = new Size(257, 23);
            searchBox.TabIndex = 0;
            // 
            // AtoZbox
            // 
            AtoZbox.ForeColor = Color.Gray;
            AtoZbox.FormattingEnabled = true;
            AtoZbox.Location = new Point(201, 88);
            AtoZbox.Name = "AtoZbox";
            AtoZbox.Size = new Size(114, 28);
            AtoZbox.TabIndex = 2;
            AtoZbox.Text = "   Từ A to Z";
            // 
            // arrangeBox
            // 
            arrangeBox.BackColor = Color.White;
            arrangeBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arrangeBox.ForeColor = Color.Gray;
            arrangeBox.FormattingEnabled = true;
            arrangeBox.Location = new Point(10, 87);
            arrangeBox.Name = "arrangeBox";
            arrangeBox.Size = new Size(174, 28);
            arrangeBox.TabIndex = 1;
            arrangeBox.Text = "    Sắp xếp theo";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(56, 799);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 66);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(returnBtn);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(720, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 66);
            panel3.TabIndex = 0;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(50, 105, 232);
            returnBtn.Dock = DockStyle.Left;
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.White;
            returnBtn.Image = (Image)resources.GetObject("returnBtn.Image");
            returnBtn.Location = new Point(0, 0);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(165, 66);
            returnBtn.TabIndex = 1;
            returnBtn.Text = "Quay lại ";
            returnBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(70, 197, 100);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(171, 0);
            button2.Name = "button2";
            button2.Size = new Size(207, 66);
            button2.TabIndex = 0;
            button2.Text = "  Thêm phòng";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // roomDataGridView
            // 
            roomDataGridView.BackgroundColor = Color.White;
            roomDataGridView.BorderStyle = BorderStyle.None;
            roomDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            roomDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            roomDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            roomDataGridView.Dock = DockStyle.Fill;
            roomDataGridView.GridColor = Color.White;
            roomDataGridView.Location = new Point(56, 131);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            roomDataGridView.RowHeadersVisible = false;
            roomDataGridView.RowHeadersWidth = 51;
            roomDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            roomDataGridView.RowTemplate.Height = 45;
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            roomDataGridView.Size = new Size(1098, 668);
            roomDataGridView.TabIndex = 7;
            roomDataGridView.CellContentClick += roomDataGridView_CellContentClick;
            // 
            // HouseDetailPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 865);
            Controls.Add(roomDataGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(spacePanel);
            Name = "HouseDetailPage";
            Text = "HouseDetailPage";
            panel1.ResumeLayout(false);
            searchBarPanel.ResumeLayout(false);
            searchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel spacePanel;
        private Panel panel1;
        private Button button1;
        private Panel searchBarPanel;
        private PictureBox searchPic;
        private TextBox searchBox;
        private ComboBox AtoZbox;
        private ComboBox arrangeBox;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
        private Button returnBtn;
        private DataGridView roomDataGridView;
    }
}