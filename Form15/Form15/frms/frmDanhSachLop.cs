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
    public partial class frmDanhSachLop : Form
    {
        public frmDanhSachLop()
        {
            InitializeComponent();
        }

        private void frmDanhSachLop_Load(object sender, EventArgs e)
        {
            UtilityDB data = new UtilityDB();
            cbKhoa.DataSource = data.getKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedIndex != -1)
            {
                UtilityDB data = new UtilityDB();
                string MaKhoa = cbKhoa.SelectedValue.ToString();
                gvLop.DataSource = data.getLop(MaKhoa);
            }
        }
    }
}
