﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form16.frms;

namespace Form16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuDanhSachKhoa_Click(object sender, EventArgs e)
        {
            frmDanhSachKhoa frm = new frmDanhSachKhoa();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuDanhSachLop_Click(object sender, EventArgs e)
        {
            frmDanhSachLop frm = new frmDanhSachLop();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnuReportDachSachLop_Click(object sender, EventArgs e)
        {
            frmReportLop frm = new frmReportLop();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
