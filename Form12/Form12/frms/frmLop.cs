using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form12.frms
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            UtilityDB data = new UtilityDB();
            cbKhoa.DataSource = data.getKhoa();
            cbKhoa.DisplayMember = "Tên Khoa";
            cbKhoa.ValueMember = "Mã Khoa";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            UtilityDB data = new UtilityDB();
            string MaKhoa = cbKhoa.SelectedValue.ToString();
            gvDanhSachLop.DataSource = data.getLop(MaKhoa);
        }

        private void gvDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                DataGridViewRow row = gvDanhSachLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = txtTenLop.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malop = txtMaLop.Text;
            string tenlop = txtTenLop.Text;
            UtilityDB data = new UtilityDB();
            bool kq = data.updateLop(malop, tenlop);
            if (kq == true)
            {
                MessageBox.Show("Sửa khoa có mã khoa " + malop + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa khoa có mã khoa " + malop + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string malop = txtMaLop.Text;
            string tenlop = txtTenLop.Text;
            string makhoa = cbKhoa.SelectedValue.ToString();
            UtilityDB data = new UtilityDB();
            bool kq = data.createLop(malop, tenlop, makhoa);
            if (kq == true)
            {
                MessageBox.Show("Thêm khoa có mã khoa " + tenlop + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khoa có mã khoa " + tenlop + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string malop = txtMaLop.Text;
            UtilityDB data = new UtilityDB();
            bool kq = data.deleteLop(malop);
            if (kq == true)
            {
                MessageBox.Show("Xóa khoa có mã khoa " + malop + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa khoa có mã khoa " + malop + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
