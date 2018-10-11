using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2 = 0;
            a = double.Parse(txtHeSoa.Text);
            b = double.Parse(txtHeSob.Text);
            c = double.Parse(txtHeSoc.Text);
            if(a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        MessageBox.Show("Phương trình vô số nghiệm");
                    }
                    else
                        MessageBox.Show("Phương trình vô nghiệm");
                }
                else
                {
                    x1 = x2 = -b / c;
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    MessageBox.Show("Phương trình vô nghiệm");
                else if(delta==0)
                {
                    x1 = x2 = -b / (2 * a);
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
            }
        }
    }
}
