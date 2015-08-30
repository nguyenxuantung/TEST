using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKinhDoanhDienThoai
{
    class AccessData
    {
        public  SqlConnection GetConnection()
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
