using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Lab2
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["So_luot_truy_cap"] = 0;
            Application["So_nguoi_online"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

            Application["So_luot_truy_cap"] =
            int.Parse(Application["So_luot_truy_cap"].ToString()) + 1;
            Application["So_nguoi_online"] =
            int.Parse(Application["So_nguoi_online"].ToString()) + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends.
            Application["So_luot_truy_cap"] =

            int.Parse(Application["So_luot_truy_cap"].ToString()) - 1;

            Application["So_nguoi_online"] =

            int.Parse(Application["So_nguoi_online"].ToString()) - 1;
        }
    }
}