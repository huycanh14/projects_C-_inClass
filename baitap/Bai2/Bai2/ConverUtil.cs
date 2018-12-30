using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class ConverUtil
    {
        public static string chuyendoi(int a, int b)
        {
            string s = "";
            s = Convert.ToString(a, b);
            return s;
        }
    }
}
