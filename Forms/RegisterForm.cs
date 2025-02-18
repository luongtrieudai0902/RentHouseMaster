using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RentHouseMaster.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-72SMDCU\\ANHHAO;Database=UserInfo;Integrated Security=True;";

        private void btn_DangKy(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtHovaTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDTOrEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                return;
            }

            if (!KiemTraHopLe(txtSDTOrEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc email hợp lệ.");
                return;
            }

            // Kiểm tra sự tồn tại của email/điện thoại trong cơ sở dữ liệu
            if (KiemTraTonTai(txtSDTOrEmail.Text))
            {
                MessageBox.Show("Email/Số điện thoại này đã được đăng ký.");
                return;
            }

            DangKy(txtHovaTen.Text, txtSDTOrEmail.Text, txtMatKhau.Text);
        }

        // Kiểm tra nếu email hoặc số điện thoại đã tồn tại
        private bool KiemTraTonTai(string phoneOrEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM userList WHERE phoneOrEmail = @PhoneOrEmail";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PhoneOrEmail", phoneOrEmail);

                connection.Open();
                int userCount = (int)cmd.ExecuteScalar();
                return userCount > 0;
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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Câu SQL để thêm người dùng mới
                    string query = "INSERT INTO userList (fullName, phoneOrEmail, uPassWord) " +
                                   "VALUES (@FullName, @PhoneOrEmail, @UPassword)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = fullName;
                    cmd.Parameters.Add("@PhoneOrEmail", SqlDbType.VarChar).Value = phoneOrEmail;
                    cmd.Parameters.Add("@UPassword", SqlDbType.VarChar).Value = password; // Mật khẩu không mã hóa

                    connection.Open();

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi đăng ký.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Kiểm tra lỗi trùng lặp, ví dụ như lỗi vi phạm ràng buộc UNIQUE
                        if (ex.Number == 2627 || ex.Number == 2601) // Lỗi trùng lặp khóa chính hoặc khóa duy nhất
                        {
                            MessageBox.Show("Email/Số điện thoại này đã được đăng ký.");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi kết nối: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi chung nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
