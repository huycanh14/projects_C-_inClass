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
    public partial class home : System.Web.UI.Page
    {
        public cls_connect conn = new cls_connect();
        public DataTable db = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = conn.laydulieu("Count_HoSoSV");
            if(db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCountHoSoSV.Text = row["HoSoSV"].ToString();
            }

            db = conn.laydulieu("Count_HoSoGV");
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCountHoSoGV.Text = row["HoSoGV"].ToString();
            }

            db = conn.laydulieu("Count_DoAnTN");
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_DoAnTN.Text = row["DoAnTotNghiep"].ToString();
            }

            db = conn.laydulieu("Count_ChuyenNganh");
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_ChuyenNganh.Text = row["ChuyenNganh"].ToString();
            }

            db = conn.laydulieu("List_ChuyenNganh");
            if (db.Rows.Count > 0)
            {
                string table_sv_cn = "";
                byte stt = 1;
                foreach(DataRow row in db.Rows)
                {
                    table_sv_cn += "<tr>";
                    table_sv_cn += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_sv_cn += "<td>" + row["tencn"].ToString() + "</td>";
                    table_sv_cn += "<td >" + row["sosv"].ToString() + "</td>";
                    table_sv_cn += "<td ><a href = 'frm_danhsachcn.aspx?macn="+ row["macn"].ToString() +"'><i class='fas fa-search'></i>&emsp;Danh sách</a></td>";
                    table_sv_cn += "</tr>";
                    stt += 1;
                }

                lit_sv_cn.Text = table_sv_cn;
            }

            db = conn.laydulieu("Count_DiemDoAn", new string[] { "@Diem_1", "@Diem_2" }, new object[] {0, 7}, 2);
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_DALoai1.Text = row["count"].ToString() + " đồ án";
            }

            db = conn.laydulieu("Count_DiemDoAn", new string[] { "@Diem_1", "@Diem_2" }, new object[] { 7, 8 }, 2);
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_DALoai2.Text = row["count"].ToString() + " đồ án";
            }

            db = conn.laydulieu("Count_DiemDoAn", new string[] { "@Diem_1", "@Diem_2" }, new object[] { 8, 9 }, 2);
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_DALoai3.Text = row["count"].ToString() + " đồ án";
            }

            db = conn.laydulieu("Count_DiemDoAn", new string[] { "@Diem_1", "@Diem_2" }, new object[] { 9, 10 }, 2);
            if (db.Rows.Count > 0)
            {
                DataRow row = db.Rows[0];
                lblCount_DALoai4.Text = row["count"].ToString() + " đồ án";
            }

            db = conn.laydulieu("List_LinhVuc");
            if (db.Rows.Count > 0)
            {
                string table_da_lv = "";
                byte stt = 1;
                foreach (DataRow row in db.Rows)
                {
                    table_da_lv += "<tr>";
                    table_da_lv += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_da_lv += "<td>" + row["tenlv"].ToString() + "</td>";
                    table_da_lv += "<td >" + row["solv"].ToString() + "</td>";
                    table_da_lv += "<td ><a href = 'frm_danhsachlv.aspx?malv=" + row["malv"].ToString() + "'><i class='fas fa-search'></i>&emsp;Danh sách</a></td>";
                    table_da_lv += "</tr>";
                    stt += 1;
                }

                lit_da_lv.Text = table_da_lv;
            }
        }
    }
}