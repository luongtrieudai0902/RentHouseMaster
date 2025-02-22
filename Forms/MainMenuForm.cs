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
        public Point MouseLocation;
        public MainMenuForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove window border

        }

        //close the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maximize the app
        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //minimize the app
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //highlight the button when it's clicked
        private void btn_Hover(Button clickedBtn)
        {
            // Reset all buttons to default color
            ResetButtonColors();

            // Highlight the clicked button
            clickedBtn.BackColor = Color.FromArgb(50, 105, 232);
            clickedBtn.ForeColor = Color.White;
        }

        // Reset all buttons to default color
        private void ResetButtonColors()
        {
            btnDangkyLuuTru.BackColor = Color.White;
            btnDangkyLuuTru.ForeColor = Color.Black;

            btnQuanlyPhong.BackColor = Color.White;
            btnQuanlyPhong.ForeColor = Color.Black;

            btnQuanlyDienNuoc.BackColor = Color.White;
            btnQuanlyDienNuoc.ForeColor = Color.Black;

            btnQuanlyDichVu.BackColor = Color.White;
            btnQuanlyDichVu.ForeColor = Color.Black;
        }


        //quan ly luu tru button click event (main button)
        private void btnQuanlyLuuTru_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnQuanlyLuuTru.Height;
            panelNav.Top = btnQuanlyLuuTru.Top;
            panelNav.Left = btnQuanlyLuuTru.Left;
            btnDangkyLuuTru.Visible = !btnDangkyLuuTru.Visible;
            btnQuanlyPhong.Visible = !btnQuanlyPhong.Visible;
            btnQuanlyDienNuoc.Visible = !btnQuanlyDienNuoc.Visible;
            btnQuanlyDichVu.Visible = !btnQuanlyDichVu.Visible;
        }

        //all the menu buttons under the quan ly luu tru buttons
        private void btnDangkyLuuTru_Click(object sender, EventArgs e)
        {
            btn_Hover((Button)sender);
        }

        private void btnQuanlyPhong_Click(object sender, EventArgs e)
        {
            btn_Hover((Button)sender);
        }

        private void btnQuanlyDienNuoc_Click(object sender, EventArgs e)
        {
            btn_Hover((Button)sender);
        }

        private void btnQuanlyDichVu_Click(object sender, EventArgs e)
        {
            btn_Hover((Button)sender);
        }

        //logout button click event
        private void btnDangxuat_Click(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newMousePoint = Control.MousePosition;
                newMousePoint.Offset(MouseLocation.X, MouseLocation.Y);
                Location = newMousePoint;
            }
        }
    }
}
