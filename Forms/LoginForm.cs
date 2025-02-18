using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến cơ sở dữ liệu
        string connectionString = "Server=DESKTOP-72SMDCU\\ANHHAO;Database=UserInfo;Integrated Security=True;";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtSdtEmail.Text;  // Tên đăng nhập (email/SDT)
            string password = txtMatKhau.Text;  // Mật khẩu

            if (KiemTraDangNhap(username, password))
            {
                // Mở form Sidebar nếu đăng nhập thành công
                MainMenuForm menuForm = new MainMenuForm();
                menuForm.Show();

                // Đóng form đăng nhập
                this.Close();  // Thay vì Hide, dùng Close để đóng form login
            }
            else
            {
                // Nếu tên đăng nhập hoặc mật khẩu không đúng
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private bool KiemTraDangNhap(string username, string password)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM userList WHERE phoneOrEmail = @Username AND uPassWord = @Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Đảm bảo mật khẩu là đúng

                    connection.Open();
                    int userCount = (int)cmd.ExecuteScalar();

                    // Kiểm tra xem có đúng một tài khoản trùng khớp không
                    return userCount > 0;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu kết nối hoặc truy vấn bị lỗi
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return false;
                }
            }
        }

        private void linkLbQuenMK_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form Quên mật khẩu
            this.Hide();
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
        }

        private void linkLbDangKy_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form Đăng ký
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
