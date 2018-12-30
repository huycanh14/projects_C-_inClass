using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập cơ số cần chuyển đổi");
            string str = Console.ReadLine();
            int heso = int.Parse(str);
            
            Console.WriteLine("Nhập số cần chuyển đổi");
            str = Console.ReadLine();
            int so = int.Parse(str);
            string kq = ConverUtil.chuyendoi(so, heso);
            
            Console.WriteLine("Giá trị của {0} là: {1}", so, kq);
            Console.Read();
        }
    }
}
