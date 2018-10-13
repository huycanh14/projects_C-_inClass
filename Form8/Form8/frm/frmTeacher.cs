using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form8.frm
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }
        List<cTeacher> GiaoViens = new List<cTeacher>();
        private void frmTeacher_Load(object sender, EventArgs e)
        {
            LamGiaDulieu();
        }

        #region Làm giả dữ liệu
        private void LamGiaDulieu()
        {
            cTeacher gv1 = new cTeacher() { MaKhoa = "CNTT", ChuyenNganh = "Công nghệ thông tin", Ten = "Nguyễn Văn Tài", Tuoi = 32, DiaChi = "Hoài Đức, Hà Nội" };
            GiaoViens.Add(gv1);
            cTeacher gv2 = new cTeacher() { MaKhoa = "CNTT", ChuyenNganh = "Công nghệ thông tin", Ten = "Nguyễn Hoài Nam", Tuoi = 30, DiaChi = "Nguyễn Chí Thanh, Hà Nội" };
            GiaoViens.Add(gv2);
            cTeacher gv3 = new cTeacher() { MaKhoa = "CNTT", ChuyenNganh = "Công nghệ thông tin", Ten = "Trần Tất Nam", Tuoi = 35, DiaChi = "Xã Đàn, Hà Nội" };
            GiaoViens.Add(gv3);
            cTeacher gv4 = new cTeacher() { MaKhoa = "CNTT", ChuyenNganh = "Công nghệ thông tin", Ten = "Lê Đức Hải", Tuoi = 32, DiaChi = "Hồ Tùng Mậu, Hà Nội" };
            GiaoViens.Add(gv4);
            cTeacher gv5 = new cTeacher() { MaKhoa = "CNTT", ChuyenNganh = "Công nghệ thông tin", Ten = "Trần Thị Hoa", Tuoi = 27, DiaChi = "Thanh Oai, Hà Nội" };
            GiaoViens.Add(gv5);

            cTeacher gv6 = new cTeacher() { MaKhoa = "QTTD", ChuyenNganh = "Quản trị kinh doanh", Ten = "Mai Đức Tính", Tuoi = 25, DiaChi = "Đức Thắng, Hà Nội" };
            GiaoViens.Add(gv6);
            cTeacher gv7 = new cTeacher() { MaKhoa = "QTTD", ChuyenNganh = "Quản trị kinh doanh", Ten = "Đặng Thị Tú", Tuoi = 30, DiaChi = "Trần Đăng Ninh, Hà Nội" };
            GiaoViens.Add(gv7);
            cTeacher gv8 = new cTeacher() { MaKhoa = "QTTD", ChuyenNganh = "Quản trị kinh doanh", Ten = "Hồ Mai Chi", Tuoi = 29, DiaChi = "Phạm Hùng, Hà Nội" };
            GiaoViens.Add(gv8);
            cTeacher gv9 = new cTeacher() { MaKhoa = "QTTD", ChuyenNganh = "Quản trị kinh doanh", Ten = "Lê Thị Tuyết Lan", Tuoi = 31, DiaChi = "Cầu Giấy, Hà Nội" };
            GiaoViens.Add(gv9);
            cTeacher gv10 = new cTeacher() { MaKhoa = "QTTD", ChuyenNganh = "Quản trị kinh doanh", Ten = "Ngô Hồng Nhung", Tuoi = 25, DiaChi = "Lê Đức Thọ, Hà Nội" };
            GiaoViens.Add(gv10);

            cTeacher gv11 = new cTeacher() { MaKhoa = "KinhTe", ChuyenNganh = "Kinh tế", Ten = "Lê Hồng Hoa", Tuoi = 25, DiaChi = "Láng Hạ, Hà Nội" };
            GiaoViens.Add(gv11);
            cTeacher gv12 = new cTeacher() { MaKhoa = "KinhTe", ChuyenNganh = "Kinh tế", Ten = "Đặng Thái An", Tuoi = 27, DiaChi = "Cầu Giấy, Hà Nội" };
            GiaoViens.Add(gv12);
            cTeacher gv13 = new cTeacher() { MaKhoa = "KinhTe", ChuyenNganh = "Kinh tế", Ten = "Trần Văn Tâm", Tuoi = 33, DiaChi = "Đại Cồ Việt, Hà Nội" };
            GiaoViens.Add(gv13);
            cTeacher gv14 = new cTeacher() { MaKhoa = "KinhTe", ChuyenNganh = "Kinh tế", Ten = "Đặng Quốc Bảo", Tuoi = 25, DiaChi = "An Dương, Hà Nội" };
            GiaoViens.Add(gv14);
            cTeacher gv15 = new cTeacher() { MaKhoa = "KinhTe", ChuyenNganh = "Kinh tế", Ten = "Lê Thị Nhung", Tuoi = 28, DiaChi = "An Dương Vương, Hà Nội" };
            GiaoViens.Add(gv15);

            cTeacher gv16 = new cTeacher() { MaKhoa = "NNTA", ChuyenNganh = "Ngoại ngữ", Ten = "Trần Thị Chinh", Tuoi = 29, DiaChi = "Láng Hạ, Hà Nội" };
            GiaoViens.Add(gv16);
            cTeacher gv17 = new cTeacher() { MaKhoa = "NNTA", ChuyenNganh = "Ngoại ngữ", Ten = "Cẩm Tú Liên", Tuoi = 29, DiaChi = "Nguyễn Biểu, Hà Nội" };
            GiaoViens.Add(gv17);
            cTeacher gv18 = new cTeacher() { MaKhoa = "NNTA", ChuyenNganh = "Ngoại ngữ", Ten = "Ngô Tung Anh", Tuoi = 35, DiaChi = "Giải Phóng, Hà Nội" };
            GiaoViens.Add(gv18);
            cTeacher gv19 = new cTeacher() { MaKhoa = "NNTA", ChuyenNganh = "Ngoại ngữ", Ten = "Nguyễn Thị Hiên Hạnh", Tuoi = 29, DiaChi = "Văn Cao, Hà Nội" };
            GiaoViens.Add(gv19);
            cTeacher gv20 = new cTeacher() { MaKhoa = "NNTA", ChuyenNganh = "Ngoại ngữ", Ten = "Trần Hải Lý", Tuoi = 34, DiaChi = "Đặng Tất, Hà Nội" };
            GiaoViens.Add(gv20);

        }
        #endregion

        #region Pre_First
        private void btnPre_First_Click(object sender, EventArgs e)
        {
            if(GiaoViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
            else
            {
                int n = 0;
                InPhanTu(n);
            }
        }
        #endregion

        #region In phần tử
        private void InPhanTu(int n)
        {
            cTeacher gv = GiaoViens[n];
            txtMaKhoa.Text = gv.MaKhoa.ToString();
            txtChuyenNganh.Text = gv.ChuyenNganh.ToString();
            txtHoVaTen.Text = gv.Ten.ToString();
            txtTuoi.Text = gv.Tuoi.ToString();
            txtDiaChi.Text = gv.DiaChi.ToString();
            txtThuTu.Text = (n + 1).ToString();
        }
        #endregion

        #region Next-End
        private void btnNext_End_Click(object sender, EventArgs e)
        {
            if(GiaoViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
            else
            {
                int n = GiaoViens.Count - 1;
                InPhanTu(n);
            }
        }
        #endregion

        #region Pre
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (GiaoViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
            else
            {
                if (txtThuTu.Text == "") InPhanTu(0);
                else
                {
                    if (int.Parse(txtThuTu.Text) == 1) return;
                    else
                    {
                        int n = int.Parse(txtThuTu.Text) - 1;
                        InPhanTu(n - 1);
                    }
                }
            }
        }
        #endregion

        #region Next
        private void btbNext_Click(object sender, EventArgs e)
        {
            if (GiaoViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
            else
            {
                if (txtThuTu.Text == "") InPhanTu(0);
                else
                {
                    if(int.Parse(txtThuTu.Text) == GiaoViens.Count) return;
                    else
                    {
                        int n = int.Parse(txtThuTu.Text) - 1;
                        InPhanTu(n + 1);
                    }
                }
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            int n = GiaoViens.Count + 1;
            txtThuTu.Text = n.ToString();
            txtTuoi.Text = txtDiaChi.Text = txtHoVaTen.Text = txtChuyenNganh.Text = txtMaKhoa.Text = "";
        }

        #region Luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                txtThuTu.Text = (GiaoViens.Count + 1).ToString();
                cTeacher gv = new cTeacher();
                gv.MaKhoa = txtMaKhoa.Text;
                gv.ChuyenNganh = txtChuyenNganh.Text;
                gv.Ten = txtHoVaTen.Text;
                gv.Tuoi = int.Parse(txtTuoi.Text);
                gv.DiaChi = txtDiaChi.Text;
                GiaoViens.Add(gv);
                MessageBox.Show("Bạn thêm thành công");
            }
            catch
            {
                MessageBox.Show("Bạn nhập chưa đúng");
            }
        }
        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn sửa", "Hỏi edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    int n = int.Parse(txtThuTu.Text);
                    if ((GiaoViens.Count) >= n)
                    {
                        cTeacher gv = GiaoViens[n - 1];
                        gv.MaKhoa = txtMaKhoa.Text;
                        gv.ChuyenNganh = txtChuyenNganh.Text;
                        gv.Ten = txtHoVaTen.Text;
                        gv.Tuoi = int.Parse(txtTuoi.Text);
                        gv.DiaChi = txtDiaChi.Text;
                    }
                    else
                    {
                        MessageBox.Show("Giáo Viên chưa chọn");
                    }
                }
                catch
                {
                    MessageBox.Show("Giáo Viên chưa chọn");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(GiaoViens.Count > 0)
            {
                if (txtThuTu.Text == "") return;
                else
                {
                    DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        try
                        {
                            int n = int.Parse(txtThuTu.Text);
                            cTeacher gv = GiaoViens[n - 1];
                            GiaoViens.RemoveAt(n - 1);
                            LayVaInPhanTu(n - 1);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn sinh viên");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
        }

        private void LayVaInPhanTu(int n)
        {
            if ((GiaoViens.Count - 1) >= n)
            {
                n = n + 1;
                cTeacher gv = GiaoViens[n - 1];
                InPhanTu(n - 1);

            }
            else
            {
                if (GiaoViens.Count == 0)
                {
                    txtThuTu.Text = (GiaoViens.Count + 1).ToString();
                    txtDiaChi.Text = txtHoVaTen.Text = txtMaKhoa.Text = txtChuyenNganh.Text = txtTuoi.Text = "";
                }
                else
                {
                    cTeacher gv = GiaoViens[n - 1];
                    InPhanTu(n - 1);

                }
            }
        }
    }
}
