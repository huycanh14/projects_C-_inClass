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
    public partial class frmPTB2 : Form
    {
        public frmPTB2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;
            double test = 0;
            errorProvider1.SetError(txtHeSoA, "");
            errorProvider1.SetError(txtHeSoB, "");
            errorProvider1.SetError(txtHeSoC, "");
            try
            {
                a = double.Parse(txtHeSoA.Text);
                b = double.Parse(txtHeSoB.Text);
                c = double.Parse(txtHeSoC.Text);
                string[] Nghiem = new string[2];
                Nghiem = cXuLy.PhuongTrinhBac2(a, b, c);
                txtX1.Text = Nghiem[0];
                txtX2.Text = Nghiem[1];
            }
            catch
            {
                if (txtHeSoA.Text == "")
                    errorProvider1.SetError(txtHeSoA, "Hệ số a bạn đang để trống");
                else if (double.TryParse(txtHeSoA.Text, out test) == false)
                    errorProvider1.SetError(txtHeSoA, "Bạn nhập hệ số a chưa đúng");

                if (txtHeSoB.Text == "")
                    errorProvider1.SetError(txtHeSoB, "Hệ số b bạn đang để trống");
                else if (double.TryParse(txtHeSoB.Text, out test) == false)
                    errorProvider1.SetError(txtHeSoB, "Bạn nhập hệ số b chưa đúng");

                if (txtHeSoC.Text == "")
                    errorProvider1.SetError(txtHeSoC, "Hệ số c bạn đang để trống");
                else if (double.TryParse(txtHeSoC.Text, out test) == false)
                    errorProvider1.SetError(txtHeSoC, "Bạn nhập hệ số c chưa đúng");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtX2.Text = txtX1.Text = txtHeSoC.Text = txtHeSoB.Text = txtHeSoA.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
