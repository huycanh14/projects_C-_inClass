using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            int ucln = a;
            txtKetQua.Text = ucln.ToString();
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            int tich = a * b;
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            int ucln = a;
            int bcnn = tich / ucln;
            txtKetQua.Text = bcnn.ToString();
        }
    }
}
