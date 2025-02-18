using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class MainMenuForm : Form
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
        public MainMenuForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove window border
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnQuanlyLuuTru_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnQuanlyLuuTru.Height;
            panelNav.Top = btnQuanlyLuuTru.Top;
            panelNav.Left = btnQuanlyLuuTru.Left;
            btnDangkyLuuTru.Visible = !btnDangkyLuuTru.Visible;
        }

        private void btnDangkyLuuTru_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanlyPhong_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnQuanlyPhong.Height;
            panelNav.Top = btnQuanlyPhong.Top;
            panelNav.Left = btnQuanlyPhong.Left;
            
        }

        private void btnQuanlyDienNuoc_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnQuanlyDienNuoc.Height;
            panelNav.Top = btnQuanlyDienNuoc.Top;
            panelNav.Left = btnQuanlyDienNuoc.Left;
        }

        private void btnQuanlyDichVu_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnQuanlyDichVu.Height;
            panelNav.Top = btnQuanlyDichVu.Top;
            panelNav.Left = btnQuanlyDichVu.Left;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {

        }
    }
}
