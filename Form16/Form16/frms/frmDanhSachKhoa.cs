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
    public partial class frmDanhSachKhoa : Form
    {
        public frmDanhSachKhoa()
        {
            InitializeComponent();
        }

        private void frmDanhSachKhoa_Load(object sender, EventArgs e)
        {
            UtilityDB data = new UtilityDB();
            gvKhoa.DataSource = data.getKhoa();
        }
    }
}
