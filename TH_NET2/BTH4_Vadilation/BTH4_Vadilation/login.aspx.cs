using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTH4_Vadilation
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if(txtUser.Text != "admin" && txtMatKhau.Text != "12345")
            {
                lblError.Text = "Bạn đăng nhập sai";
            }
            else
            {
                Response.Redirect("admin.aspx");
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtMatKhau.Text = "";
            txtUser.Focus();
        }
    }
}