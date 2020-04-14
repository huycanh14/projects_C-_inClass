using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Downloadfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string staptin = "Lab02.pdf";
            string duongdan;
            duongdan = Server.MapPath("~/Download/") + staptin;
            Response.AddHeader("Content-Disposition", "filename=" + staptin);
            Response.WriteFile(duongdan);
            Response.End();
        }
    }
}