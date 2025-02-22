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

        string connectionString = "Server=DESKTOP-72SMDCU\\ANHHAO;Database=UserInfo;Integrated Security=True;TrustServerCertificate=True;";

        SqlConnection sqlConnection = null;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string username = txtSdtEmail.Text;
                string password = txtMatKhau.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                if (!KiemTraDangNhap(username, password))
                {
                    MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng!");
                    return;
                }

                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private bool KiemTraDangNhap(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM userList WHERE phoneOrEmail = @Username AND uPassWord = @Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int userCount = (int)cmd.ExecuteScalar();

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
            this.Hide();
            SendCodeForm sendCodeForm = new SendCodeForm();
            sendCodeForm.Show();
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
