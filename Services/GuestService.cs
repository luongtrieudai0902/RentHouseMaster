using System;
using System.Data;
using RentHouseMaster.Models;
using RentHouseMaster.Services;
using Microsoft.Data.SqlClient;

namespace RentHouseMaster.Services
{
    public class GuestService
    {
        private readonly DatabaseService _dbService;

        public GuestService()
        {
            _dbService = new DatabaseService();
        }

        // Thêm khách lưu trú mới
        public int AddGuest(Guest guest)
        {
            string query = @"INSERT INTO Guests (FullName, Gender, BirthDate, IdType, IdNumber, 
                             Nationality, Province, District, Ward, Address) 
                             VALUES (@FullName, @Gender, @BirthDate, @IdType, @IdNumber, 
                             @Nationality, @Province, @District, @Ward, @Address);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", guest.FullName),
                new SqlParameter("@Gender", guest.Gender),
                new SqlParameter("@BirthDate", guest.BirthDate),
                new SqlParameter("@IdType", guest.IdType),
                new SqlParameter("@IdNumber", guest.IdNumber),
                new SqlParameter("@Nationality", guest.Nationality),
                new SqlParameter("@Province", guest.Province),
                new SqlParameter("@District", guest.District),
                new SqlParameter("@Ward", guest.Ward),
                new SqlParameter("@Address", guest.Address)
            };

            // Thực thi câu lệnh và trả về ID của bản ghi vừa thêm
            object result = _dbService.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        // Kiểm tra xem khách đã tồn tại chưa (dựa vào số giấy tờ)
        public bool CheckGuestExists(string idNumber)
        {
            string query = "SELECT COUNT(*) FROM Guests WHERE IdNumber = @IdNumber";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdNumber", idNumber)
            };

            object result = _dbService.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        // Lấy thông tin khách theo ID
        public Guest GetGuestById(int id)
        {
            string query = "SELECT * FROM Guests WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            DataTable dataTable = _dbService.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Guest
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FullName = row["FullName"].ToString(),
                    Gender = row["Gender"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    IdType = row["IdType"].ToString(),
                    IdNumber = row["IdNumber"].ToString(),
                    Nationality = row["Nationality"].ToString(),
                    Province = row["Province"].ToString(),
                    District = row["District"].ToString(),
                    Ward = row["Ward"].ToString(),
                    Address = row["Address"].ToString()
                };
            }

            return null;
        }

        // Thêm phương thức này để sửa lỗi CS1061
        public DataTable GetGuestsByIdNumber(string idNumber)
        {
            string query = "SELECT * FROM Guests WHERE IdNumber = @IdNumber";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdNumber", idNumber)
            };

            return _dbService.ExecuteQuery(query, parameters);
        }
    }
}