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
        string serverName = "";
        string database = "";
        string user = "";
        string password = "";

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string ServerName, string Database, string User, string Password):this()
        {
            serverName = ServerName;
            database = Database;
            user = User;
            password = Password;
        }

        private void mnuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa(serverName, database, user, password);
            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuQuanLyLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop(serverName, database, user, password);
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}
