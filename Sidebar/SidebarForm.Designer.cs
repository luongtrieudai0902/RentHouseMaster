namespace Sidebar
{
    partial class SidebarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarForm));
            sidebar = new Panel();
            btnSetting = new Button();
            btnReport = new Button();
            btnPayment = new Button();
            btnTenants = new Button();
            btnProperties = new Button();
            btnDashboard = new Button();
            topPanel = new Panel();
            loginLabel = new Label();
            userPictureBox = new PictureBox();
            userlabel = new Label();
            panelNav = new Panel();
            PropertiesOverviewPanel = new Panel();
            house4Panel = new Panel();
            label14 = new Label();
            pictureBox11 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            pictureBox12 = new PictureBox();
            house3Panel = new Panel();
            label11 = new Label();
            pictureBox9 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            pictureBox10 = new PictureBox();
            house2Panel = new Panel();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox8 = new PictureBox();
            house1Panel = new Panel();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            properoverviewbtn = new Button();
            label1 = new Label();
            searchBox = new TextBox();
            btnSearch = new Button();
            alertPictureBox = new PictureBox();
            averageSalePanel = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            salesLineGraph = new PictureBox();
            totalApplicationPanel = new Panel();
            pictureBox14 = new PictureBox();
            label18 = new Label();
            label17 = new Label();
            mailBox = new PictureBox();
            totalPaymentsPanel = new Panel();
            label19 = new Label();
            label20 = new Label();
            moneyBox = new PictureBox();
            totalPropertiesPanel = new Panel();
            pictureBox17 = new PictureBox();
            label21 = new Label();
            label22 = new Label();
            propertiesBox = new PictureBox();
            sidebar.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            PropertiesOverviewPanel.SuspendLayout();
            house4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            house3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            house2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            house1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alertPictureBox).BeginInit();
            averageSalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesLineGraph).BeginInit();
            totalApplicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailBox).BeginInit();
            totalPaymentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moneyBox).BeginInit();
            totalPropertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertiesBox).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.BorderStyle = BorderStyle.Fixed3D;
            sidebar.Controls.Add(btnSetting);
            sidebar.Controls.Add(btnReport);
            sidebar.Controls.Add(btnPayment);
            sidebar.Controls.Add(btnTenants);
            sidebar.Controls.Add(btnProperties);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(topPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 800);
            sidebar.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Bottom;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.FromArgb(0, 126, 249);
            btnSetting.Image = Properties.Resources.setting;
            btnSetting.Location = new Point(0, 754);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(196, 42);
            btnSetting.TabIndex = 2;
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
            btnReport.TabIndex = 2;
            btnReport.Text = "Report      ";
            btnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.FromArgb(0, 126, 249);
            btnPayment.Image = Properties.Resources.payment;
            btnPayment.Location = new Point(0, 302);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(196, 45);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payments  ";
            btnPayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
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
            btnTenants.TabIndex = 2;
            btnTenants.Text = "Tenants      ";
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
            btnProperties.TabIndex = 2;
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
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(loginLabel);
            topPanel.Controls.Add(userPictureBox);
            topPanel.Controls.Add(userlabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(196, 167);
            topPanel.TabIndex = 1;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(158, 161, 178);
            loginLabel.Location = new Point(23, 126);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(148, 16);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Logined 6 hours ago";
            // 
            // userPictureBox
            // 
            userPictureBox.Image = Properties.Resources.user;
            userPictureBox.Location = new Point(74, 21);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(58, 67);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 1;
            userPictureBox.TabStop = false;
            // 
            // userlabel
            // 
            userlabel.AutoSize = true;
            userlabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userlabel.ForeColor = Color.FromArgb(0, 126, 149);
            userlabel.Location = new Point(46, 97);
            userlabel.Name = "userlabel";
            userlabel.Size = new Size(103, 20);
            userlabel.TabIndex = 1;
            userlabel.Text = "User Name";
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 126, 249);
            panelNav.Location = new Point(0, 193);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 100);
            panelNav.TabIndex = 1;
            // 
            // PropertiesOverviewPanel
            // 
            PropertiesOverviewPanel.BackColor = Color.WhiteSmoke;
            PropertiesOverviewPanel.Controls.Add(house4Panel);
            PropertiesOverviewPanel.Controls.Add(house3Panel);
            PropertiesOverviewPanel.Controls.Add(house2Panel);
            PropertiesOverviewPanel.Controls.Add(house1Panel);
            PropertiesOverviewPanel.Controls.Add(properoverviewbtn);
            PropertiesOverviewPanel.Controls.Add(label1);
            PropertiesOverviewPanel.Location = new Point(705, 270);
            PropertiesOverviewPanel.Name = "PropertiesOverviewPanel";
            PropertiesOverviewPanel.Size = new Size(483, 518);
            PropertiesOverviewPanel.TabIndex = 2;
            // 
            // house4Panel
            // 
            house4Panel.BackColor = Color.White;
            house4Panel.Controls.Add(label14);
            house4Panel.Controls.Add(pictureBox11);
            house4Panel.Controls.Add(label15);
            house4Panel.Controls.Add(label16);
            house4Panel.Controls.Add(pictureBox12);
            house4Panel.Location = new Point(29, 472);
            house4Panel.Name = "house4Panel";
            house4Panel.Size = new Size(433, 115);
            house4Panel.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(209, 80);
            label14.Name = "label14";
            label14.Size = new Size(70, 16);
            label14.TabIndex = 4;
            label14.Text = "see more..";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(209, 43);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(22, 22);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 3;
            pictureBox11.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(237, 45);
            label15.Name = "label15";
            label15.Size = new Size(171, 20);
            label15.TabIndex = 2;
            label15.Text = "1st Main Street, Magway";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(209, 16);
            label16.Name = "label16";
            label16.Size = new Size(194, 18);
            label16.TabIndex = 1;
            label16.Text = "Spacious House for sale";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(0, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(178, 115);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // house3Panel
            // 
            house3Panel.BackColor = Color.White;
            house3Panel.Controls.Add(label11);
            house3Panel.Controls.Add(pictureBox9);
            house3Panel.Controls.Add(label12);
            house3Panel.Controls.Add(label13);
            house3Panel.Controls.Add(pictureBox10);
            house3Panel.Location = new Point(29, 344);
            house3Panel.Name = "house3Panel";
            house3Panel.Size = new Size(433, 115);
            house3Panel.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(209, 80);
            label11.Name = "label11";
            label11.Size = new Size(70, 16);
            label11.TabIndex = 4;
            label11.Text = "see more..";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(209, 43);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(22, 22);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(237, 45);
            label12.Name = "label12";
            label12.Size = new Size(171, 20);
            label12.TabIndex = 2;
            label12.Text = "1st Main Street, Magway";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(209, 16);
            label13.Name = "label13";
            label13.Size = new Size(194, 18);
            label13.TabIndex = 1;
            label13.Text = "Spacious House for sale";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(178, 115);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // house2Panel
            // 
            house2Panel.BackColor = Color.White;
            house2Panel.Controls.Add(label8);
            house2Panel.Controls.Add(pictureBox7);
            house2Panel.Controls.Add(label9);
            house2Panel.Controls.Add(label10);
            house2Panel.Controls.Add(pictureBox8);
            house2Panel.Location = new Point(29, 211);
            house2Panel.Name = "house2Panel";
            house2Panel.Size = new Size(433, 115);
            house2Panel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(209, 80);
            label8.Name = "label8";
            label8.Size = new Size(70, 16);
            label8.TabIndex = 4;
            label8.Text = "see more..";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(209, 43);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(237, 45);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 2;
            label9.Text = "1st Main Street, Magway";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(209, 16);
            label10.Name = "label10";
            label10.Size = new Size(194, 18);
            label10.TabIndex = 1;
            label10.Text = "Spacious House for sale";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(178, 115);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // house1Panel
            // 
            house1Panel.BackColor = Color.White;
            house1Panel.Controls.Add(label7);
            house1Panel.Controls.Add(pictureBox6);
            house1Panel.Controls.Add(label4);
            house1Panel.Controls.Add(label3);
            house1Panel.Controls.Add(pictureBox2);
            house1Panel.Location = new Point(29, 79);
            house1Panel.Name = "house1Panel";
            house1Panel.Size = new Size(433, 115);
            house1Panel.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(209, 80);
            label7.Name = "label7";
            label7.Size = new Size(70, 16);
            label7.TabIndex = 4;
            label7.Text = "see more..";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(209, 43);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(237, 45);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 2;
            label4.Text = "1st Main Street, Magway";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(209, 16);
            label3.Name = "label3";
            label3.Size = new Size(194, 18);
            label3.TabIndex = 1;
            label3.Text = "Spacious House for sale";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // properoverviewbtn
            // 
            properoverviewbtn.FlatAppearance.BorderSize = 0;
            properoverviewbtn.FlatStyle = FlatStyle.Flat;
            properoverviewbtn.ForeColor = Color.Gray;
            properoverviewbtn.Location = new Point(368, 19);
            properoverviewbtn.Name = "properoverviewbtn";
            properoverviewbtn.Size = new Size(94, 29);
            properoverviewbtn.TabIndex = 1;
            properoverviewbtn.Text = "View All";
            properoverviewbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "New Properties";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(249, 249, 250);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.Gray;
            searchBox.Location = new Point(258, 23);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(415, 34);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search here..";
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(227, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(25, 34);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // alertPictureBox
            // 
            alertPictureBox.Image = (Image)resources.GetObject("alertPictureBox.Image");
            alertPictureBox.Location = new Point(1093, 23);
            alertPictureBox.Name = "alertPictureBox";
            alertPictureBox.Size = new Size(74, 37);
            alertPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            alertPictureBox.TabIndex = 5;
            alertPictureBox.TabStop = false;
            // 
            // averageSalePanel
            // 
            averageSalePanel.BackColor = Color.WhiteSmoke;
            averageSalePanel.Controls.Add(pictureBox4);
            averageSalePanel.Controls.Add(label6);
            averageSalePanel.Controls.Add(label5);
            averageSalePanel.Controls.Add(salesLineGraph);
            averageSalePanel.Location = new Point(236, 270);
            averageSalePanel.Name = "averageSalePanel";
            averageSalePanel.Size = new Size(447, 518);
            averageSalePanel.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(136, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(22, 53);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 1;
            label6.Text = "$1249600";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 19);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 1;
            label5.Text = "Average Sale Values";
            // 
            // salesLineGraph
            // 
            salesLineGraph.Image = (Image)resources.GetObject("salesLineGraph.Image");
            salesLineGraph.Location = new Point(0, 94);
            salesLineGraph.Name = "salesLineGraph";
            salesLineGraph.Size = new Size(447, 424);
            salesLineGraph.SizeMode = PictureBoxSizeMode.StretchImage;
            salesLineGraph.TabIndex = 0;
            salesLineGraph.TabStop = false;
            // 
            // totalApplicationPanel
            // 
            totalApplicationPanel.BackColor = Color.WhiteSmoke;
            totalApplicationPanel.Controls.Add(pictureBox14);
            totalApplicationPanel.Controls.Add(label18);
            totalApplicationPanel.Controls.Add(label17);
            totalApplicationPanel.Controls.Add(mailBox);
            totalApplicationPanel.Location = new Point(236, 102);
            totalApplicationPanel.Name = "totalApplicationPanel";
            totalApplicationPanel.Size = new Size(271, 125);
            totalApplicationPanel.TabIndex = 7;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(67, 74);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(25, 25);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 3;
            pictureBox14.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(22, 67);
            label18.Name = "label18";
            label18.Size = new Size(48, 32);
            label18.TabIndex = 1;
            label18.Text = "18";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(28, 26);
            label17.Name = "label17";
            label17.Size = new Size(102, 20);
            label17.TabIndex = 9;
            label17.Text = "Application";
            // 
            // mailBox
            // 
            mailBox.Image = (Image)resources.GetObject("mailBox.Image");
            mailBox.Location = new Point(136, 38);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(104, 50);
            mailBox.SizeMode = PictureBoxSizeMode.Zoom;
            mailBox.TabIndex = 0;
            mailBox.TabStop = false;
            // 
            // totalPaymentsPanel
            // 
            totalPaymentsPanel.BackColor = Color.WhiteSmoke;
            totalPaymentsPanel.Controls.Add(label19);
            totalPaymentsPanel.Controls.Add(label20);
            totalPaymentsPanel.Controls.Add(moneyBox);
            totalPaymentsPanel.Location = new Point(567, 102);
            totalPaymentsPanel.Name = "totalPaymentsPanel";
            totalPaymentsPanel.Size = new Size(270, 125);
            totalPaymentsPanel.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(22, 67);
            label19.Name = "label19";
            label19.Size = new Size(142, 32);
            label19.TabIndex = 1;
            label19.Text = "$328,900";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(28, 26);
            label20.Name = "label20";
            label20.Size = new Size(139, 20);
            label20.TabIndex = 9;
            label20.Text = "Total Payments";
            // 
            // moneyBox
            // 
            moneyBox.Image = (Image)resources.GetObject("moneyBox.Image");
            moneyBox.Location = new Point(163, 38);
            moneyBox.Name = "moneyBox";
            moneyBox.Size = new Size(104, 50);
            moneyBox.SizeMode = PictureBoxSizeMode.Zoom;
            moneyBox.TabIndex = 0;
            moneyBox.TabStop = false;
            // 
            // totalPropertiesPanel
            // 
            totalPropertiesPanel.BackColor = Color.WhiteSmoke;
            totalPropertiesPanel.Controls.Add(pictureBox17);
            totalPropertiesPanel.Controls.Add(label21);
            totalPropertiesPanel.Controls.Add(label22);
            totalPropertiesPanel.Controls.Add(propertiesBox);
            totalPropertiesPanel.Location = new Point(887, 102);
            totalPropertiesPanel.Name = "totalPropertiesPanel";
            totalPropertiesPanel.Size = new Size(264, 125);
            totalPropertiesPanel.TabIndex = 7;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = (Image)resources.GetObject("pictureBox17.Image");
            pictureBox17.Location = new Point(67, 74);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(25, 25);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 3;
            pictureBox17.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(22, 67);
            label21.Name = "label21";
            label21.Size = new Size(56, 32);
            label21.TabIndex = 1;
            label21.Text = "32 ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(28, 26);
            label22.Name = "label22";
            label22.Size = new Size(144, 20);
            label22.TabIndex = 9;
            label22.Text = "Total Properties";
            // 
            // propertiesBox
            // 
            propertiesBox.Image = (Image)resources.GetObject("propertiesBox.Image");
            propertiesBox.Location = new Point(136, 38);
            propertiesBox.Name = "propertiesBox";
            propertiesBox.Size = new Size(104, 50);
            propertiesBox.SizeMode = PictureBoxSizeMode.Zoom;
            propertiesBox.TabIndex = 0;
            propertiesBox.TabStop = false;
            // 
            // SidebarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(totalPropertiesPanel);
            Controls.Add(totalPaymentsPanel);
            Controls.Add(totalApplicationPanel);
            Controls.Add(averageSalePanel);
            Controls.Add(alertPictureBox);
            Controls.Add(btnSearch);
            Controls.Add(searchBox);
            Controls.Add(PropertiesOverviewPanel);
            Controls.Add(panelNav);
            Controls.Add(sidebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SidebarForm";
            StartPosition = FormStartPosition.CenterScreen;
            
            sidebar.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            PropertiesOverviewPanel.ResumeLayout(false);
            PropertiesOverviewPanel.PerformLayout();
            house4Panel.ResumeLayout(false);
            house4Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            house3Panel.ResumeLayout(false);
            house3Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            house2Panel.ResumeLayout(false);
            house2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            house1Panel.ResumeLayout(false);
            house1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)alertPictureBox).EndInit();
            averageSalePanel.ResumeLayout(false);
            averageSalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesLineGraph).EndInit();
            totalApplicationPanel.ResumeLayout(false);
            totalApplicationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailBox).EndInit();
            totalPaymentsPanel.ResumeLayout(false);
            totalPaymentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)moneyBox).EndInit();
            totalPropertiesPanel.ResumeLayout(false);
            totalPropertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertiesBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebar;
        private Panel topPanel;
        private PictureBox userPictureBox;
        private Label loginLabel;
        private Label userlabel;
        private Button btnDashboard;
        private Button btnSetting;
        private Button btnReport;
        private Button btnPayment;
        private Button btnTenants;
        private Button btnProperties;
        private Panel panelNav;
        private Panel PropertiesOverviewPanel;
        private Panel house1Panel;
        private Label label3;
        private PictureBox pictureBox2;
        private Button properoverviewbtn;
        private Label label1;
        private Label label4;
        private TextBox searchBox;
        private Button btnSearch;
        private PictureBox alertPictureBox;
        private Panel averageSalePanel;
        private Label label5;
        private PictureBox salesLineGraph;
        private PictureBox pictureBox4;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel house4Panel;
        private Label label14;
        private PictureBox pictureBox11;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox12;
        private Panel house3Panel;
        private Label label11;
        private PictureBox pictureBox9;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox10;
        private Panel house2Panel;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox8;
        private Label label7;
        private Panel totalApplicationPanel;
        private PictureBox mailBox;
        private Label label18;
        private Label label17;
        private PictureBox pictureBox14;
        private Panel totalPaymentsPanel;
        private Label label19;
        private Label label20;
        private PictureBox moneyBox;
        private Panel totalPropertiesPanel;
        private PictureBox pictureBox17;
        private Label label21;
        private Label label22;
        private PictureBox propertiesBox;
    }
}
