using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form15
{
    public class UtilityDB
    {
        string strConn = @"Data Source=.\SQLEXPRESS; Database=QLSINHVIEN;Integrated Security=True";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable getKhoa()
        {
            OpenConnection();
            DataTable Khoa = new DataTable();
            string sql = "SELECT * FROM KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(Khoa);
            CloseConnection();
            return Khoa;
        }

        public DataTable getLop(string MaKhoa)
        {
            OpenConnection();
            DataTable Lop = new DataTable();
            string sql = "SELECT * FROM LOP WHERE MaKhoa = N'" + MaKhoa +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(Lop);
            CloseConnection();
            return Lop;
        }
    }
}
