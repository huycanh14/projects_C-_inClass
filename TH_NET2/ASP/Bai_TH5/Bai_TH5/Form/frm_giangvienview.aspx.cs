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
    public partial class frm_giangvienview : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = conn.laydulieu("List_GiangVien");
            if (db.Rows.Count > 0)
            {
                string table_gv = "";
                byte stt = 0;
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_gv += "<tr>";
                    table_gv += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_gv += "<td >" + row["magv"].ToString() + "</td>";
                    table_gv += "<td >" + row["tengv"].ToString() + "</td>";
                    table_gv += "<td >" + DateTime.Parse(row["namsinh"].ToString()) + "</td>";
                    //table_gv_cn += "<td >" + row["tensv"].ToString() + "</td>";
                    if (row["gioitinh"].ToString() == "True")
                    {
                        table_gv += "<td >Nữ</td>";
                    }
                    else
                    {
                        table_gv += "<td >Nam</td>";
                    }
                    table_gv += "<td >" + row["hocvi"].ToString() + "</td>";
                    table_gv += "<td >" + row["email"].ToString() + "</td>";
                    table_gv += "<td >" + row["dienthoai"].ToString() + "</td>";
                    table_gv += "<td >" + row["diachi"].ToString() + "</td>";
                    table_gv += "</tr>";
                }
                lit_gv.Text = table_gv;
            }
        }
    }
}