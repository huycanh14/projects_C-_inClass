using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("Url " + Request.Url.ToString());
        //Response.Write("<br> Cookie" + Request.Cookies.ToString());
        //Response.Write("<br> ApplicationPath " + Request.ApplicationPath.ToString());
        //Response.Write("<br> Browser " + Request.Browser.Version);
        //Response.Write("<br> QueryString " + Request.QueryString.ToString());
        //Response.Redirect("https://www.facebook.com/canh.huy.1998");//Chuyển hướng qua 1 trang khác
        //Response.ContentType.ToUpper().ToString();
        //HttpCookie cookie = new HttpCookie("name");
        //cookie.Value = "dhuycanh";
        //cookie.Expires = DateTime.Now.AddDays(1);
        //Response.Cookies.Add(cookie);
        //string svalue = cookie.Value;
        //Response.Write(svalue);
        string s = Request.QueryString["id"];
        switch(s)
        {
            case "1":
                plLoad.Controls.Add(LoadControl("TinTuc.ascx"));
                break;
            default:
                plLoad.Controls.Add(LoadControl("SanPham.ascx"));
                break;
        }
    }
}