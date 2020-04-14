using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Thongke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTong.Text = Application["So_luot_truy_cap"].ToString();
            lblOnline.Text = Application["So_nguoi_online"].ToString();
        }
    }
}