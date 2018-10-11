using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form07_static.frms;

namespace Form07_static
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuUCLN_BCNN_Click(object sender, EventArgs e)
        {
            frmUCLN_BCNN frm = new frmUCLN_BCNN();
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuPTB1_Click(object sender, EventArgs e)
        {
            frmPTB1 frm = new frmPTB1();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuPTB2_Click(object sender, EventArgs e)
        {
            frmPTB2 frm = new frmPTB2();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuXuLyMang_Click(object sender, EventArgs e)
        {
            frmXuLyMang frm = new frmXuLyMang();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
