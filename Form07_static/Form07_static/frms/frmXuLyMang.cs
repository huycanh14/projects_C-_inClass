using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form07_static.frms
{
    public partial class frmXuLyMang : Form
    {
        public frmXuLyMang()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoPhanTu, "");
            try
            {
                int n = int.Parse(txtSoPhanTu.Text);
                //txtKetQua.Clear();

                txtKetQua.Text = cXuLy.TaoMang(n);

            }
            catch
            {
                errorProvider1.SetError(txtSoPhanTu, "Bạn nhập chưa đúng");
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (radGiam.Checked == false && radTang.Checked == false)
                MessageBox.Show("Bạn chưa chọn Sắp xếp");
            else
            {
                string s = txtKetQua.Text.Trim();
                string[] arr = s.Split(new char[] { '\t' });
                int n = arr.Count();
                int[] so = new int[n];
                for(int i = 0; i < n; i++)
                {
                    so[i] = int.Parse(arr[i]);
                }
                if(radTang.Checked == true)
                    txtKetQua.Text = cXuLy.SapXepTangDan(so, n);
                else
                    txtKetQua.Text = cXuLy.SapXepGiamDan(so, n);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtSoPhanTu.Text = "";
            radTang.Checked = radGiam.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
