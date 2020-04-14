using Bai_TH5.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_TH5.Form
{
    public partial class frm_doanview : System.Web.UI.Page
    {
        DataTable db = new DataTable();
        cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = conn.laydulieu("List_DoAn");
            if (db.Rows.Count > 0)
            {
                string table_da = "";
                byte stt = 0;
                foreach (DataRow row in db.Rows)
                {
                    stt += 1;
                    table_da += "<tr>";
                    table_da += "<td scope='row'>" + stt.ToString() + "</td>";
                    table_da += "<td>" + row["masv"].ToString() + "</td>";
                    table_da += "<td >" + row["tensv"].ToString() + "</td>";
                    table_da += "<td >" + row["tenda"].ToString() + "</td>";
                    table_da += "<td >" + row["gvhd"].ToString() + "</td>";
                    table_da += "<td >" + row["gvpb"].ToString() + "</td>";
                    table_da += "<td >" + row["tenlv"].ToString() + "</td>";
                    table_da += "<td >" + row["diem"].ToString() + "</td>";
                    table_da += "<td >" + row["namtn"].ToString() + "</td>";
                    table_da += "</tr>";
                }
                lit_da.Text = table_da;
            }
        }
    }
}