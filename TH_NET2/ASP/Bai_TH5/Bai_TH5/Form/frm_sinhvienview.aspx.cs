using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Bai_TH5.Class;

namespace Bai_TH5.Form
{
    public partial class frm_sinhvienview : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = conn.laydulieu("List_SinhVien");
            if (db.Rows.Count > 0)
            {
                string table_sv = "";
                byte stt = 0;
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_sv += "<tr>";
                    table_sv += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_sv += "<td>" + row["masv"].ToString() + "</td>";
                    table_sv += "<td >" + row["tensv"].ToString() + "</td>";
                    table_sv += "<td >" + DateTime.Parse(row["namsinh"].ToString()) + "</td>";
                    //table_sv_cn += "<td >" + row["tensv"].ToString() + "</td>";
                    if (row["gioitinh"].ToString() == "True")
                    {
                        table_sv += "<td ><input type='checkbox' checked disabled></td>";
                    }
                    else
                    {
                        table_sv += "<td ><input type='checkbox' disabled></td>";
                    }
                    table_sv += "<td >" + row["khoa"].ToString() + "</td>";
                    table_sv += "<td >" + row["tencn"].ToString() + "</td>";
                    table_sv += "<td >" + row["email"].ToString() + "</td>";
                    table_sv += "<td >" + row["dienthoai"].ToString() + "</td>";
                    table_sv += "<td >" + row["diachi"].ToString() + "</td>";
                    table_sv += "</tr>";
                }
                lit_sv.Text = table_sv;
            }
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            //string st_id = 
        }

        protected void drlKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = drlKhoa.SelectedValue.ToString();
            db = conn.laydulieu("List_SinhVienMaKhoa", new string[] { "@MaKhoa" }, new object[] { int.Parse(ma) }, 1);
            string table_sv = "";
            byte stt = 0;
            foreach (DataRow row in db.Rows)
            {
                stt += 1;
                table_sv += "<tr>";
                table_sv += "<td scope='row'>" + stt.ToString() + "</td>";
                table_sv += "<td>" + row["masv"].ToString() + "</td>";
                table_sv += "<td >" + row["tensv"].ToString() + "</td>";
                table_sv += "<td >" + DateTime.Parse(row["namsinh"].ToString()) + "</td>";
                //table_sv_cn += "<td >" + row["tensv"].ToString() + "</td>";
                if (row["gioitinh"].ToString() == "True")
                {
                    table_sv += "<td ><input type='checkbox' checked disabled></td>";
                }
                else
                {
                    table_sv += "<td ><input type='checkbox' disabled></td>";
                }
                table_sv += "<td >" + row["khoa"].ToString() + "</td>";
                table_sv += "<td >" + row["tencn"].ToString() + "</td>";
                table_sv += "<td >" + row["email"].ToString() + "</td>";
                table_sv += "<td >" + row["dienthoai"].ToString() + "</td>";
                table_sv += "<td >" + row["diachi"].ToString() + "</td>";
                table_sv += "</tr>";
            }
            lit_sv.Text = table_sv;
        }
    }
}