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
    public partial class frmPTB1 : Form
    {
        public frmPTB1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;
            errorProvider1.SetError(txtHeSoA, "");
            errorProvider1.SetError(txtHeSoB, "");
            try
            {
                if (txtHeSoA.Text == "")
                    errorProvider1.SetError(txtHeSoA, "Hệ số a bạn đang bỏ trống");
                else
                {
                    try
                    {
                        if (txtHeSoB.Text == "")
                            errorProvider1.SetError(txtHeSoB, "Hệ số b bạn đang bỏ trống");
                        else
                        {
                            a = double.Parse(txtHeSoA.Text);
                            b = double.Parse(txtHeSoB.Text);
                            c = -b / a;
                            txtKetQua.Text = c.ToString();
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtHeSoB, "Hệ số b phải là số");
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(txtHeSoA, "Hệ số a phải là số");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtHeSoB.Text = txtHeSoA.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
