using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form14.frms
{
    public partial class frmReportKhoa : Form
    {
        public frmReportKhoa()
        {
            InitializeComponent();
        }

        private void rpvKhoa_Load(object sender, EventArgs e)
        {
            rpdKhoa.Load("CrystalReportKhoa.rpt");
            rpvKhoa.ReportSource = rpdKhoa;
            rpvKhoa.Refresh();

        }
    }
}
