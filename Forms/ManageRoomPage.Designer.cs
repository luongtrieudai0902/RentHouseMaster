namespace RentHouseMaster.Forms
{
    partial class ManageRoomPage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomPage));
            spacePanel = new Panel();
            contentPanel = new Panel();
            panel3 = new Panel();
            houseDataGridView = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            searchBarPanel = new Panel();
            searchPic = new PictureBox();
            searchBox = new TextBox();
            AtoZbox = new ComboBox();
            arrangeBox = new ComboBox();
            contentPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)houseDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            searchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            SuspendLayout();
            // 
            // spacePanel
            // 
            spacePanel.Dock = DockStyle.Left;
            spacePanel.Location = new Point(0, 0);
            spacePanel.Name = "spacePanel";
            spacePanel.Size = new Size(56, 865);
            spacePanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(panel3);
            contentPanel.Controls.Add(panel2);
            contentPanel.Controls.Add(panel1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(56, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1098, 865);
            contentPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(houseDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(1098, 668);
            panel3.TabIndex = 6;
            // 
            // houseDataGridView
            // 
            houseDataGridView.BackgroundColor = Color.White;
            houseDataGridView.BorderStyle = BorderStyle.None;
            houseDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            houseDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            houseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            houseDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            houseDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            houseDataGridView.Dock = DockStyle.Fill;
            houseDataGridView.GridColor = Color.White;
            houseDataGridView.Location = new Point(0, 0);
            houseDataGridView.Name = "houseDataGridView";
            houseDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            houseDataGridView.RowHeadersVisible = false;
            houseDataGridView.RowHeadersWidth = 51;
            houseDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            houseDataGridView.RowTemplate.Height = 45;
            houseDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            houseDataGridView.Size = new Size(1098, 668);
            houseDataGridView.TabIndex = 0;
            houseDataGridView.CellContentClick += roomDataGridView_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 799);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 66);
            panel2.TabIndex = 5;
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
            button2.Location = new Point(891, 0);
            button2.Name = "button2";
            button2.Size = new Size(207, 66);
            button2.TabIndex = 0;
            button2.Text = "  Thêm nhà";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(searchBarPanel);
            panel1.Controls.Add(AtoZbox);
            panel1.Controls.Add(arrangeBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 131);
            panel1.TabIndex = 4;
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
            // ManageRoomPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 865);
            Controls.Add(contentPanel);
            Controls.Add(spacePanel);
            Name = "ManageRoomPage";
            Text = "ManageRoomPage";
            contentPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)houseDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            searchBarPanel.ResumeLayout(false);
            searchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel spacePanel;
        private Panel contentPanel;
        private Panel searchBarPanel;
        private TextBox searchBox;
        private PictureBox searchPic;
        private ComboBox AtoZbox;
        private ComboBox arrangeBox;
        private Button button1;
        private Panel panel3;
        private DataGridView houseDataGridView;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
    }
}