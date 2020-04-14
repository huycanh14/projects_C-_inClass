using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class ChaoMung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string name = Request.QueryString["chuoia"];
            //lblTen.Text = name;
            string name = Request.Form.Get("txtTenDangNhap");
            lblTen.Text = name;
        }
    }
}