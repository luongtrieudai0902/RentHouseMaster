namespace RentHouseMaster.Forms
{
    partial class Sidebar
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
            sidebarPanel = new Panel();
            panelNav = new Panel();
            btnClose = new Button();
            btnSetting = new Button();
            btnReport = new Button();
            btnPayments = new Button();
            btnTenants = new Button();
            btnProperties = new Button();
            btnDashboard = new Button();
            userPanel = new Panel();
            loginLabel = new Label();
            usernameLabel = new Label();
            userProfile = new PictureBox();
            sidebarPanel.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.White;
            sidebarPanel.BorderStyle = BorderStyle.Fixed3D;
            sidebarPanel.Controls.Add(panelNav);
            sidebarPanel.Controls.Add(btnClose);
            sidebarPanel.Controls.Add(btnSetting);
            sidebarPanel.Controls.Add(btnReport);
            sidebarPanel.Controls.Add(btnPayments);
            sidebarPanel.Controls.Add(btnTenants);
            sidebarPanel.Controls.Add(btnProperties);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(userPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 800);
            sidebarPanel.TabIndex = 0;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 126, 249);
            panelNav.Location = new Point(0, 241);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 100);
            panelNav.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(158, 161, 178);
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(0, 751);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(196, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close Menu";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.FromArgb(0, 126, 249);
            btnSetting.Image = Properties.Resources.setting;
            btnSetting.Location = new Point(0, 392);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(196, 45);
            btnSetting.TabIndex = 1;
            btnSetting.Text = "Setting";
            btnSetting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.FromArgb(0, 126, 249);
            btnReport.Image = Properties.Resources.report;
            btnReport.Location = new Point(0, 347);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(196, 45);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report   ";
            btnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPayments
            // 
            btnPayments.Dock = DockStyle.Top;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.FromArgb(0, 126, 249);
            btnPayments.Image = Properties.Resources.payment;
            btnPayments.Location = new Point(0, 302);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(196, 45);
            btnPayments.TabIndex = 1;
            btnPayments.Text = "Payments";
            btnPayments.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnTenants
            // 
            btnTenants.Dock = DockStyle.Top;
            btnTenants.FlatAppearance.BorderSize = 0;
            btnTenants.FlatStyle = FlatStyle.Flat;
            btnTenants.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTenants.ForeColor = Color.FromArgb(0, 126, 249);
            btnTenants.Image = Properties.Resources.tenant;
            btnTenants.Location = new Point(0, 257);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(196, 45);
            btnTenants.TabIndex = 1;
            btnTenants.Text = "Tenants   ";
            btnTenants.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTenants.UseVisualStyleBackColor = true;
            btnTenants.Click += btnTenants_Click;
            // 
            // btnProperties
            // 
            btnProperties.Dock = DockStyle.Top;
            btnProperties.FlatAppearance.BorderSize = 0;
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProperties.ForeColor = Color.FromArgb(0, 126, 249);
            btnProperties.Image = Properties.Resources.properties;
            btnProperties.Location = new Point(0, 212);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(196, 45);
            btnProperties.TabIndex = 1;
            btnProperties.Text = "Properties";
            btnProperties.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.home_btn;
            btnDashboard.Location = new Point(0, 167);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(196, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(loginLabel);
            userPanel.Controls.Add(usernameLabel);
            userPanel.Controls.Add(userProfile);
            userPanel.Dock = DockStyle.Top;
            userPanel.Location = new Point(0, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(196, 167);
            userPanel.TabIndex = 1;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(158, 161, 178);
            loginLabel.Location = new Point(22, 140);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(148, 16);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Logined 6 hours ago";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.FromArgb(0, 126, 149);
            usernameLabel.Location = new Point(40, 107);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "User Name";
            // 
            // userProfile
            // 
            userProfile.Image = Properties.Resources.user;
            userProfile.Location = new Point(64, 18);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(58, 67);
            userProfile.SizeMode = PictureBoxSizeMode.Zoom;
            userProfile.TabIndex = 0;
            userProfile.TabStop = false;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 800);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sidebar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidebar";
            sidebarPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel userPanel;
        private Button btnDashboard;
        private Label loginLabel;
        private Label usernameLabel;
        private PictureBox userProfile;
        private Button btnClose;
        private Button btnSetting;
        private Button btnReport;
        private Button btnPayments;
        private Button btnTenants;
        private Button btnProperties;
        private Panel panelNav;
    }
}