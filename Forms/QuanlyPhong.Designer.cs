namespace RentHouseMaster.Forms
{
    partial class QuanlyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanlyPhong));
            panel1 = new Panel();
            roomDataGridView = new DataGridView();
            panel4 = new Panel();
            panel3 = new Panel();
            btnAddPhong = new Button();
            searchbarPanel = new Panel();
            btnQL = new Button();
            panel2 = new Panel();
            searchtextbox = new TextBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            panel3.SuspendLayout();
            searchbarPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(searchbarPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // roomDataGridView
            // 
            roomDataGridView.BackgroundColor = Color.White;
            roomDataGridView.BorderStyle = BorderStyle.None;
            roomDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(163, 163, 163);
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            roomDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 236, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 15, 10, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            roomDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            roomDataGridView.Dock = DockStyle.Fill;
            roomDataGridView.EnableHeadersVisualStyles = false;
            roomDataGridView.GridColor = Color.White;
            roomDataGridView.Location = new Point(20, 0);
            roomDataGridView.Margin = new Padding(10, 3, 10, 3);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            roomDataGridView.RowHeadersVisible = false;
            roomDataGridView.RowHeadersWidth = 51;
            roomDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            roomDataGridView.RowTemplate.Height = 45;
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            roomDataGridView.Size = new Size(760, 307);
            roomDataGridView.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 10);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddPhong);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 77);
            panel3.TabIndex = 3;
            // 
            // btnAddPhong
            // 
            btnAddPhong.BackColor = Color.FromArgb(50, 105, 232);
            btnAddPhong.Dock = DockStyle.Right;
            btnAddPhong.FlatAppearance.BorderSize = 0;
            btnAddPhong.FlatStyle = FlatStyle.Flat;
            btnAddPhong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPhong.ForeColor = Color.White;
            btnAddPhong.Image = (Image)resources.GetObject("btnAddPhong.Image");
            btnAddPhong.Location = new Point(659, 0);
            btnAddPhong.Name = "btnAddPhong";
            btnAddPhong.Size = new Size(141, 77);
            btnAddPhong.TabIndex = 2;
            btnAddPhong.Text = "Thêm phòng";
            btnAddPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPhong.UseVisualStyleBackColor = false;
            // 
            // searchbarPanel
            // 
            searchbarPanel.Controls.Add(btnQL);
            searchbarPanel.Controls.Add(panel2);
            searchbarPanel.Dock = DockStyle.Top;
            searchbarPanel.Location = new Point(0, 0);
            searchbarPanel.Name = "searchbarPanel";
            searchbarPanel.Size = new Size(800, 56);
            searchbarPanel.TabIndex = 1;
            // 
            // btnQL
            // 
            btnQL.BackColor = Color.FromArgb(50, 105, 232);
            btnQL.FlatAppearance.BorderSize = 0;
            btnQL.FlatStyle = FlatStyle.Flat;
            btnQL.ForeColor = Color.White;
            btnQL.Image = (Image)resources.GetObject("btnQL.Image");
            btnQL.Location = new Point(454, 12);
            btnQL.Name = "btnQL";
            btnQL.Size = new Size(97, 35);
            btnQL.TabIndex = 1;
            btnQL.Text = "QL CSLT";
            btnQL.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQL.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(searchtextbox);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(21, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 35);
            panel2.TabIndex = 0;
            // 
            // searchtextbox
            // 
            searchtextbox.BackColor = Color.White;
            searchtextbox.BorderStyle = BorderStyle.None;
            searchtextbox.ForeColor = Color.Gray;
            searchtextbox.Location = new Point(38, 5);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.PlaceholderText = "Tìm phòng";
            searchtextbox.Size = new Size(310, 20);
            searchtextbox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(roomDataGridView);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 66);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(800, 307);
            panel5.TabIndex = 6;
            // 
            // QuanlyPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "QuanlyPhong";
            Text = "QuanlyPhong";
            Shown += QuanlyPhong_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            panel3.ResumeLayout(false);
            searchbarPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel searchbarPanel;
        private Panel panel2;
        private TextBox searchtextbox;
        private PictureBox pictureBox1;
        private Button btnQL;
        private Button btnAddPhong;
        private Panel panel3;
        private DataGridView roomDataGridView;
        private Panel panel4;
        private Panel panel5;
    }
}