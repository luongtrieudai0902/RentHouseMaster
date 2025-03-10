using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentHouseMaster.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công!");
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();

            mainMenuForm.Show();
        }

        private void linkLbQuenMK_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SendCodeForm sendCodeForm = new SendCodeForm();
            sendCodeForm.Show();
        }

        private void linkLbDangKy_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
 