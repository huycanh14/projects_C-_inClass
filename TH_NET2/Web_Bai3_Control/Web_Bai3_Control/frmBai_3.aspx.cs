using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Web_Bai3_Control
{
    public partial class frmBai_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btt_upload_Click(object sender, EventArgs e)
        {
            string path;
            path = FileUpload1.FileName;
            lblKetQua.Text = FileUpload1.ToString();
            //lấy tên file muốn tải lên
            //if (FileUpload1.HasFile)
            //{
            //    if (check_pic(path) == true)
            //    {
            //        //Thực hiện chức năng upload lên server vào thư mục
            //        FileUpload1.SaveAs(MapPath("/image/" + path));
            //        //thông báo kết quả
            //        lbl_thongbao.Text = "Tải ảnh lên server thành công";
            //        //hiển thị ảnh ra control Image
            //        img_view.ImageUrl = "/image/" + path;
            //    }
            //    else
            //    {
            //        lbl_thongbao.Text = "Chỉ cho phép upload file ảnh";
            //    }
            //}
            //else
            //{
            //    lbl_thongbao.Text = "File đã upload lên server";
            //}
        }

        private bool check_pic(string file)
        {
            string st_Exten = Path.GetExtension(file);
            st_Exten = st_Exten.ToLower();
            switch (st_Exten)
            {
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                case ".png":
                    return true;
                case ".gif":
                    return true;
                default:
                    return false;
            }
        }
    }
}