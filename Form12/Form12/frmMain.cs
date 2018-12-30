using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form12.frms;

namespace Form12
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuQuanLyLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
