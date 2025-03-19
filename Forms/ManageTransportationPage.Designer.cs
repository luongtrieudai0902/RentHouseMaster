namespace RentHouseMaster.Forms
{
    partial class ManageTransportationPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransportationPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TransportDataGridView = new DataGridView();
            panel1 = new Panel();
            searchBarPanel = new Panel();
            searchPic = new PictureBox();
            searchBox = new TextBox();
            AtoZbox = new ComboBox();
            arrangeBox = new ComboBox();
            spacePanel = new Panel();
            roomDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TransportDataGridView).BeginInit();
            panel1.SuspendLayout();
            searchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TransportDataGridView
            // 
            TransportDataGridView.BackgroundColor = Color.White;
            TransportDataGridView.BorderStyle = BorderStyle.None;
            TransportDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TransportDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TransportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TransportDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TransportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            TransportDataGridView.Dock = DockStyle.Fill;
            TransportDataGridView.GridColor = Color.White;
            TransportDataGridView.Location = new Point(56, 131);
            TransportDataGridView.Name = "TransportDataGridView";
            TransportDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TransportDataGridView.RowHeadersVisible = false;
            TransportDataGridView.RowHeadersWidth = 51;
            TransportDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            TransportDataGridView.RowTemplate.Height = 45;
            TransportDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TransportDataGridView.Size = new Size(1024, 556);
            TransportDataGridView.TabIndex = 15;
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
            panel1.TabIndex = 13;
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
            spacePanel.TabIndex = 12;
            // 
            // roomDataGridView
            // 
            roomDataGridView.BackgroundColor = Color.White;
            roomDataGridView.BorderStyle = BorderStyle.None;
            roomDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 105, 232);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            roomDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            roomDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
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
            roomDataGridView.TabIndex = 14;
            // 
            // ManageTransportationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 687);
            Controls.Add(TransportDataGridView);
            Controls.Add(panel1);
            Controls.Add(spacePanel);
            Controls.Add(roomDataGridView);
            Name = "ManageTransportationPage";
            Text = "ManageTransportationPage";
            ((System.ComponentModel.ISupportInitialize)TransportDataGridView).EndInit();
            panel1.ResumeLayout(false);
            searchBarPanel.ResumeLayout(false);
            searchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TransportDataGridView;
        private Panel panel1;
        private Panel searchBarPanel;
        private PictureBox searchPic;
        private TextBox searchBox;
        private ComboBox AtoZbox;
        private ComboBox arrangeBox;
        private Panel spacePanel;
        private DataGridView roomDataGridView;
    }
}