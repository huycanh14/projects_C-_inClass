using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Bai_TH5.Class;

namespace Bai_TH5.Form
{
    public partial class sinhvienchitiet : System.Web.UI.Page
    {
        public cls_connect conn = new cls_connect();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ma = Request.QueryString.Get("masv").ToString();
        }
    }
}