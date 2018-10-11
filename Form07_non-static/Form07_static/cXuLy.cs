using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form07_static
{
    public class cXuLy
    {
        #region Ước chung nhỏ nhất - Bội chung lớn nhất
        public string UocChungLonNhat(int a, int b)
        {
            while(a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a.ToString();
        }

        public string BoiChungNhoNhat(int a, int b)
        {
            int c = a * b;
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }

            return (c/a).ToString();
        }
        #endregion

        #region Phương trình bậc 1
        public string PhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            else
                return (-b / a).ToString();
        }
        #endregion

        #region Phương trình bậc 2
        public string[] PhuongTrinhBac2(double a, double b, double c)
        {
            string[] Nghiem = new string[2];
            if(a == 0)
            {
                cXuLy bt = new cXuLy();
                Nghiem[0] = Nghiem[1] = bt.PhuongTrinhBac1(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Nghiem[0] = Nghiem[1] = "Phương trình vô nghiệm";
                else if(delta > 0)
                {
                    Nghiem[0] = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                    Nghiem[1] = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                }
                else
                {
                    Nghiem[0] = Nghiem[1] = (-b / (2 * a)).ToString();
                }
            }
            return Nghiem;
        }
        #endregion


        #region Xử lý mảng
        public string TaoMang(int n)
        {
            Random rd = new Random();
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(100);
            }
            string s = "";
            cXuLy bt = new cXuLy();
            s = bt.InKetQua(s, arr);
            return s;
        }

        public string SapXepTangDan(int[] arr, int n)
        {
            for(int i = 0; i < n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            string s = "";
            cXuLy bt = new cXuLy();
            s = bt.InKetQua(s, arr);
            return s;
        }

        public string SapXepGiamDan(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            string s = "";
            cXuLy bt = new cXuLy();
            s = bt.InKetQua(s, arr);
            return s;
        }

        private string InKetQua(string s, int[] arr)
        {
            foreach (int a in arr)
            {
                s += a.ToString() + "\t";
            }
            return s;
        }

        #endregion
    }
}
