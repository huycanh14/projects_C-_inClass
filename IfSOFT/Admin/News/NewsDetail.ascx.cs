using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IfSOFT;
using IFSORT_DAL;

namespace IfSOFT.Admin.News
{
    public partial class NewsDetail : System.Web.UI.UserControl
    {
        cNews _news = new cNews();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
        }
        
        void LoadData()
        {
            rptNewsCategory.DataSource = _news.GetList();
            rptNewsCategory.DataBind();
        }
    }
}