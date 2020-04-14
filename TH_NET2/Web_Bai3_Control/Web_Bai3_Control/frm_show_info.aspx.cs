using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Bai3_Control
{
    public partial class frm_show_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string st_name, st_gioitinh, st_namsinh;
            st_name = Request.Form.Get("txbUser");
            st_gioitinh = Request.Form.Get("GioiTinh");
            st_namsinh = Request.Form.Get("drlNamS");

            lblHoTen.Text = st_name;
            lblGioiTinh.Text = st_gioitinh;
            lblNamSinh.Text = DateTime.Now.Year - int.Parse(st_namsinh) + "";
        }
    }
}