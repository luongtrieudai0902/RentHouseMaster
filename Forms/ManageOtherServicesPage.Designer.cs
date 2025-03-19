namespace RentHouseMaster.Forms
{
    partial class ManageOtherServicesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOtherServicesPage));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            searchBarPanel = new Panel();
            searchPic = new PictureBox();
            searchBox = new TextBox();
            AtoZbox = new ComboBox();
            arrangeBox = new ComboBox();
            spacePanel = new Panel();
            roomDataGridView = new DataGridView();
            servicesDataGridView = new DataGridView();
            panel1.SuspendLayout();
            searchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchBarPanel);
            panel1.Controls.Add(AtoZbox);
            panel1.Controls.Add(arrangeBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(56, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 131);
            panel1.TabIndex = 9;
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
            // spacePanel
            // 
            spacePanel.Dock = DockStyle.Left;
            spacePanel.Location = new Point(0, 0);
            spacePanel.Name = "spacePanel";
            spacePanel.Size = new Size(56, 687);
            spacePanel.TabIndex = 8;
            // 
            // roomDataGridView
            // 
            roomDataGridView.BackgroundColor = Color.White;
            roomDataGridView.BorderStyle = BorderStyle.None;
            roomDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            roomDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle6.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            roomDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            roomDataGridView.Dock = DockStyle.Fill;
            roomDataGridView.GridColor = Color.White;
            roomDataGridView.Location = new Point(0, 0);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            roomDataGridView.RowHeadersVisible = false;
            roomDataGridView.RowHeadersWidth = 51;
            roomDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            roomDataGridView.RowTemplate.Height = 45;
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            roomDataGridView.Size = new Size(1080, 687);
            roomDataGridView.TabIndex = 10;
            // 
            // servicesDataGridView
            // 
            servicesDataGridView.BackgroundColor = Color.White;
            servicesDataGridView.BorderStyle = BorderStyle.None;
            servicesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            servicesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            servicesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            servicesDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle8.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            servicesDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            servicesDataGridView.Dock = DockStyle.Fill;
            servicesDataGridView.GridColor = Color.White;
            servicesDataGridView.Location = new Point(56, 131);
            servicesDataGridView.Name = "servicesDataGridView";
            servicesDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            servicesDataGridView.RowHeadersVisible = false;
            servicesDataGridView.RowHeadersWidth = 51;
            servicesDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            servicesDataGridView.RowTemplate.Height = 45;
            servicesDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            servicesDataGridView.Size = new Size(1024, 556);
            servicesDataGridView.TabIndex = 11;
            // 
            // ManageOtherServicesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 687);
            Controls.Add(servicesDataGridView);
            Controls.Add(panel1);
            Controls.Add(spacePanel);
            Controls.Add(roomDataGridView);
            Name = "ManageOtherServicesPage";
            Text = "ManageOtherServicesPage";
            panel1.ResumeLayout(false);
            searchBarPanel.ResumeLayout(false);
            searchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel searchBarPanel;
        private PictureBox searchPic;
        private TextBox searchBox;
        private ComboBox AtoZbox;
        private ComboBox arrangeBox;
        private Panel spacePanel;
        private DataGridView roomDataGridView;
        private DataGridView servicesDataGridView;
    }
}