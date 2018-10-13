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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (SinhViens.Count > 0)
            {
                if (txtThuTu.Text == "") return;
                else
                {
                    DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(ret == DialogResult.Yes)
                    {
                        try
                        {
                            int n = int.Parse(txtThuTu.Text);
                            cStudent sv = SinhViens[n - 1];
                            SinhViens.RemoveAt(n - 1);
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
                MessageBox.Show("Chưa có sinh viên được chọn");
            }
        }

        private void LayVaInPhanTu(int n)
        {
            if((SinhViens.Count-1) >= n)
            {
                n = n + 1;
                cStudent sv = SinhViens[n - 1];
                InPhanTu(n - 1);
                
            }
            else
            {
                if(SinhViens.Count == 0)
                {
                    txtThuTu.Text = (SinhViens.Count + 1).ToString();
                    txtDiaChi.Text = txtHoTen.Text = txtMaLop.Text = txtMaSV.Text = txtTuoi.Text = "";
                }
                else
                {
                    cStudent sv = SinhViens[n - 1];
                    InPhanTu(n - 1);
                    
                }
            }
        }

        private void InPhanTu(int n)
        {
            cStudent sv = SinhViens[n];
            txtMaLop.Text = sv.MaLop.ToString();
            txtMaSV.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.Ten.ToString();
            txtTuoi.Text = sv.Tuoi.ToString();
            txtDiaChi.Text = sv.DiaChi.ToString();
            
        }

        List<cStudent> SinhViens = new List<cStudent>();
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LamGiaDuLieu();
            //MessageBox.Show(SinhViens.Count.ToString());
            //MessageBox.Show(SinhViens[0].ToString());
        }

        private void LamGiaDuLieu()
        {
            cStudent sv1 = new cStudent() { MaSV = "sv1", MaLop = "CNTT1", Ten = "Trần Văn Hòa", Tuoi = 18, DiaChi = "Cổ Nhuế, Hà Nội" };
            SinhViens.Add(sv1);
            cStudent sv2 = new cStudent()
            {
                MaSV = "sv2",
                MaLop = "CNTT1",
                Ten = "Nguyễn Thị Hoa",
                Tuoi = 18,
                DiaChi = "Kiến Xương, Hà Nội"
            };
            SinhViens.Add(sv2);

            cStudent sv3 = new cStudent() { MaSV = "sv3", MaLop = "CNTT1", Ten = "Lê Văn Tám", Tuoi = 18, DiaChi = "Biên Hòa" };
            SinhViens.Add(sv3);

            cStudent sv4 = new cStudent() { MaSV = "sv4", MaLop = "CNTT1", Ten = "Đặng Quốc Anh", Tuoi = 18, DiaChi = "Nam Định" };
            SinhViens.Add(sv4);

            cStudent sv5 = new cStudent() { MaSV = "sv5", MaLop = "CNTT1", Ten = "Trần Văn An", Tuoi = 18, DiaChi = "Kiến Xương, Thái Bình" };
            SinhViens.Add(sv5);

            cStudent sv6 = new cStudent() { MaSV = "sv6", MaLop = "KinhTe", Ten = "Lê Thị Mai", Tuoi = 20, DiaChi = "Lê Đức Thọ, Hà Nội" };
            SinhViens.Add(sv6);
            cStudent sv7 = new cStudent() { MaSV = "sv7", MaLop = "KinhTe", Ten = "Trần Thị Hồng Nhung", Tuoi = 20, DiaChi = "Hà Nội" };
            SinhViens.Add(sv7);
            cStudent sv8 = new cStudent() { MaSV = "sv8", MaLop = "KinhTe", Ten = "Nguyễn Minh Trí", Tuoi = 20, DiaChi = "Hà Nội" };
            SinhViens.Add(sv8);
            cStudent sv9 = new cStudent() { MaSV = "sv9", MaLop = "KinhTe", Ten = "Mai Công Toàn", Tuoi = 20, DiaChi = "Bắc Giang" };
            SinhViens.Add(sv9);
            cStudent sv10 = new cStudent() { MaSV = "sv10", MaLop = "KinhTe", Ten = "Trần Thị Mai", Tuoi = 20, DiaChi = "Hà Nội" };
            SinhViens.Add(sv10);

            cStudent sv11 = new cStudent() { MaSV = "sv11", MaLop = "QTKD", Ten = "Trần Văn Thái", Tuoi = 20, DiaChi = "Bắc Ninh" };
            SinhViens.Add(sv11);
            cStudent sv12 = new cStudent() { MaSV = "sv12", MaLop = "QTKD", Ten = "Lê Đức Thọ", Tuoi = 20, DiaChi = "Phạm Văn Đồng, Hà Nội" };
            SinhViens.Add(sv12);
            cStudent sv13 = new cStudent() { MaSV = "sv13", MaLop = "QTKD", Ten = "Đặng Thái Bình", Tuoi = 20, DiaChi = "12 Kiến Xương, Nam Định" };
            SinhViens.Add(sv13);
            cStudent sv14 = new cStudent() { MaSV = "sv14", MaLop = "QTKD", Ten = "Đào Văn Tài", Tuoi = 20, DiaChi = "Bắc Ninh" };
            SinhViens.Add(sv14);
            cStudent sv15 = new cStudent() { MaSV = "sv15", MaLop = "QTKD", Ten = "Ngô Quốc Hùng", Tuoi = 20, DiaChi = "Cầu Giấy, Hà Nội" };
            SinhViens.Add(sv15);

            cStudent sv16 = new cStudent() { MaSV = "sv16", MaLop = "NNTA", Ten = "Ngô Chí Tài", Tuoi = 20, DiaChi = "Nguyễn Chí Thanh, Hà Nội" };
            SinhViens.Add(sv16);
            cStudent sv17 = new cStudent() { MaSV = "sv17", MaLop = "NNTA", Ten = "Trần Văn Quyết", Tuoi = 20, DiaChi = "Quảng Ninh" };
            SinhViens.Add(sv17);
            cStudent sv18 = new cStudent() { MaSV = "sv18", MaLop = "NNTA", Ten = "Lê Thị Hồng", Tuoi = 20, DiaChi = "Ninh Bình" };
            SinhViens.Add(sv18);
            cStudent sv19 = new cStudent() { MaSV = "sv19", MaLop = "NNTA", Ten = "Nguyễn Tuyết Mai", Tuoi = 20, DiaChi = "Hà Nam" };
            SinhViens.Add(sv19);
            cStudent sv20 = new cStudent() { MaSV = "sv20", MaLop = "NNTA", Ten = "Đặng Thái Hà", Tuoi = 20, DiaChi = "Nam Định" };
            SinhViens.Add(sv20);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreFirst_Click(object sender, EventArgs e)
        {
            if(SinhViens.Count > 0)
            {
                cStudent sv = SinhViens[0];
                InPhanTu(1);
                txtThuTu.Text = 1.ToString();
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
        }

        private void btnNextEnd_Click(object sender, EventArgs e)
        {
            if(SinhViens.Count > 0)
            {
                int n = SinhViens.Count;
                cStudent sv = SinhViens[n - 1];
                InPhanTu(n - 1);
                txtThuTu.Text = n.ToString();
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(SinhViens.Count > 0)
            {
                int n = 0;
                if (txtThuTu.Text == "")
                {
                    n = 2;
                }
                else
                {
                    n = int.Parse(txtThuTu.Text);
                }
                if (n == 1) return;
                else
                {
                    n = n - 1;
                    cStudent sv = SinhViens[n - 1];
                    txtMaLop.Text = sv.MaLop.ToString();
                    txtMaSV.Text = sv.MaSV.ToString();
                    txtHoTen.Text = sv.Ten.ToString();
                    txtTuoi.Text = sv.Tuoi.ToString();
                    txtDiaChi.Text = sv.DiaChi.ToString();
                    txtThuTu.Text = n.ToString();
                }
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(SinhViens.Count > 0)
            {
                int n = 0;
                if (txtThuTu.Text == "")
                {
                    n = 0;
                }
                else
                {
                    n = int.Parse(txtThuTu.Text);
                }
                if (n == SinhViens.Count) return;
                else
                {
                    n = n + 1;
                    cStudent sv = SinhViens[n - 1];
                    txtMaLop.Text = sv.MaLop.ToString();
                    txtMaSV.Text = sv.MaSV.ToString();
                    txtHoTen.Text = sv.Ten.ToString();
                    txtTuoi.Text = sv.Tuoi.ToString();
                    txtDiaChi.Text = sv.DiaChi.ToString();
                    txtThuTu.Text = n.ToString();
                }
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtThuTu.Text = (SinhViens.Count + 1).ToString();
            txtDiaChi.Text = txtHoTen.Text = txtMaLop.Text = txtMaSV.Text = txtTuoi.Text = "";
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtThuTu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để sửa");
            }
            else
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn sửa", "Hỏi edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret == DialogResult.Yes)
                {
                    int n = int.Parse(txtThuTu.Text);
                    if ((SinhViens.Count) >= n)
                    {
                        cStudent sv = SinhViens[n - 1];
                        sv.MaLop = txtMaLop.Text;
                        sv.MaSV = txtMaSV.Text;
                        sv.Ten = txtHoTen.Text;
                        sv.Tuoi = int.Parse(txtTuoi.Text);
                        sv.DiaChi = txtDiaChi.Text;
                    }
                    else
                    {
                        MessageBox.Show("Sinh Viên chưa chọn");
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                txtThuTu.Text = (SinhViens.Count + 1).ToString();
                cStudent sv = new cStudent();
                sv.MaLop = txtMaLop.Text;
                sv.MaSV = txtMaSV.Text;
                sv.Ten = txtHoTen.Text;
                sv.Tuoi = int.Parse(txtTuoi.Text);
                sv.DiaChi = txtDiaChi.Text;
                SinhViens.Add(sv);
                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch
            {
                MessageBox.Show("Bạn chưa điền đúng");
            }
        }
    }
}
