using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form09_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = txtThem.Text;
            lstLeft.Items.Add(s);
            txtThem.Focus();

        }

        private void btnMoveOnLeftToRight_Click(object sender, EventArgs e)
        {
            while(lstLeft.SelectedIndices.Count > 0)
            {
                //string s = lstLeft.SelectedIndices[0];
                lstRight.Items.Add(lstLeft.SelectedItems[0]);
                lstLeft.Items.RemoveAt(lstLeft.SelectedIndices[0]);

            }
        }

        private void btnMoveAllLeftToRight_Click(object sender, EventArgs e)
        {
            while(lstLeft.Items.Count > 0)
            {
                lstRight.Items.Add(lstLeft.Items[0]);
                lstLeft.Items.RemoveAt(0);
            }
        }

        private void btnMoveOneRightToLeft_Click(object sender, EventArgs e)
        {
            while (lstRight.SelectedIndices.Count > 0)
            {
                lstLeft.Items.Add(lstRight.SelectedItems[0]);
                lstRight.Items.RemoveAt(lstRight.SelectedIndices[0]);

            }
        }

        private void btnMoveAllRightToLeft_Click(object sender, EventArgs e)
        {
            while (lstRight.Items.Count > 0)
            {
                lstLeft.Items.Add(lstRight.Items[0]);
                lstRight.Items.RemoveAt(0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát chương trình", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
