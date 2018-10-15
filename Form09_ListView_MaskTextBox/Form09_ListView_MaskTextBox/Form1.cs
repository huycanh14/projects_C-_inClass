using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form09_ListView_MaskTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Cách 1
            //tạo ListViewItem (tạo 1 dòng)
            ListViewItem lvi = new ListViewItem(txtHoTen.Text);
            //Thêm cột còn lại
            lvi.SubItems.Add(mtxtNgaySinh.Text);
            lvi.SubItems.Add(mtxtSoDienThoai.Text);
            lvi.SubItems.Add(cboTinh.Text);
            //Dưa lvi lên giao diện
            lvDanhSach.Items.Add(lvi);
            */

            //Cách 2
            string[] strSubItem = new string[4];
            strSubItem[0] = txtHoTen.Text;
            strSubItem[1] = mtxtNgaySinh.Text;
            strSubItem[2] = mtxtSoDienThoai.Text;
            strSubItem[3] = cboTinh.Text;
            ListViewItem lvi = new ListViewItem(strSubItem);
            lvDanhSach.Items.Add(lvi);
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhSach.SelectedItems[0];
                txtHoTen.Text = lvi.SubItems[0].Text;
                mtxtNgaySinh.Text = lvi.SubItems[1].Text;
                mtxtSoDienThoai.Text = lvi.SubItems[2].Text;
                cboTinh.Text = lvi.SubItems[3].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                lvDanhSach.Items.RemoveAt(lvDanhSach.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chưa chọn phần tử để xóa");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
