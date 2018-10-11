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
    public partial class frmPTB1 : Form
    {
        public frmPTB1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtHeSoA, "");
            errorProvider1.SetError(txtHeSoB, "");
            double a, b = 0;
            try
            {
                a = double.Parse(txtHeSoA.Text);
                b = double.Parse(txtHeSoB.Text);
                txtKetQua.Text = cXuLy.PhuongTrinhBac1(a, b);
            }
            catch(Exception)
            {
                double x  = 0;
                //int.TryParse(txtHeSoA.Text, out a);
                if (txtHeSoA.Text == "")
                {
                    errorProvider1.SetError(txtHeSoA, "Hệ số a bạn đang bỏ trống");
                }
                else if(double.TryParse(txtHeSoA.Text, out x) == false)
                    errorProvider1.SetError(txtHeSoA, "Hệ số a bạn nhập chưa đúng");

                if (txtHeSoB.Text == "")
                {
                    errorProvider1.SetError(txtHeSoB, "Hệ số b bạn đang bỏ trống");
                }
                else if(double.TryParse(txtHeSoB.Text, out x) == false)
                    errorProvider1.SetError(txtHeSoB, "Hệ số b bạn nhập chưa đúng");
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
