using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class MainMenu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private bool isSidebarOpen = true; // Initial state: Sidebar is open
        private const int sidebarWidthOpen = 200; // Sidebar width when open
        private const int sidebarWidthClosed = 75;
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove window border
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnProperties.Height;
            panelNav.Top = btnProperties.Top;
            panelNav.Left = btnProperties.Left;
            btnProperties.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnTenants.Height;
            panelNav.Top = btnTenants.Top;
            panelNav.Left = btnTenants.Left;
            btnTenants.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnPayments.Height;
            panelNav.Top = btnPayments.Top;
            panelNav.Left = btnPayments.Left;
            btnPayments.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnReport.Height;
            panelNav.Top = btnReport.Top;
            panelNav.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnSetting.Height;
            panelNav.Top = btnSetting.Top;
            panelNav.Left = btnSetting.Left;
            btnSetting.BackColor = Color.FromArgb(244, 246, 248);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isSidebarOpen)
            {
                // Close the sidebar
                sideBar.Width = sidebarWidthClosed;

                // Hide the text of all buttons
                btnDashboard.Text = "";
                btnProperties.Text = "";
                btnTenants.Text = "";
                btnPayments.Text = "";
                btnReport.Text = "";
                btnSetting.Text = "";
                btnClose.Text = "";

                // Adjust button alignment for icons
                btnDashboard.TextAlign = ContentAlignment.MiddleCenter;
                btnProperties.TextAlign = ContentAlignment.MiddleCenter;
                btnTenants.TextAlign = ContentAlignment.MiddleCenter;
                btnPayments.TextAlign = ContentAlignment.MiddleCenter;
                btnReport.TextAlign = ContentAlignment.MiddleCenter;
                btnSetting.TextAlign = ContentAlignment.MiddleCenter;
                btnClose.TextAlign = ContentAlignment.MiddleCenter;

                // hide proflie, username and login info
                userPanel.Visible = false;
                panelNav.Visible = false;
            }
            else
            {
                // Open the sidebar
                sideBar.Width = sidebarWidthOpen;

                // Restore the text of all buttons
                btnDashboard.Text = "Dashboard";
                btnProperties.Text = "Properties";
                btnTenants.Text = "Tenants   ";
                btnPayments.Text = "Payments";
                btnReport.Text = "Report    ";
                btnSetting.Text = "Settings ";
                btnClose.Text = "Close menu";

                // Adjust button alignment for text and icons
                btnDashboard.TextAlign = ContentAlignment.MiddleCenter;
                btnProperties.TextAlign = ContentAlignment.MiddleCenter;
                btnTenants.TextAlign = ContentAlignment.MiddleCenter;
                btnPayments.TextAlign = ContentAlignment.MiddleCenter;
                btnReport.TextAlign = ContentAlignment.MiddleCenter;
                btnSetting.TextAlign = ContentAlignment.MiddleCenter;
                btnClose.TextAlign = ContentAlignment.MiddleCenter;

                // show proflie, username and login info
                userPanel.Visible = true;
                panelNav.Visible = true;
            }

            // Toggle the state
            isSidebarOpen = !isSidebarOpen;
        }
    }
}
