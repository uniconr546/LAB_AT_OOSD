using System.Data.SqlClient;

namespace QuanLyKhachSan.DAL
{
    public static class DbConnection
    {
        private static readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=QuanLyKhachSan;
              Integrated Security=True;
              TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}