using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLCN.DB
{
    public class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCongNhan;Integrated Security=True; Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
