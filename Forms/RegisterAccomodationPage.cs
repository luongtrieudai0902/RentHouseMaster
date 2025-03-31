using Microsoft.Data.SqlClient;
using RentHouseMaster.Models;
using RentHouseMaster.Services;
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
    public partial class RegisterAccomodationPage : Form
    {
        private readonly GuestService _guestService;
        private readonly AccommodationService _accommodationService;

        public RegisterAccomodationPage()
        {
            InitializeComponent();
            _guestService = new GuestService();
            _accommodationService = new AccommodationService();

            // Khởi tạo dữ liệu cho các combobox
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Combo box giới tính
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.Items.Add("Khác");

            // Combo box loại giấy tờ
            cboIdType.Items.Add("CCCD");
            cboIdType.Items.Add("CMND");
            cboIdType.Items.Add("Hộ chiếu");

            // Các combobox quốc tịch
            cboNationality.Items.Add("Việt Nam");
            cboNationality.Items.Add("Nước ngoài");
            // Có thể thêm các quốc tịch phổ biến nếu cần
            cboNationality.Items.Add("Trung Quốc");
            cboNationality.Items.Add("Hàn Quốc");
            cboNationality.Items.Add("Nhật Bản");
            cboNationality.Items.Add("Mỹ");

            // Các tỉnh/thành phố phổ biến của Việt Nam
            cboProvince.Items.Add("Hà Nội");
            cboProvince.Items.Add("TP. Hồ Chí Minh");
            cboProvince.Items.Add("Đà Nẵng");
            cboProvince.Items.Add("Hải Phòng");
            cboProvince.Items.Add("Cần Thơ");
            cboProvince.Items.Add("Hải Dương");
            cboProvince.Items.Add("Bình Dương");
            cboProvince.Items.Add("Đồng Nai");

            // Các quận/huyện mẫu
            // Trong thực tế, dữ liệu này nên thay đổi dựa vào Tỉnh/TP được chọn
            cboDistrict.Items.Add("Quận 1");
            cboDistrict.Items.Add("Quận 2");
            cboDistrict.Items.Add("Quận 3");
            cboDistrict.Items.Add("Huyện A");
            cboDistrict.Items.Add("Huyện B");
            cboDistrict.Items.Add("Thị xã C");

            // Các xã/phường/thị trấn mẫu
            // Trong thực tế, dữ liệu này nên thay đổi dựa vào Quận/Huyện được chọn
            cboWard.Items.Add("Phường X");
            cboWard.Items.Add("Phường Y");
            cboWard.Items.Add("Phường Z");
            cboWard.Items.Add("Xã A");
            cboWard.Items.Add("Xã B");
            cboWard.Items.Add("Thị trấn C");

            // Combobox cơ sở lưu trú
            cboAccommodationPlace.Items.Add("Khách sạn A");
            cboAccommodationPlace.Items.Add("Khách sạn B");
            cboAccommodationPlace.Items.Add("Nhà nghỉ C");

            // Combobox phòng
            cboRoom.Items.Add("101");
            cboRoom.Items.Add("102");
            cboRoom.Items.Add("201");
            cboRoom.Items.Add("202");

            // Thiết lập giá trị mặc định cho các combobox để tránh lỗi null
            cboGender.SelectedIndex = 0;
            cboIdType.SelectedIndex = 0;
            cboNationality.SelectedIndex = 0;
            cboProvince.SelectedIndex = 0;
            cboDistrict.SelectedIndex = 0;
            cboWard.SelectedIndex = 0;
            cboAccommodationPlace.SelectedIndex = 0;
            cboRoom.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng kí rồi nè");
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (!ValidateInputs())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng khách lưu trú
                Guest guest = new Guest
                {
                    FullName = txtFullName.Text.Trim(),
                    Gender = cboGender.SelectedItem?.ToString() ?? "",
                    BirthDate = dtpBirthDate.Value,
                    IdType = cboIdType.SelectedItem?.ToString() ?? "",
                    IdNumber = txtIdNumber.Text.Trim(),
                    Nationality = cboNationality.SelectedItem?.ToString() ?? "",
                    Province = cboProvince.SelectedItem?.ToString() ?? "",
                    District = cboDistrict.SelectedItem?.ToString() ?? "",
                    Ward = cboWard.SelectedItem?.ToString() ?? "",
                    Address = txtAddress.Text.Trim()
                };

                // Kiểm tra xem khách đã tồn tại chưa (dựa vào số giấy tờ)
                int guestId;
                if (_guestService.CheckGuestExists(guest.IdNumber))
                {
                    // Cập nhật thông tin khách (có thể thêm logic cập nhật nếu cần)
                    // Ở đây giả sử lấy thông tin khách đã tồn tại
                    DataTable existingGuests = _guestService.GetGuestsByIdNumber(guest.IdNumber);
                    guestId = Convert.ToInt32(existingGuests.Rows[0]["Id"]);
                }
                else
                {
                    // Thêm mới thông tin khách
                    guestId = _guestService.AddGuest(guest);
                }

                // Tạo đối tượng đăng ký lưu trú
                Accommodation accommodation = new Accommodation
                {
                    GuestId = guestId,
                    AccommodationPlace = cboAccommodationPlace.SelectedItem?.ToString() ?? string.Empty,
                    Room = cboRoom.SelectedItem?.ToString() ?? string.Empty,
                    CheckInDate = dtpCheckInDate.Value
                };

                // Thêm thông tin đăng ký lưu trú
                int accommodationId = _accommodationService.AddAccommodation(accommodation);

                MessageBox.Show("Đăng ký lưu trú thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi đăng ký thành công
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            return true;
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                cboGender.SelectedIndex == -1 ||
                cboIdType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtIdNumber.Text) ||
                cboNationality.SelectedIndex == -1 ||
                cboAccommodationPlace.SelectedIndex == -1 ||
                cboRoom.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            // Xóa dữ liệu trên form
            txtFullName.Text = string.Empty;
            cboGender.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now;
            cboIdType.SelectedIndex = -1;
            txtIdNumber.Text = string.Empty;
            cboNationality.SelectedIndex = -1;
            cboProvince.SelectedIndex = -1;
            cboDistrict.SelectedIndex = -1;
            cboWard.SelectedIndex = -1;
            txtAddress.Text = string.Empty;
            cboAccommodationPlace.SelectedIndex = -1;
            cboRoom.SelectedIndex = -1;
            dtpCheckInDate.Value = DateTime.Now;
        }

        // Bổ sung code cho lớp GuestService để lấy thông tin khách theo số giấy tờ
        private DataTable GetGuestsByIdNumber(string idNumber)
        {
            string query = "SELECT * FROM Guests WHERE IdNumber = @IdNumber";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@IdNumber", idNumber)
            };

            return _guestService.GetGuestsByIdNumber(idNumber);
        }
    }
}

