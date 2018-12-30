using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form15.frms
{
    public partial class frmReportLop : Form
    {
        public frmReportLop()
        {
            InitializeComponent();
        }

        private void rpvLop_Load(object sender, EventArgs e)
        {
            rpdLop.Load("CrystalReportKhoa.rpt");
            rpvLop.ReportSource = rpdLop;
            rpvLop.Refresh();
        }
    }
}
