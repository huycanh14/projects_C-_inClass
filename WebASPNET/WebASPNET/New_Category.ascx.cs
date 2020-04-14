using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebASPNET
{
    public partial class New_Category : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Chuỗi kết nối đến cơ sở dữ liệu
            
            //Câu truy vấn dữ liệu
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM News_Category";
            //Đưa dữ liệu lên Dropdownlist 
            drpNewCategory.DataSource = SQLDB.SQLDB.GetData(command);
            drpNewCategory.DataValueField = "IDCategory";
            drpNewCategory.DataTextField = "CateName";
            drpNewCategory.DataBind();
        }

        protected void drpNewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM News_Detail WHERE CategoryID = @categoryID and active = 1";
            command.Parameters.Add("@categoryID", int.Parse(drpNewCategory.SelectedValue.ToString()));
            rptNews.DataSource = SQLDB.SQLDB.GetData(command);
            rptNews.DataBind();
        }
    }
}