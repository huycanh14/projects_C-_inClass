using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Tinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, EventArgs e)
        {
            float so_n = float.Parse(txtSon.Text);
            float so_m = float.Parse(txtSom.Text);
            float kq = so_n + so_m;
            txtKetQua.Text = kq.ToString();
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            float so_n = float.Parse(txtSon.Text);
            float so_m = float.Parse(txtSom.Text);
            float kq = so_n - so_m;
            txtKetQua.Text = kq.ToString();
        }

        protected void btnNha_Click(object sender, EventArgs e)
        {
            float so_n = float.Parse(txtSon.Text);
            float so_m = float.Parse(txtSom.Text);
            float kq = so_n * so_m;
            txtKetQua.Text = kq.ToString();
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            float so_n = float.Parse(txtSon.Text);
            float so_m = float.Parse(txtSom.Text);
            float kq = so_n / so_m;
            txtKetQua.Text = kq.ToString();
        }
    }
}