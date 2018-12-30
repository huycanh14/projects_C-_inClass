using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Form12
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
            string sql = "SELECT MaKhoa as N'Mã Khoa', TenKhoa as N'Tên Khoa' FROM KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(Khoa);
            CloseConnection();
            return Khoa;
        }

        public DataTable getLop(string MaKhoa)
        {
            OpenConnection();
            DataTable Lop = new DataTable();
            string sql = "SELECT * FROM LOP WHERE MaKhoa = N'" + MaKhoa + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(Lop);
            CloseConnection();
            return Lop;
        }

        public bool updateKhoa(string MaKhoa, string TenKhoa)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "UPDATE KHOA SET TenKhoa = @tenkhoa WHERE MaKhoa = @makhoa";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = TenKhoa;
            command.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = MaKhoa;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }

        public bool createKhoa(string MaKhoa, string TenKhoa)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "INSERT INTO KHOA (TenKhoa, MaKhoa) VALUES (@tenkhoa, @makhoa)";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = TenKhoa;
            command.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = MaKhoa;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }

        public bool deleteKhoa(string MaKhoa)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "DELETE FROM KHOA where MaKhoa = @makhoa";
            command.CommandText = sql;
            command.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = MaKhoa;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }

        public bool updateLop(string MaLop, string Tenlop)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "UPDATE LOP SET TenLop = @tenlop WHERE MaLop = @malop";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = Tenlop;
            command.Parameters.Add("@malop", SqlDbType.NVarChar).Value = MaLop;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }

        public bool createLop(string Malop, string TenLop, string MaKhoa)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@malop, @tenlop, @makhoa)";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@malop", SqlDbType.NVarChar).Value = Malop;
            command.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = TenLop;
            command.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = MaKhoa;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }

        public bool deleteLop(string MaLop)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "DELETE FROM LOP where MaLop = @malop";
            command.CommandText = sql;
            command.Parameters.Add("@malop", SqlDbType.NVarChar).Value = MaLop;
            int kq = command.ExecuteNonQuery();
            CloseConnection();
            if (kq > 0) return true;
            else return false;
        }
    }
}
