using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form6.Main
{
    public partial class frmUCLN_BCNN : Form
    {
        public frmUCLN_BCNN()
        {
            InitializeComponent();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            errorProvider1.SetError(txtSoThu1, "");
            errorProvider1.SetError(txtSoThu2, "");
            try
            {
                if(txtSoThu1.Text == "")
                {
                    errorProvider1.SetError(txtSoThu1, "Bạn đang để trống số thứ nhất");
                }
                else
                {
                    try
                    {
                        if(txtSoThu2.Text == "")
                        {
                            errorProvider1.SetError(txtSoThu2, "Bạn đang để trống số thứ hai");
                        }
                        else
                        {
                            a = int.Parse(txtSoThu1.Text);
                            b = int.Parse(txtSoThu2.Text);
                            c = uocchunglonnhat(a, b);
                            txtKetQua.Text = c.ToString();
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtSoThu2, "Số thứ hai phải là số thực");
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(txtSoThu1, "Số thứ nhất phải là số thực");
            }
        }

        private int uocchunglonnhat(int a, int b)
        {
            int c = 0;
            while(a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            c = a;
            return c;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            errorProvider1.SetError(txtSoThu1, "");
            errorProvider1.SetError(txtSoThu2, "");
            try
            {
                if (txtSoThu1.Text == "")
                {
                    errorProvider1.SetError(txtSoThu1, "Bạn đang để trống số thứ nhất");
                }
                else
                {
                    try
                    {
                        if (txtSoThu2.Text == "")
                        {
                            errorProvider1.SetError(txtSoThu2, "Bạn đang để trống số thứ hai");
                        }
                        else
                        {
                            a = int.Parse(txtSoThu1.Text);
                            b = int.Parse(txtSoThu2.Text);
                            c = uocchunglonnhat(a, b);
                            int tich = a * b;
                            int bcnn = tich / c;
                            txtKetQua.Text = bcnn.ToString();
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtSoThu2, "Số thứ hai phải là số thực");
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(txtSoThu1, "Số thứ nhất phải là số thực");
            }
        }
    }
}
