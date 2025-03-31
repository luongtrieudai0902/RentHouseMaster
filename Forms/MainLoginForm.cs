using RentHouseMaster.Models;
using RentHouseMaster.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class MainLoginForm : Form
    {
        private string userRole;

        public MainLoginForm(string role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            userRole = role;

            lblRole.Text = role switch
            {
                "ChuNha" => "Bạn đang đăng nhập với vai trò: Chủ Nhà",
                "NhanVien" => "Bạn đang đăng nhập với vai trò: Nhân Viên",
                _ => "Bạn đang đăng nhập với vai trò: Khách Thuê"
            };
        }

        public MainLoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserRepository userRepo = new UserRepository();

            UserModel user = new UserModel
            {
                Username = userRepo.GetUserName(emailBox.Text),
                Email = emailBox.Text,
                Password = pswBox.Text,
                Role = userRole
            };

            if (AuthService.Login(user))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
                MainMenuForm mainMenuForm = new MainMenuForm(user);
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
    }
}
