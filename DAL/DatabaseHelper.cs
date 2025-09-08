using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCN.DAL
{
    public class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCN;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm thực thi SELECT, trả về DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Hàm thực thi INSERT, UPDATE, DELETE, trả về số dòng ảnh hưởng
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int result = 0;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        // Hàm thực thi Scalar (lấy 1 giá trị, ví dụ COUNT(*))
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = cmd.ExecuteScalar();
            }
            return result;
        }
    }
}
