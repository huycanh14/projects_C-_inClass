using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTH3_1621050058.All_Class
{
    public class cTimSo
    {
        public string TimSo(int n)
        {
            string s = "";
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    for (int c = 0; c <= 9; c++)
                        for (int d = 0; d <= 9; d++)
                            if ((a + b + c + d)%10 == n)
                                s += a + "" + b + "" + c + "" + d + ", \t";
            return s;
        }
    }
}