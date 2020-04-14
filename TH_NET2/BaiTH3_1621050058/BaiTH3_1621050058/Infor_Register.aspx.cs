using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH3_1621050058
{
    public partial class Infor_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = Request.Form.Get("txtTen");
            lblNgaySinh.Text = Request.Form.Get("drpNgay") + "/" + Request.Form.Get("drpThang") + "/" + Request.Form.Get("drpNam");
            lblGioiTinh.Text = Request.Form.Get("GioiTinh");
            lblDienThoai.Text = Request.Form.Get("txtSoDienThoai");
            lblEmail.Text = Request.Form.Get("txtEmail");
            lblDiaChi.Text = Request.Form.Get("txtaDiaChi");
        }
    }
}