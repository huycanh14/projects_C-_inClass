using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiTH3_1621050058.All_Class;

namespace BaiTH3_1621050058
{
    public partial class Bai_3 : System.Web.UI.Page
    {
        cls_chuyendoi chuyendoi = new cls_chuyendoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string kq = "";
            int n = int.Parse(txtSoNhap.Text);
            if(radNhiPhan.Checked == true)
            {
                kq = chuyendoi.HeNhiPhan(n);
            }
            if(radBatPhan.Checked == true)
            {
                kq = chuyendoi.HeBatPhan(n);
            }
            if(radThapLucPhan.Checked == true)
            {
                kq = chuyendoi.HeThapLucPhan(n);
            }
            //kq = String.Format("{0:0 0}", kq) + " ( " + kq.Length + " bit)";            
            kq = kq + " ( " + kq.Length + " bit)";
            lblKetQua.Text = kq;
        }
    }
}