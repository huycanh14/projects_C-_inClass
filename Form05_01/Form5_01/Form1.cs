using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = txtHeSoB.Text = txtNghiem.Text = "";
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;
            errorProvider1.SetError(txtHeSoA, "");
            errorProvider1.SetError(txtHeSoB, "");
            try
            {
               if(txtHeSoA.Text == "")
               {
                    errorProvider1.SetError(txtHeSoA, "Hệ số A bạn đang bỏ trống");
               }
                try
                {
                    if (txtHeSoB.Text == "")
                    {
                        errorProvider1.SetError(txtHeSoB, "Hệ số B bạn đang bỏ trống");
                    }
                    a = double.Parse(txtHeSoA.Text);
                    b = double.Parse(txtHeSoB.Text);
                    c = (double)-b / a;
                }
                catch
                {
                    errorProvider1.SetError(txtHeSoB, "Hệ số B phải là số");
                }

            }
            catch
            {
                errorProvider1.SetError(txtHeSoA, "Hệ số A phải là số");
            }

            
            //a = double.Parse(txtHeSoA.Text);
            //b = double.Parse(txtHeSoB.Text);
            //c = (double)-b / a;
            txtNghiem.Text = c.ToString();
        }
    }
}
