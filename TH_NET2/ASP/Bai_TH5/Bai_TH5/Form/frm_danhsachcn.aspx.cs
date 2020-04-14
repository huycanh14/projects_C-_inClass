using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bai_TH5.Class;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bai_TH5.Form
{
    public partial class frm_chitietsv : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            int macn = int.Parse(Request.QueryString["macn"]);
            db = conn.laydulieu("List_SinhVienCN", new string[] { "@MaCN" }, new object[] { macn }, 1);
            if (db.Rows.Count > 0)
            {
                string table_sv_cn = "";
                byte stt = 0;
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_sv_cn += "<tr>";
                    table_sv_cn += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_sv_cn += "<td>" + row["masv"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["tensv"].ToString() + "</td>";
                    table_sv_cn += "<td >" + DateTime.Parse(row["namsinh"].ToString()) + "</td>";
                    //table_sv_cn += "<td >" + row["tensv"].ToString() + "</td>";
                    if(row["gioitinh"].ToString() == "True")
                    {
                        table_sv_cn += "<td ><input type='checkbox' checked disabled></td>";
                    }
                    else
                    {
                        table_sv_cn += "<td ><input type='checkbox' disabled></td>";
                    }
                    table_sv_cn += "<td >" + row["khoa"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["tencn"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["email"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["dienthoai"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["diachi"].ToString() + "</td>";
                    table_sv_cn += "</tr>";
                }
                lblCount_BanGhi.Text = stt.ToString();
                lit_sv_cn.Text = table_sv_cn;
            }
        }
    }
}