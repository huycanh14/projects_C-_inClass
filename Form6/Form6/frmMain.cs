using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form6.Main;

namespace Form6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuUCNN_BCLN_Click(object sender, EventArgs e)
        {
            frmUCLN_BCNN frm = new frmUCLN_BCNN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPTB1_Click(object sender, EventArgs e)
        {
            frmPTB1 frm = new frmPTB1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPTB2_Click(object sender, EventArgs e)
        {
            //frmPTB2 frm = new frmPTB2();
            //frm.MdiParent = this;
            //frm.Show();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{

            //}
            frmPTB2 frm = new frmPTB2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuXuLyMang_Click(object sender, EventArgs e)
        {
            frmXuLyMang frm = new frmXuLyMang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
