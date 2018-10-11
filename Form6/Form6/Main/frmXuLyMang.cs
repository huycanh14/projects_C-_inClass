using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form6.Main
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
            errorProvider1.SetError(txtPhanTu, "");
            int n = 0;
            try
            {
                if(txtPhanTu.Text == "")
                {
                    errorProvider1.SetError(txtPhanTu, "Bạn chưa nhập phần tử");
                }
                else
                {
                    n = int.Parse(txtPhanTu.Text);
                    int[] arr = new int[n];
                    for(int i = 0; i < n; i++)
                    {
                        arr[i] = rd.Next(100);
                    }
                    InKetQua(arr, n);
                }
            }
            catch
            {
                errorProvider1.SetError(txtPhanTu, "Số phần tử phải là số nguyên dương");
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (radGiam.Checked == false && radTang.Checked == false)
                MessageBox.Show("Bạn chưa chọn cách sắp xếp");
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
                if (radTang.Checked == true)
                    so = SapXepTangDan(so, n);
                else
                    so = SapXepGiamDan(so, n);
                InKetQua(so, n);
            }
        }

        private int[] SapXepGiamDan(int[] so, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (so[i] < so[j])
                    {
                        int temp = so[i];
                        so[i] = so[j];
                        so[j] = temp;
                    }
                }
            }
            return so;
        }

        private void InKetQua(int[] so, int n)
        {
            txtKetQua.Clear();
            foreach (int s in so)
            {
                txtKetQua.Text += s.ToString() + "\t";
            }
        }

        private int[] SapXepTangDan(int[] so, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (so[i] > so[j])
                    {
                        int temp = so[i];
                        so[i] = so[j];
                        so[j] = temp;
                    }
                }
            }
            return so;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtPhanTu.Text = "";
            radTang.Checked = radGiam.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
