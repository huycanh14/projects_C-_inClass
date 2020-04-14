using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bai_TH5.Class;

namespace Bai_TH5.Form
{
    public partial class frm_danhsachlv : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ma = int.Parse(Request.QueryString["malv"]);
            db = conn.laydulieu("List_SinhVienLinhVuc", new string[] { "@MaLV"}, new object[] { ma}, 1);
            byte stt = 0;
            string table_sv_lv = "";
            if (db.Rows.Count > 0)
            {
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_sv_lv += "<tr>";
                    table_sv_lv += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_sv_lv += "<td>" + row["masv"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["tensv"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["tenda"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["gvhd"].ToString() +"</td>";
                    table_sv_lv += "<td >" + row["gvpb"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["tenlv"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["diem"].ToString() + "</td>";
                    table_sv_lv += "<td >" + row["namtn"].ToString() + "</td>";
                    table_sv_lv += "</tr>";
                }
                lblCount_BanGhi.Text = stt.ToString();
                lit_sv_lv.Text = table_sv_lv;
            }

        }
    }
}