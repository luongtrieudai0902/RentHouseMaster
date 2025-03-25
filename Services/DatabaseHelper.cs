using System;
using System.Collections;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Import để hiển thị lỗi

namespace RentHouseMaster.Services
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=DESKTOP-NL1J62Q\\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;TrustServerCertificate=True;";

        // ✅ Hàm kiểm tra đăng nhập
        public static bool CheckLogin(string email, string password, string role)
        {
            bool isValid = false;
            string query = "SELECT PasswordHash FROM UserAccount WHERE Email = @Email AND Role = @Role";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Role", role);

                        object storedPasswordHash = cmd.ExecuteScalar();

                        if (storedPasswordHash != null)
                        {
                            byte[] hashedInputPassword = HashPassword(password);

                            // Chuyển đổi storedPasswordHash từ object về byte[]
                            byte[] storedPasswordBytes = (byte[])storedPasswordHash;

                            // So sánh từng byte
                            isValid = StructuralComparisons.StructuralEqualityComparer.Equals(hashedInputPassword, storedPasswordBytes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CheckLogin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        // ✅ Hàm kiểm tra email đã tồn tại
        public static bool IsEmailExists(string email)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
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

        // ✅ Hàm đăng ký tài khoản mới
        public static bool RegisterUser(string username, string email, string password, string role, string phone)
        {
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
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarBinary, 64).Value = HashPassword(password); // Sửa lỗi kiểu dữ liệu
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        int result = cmd.ExecuteNonQuery();
                        isRegistered = result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RegisterUser: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isRegistered;
        }


        // ✅ Mã hóa mật khẩu thành SHA-256 (trả về byte[])
        public static byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
