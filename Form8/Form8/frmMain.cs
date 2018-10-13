using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Form8.frm;

namespace Form8
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuGiaoVien_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
