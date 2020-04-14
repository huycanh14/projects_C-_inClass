using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Tinhtoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtSoLuong.Text = "1";
        }

        protected void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtSoLuong.Text);
            int dongia = int.Parse(txtDonGia.Text);
            txtThanhTien.Text = (soluong * dongia).ToString();
        }
    }
}