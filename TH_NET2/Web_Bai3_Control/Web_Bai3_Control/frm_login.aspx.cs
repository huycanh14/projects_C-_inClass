using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Bai3_Control
{
    public partial class frm_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPass.Text = txtUser.Text = "";
            txtUser.Focus();
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string st_name, st_pass;
            st_name = txtUser.Text.Trim();
            st_pass = txtPass.Text.Trim();

            if (st_name == "admin" && st_pass == "admin")
            {
                Response.Redirect("~/frm_success");
            }
            else
            {
                //Không đúng!
                lblError.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }
    }
}