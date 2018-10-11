using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form07_static.frms
{
    public partial class frmUCLN_BCNN : Form
    {
        public frmUCLN_BCNN()
        {
            InitializeComponent();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            errorProvider1.SetError(txtSoThu1, "");
            errorProvider1.SetError(txtSoThu2, "");
            try
            {
                if (txtSoThu1.Text == "")
                    errorProvider1.SetError(txtSoThu1, "Bạn chưa nhập số thứ nhất");
                else
                {
                    try
                    {
                        if(txtSoThu2.Text == "")
                            errorProvider1.SetError(txtSoThu2, "Bạn chưa nhập số thứ hai");
                        else
                        {
                            a = int.Parse(txtSoThu1.Text);
                            b = int.Parse(txtSoThu2.Text);
                            cXuLy bt = new cXuLy();
                            txtKetQua.Text = bt.UocChungLonNhat(a, b);
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtSoThu1, "Số thứ hai phải là số nguyên");
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(txtSoThu1, "Số thứ nhất phải là số nguyên");
            }
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            errorProvider1.SetError(txtSoThu1, "");
            errorProvider1.SetError(txtSoThu2, "");
            try
            {
                if (txtSoThu1.Text == "")
                    errorProvider1.SetError(txtSoThu1, "Bạn chưa nhập số thứ nhất");
                else
                {
                    try
                    {
                        if (txtSoThu2.Text == "")
                            errorProvider1.SetError(txtSoThu2, "Bạn chưa nhập số thứ hai");
                        else
                        {
                            a = int.Parse(txtSoThu1.Text);
                            b = int.Parse(txtSoThu2.Text);
                            cXuLy bt = new cXuLy();
                            txtKetQua.Text = bt.BoiChungNhoNhat(a, b);
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtSoThu1, "Số thứ hai phải là số nguyên");
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(txtSoThu1, "Số thứ nhất phải là số nguyên");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
