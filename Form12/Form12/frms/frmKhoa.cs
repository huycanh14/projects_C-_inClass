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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            btnThemMoi.PerformClick();
            HienDanhSachKhoaLenDataGridView();
        }

        private void HienDanhSachKhoaLenDataGridView()
        {
            UtilityDB data = new UtilityDB();
            gvKhoa.DataSource = data.getKhoa();
        }

        private void gvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                DataGridViewRow row = gvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells[0].Value.ToString();
                txtTenKhoa.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = txtTenKhoa.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makhoa = txtMaKhoa.Text;
            string tenkhoa = txtTenKhoa.Text;
            UtilityDB data = new UtilityDB();
            bool kq = data.updateKhoa(makhoa, tenkhoa);
            if(kq == true)
            {
                MessageBox.Show("Sửa khoa có mã khoa " + makhoa + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachKhoaLenDataGridView();
            }
            else
            {
                MessageBox.Show("Sửa khoa có mã khoa " + makhoa + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string makhoa = txtMaKhoa.Text;
            string tenkhoa = txtTenKhoa.Text;
            UtilityDB data = new UtilityDB();
            bool kq = data.createKhoa(makhoa, tenkhoa);
            if (kq == true)
            {
                MessageBox.Show("Thêm khoa có mã khoa " + makhoa + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachKhoaLenDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm khoa có mã khoa " + makhoa + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makhoa = txtMaKhoa.Text;
            UtilityDB data = new UtilityDB();
            bool kq = data.deleteKhoa(makhoa);
            if (kq == true)
            {
                MessageBox.Show("Xóa khoa có mã khoa " + makhoa + " thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachKhoaLenDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa khoa có mã khoa " + makhoa + " thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret =  MessageBox.Show("Bạn có muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
