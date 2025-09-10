using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLCN.DB
{
    public class DatabaseHelper
    {
        //private static string connectionString =
        //    @"Data Source=192.168.0.102\SQLEXPRESS,1433;Initial Catalog=QuanLyCongNhan;Integrated Security=True; Trust Server Certificate=True";
        private static string connectionString =
            @"Data Source=192.168.0.102,1433;Initial Catalog=QuanLyCongNhan;User Id=minh;Password=123456;Trust Server Certificate=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
