using System;
using System.Web.UI.WebControls;

namespace B2_1621050058_ĐặngHuyCảnh.form
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            lblTitle.Text = "Hôm nay: Ngày " + date.ToLongDateString();
            int year = DateTime.Now.Year;
            for (int i = 1960; i <= year; i++)
            {
                drpNam.Items.Add(new ListItem(i.ToString()));
            }
            for (int i = 1; i <= 12; i++)
            {
                drpThang.Items.Add(new ListItem(i.ToString()));
            }

            LoadNgay();
        }

        private void LoadNgay()
        {
            int thang = int.Parse(drpThang.Text);
            int nam = int.Parse(drpNam.Text);
            drpNgay.Items.Clear();
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    drpNgay.Items.Add(new ListItem(i.ToString()));
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                for (int i = 1; i <= 30; i++)
                {
                    drpNgay.Items.Add(new ListItem(i.ToString()));
                }
            }
            else
            {
                lblTitle.Text = "22222";
                if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        drpNgay.Items.Add(new ListItem(i.ToString()));
                    }
                }
                else
                {
                    for (int i = 1; i <= 28; i++)
                    {
                        drpNgay.Items.Add(new ListItem(i.ToString()));
                    }
                }
            }
        }

        protected void drpNgay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void drpThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
        }

        protected void drpNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgay();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtHovaTen.Text = txtEmail.Text = txtSoDienThoai.Text = "";
            txtHovaTen.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}