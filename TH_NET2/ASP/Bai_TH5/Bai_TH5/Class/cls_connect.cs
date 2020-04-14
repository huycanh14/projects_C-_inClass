using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bai_TH5.Class
{
    public class cls_connect
    {
        //Lấy chuỗi kết nối trong web.config
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connec_DATN"].ConnectionString);
        public void clsketnoi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void clsdong()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }
        public DataTable laydulieu(string sql)
        {
            clsketnoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            clsdong();
            return dt;
        }

        //Hàm lấy dữ liệu chưa tham số
        public DataTable laydulieu(string sql, string[] name, object[] value, int Nparmeter)
        {
            clsketnoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparmeter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            clsdong();
            return dt;
        }
    }
}