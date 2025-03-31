using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RentHouseMaster.Services
{
    public class DatabaseService
    {
        private static string _connectionString = "Data Source=LAPTOP-IBO89B54\\SQLEXPRESS;Initial Catalog=QuanLyThueNha;Integrated Security=True;TrustServerCertificate=True;";
        // Phương thức kết nối database
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Phương thức thực thi câu lệnh SQL không trả về dữ liệu (Insert, Update, Delete)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Phương thức thực thi câu lệnh SQL trả về một giá trị (Count, Sum, ...)
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        // Phương thức thực thi câu lệnh SQL trả về dữ liệu dạng DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
    }
}