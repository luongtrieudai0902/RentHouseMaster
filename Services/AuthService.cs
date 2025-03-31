using RentHouseMaster.Models;
using System;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RentHouseMaster.Services
{
    public class AuthService
    {
        private static string connectionString = "Data Source=LAPTOP-IBO89B54\\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;TrustServerCertificate=True;";

        public static bool Login(UserModel user)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Email và mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Chuẩn hóa email - loại bỏ khoảng trắng
            user.Email = user.Email.Trim();

            bool isValid = false;

            // Kiểm tra xem email có tồn tại không, bất kể Role
            string checkEmailQuery = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email";

            // Truy vấn chính để lấy mật khẩu
            string passwordQuery = "SELECT PasswordHash FROM UserAccount WHERE Email = @Email AND Role = @Role";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra xem email có tồn tại không
                    bool emailExists = false;
                    using (SqlCommand cmdCheckEmail = new SqlCommand(checkEmailQuery, conn))
                    {
                        cmdCheckEmail.Parameters.AddWithValue("@Email", user.Email);
                        int count = (int)cmdCheckEmail.ExecuteScalar();
                        emailExists = (count > 0);
                    }

                    // Nếu email không tồn tại, thông báo cho người dùng
                    if (!emailExists)
                    {
                        MessageBox.Show($"Email '{user.Email}' không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    // Tiến hành kiểm tra mật khẩu
                    using (SqlCommand cmd = new SqlCommand(passwordQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Role", user.Role);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kiểm tra xem có giá trị null không
                                if (!reader.IsDBNull(0))
                                {
                                    byte[] storedPasswordBytes = (byte[])reader.GetValue(0);
                                    byte[] hashedInputPassword = HashPassword(user.Password);

                                    // So sánh mật khẩu
                                    isValid = hashedInputPassword.SequenceEqual(storedPasswordBytes);

                                    if (!isValid)
                                    {
                                        MessageBox.Show("Mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không thể xác thực vì mật khẩu trong cơ sở dữ liệu là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // Email tồn tại nhưng Role không khớp
                                MessageBox.Show($"Tài khoản này không có quyền '{user.Role}'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        public static byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // Phương thức để test kết nối đến cơ sở dữ liệu
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Kết nối đến cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}