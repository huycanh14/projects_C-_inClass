using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form16.frms
{
    public partial class frmReportLop : Form
    {
        public frmReportLop()
        {
            InitializeComponent();
        }

        private void rpvLop_Load(object sender, EventArgs e)
        {
            UtilityDB data = new UtilityDB();
            cbKhoa.DataSource = data.getKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            //string sql = "select * from lop, khoa where Lop.MaKhoa=Khoa.MaKhoa and Lop.MaKhoa='" + cbKhoa.SelectedValue + "'";
            string sql = "SELECT * FROM LOP, KHOA WHERE LOP.MaKhoa = KHOA.MaKhoa AND LOP.MaKhoa = '" + cbKhoa.SelectedValue + "'";
            CrystalReportLop crtLop = new CrystalReportLop();
            UtilityDB data = new UtilityDB();
            crtLop.SetDataSource(data.getDataInTable(sql));
            rpvLop.ReportSource = crtLop;
            rpvLop.Refresh();
        }
    }
}
