using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sidebar
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove window border
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(244, 246, 248);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnPayment.Height;
            panelNav.Top = btnPayment.Top;
            panelNav.Left = btnPayment.Left;
            btnPayment.BackColor = Color.FromArgb(244, 246, 248);
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
            btnSetting.BackColor = Color.FromArgb(244,246,248);
        }

        
    }
}
