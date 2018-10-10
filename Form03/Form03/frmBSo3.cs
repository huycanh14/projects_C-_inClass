using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form03
{
    public partial class frmBSo3 : Form
    {
        public frmBSo3()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret =  MessageBox.Show("Bạn muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnChuanHoaChuoi_Click(object sender, EventArgs e)
        {
            Chuanhochuoi();
            txtHoTen.Text = txtHoTen.Text.Trim();
        }

        private void Chuanhochuoi()
        {
            string s = txtHoTen.Text.Trim();
            //Trả về mảng các chuỗi con được phân cách bởi khoảng cách
            //StringSplitOptions.RemoveEmptyEntries: những khoảng trắng liên tục nhau thì xóa đi
            string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            txtHoTen.Text = "";
            foreach (string word in arr)
            {
                string s3 = word.ToLower(); //Chuyển chuỗi về in thường
                char[] s4 = s3.ToCharArray(); //chuyển chuỗi về mảng
                s4[0] = char.ToUpper(s4[0]); //lấy chữ cái đầu tiên để in hoa
                s3 = new string(s4); //chuyển lại mảng về chuỗi
                txtHoTen.Text += s3 + " ";
            }
        }

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            Chuanhochuoi();
            string s = txtHoTen.Text.Trim();
            int vtri = s.LastIndexOf(" ");
            if (vtri != -1)
            {
                txtHo.Text = s.Substring(0, vtri);
                txtTen.Text = s.Substring(vtri + 1);
            }
            else
                MessageBox.Show("Chuỗi rỗng");
        }
    }
}
