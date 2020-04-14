using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiTH3_1621050058.All_Class;

namespace BaiTH3_1621050058
{
    public partial class Bai_1 : System.Web.UI.Page
    {
        cTimSo cTimSo = new cTimSo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoDu.Text);
            string s = cTimSo.TimSo(n);
            lblKetQua.Text = s;
        }
    }
}