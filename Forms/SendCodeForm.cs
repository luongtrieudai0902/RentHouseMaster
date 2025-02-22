using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class SendCodeForm : Form
    {
        public SendCodeForm()
        {
            InitializeComponent();
        }
        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string phoneOrEmail = txtSDTEmail.Text;
            if (string.IsNullOrEmpty(phoneOrEmail))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc email!");
                return;
            }
            MessageBox.Show("Đã gửi mã đăng nhập, hãy kiểm tra hộp thư của bạn!");
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}