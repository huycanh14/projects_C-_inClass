using Bai_TH5.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_TH5.Form
{
    public partial class frm_danhsachdiemda : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            int loai = int.Parse(Request.QueryString["loai"]);
            object[] param = new object[2];
            if(loai == 1)
            {
                param[0] = 0; param[1] = 7;
                lblThongTin.Text = "<= 7 điểm";
            }
            else if(loai == 2)
            {
                param[0] = 7; param[1] = 8;
                lblThongTin.Text = "7 -> 8 điểm";
            }
            else if(loai == 3)
            {
                param[0] = 8; param[1] = 9;
                lblThongTin.Text = "8 -> 9 điểm";
            }

            else
            {
                param[0] = 9; param[1] = 10;
                lblThongTin.Text = "> 9 điểm";
            }
            db = conn.laydulieu("List_SinhVienDiemDA", new string[] { "@Diem_1", "@Diem_2" }, param, 2);
            byte stt = 0;
            string table_sv_diem = "";
            if(db.Rows.Count > 0)
            {
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_sv_diem += "<tr>";
                    table_sv_diem += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_sv_diem += "<td>" + row["masv"].ToString() + "</td>";
                    table_sv_diem += "<td >" + row["tensv"].ToString() + "</td>";
                    table_sv_diem += "<td >" + row["tenda"].ToString() + "</td>";
                    table_sv_diem += "<td >" + row["gvhd"].ToString() + " - " + row["tengv"]+"</td>";
                    table_sv_diem += "<td >" + row["diem"].ToString() + "</td>";
                    table_sv_diem += "</tr>";
                }
                lblCount_BanGhi.Text = stt.ToString();
                lit_sv_diem.Text = table_sv_diem;
            }
        }
    }
}