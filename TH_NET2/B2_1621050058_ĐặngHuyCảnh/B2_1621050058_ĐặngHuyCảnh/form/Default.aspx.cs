using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2_1621050058_ĐặngHuyCảnh.form
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            lblNgay.Text = "Hôm nay: Ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;

            lblInfo.Text = Request.Form.Get("txtHovaTen");
            txtNgaySinh.Text = Request.Form.Get("drpNgay") + "/" + Request.Form.Get("drpThang") + "/" + Request.Form.Get("drpNam") + "(" + (date.Year - int.Parse(Request.Form.Get("drpNam"))) + " tuổi )";

            txtEmail.Text = Request.Form.Get("txtEmail");
            var gioitinh = Request.Form.Get("GioiTinh");
            if (int.Parse(gioitinh) == 1)
            {
                imgGioiTinh.ImageUrl = "~/image/pic_Nam.png";
            }
            else
            {
                imgGioiTinh.ImageUrl = "~/image/pic_Nu.png";
            }
            txtDienThoai.Text = Request.Form.Get("txtSoDienThoai");
            txtDiaChi.Text = Request.Form.Get("txtDiaChi");
            var month = Request.Form.Get("drpThang");
            int thang = int.Parse(month);
            if (thang == 1 || thang == 2 || thang == 3)
            {
                MuaXuan(thang);
            }
            else if(thang == 4 || thang == 6 || thang == 5)
            {
                MuaHe(thang);
            }
            else if(thang == 7|| thang == 8 || thang == 9)
            {
                MuaThua(thang);
            }
            else
            {
                MuaDong(thang);
            }
        }

        private void MuaDong(int thang)
        {
            imgMua.ImageUrl = "~/image/muadong.JPG";
            lblTho.Text = "(Bạn sinh vào: Tháng " + thang + " - Mùa Đông)";
            lblMua.Text = "MÙA HOA CẢI<br>Có một mùa hoa cải<br>Nở vàng bên bến sông<br>Em đang thì con gái<br>Đợi anh chưa lấy chồng<br><br>... <br><br>Anh lại gieo hạt cải<br>Lại âm thầm đợi mong<br>Có một người con gái<br>Đợi anh chưa lấy chồng";
        }

        private void MuaThua(int thang)
        {
            imgMua.ImageUrl = "~/image/muathu.JPG";
            lblTho.Text = "(Bạn sinh vào: Tháng " + thang + " - Mùa Thu)";
            lblMua.Text = "HOA CÚC MÙA THU<br>Thu về cho đoá Cúc vàng,<br>Cho hàng phong trút lá vàng đầy sân.<br>Ngồi nghe một chút hương lân, <br>Nhớ em áo lụa thanh tân thuở nào. <br>Lòng sao nghe vẫn dạt dào,<br>Màu hoa năm ấy ngọt ngào trong tim.";
        }

        private void MuaHe(int thang)
        {
            imgMua.ImageUrl = "~/image/muahe.jpg";
            lblTho.Text = "(Bạn sinh vào: Tháng " + thang + " - Mùa Hè)";
            lblMua.Text = "HOA DÂM BỤT <br/> <br/>Hôm qua trở lại vườn xưa, <br/>Đầu cành dâm bụt, lưa thưa nắng vàng.  <br/>Thoảng nghe chim hót trên ngàn, <br/>Bên hàng bụt đỏ ,ngân vang tiếng cười. <br/>Dáng ai, thấp thoáng mơ màng, <br/>Nghe chừng như bóng em về đâu đây.<br/>Nắng chiều lãng đãng hiên tây,<br/>Giật mình tĩnh giấc, còn đây nỗi buồn.";
        }

        private void MuaXuan(int thang)
        {
            imgMua.ImageUrl = "~/image/muaxuan.jpg";
            lblTho.Text = "(Bạn sinh vào: Tháng " + thang + " - Mùa Xuân)";
            //lblMua.Text = "iosjifhdif\r\nidohfsd";
            lblMua.Text = "XUÂN<br>Tôi có chờ đâu, có đợi đâu<br>Đem chi xuân lại gợi thêm sầu? <br>Với tôi tất cả như vô nghĩa<br>Tất cả không ngoài nghĩa khổ đau! <br>... <br>Có đứa trẻ thơ không biết khóc<br><br> Vô tình bỗng nổi tiếng cười ran! <br>Chao ôi! Mong nhớ!Ôi, mong nhớ,<br> Một cánh chim thu lạc cuối ngàn!<br>";
        }
    }
}