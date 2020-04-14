using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Bai3_Control
{
    public partial class frmBai_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            string st_kq = "";
            if(rbt_nam.Checked == true)
            {
                st_kq += "<b> Chào anh! </b> Anh thích môn thể thao: ";
            }
            else if (rbt_nu.Checked == true)
            {
                st_kq += "<b> Chào chị! </b> Chị thích môn thể thao: ";
            }
            else
            {
                st_kq += "<b> Chào cưng! </b> Cưng thích môn thể thao: ";
            }
            
            if(cbk_boiloi.Checked == true)
            {
                st_kq += "<li> Bơi lội</li>";
            }
            if (cbk_bongda.Checked == true)
            {
                st_kq += "<li> Bóng đá</li>";
            }
            if (cbk_covua.Checked == true)
            {
                st_kq += "<li> Cờ vua</li>";
            }
            if (cbk_bongban.Checked == true)
            {
                st_kq += "<li> Bóng bàn</li>";
            }
            if (cbk_nhayday.Checked == true)
            {
                st_kq += "<li> Nhảy dây</li>";
            }
            lbl_kq.Text = st_kq;
            ltr_kq.Text = st_kq;
        }
    }
}