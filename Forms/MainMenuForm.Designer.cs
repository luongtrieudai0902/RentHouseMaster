namespace RentHouseMaster.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            panelMenu = new Panel();
            panelMenuBtn = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnMaximize = new Button();
            labelMenu = new Label();
            logoBox = new PictureBox();
            sidebarPanel = new Panel();
            logoutBtn = new Button();
            panelForHelp = new Panel();
            helpBtn = new Button();
            subPanelForTools = new Panel();
            printBtn = new Button();
            panelForTools = new Panel();
            expandPicforTools = new PictureBox();
            manageToolsBtn = new Button();
            subPanelForServices = new Panel();
            requestBtn = new Button();
            manageTransportationBtn = new Button();
            manageOtherServicesBtn = new Button();
            manageElectricsBtn = new Button();
            panelforServices = new Panel();
            expandPicServices = new PictureBox();
            manageServicesBtn = new Button();
            subPanelForAccomo = new Panel();
            manageRoomBtn = new Button();
            registerAccomoBtn = new Button();
            PanelForAccomo = new Panel();
            expandPicAccomo = new PictureBox();
            manageAccomoBtn = new Button();
            panelForHome = new Panel();
            homeBtn = new Button();
            searchBarPanel = new Panel();
            searchBar = new Panel();
            searchBox = new TextBox();
            searchPic = new PictureBox();
            userProfilePanel = new Panel();
            lblEmail = new Label();
            lblUsername = new Label();
            userPic = new PictureBox();
            contentPanel = new Panel();
            panelMenu.SuspendLayout();
            panelMenuBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            sidebarPanel.SuspendLayout();
            panelForHelp.SuspendLayout();
            subPanelForTools.SuspendLayout();
            panelForTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPicforTools).BeginInit();
            subPanelForServices.SuspendLayout();
            panelforServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPicServices).BeginInit();
            subPanelForAccomo.SuspendLayout();
            PanelForAccomo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPicAccomo).BeginInit();
            panelForHome.SuspendLayout();
            searchBarPanel.SuspendLayout();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(panelMenuBtn);
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Controls.Add(logoBox);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1422, 65);
            panelMenu.TabIndex = 1;
            panelMenu.MouseDown += mouse_Down;
            panelMenu.MouseMove += mouse_Move;
            // 
            // panelMenuBtn
            // 
            panelMenuBtn.Controls.Add(btnMinimize);
            panelMenuBtn.Controls.Add(btnClose);
            panelMenuBtn.Controls.Add(btnMaximize);
            panelMenuBtn.Dock = DockStyle.Right;
            panelMenuBtn.Location = new Point(1189, 0);
            panelMenuBtn.Name = "panelMenuBtn";
            panelMenuBtn.Size = new Size(233, 65);
            panelMenuBtn.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(49, 22);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(178, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(119, 24);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(20, 20);
            btnMaximize.TabIndex = 4;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(99, 22);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(145, 23);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "RentHouseMaster";
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.Logo;
            logoBox.Location = new Point(22, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(40, 40);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.White;
            sidebarPanel.Controls.Add(logoutBtn);
            sidebarPanel.Controls.Add(panelForHelp);
            sidebarPanel.Controls.Add(subPanelForTools);
            sidebarPanel.Controls.Add(panelForTools);
            sidebarPanel.Controls.Add(subPanelForServices);
            sidebarPanel.Controls.Add(panelforServices);
            sidebarPanel.Controls.Add(subPanelForAccomo);
            sidebarPanel.Controls.Add(PanelForAccomo);
            sidebarPanel.Controls.Add(panelForHome);
            sidebarPanel.Controls.Add(searchBarPanel);
            sidebarPanel.Controls.Add(userProfilePanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 65);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(250, 912);
            sidebarPanel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(217, 217, 217);
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Image = Properties.Resources.Logout;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 862);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(20, 0, 0, 0);
            logoutBtn.Size = new Size(250, 50);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // panelForHelp
            // 
            panelForHelp.Controls.Add(helpBtn);
            panelForHelp.Dock = DockStyle.Top;
            panelForHelp.Location = new Point(0, 703);
            panelForHelp.Name = "panelForHelp";
            panelForHelp.Size = new Size(250, 50);
            panelForHelp.TabIndex = 9;
            // 
            // helpBtn
            // 
            helpBtn.Dock = DockStyle.Fill;
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Image = (Image)resources.GetObject("helpBtn.Image");
            helpBtn.ImageAlign = ContentAlignment.MiddleLeft;
            helpBtn.Location = new Point(0, 0);
            helpBtn.Name = "helpBtn";
            helpBtn.Padding = new Padding(20, 0, 0, 0);
            helpBtn.Size = new Size(250, 50);
            helpBtn.TabIndex = 19;
            helpBtn.Text = "Cần hỗ trợ?";
            helpBtn.TextAlign = ContentAlignment.MiddleLeft;
            helpBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            helpBtn.UseVisualStyleBackColor = true;
            helpBtn.Click += helpBtn_Click;
            // 
            // subPanelForTools
            // 
            subPanelForTools.Controls.Add(printBtn);
            subPanelForTools.Dock = DockStyle.Top;
            subPanelForTools.Location = new Point(0, 653);
            subPanelForTools.Name = "subPanelForTools";
            subPanelForTools.Size = new Size(250, 50);
            subPanelForTools.TabIndex = 8;
            // 
            // printBtn
            // 
            printBtn.Dock = DockStyle.Fill;
            printBtn.FlatAppearance.BorderSize = 0;
            printBtn.FlatStyle = FlatStyle.Flat;
            printBtn.Image = (Image)resources.GetObject("printBtn.Image");
            printBtn.ImageAlign = ContentAlignment.MiddleLeft;
            printBtn.Location = new Point(0, 0);
            printBtn.Name = "printBtn";
            printBtn.Padding = new Padding(20, 0, 0, 0);
            printBtn.Size = new Size(250, 50);
            printBtn.TabIndex = 18;
            printBtn.Text = "Thông kê, in ấn, xuất file";
            printBtn.TextAlign = ContentAlignment.MiddleLeft;
            printBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // panelForTools
            // 
            panelForTools.Controls.Add(expandPicforTools);
            panelForTools.Controls.Add(manageToolsBtn);
            panelForTools.Dock = DockStyle.Top;
            panelForTools.Location = new Point(0, 603);
            panelForTools.Name = "panelForTools";
            panelForTools.Size = new Size(250, 50);
            panelForTools.TabIndex = 7;
            // 
            // expandPicforTools
            // 
            expandPicforTools.Dock = DockStyle.Right;
            expandPicforTools.Image = Properties.Resources.expend;
            expandPicforTools.Location = new Point(228, 0);
            expandPicforTools.Name = "expandPicforTools";
            expandPicforTools.Size = new Size(22, 50);
            expandPicforTools.SizeMode = PictureBoxSizeMode.Zoom;
            expandPicforTools.TabIndex = 22;
            expandPicforTools.TabStop = false;
            // 
            // manageToolsBtn
            // 
            manageToolsBtn.Dock = DockStyle.Left;
            manageToolsBtn.FlatAppearance.BorderSize = 0;
            manageToolsBtn.FlatStyle = FlatStyle.Flat;
            manageToolsBtn.Image = (Image)resources.GetObject("manageToolsBtn.Image");
            manageToolsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageToolsBtn.Location = new Point(0, 0);
            manageToolsBtn.Name = "manageToolsBtn";
            manageToolsBtn.Padding = new Padding(20, 0, 0, 0);
            manageToolsBtn.Size = new Size(225, 50);
            manageToolsBtn.TabIndex = 21;
            manageToolsBtn.Text = "Công cụ tiện ích";
            manageToolsBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageToolsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageToolsBtn.UseVisualStyleBackColor = true;
            manageToolsBtn.Click += manageToolsBtn_Click;
            // 
            // subPanelForServices
            // 
            subPanelForServices.Controls.Add(requestBtn);
            subPanelForServices.Controls.Add(manageTransportationBtn);
            subPanelForServices.Controls.Add(manageOtherServicesBtn);
            subPanelForServices.Controls.Add(manageElectricsBtn);
            subPanelForServices.Dock = DockStyle.Top;
            subPanelForServices.Location = new Point(0, 403);
            subPanelForServices.Name = "subPanelForServices";
            subPanelForServices.Size = new Size(250, 200);
            subPanelForServices.TabIndex = 6;
            // 
            // requestBtn
            // 
            requestBtn.Dock = DockStyle.Top;
            requestBtn.FlatAppearance.BorderSize = 0;
            requestBtn.FlatStyle = FlatStyle.Flat;
            requestBtn.Image = (Image)resources.GetObject("requestBtn.Image");
            requestBtn.ImageAlign = ContentAlignment.MiddleLeft;
            requestBtn.Location = new Point(0, 150);
            requestBtn.Name = "requestBtn";
            requestBtn.Padding = new Padding(20, 0, 0, 0);
            requestBtn.Size = new Size(250, 50);
            requestBtn.TabIndex = 20;
            requestBtn.Text = "Yêu cầu/phản ánh";
            requestBtn.TextAlign = ContentAlignment.MiddleLeft;
            requestBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            requestBtn.UseVisualStyleBackColor = true;
            requestBtn.Click += requestBtn_Click;
            // 
            // manageTransportationBtn
            // 
            manageTransportationBtn.Dock = DockStyle.Top;
            manageTransportationBtn.FlatAppearance.BorderSize = 0;
            manageTransportationBtn.FlatStyle = FlatStyle.Flat;
            manageTransportationBtn.Image = (Image)resources.GetObject("manageTransportationBtn.Image");
            manageTransportationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageTransportationBtn.Location = new Point(0, 100);
            manageTransportationBtn.Name = "manageTransportationBtn";
            manageTransportationBtn.Padding = new Padding(20, 0, 0, 0);
            manageTransportationBtn.Size = new Size(250, 50);
            manageTransportationBtn.TabIndex = 19;
            manageTransportationBtn.Text = "Quản lý phương tiện";
            manageTransportationBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageTransportationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageTransportationBtn.UseVisualStyleBackColor = true;
            manageTransportationBtn.Click += manageTransportationBtn_Click;
            // 
            // manageOtherServicesBtn
            // 
            manageOtherServicesBtn.Dock = DockStyle.Top;
            manageOtherServicesBtn.FlatAppearance.BorderSize = 0;
            manageOtherServicesBtn.FlatStyle = FlatStyle.Flat;
            manageOtherServicesBtn.Image = (Image)resources.GetObject("manageOtherServicesBtn.Image");
            manageOtherServicesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageOtherServicesBtn.Location = new Point(0, 50);
            manageOtherServicesBtn.Name = "manageOtherServicesBtn";
            manageOtherServicesBtn.Padding = new Padding(20, 0, 0, 0);
            manageOtherServicesBtn.Size = new Size(250, 50);
            manageOtherServicesBtn.TabIndex = 15;
            manageOtherServicesBtn.Text = "Quản lý dịch vụ khác";
            manageOtherServicesBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageOtherServicesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageOtherServicesBtn.UseVisualStyleBackColor = true;
            manageOtherServicesBtn.Click += manageOtherServicesBtn_Click;
            // 
            // manageElectricsBtn
            // 
            manageElectricsBtn.Dock = DockStyle.Top;
            manageElectricsBtn.FlatAppearance.BorderSize = 0;
            manageElectricsBtn.FlatStyle = FlatStyle.Flat;
            manageElectricsBtn.Image = (Image)resources.GetObject("manageElectricsBtn.Image");
            manageElectricsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageElectricsBtn.Location = new Point(0, 0);
            manageElectricsBtn.Name = "manageElectricsBtn";
            manageElectricsBtn.Padding = new Padding(20, 0, 0, 0);
            manageElectricsBtn.Size = new Size(250, 50);
            manageElectricsBtn.TabIndex = 13;
            manageElectricsBtn.Text = "Quản lý chỉ số điện/nước";
            manageElectricsBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageElectricsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageElectricsBtn.UseVisualStyleBackColor = true;
            manageElectricsBtn.Click += manageElectricsBtn_Click;
            // 
            // panelforServices
            // 
            panelforServices.Controls.Add(expandPicServices);
            panelforServices.Controls.Add(manageServicesBtn);
            panelforServices.Dock = DockStyle.Top;
            panelforServices.Location = new Point(0, 353);
            panelforServices.Name = "panelforServices";
            panelforServices.Size = new Size(250, 50);
            panelforServices.TabIndex = 5;
            // 
            // expandPicServices
            // 
            expandPicServices.Dock = DockStyle.Right;
            expandPicServices.Image = Properties.Resources.expend;
            expandPicServices.Location = new Point(228, 0);
            expandPicServices.Name = "expandPicServices";
            expandPicServices.Size = new Size(22, 50);
            expandPicServices.SizeMode = PictureBoxSizeMode.Zoom;
            expandPicServices.TabIndex = 0;
            expandPicServices.TabStop = false;
            // 
            // manageServicesBtn
            // 
            manageServicesBtn.Dock = DockStyle.Left;
            manageServicesBtn.FlatAppearance.BorderSize = 0;
            manageServicesBtn.FlatStyle = FlatStyle.Flat;
            manageServicesBtn.Image = (Image)resources.GetObject("manageServicesBtn.Image");
            manageServicesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageServicesBtn.Location = new Point(0, 0);
            manageServicesBtn.Name = "manageServicesBtn";
            manageServicesBtn.Padding = new Padding(20, 0, 0, 0);
            manageServicesBtn.Size = new Size(225, 50);
            manageServicesBtn.TabIndex = 17;
            manageServicesBtn.Text = "Quản lý dịch vụ";
            manageServicesBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageServicesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageServicesBtn.UseVisualStyleBackColor = true;
            manageServicesBtn.Click += manageServicesBtn_Click;
            // 
            // subPanelForAccomo
            // 
            subPanelForAccomo.Controls.Add(manageRoomBtn);
            subPanelForAccomo.Controls.Add(registerAccomoBtn);
            subPanelForAccomo.Dock = DockStyle.Top;
            subPanelForAccomo.Location = new Point(0, 253);
            subPanelForAccomo.Name = "subPanelForAccomo";
            subPanelForAccomo.Size = new Size(250, 100);
            subPanelForAccomo.TabIndex = 4;
            // 
            // manageRoomBtn
            // 
            manageRoomBtn.Dock = DockStyle.Top;
            manageRoomBtn.FlatAppearance.BorderSize = 0;
            manageRoomBtn.FlatStyle = FlatStyle.Flat;
            manageRoomBtn.Image = (Image)resources.GetObject("manageRoomBtn.Image");
            manageRoomBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageRoomBtn.Location = new Point(0, 50);
            manageRoomBtn.Name = "manageRoomBtn";
            manageRoomBtn.Padding = new Padding(20, 0, 0, 0);
            manageRoomBtn.Size = new Size(250, 50);
            manageRoomBtn.TabIndex = 14;
            manageRoomBtn.Text = "Quản lý nhà/hợp đồng";
            manageRoomBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageRoomBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageRoomBtn.UseVisualStyleBackColor = true;
            manageRoomBtn.Click += manageRoomBtn_Click;
            // 
            // registerAccomoBtn
            // 
            registerAccomoBtn.Dock = DockStyle.Top;
            registerAccomoBtn.FlatAppearance.BorderSize = 0;
            registerAccomoBtn.FlatStyle = FlatStyle.Flat;
            registerAccomoBtn.Image = (Image)resources.GetObject("registerAccomoBtn.Image");
            registerAccomoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerAccomoBtn.Location = new Point(0, 0);
            registerAccomoBtn.Name = "registerAccomoBtn";
            registerAccomoBtn.Padding = new Padding(20, 0, 0, 0);
            registerAccomoBtn.Size = new Size(250, 50);
            registerAccomoBtn.TabIndex = 12;
            registerAccomoBtn.Text = "Đăng ký lưu trú";
            registerAccomoBtn.TextAlign = ContentAlignment.MiddleLeft;
            registerAccomoBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            registerAccomoBtn.UseVisualStyleBackColor = true;
            registerAccomoBtn.Click += registerAccomoBtn_Click;
            // 
            // PanelForAccomo
            // 
            PanelForAccomo.Controls.Add(expandPicAccomo);
            PanelForAccomo.Controls.Add(manageAccomoBtn);
            PanelForAccomo.Dock = DockStyle.Top;
            PanelForAccomo.Location = new Point(0, 203);
            PanelForAccomo.Name = "PanelForAccomo";
            PanelForAccomo.Size = new Size(250, 50);
            PanelForAccomo.TabIndex = 3;
            // 
            // expandPicAccomo
            // 
            expandPicAccomo.Dock = DockStyle.Right;
            expandPicAccomo.Image = Properties.Resources.expend;
            expandPicAccomo.Location = new Point(228, 0);
            expandPicAccomo.Name = "expandPicAccomo";
            expandPicAccomo.Size = new Size(22, 50);
            expandPicAccomo.SizeMode = PictureBoxSizeMode.Zoom;
            expandPicAccomo.TabIndex = 17;
            expandPicAccomo.TabStop = false;
            // 
            // manageAccomoBtn
            // 
            manageAccomoBtn.Dock = DockStyle.Left;
            manageAccomoBtn.FlatAppearance.BorderSize = 0;
            manageAccomoBtn.FlatStyle = FlatStyle.Flat;
            manageAccomoBtn.Image = (Image)resources.GetObject("manageAccomoBtn.Image");
            manageAccomoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageAccomoBtn.Location = new Point(0, 0);
            manageAccomoBtn.Name = "manageAccomoBtn";
            manageAccomoBtn.Padding = new Padding(20, 0, 0, 0);
            manageAccomoBtn.Size = new Size(225, 50);
            manageAccomoBtn.TabIndex = 16;
            manageAccomoBtn.Text = "Quản lý lưu trú";
            manageAccomoBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageAccomoBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageAccomoBtn.UseVisualStyleBackColor = true;
            manageAccomoBtn.Click += manageAccomoBtn_Click;
            // 
            // panelForHome
            // 
            panelForHome.Controls.Add(homeBtn);
            panelForHome.Dock = DockStyle.Top;
            panelForHome.Location = new Point(0, 153);
            panelForHome.Name = "panelForHome";
            panelForHome.Size = new Size(250, 50);
            panelForHome.TabIndex = 2;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Fill;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Image = Properties.Resources.home;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(20, 0, 0, 0);
            homeBtn.Size = new Size(250, 50);
            homeBtn.TabIndex = 11;
            homeBtn.Text = "Trang chủ";
            homeBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // searchBarPanel
            // 
            searchBarPanel.Controls.Add(searchBar);
            searchBarPanel.Dock = DockStyle.Top;
            searchBarPanel.Location = new Point(0, 88);
            searchBarPanel.Name = "searchBarPanel";
            searchBarPanel.Size = new Size(250, 65);
            searchBarPanel.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Controls.Add(searchBox);
            searchBar.Controls.Add(searchPic);
            searchBar.Location = new Point(3, 6);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(241, 53);
            searchBar.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Location = new Point(49, 16);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Tìm kiếm mực";
            searchBox.Size = new Size(186, 20);
            searchBox.TabIndex = 1;
            // 
            // searchPic
            // 
            searchPic.Image = (Image)resources.GetObject("searchPic.Image");
            searchPic.Location = new Point(18, 13);
            searchPic.Name = "searchPic";
            searchPic.Size = new Size(25, 25);
            searchPic.SizeMode = PictureBoxSizeMode.Zoom;
            searchPic.TabIndex = 0;
            searchPic.TabStop = false;
            // 
            // userProfilePanel
            // 
            userProfilePanel.Controls.Add(lblEmail);
            userProfilePanel.Controls.Add(lblUsername);
            userProfilePanel.Controls.Add(userPic);
            userProfilePanel.Dock = DockStyle.Top;
            userProfilePanel.Location = new Point(0, 0);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(250, 88);
            userProfilePanel.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.ForeColor = Color.DarkGray;
            lblEmail.Location = new Point(94, 52);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(121, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "vidu@gmail.com";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(94, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "User Name";
            // 
            // userPic
            // 
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.Location = new Point(22, 22);
            userPic.Name = "userPic";
            userPic.Size = new Size(50, 50);
            userPic.SizeMode = PictureBoxSizeMode.CenterImage;
            userPic.TabIndex = 0;
            userPic.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(250, 65);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1172, 912);
            contentPanel.TabIndex = 3;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelMenuBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            sidebarPanel.ResumeLayout(false);
            panelForHelp.ResumeLayout(false);
            subPanelForTools.ResumeLayout(false);
            panelForTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandPicforTools).EndInit();
            subPanelForServices.ResumeLayout(false);
            panelforServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandPicServices).EndInit();
            subPanelForAccomo.ResumeLayout(false);
            PanelForAccomo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandPicAccomo).EndInit();
            panelForHome.ResumeLayout(false);
            searchBarPanel.ResumeLayout(false);
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            userProfilePanel.ResumeLayout(false);
            userProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private PictureBox logoBox;
        private Label labelMenu;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Panel panelMenuBtn;
        private Panel sidebarPanel;
        private Panel contentPanel;
        private Panel userProfilePanel;
        private Panel panelForHome;
        private Panel searchBarPanel;
        private Button logoutBtn;
        private Panel panelForHelp;
        private Panel subPanelForTools;
        private Panel panelForTools;
        private Panel subPanelForServices;
        private Panel panelforServices;
        private Panel subPanelForAccomo;
        private Panel PanelForAccomo;
        private Button manageToolsBtn;
        private Button requestBtn;
        private Button manageTransportationBtn;
        private Button printBtn;
        private Button manageServicesBtn;
        private Button manageAccomoBtn;
        private Button manageOtherServicesBtn;
        private Button manageRoomBtn;
        private Button manageElectricsBtn;
        private Button registerAccomoBtn;
        private Button homeBtn;
        private Button helpBtn;
        private PictureBox expandPicforTools;
        private PictureBox expandPicServices;
        private PictureBox expandPicAccomo;
        private Panel searchBar;
        private TextBox searchBox;
        private PictureBox searchPic;
        private Label lblEmail;
        private Label lblUsername;
        private PictureBox userPic;
    }
}