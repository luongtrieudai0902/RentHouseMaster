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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void linkLabelDN(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btn_Tieptuc(object sender, EventArgs e)
        {
            string phoneOrEmail = txtPhoneOrEmail.Text;
            string validCode = txtValidCode.Text;
            // Kiểm tra thông tin người dùng nhập vào
            if (string.IsNullOrEmpty(phoneOrEmail) || string.IsNullOrEmpty(validCode))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra thông tin người dùng trong cơ sở dữ liệu


            // Nếu thông tin hợp lệ, chuyển sang form LoginForm
            MessageBox.Show("Đăng nhập thành công!");
            this.Hide();
            var lgForm = new LoginForm();
            lgForm.Show();
        }
    }
}
