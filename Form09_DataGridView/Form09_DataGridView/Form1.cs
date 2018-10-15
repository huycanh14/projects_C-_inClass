using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form09_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] strSubItem = new string[4];
            strSubItem[0] = txtHoTen.Text;
            strSubItem[1] = mtxtNgaySinh.Text;
            strSubItem[2] = mtxtSoDienThoai.Text;
            strSubItem[3] = cboTinh.Text;
            gvDanhSach.Rows.Add(strSubItem);

            /*
            #region Cach 2
            gvDanhSach.Rows.Add(txtHoTen.Text, mtxtNgaySinh.Text, mtxtSoDienThoai.Text, cboTinh.Text);
            #endregion
            */
        }

        private void gvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                DataGridViewRow row = gvDanhSach.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells[0].Value.ToString() ;
                mtxtNgaySinh.Text = row.Cells[1].Value.ToString();
                mtxtSoDienThoai.Text = row.Cells[2].Value.ToString();
                cboTinh.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.SelectedRows.Count > 0)
            {
                gvDanhSach.Rows.RemoveAt(gvDanhSach.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Chưa chọn phần tử để xóa");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
