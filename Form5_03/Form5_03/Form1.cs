using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rd = new Random();
        private void btnTaomang_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoPhanTu.Text);
            int[] A = new int[n];
            txtKetQua.Clear();
            for(int i = 0; i< n; i++)
            {
                A[i] = rd.Next(100);
                txtKetQua.Text += A[i] + "\t";
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoPhanTu.Text);
            string s = txtKetQua.Text.Trim();
            string[] arr = s.Split(new char[] { '\t' });
            int dem = 0;
            int[] A = new int[n];
            foreach (string so in arr)
            {
                A[dem] = int.Parse(so);
                dem++;
            }
            if (radTang.Checked == false && radGiam.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn cách sắp xếp");
            }
            else if(radTang.Checked == true)
            {
                //int n = int.Parse(txtSoPhanTu.Text);
                txtKetQua.Clear();
                for (int i = 0; i<n-1; i++)
                {
                    for(int j = i + 1; j< n; j++)
                    {
                        if(A[i] < A[j])
                        {
                            int temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    txtKetQua.Text += A[i] + "\t";
                }
            }
            else
            {
                txtKetQua.Clear();
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (A[i] > A[j])
                        {
                            int temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    txtKetQua.Text += A[i] + "\t";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            txtSoPhanTu.Clear();
            radGiam.Checked = radTang.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }
    }
}
