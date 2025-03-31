using System;
using System.Data;
using RentHouseMaster.Models;
using Microsoft.Data.SqlClient;

namespace RentHouseMaster.Services
{
    public class AccommodationService
    {
        private readonly DatabaseService _dbService;

        public AccommodationService()
        {
            _dbService = new DatabaseService();
        }

        // Thêm thông tin lưu trú mới
        public int AddAccommodation(Accommodation accommodation)
        {
            string query = @"INSERT INTO Accommodations (GuestId, AccommodationPlace, Room, CheckInDate) 
                             VALUES (@GuestId, @AccommodationPlace, @Room, @CheckInDate);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@GuestId", accommodation.GuestId),
                new SqlParameter("@AccommodationPlace", accommodation.AccommodationPlace),
                new SqlParameter("@Room", accommodation.Room),
                new SqlParameter("@CheckInDate", accommodation.CheckInDate)
            };

            // Thực thi câu lệnh và trả về ID của bản ghi vừa thêm
            object result = _dbService.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        // Các phương thức khác có thể thêm vào sau
    }
}