using System;
using System.Collections;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentHouseMaster.Models
{
    public class UserRepository
    {
        private static string connectionString = "Data Source=LAPTOP-IBO89B54\\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;TrustServerCertificate=True;";

        public string GetUserName(string email)
        {
            string query = "SELECT Username FROM UserAccount WHERE Email = @Email";
            string username = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader["Username"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn người dùng: " + ex.Message);
            }
            return username;
        }
        public static UserModel GetUserByEmail(string email)
        {
            UserModel user = null;
            string query = "SELECT Email, Role, Username, Phone FROM UserAccount WHERE Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new UserModel
                                {
                                    Email = reader["Email"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    Username = reader["Username"].ToString(),
                                    Phone = reader["Phone"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn người dùng: " + ex.Message);
            }
            return user;
        }
        // Lấy mật khẩu đã hash từ database
        public byte[] GetPasswordHash(string email, string role)
        {
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

                        object result = cmd.ExecuteScalar();
                        return result != null ? (byte[])result : null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy mật khẩu từ DB: " + ex.Message);
            }
        }

        // Kiểm tra email tồn tại
        public bool IsEmailExists(string email)
        {
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
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra email: " + ex.Message);
            }
        }

        // Lưu user mới vào DB
        public bool CreateUser(string username, string email, byte[] passwordHash, string role, string phone)
        {
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
                        cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarBinary, 64).Value = passwordHash;
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tạo tài khoản: " + ex.Message);
            }
        }
    }
}
