using System;
using System.Linq; // Thêm để sử dụng SequenceEqual
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Chỉ sử dụng một thư viện SqlClient

namespace RentHouseMaster.Services
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=LAPTOP-IBO89B54\\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;TrustServerCertificate=True;";

        // Phương thức kiểm tra kết nối đến CSDL
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Hàm kiểm tra đăng nhập - đã cải thiện
        public static bool CheckLogin(string email, string password, string role)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email và mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra tồn tại email trước
            if (!IsEmailExists(email))
            {
                MessageBox.Show("Email không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            bool isValid = false;
            string query = "SELECT PasswordHash FROM UserAccount WHERE Email = @Email AND Role = @Role";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim());
                        cmd.Parameters.AddWithValue("@Role", role);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kiểm tra xem có giá trị null không
                                if (!reader.IsDBNull(0))
                                {
                                    byte[] storedPasswordBytes = (byte[])reader.GetValue(0);
                                    byte[] hashedInputPassword = HashPassword(password);

                                    // Sử dụng LINQ SequenceEqual để so sánh mảng byte một cách chính xác
                                    isValid = hashedInputPassword.SequenceEqual(storedPasswordBytes);
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi: Mật khẩu trong cơ sở dữ liệu là null", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Tài khoản này không có quyền '{role}'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                if (!isValid && IsEmailExists(email))
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        // Hàm kiểm tra email đã tồn tại - đã cải thiện
        public static bool IsEmailExists(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            bool exists = false;
            string query = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim());
                        int count = (int)cmd.ExecuteScalar();
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exists;
        }

        // Hàm đăng ký tài khoản mới - đã cải thiện
        public static bool RegisterUser(string username, string email, string password, string role, string phone)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Chuẩn hóa email
            email = email.Trim();

            if (IsEmailExists(email))
            {
                MessageBox.Show("Email đã tồn tại! Vui lòng chọn email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool isRegistered = false;
            string query = "INSERT INTO UserAccount (Username, Email, PasswordHash, Role, SoDienThoai) VALUES (@Username, @Email, @Password, @Role, @Phone)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarBinary).Value = HashPassword(password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value); // Xử lý phone có thể null

                        int result = cmd.ExecuteNonQuery();
                        isRegistered = result > 0;

                        if (isRegistered)
                        {
                            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isRegistered;
        }

        // Mã hóa mật khẩu thành SHA-256 (trả về byte[])
        public static byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}