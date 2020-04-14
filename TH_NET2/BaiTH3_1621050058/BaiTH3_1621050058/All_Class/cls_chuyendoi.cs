using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTH3_1621050058.All_Class
{
    public class cls_chuyendoi
    {
        public string HeNhiPhan(int n)
        {
            string kq = Convert.ToString(n, 2);
            return kq;
        }
        public string HeBatPhan(int n)
        {
            string kq = Convert.ToString(n, 8);
            return kq;
        }
        public string HeThapLucPhan(int n)
        {
            string kq = Convert.ToString(n, 16);
            return kq;
        }
    }
}