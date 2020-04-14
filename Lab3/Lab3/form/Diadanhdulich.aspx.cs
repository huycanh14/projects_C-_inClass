using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3.form
{
    public partial class Diadanhdulich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstDiaDanh.Items.Add("Vịnh Hạ Long");
                lstDiaDanh.Items.Add("Phan Thiết - Mũi Né");
                lstDiaDanh.Items.Add("Nha Trang");
                lstDiaDanh.Items.Add("Đà Lạt");
                lstDiaDanh.Items.Add("Nam Định");
                lstDiaDanh.Items.Add("Thái Bình");
                lstDiaDanh.Items.Add("Hà Nam");
                lblSoDD.Text = lstDiaDanh.Items.Count.ToString();
            }
        }

        protected void btnChon_Click(object sender, EventArgs e)
        {
            lblDiaDanh.Text = "";
            for (int i = 0; i < lstDiaDanh.Items.Count; i++)
            {
                if(lstDiaDanh.Items[i].Selected)
                {
                    lblDiaDanh.Text += "<li>" + lstDiaDanh.Items[i].Value + "</li>";
                }
            }
        }
    }
}