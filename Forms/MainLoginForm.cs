using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentHouseMaster.Services;

namespace RentHouseMaster.Forms
{
    public partial class MainLoginForm : Form
    {

        public Point MouseLocation;
        private string userRole;
        public MainLoginForm(string role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            userRole = role;
            if (userRole == "ChuNha")
            {
                lblRole.Text = "Bạn đang đăng nhập với vai trò : Chủ Nhà " ;
            }
            else if (userRole == "Nhân Viên")
            {
                lblRole.Text = "Bạn đang đăng nhập với vai trò : Nhân Viên ";
            }
            else
            {
                lblRole.Text = "Bạn đang đăng nhập với vai trò : Khách Thuê ";
            }

        }

        public MainLoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //close the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //minimize the app
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //for movable form
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = pswBox.Text;

            if (DatabaseHelper.CheckLogin(email, password, userRole))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void forgotpswLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForgotPassword forgotPsw = new MainForgotPassword();
            forgotPsw.Show();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainRegisterForm registerForm = new MainRegisterForm();
            registerForm.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
