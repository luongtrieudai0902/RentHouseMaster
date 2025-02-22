using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace RentHouseMaster.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến cơ sở dữ liệu
        string connectionString = "Server=DESKTOP-72SMDCU\\ANHHAO;Database=UserInfo;Integrated Security=True;TrustServerCertificate=True;";

        SqlConnection sqlConnection = null;

        //string connectionString = "Server=DESKTOP-72SMDCU\\ANHHAO;Database=UserInfo;Integrated Security=True;";

        private void btn_DangKy(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string fullName = txtHovaTen.Text;
                string phoneOrEmail = txtSDTEmail.Text;
                string password = txtMatKhau.Text;

                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneOrEmail) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                if (!KiemTraHopLe(phoneOrEmail))
                {
                    MessageBox.Show("Email hoặc số điện thoại không hợp lệ!");
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                if (KiemTraTonTai(phoneOrEmail))
                {
                    MessageBox.Show("Email hoặc số điện thoại này đã được đăng ký!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                DangKy(fullName, phoneOrEmail, password);
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Kiểm tra nếu email hoặc số điện thoại đã tồn tại
        private bool KiemTraTonTai(string phoneOrEmail)
        {
            string query = "SELECT COUNT(*) FROM userList WHERE phoneOrEmail = @PhoneOrEmail";
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@PhoneOrEmail", phoneOrEmail);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Kiểm tra tính hợp lệ của email hoặc số điện thoại
        private bool KiemTraHopLe(string sdtOrEmail)
        {
            return EmailHopLe(sdtOrEmail) || SdtHopLe(sdtOrEmail);
        }

        //
        private bool EmailHopLe(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        //
        private bool SdtHopLe(string phone)
        {
            string phonePattern = @"^\d{10,15}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        // Thêm một người dùng mới vào cơ sở dữ liệu
        private void DangKy(string fullName, string phoneOrEmail, string password)
        {
            string query = "INSERT INTO userList (fullName, phoneOrEmail, uPassWord) VALUES (@FullName, @PhoneOrEmail, @Password)";
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@PhoneOrEmail", phoneOrEmail);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
            }
        }

        // "Tôi đã có tài khoản"
        private void LinkLbDangNhap(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
