using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string thongbao = Request.QueryString["thongbao"];
            if(thongbao != "")
            {
                lblThongbao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            if (username != "admin" || password != "12345")
            {
                lblThongbao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            else
            {
                //Response.Redirect("ChaoMung.aspx?chuoia=" + username);
                string[] taikhoan = { username, password};
                Session["taikhoan"] = taikhoan;
            }
        }
    }
}